using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Security.Domain.Entities;

namespace Security.Persistence.Context
{
    public sealed class PersonelDbContext:DbContext
    {
       
        private string ConnectionString ="";
        

        public PersonelDbContext(string personelId,Personel personel = null)
        {
            if(personel != null)
            {
                if (personel.UserId == "")
                    ConnectionString = $"" +
                        $"Data Source={personel.ServerName};" +
                        $"Initial Catalog={personel.DatabaseName};" +
                        $"Integrated Security=True;" +
                        $"Connect Timeout=30;" +
                        $"Encrypt=True;" +
                        $"Trust Server Certificate=True;" +
                        $"Application Intent=ReadWrite;" +
                        $"Multi Subnet Failover=False";
                else
                    ConnectionString = $"" +
                        $"Data Source={personel.ServerName};" +
                        $"Initial Catalog={personel.DatabaseName};" +
                        $"User Id={personel.UserId};" +
                        $" Password={personel.Password}; " +
                        $"Integrated Security=True;" +
                        $"Connect Timeout=30;" +
                        $"Encrypt=True;" +
                        $"Trust Server Certificate=True;" +
                        $"Application Intent=ReadWrite;" +
                        $"Multi Subnet Failover=False";
            }
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) =>
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MyAssemblyReference).Assembly);

        public class PersonelDbContextFactory : IDesignTimeDbContextFactory<PersonelDbContext>
        {
            

            public PersonelDbContext CreateDbContext(string[] args)
            {

                
                return new PersonelDbContext("");
            }
        }


    }
}
