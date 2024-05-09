using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Security.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Persistence
{
    public static class PersistenceServiceLayer
    {
        public static IServiceCollection AddPersistenceLayerService(this IServiceCollection services,IConfiguration builder)
        {
            services.AddDbContext<AppDbContext>(options =>

            options.UseSqlServer(builder.GetConnectionString("DefaultConnection")
            ));

            
            return services;

        }
    }
}
