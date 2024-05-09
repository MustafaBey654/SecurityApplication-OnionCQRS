using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Identity.Client;
using Security.Domain.Common;
using Security.Domain.Entities;
using Security.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Security.Persistence.Context
{
    public sealed class AppDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Branch> Branches { get; set; }
        public DbSet<CarPlate> CarPlates { get; set; }
        public DbSet<Personel> Personels { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Visitor> Visitors { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }

        public DbSet<BranchAndUnitRelationShip> BranchAndUnitRelationShips { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entries = ChangeTracker.Entries<EntityBase>();
            foreach (var entry in entries)
            {
                if(entry.State == EntityState.Added)
                {
                    entry.Property(p => p.Id);

                    entry.Property(p => p.IsDeleted)
                        .CurrentValue = false;
                        
                }
                //if(entry.State == EntityState.Modified)
                //{
                //    entry.Property(p=>p.IsDeleted)
                //        .CurrentValue = false;
                //}
            }
            return base.SaveChangesAsync(cancellationToken);

            
        }

        public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
        {
            public AppDbContext CreateDbContext(string[] args)
            {
                var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

                var envName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

                var basePath = Directory.GetCurrentDirectory();

                var configuration = new ConfigurationBuilder()
                    .SetBasePath(basePath)
                     .AddJsonFile("appsettings.json", optional: false)
                      .AddJsonFile($"appsettings.{envName}.json", optional: true)
                      .Build();


                var connectionString =   configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

                optionsBuilder.UseSqlServer(connectionString);

                return new AppDbContext(optionsBuilder.Options);

            
            }
        }






    }
}
