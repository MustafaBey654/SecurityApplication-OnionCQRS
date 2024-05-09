using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Security.Domain.Entities.PersonelEntities;
using Security.Persistence.Constans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Persistence.Configurations
{
    public sealed class PersonelDbConfiguration : IEntityTypeConfiguration<PersonelChartOfAccount>
    {
        public void Configure(EntityTypeBuilder<PersonelChartOfAccount> builder)
        {
            builder.ToTable(TableNames.PersonelChartOfAccounts);
            builder.HasKey(p=>p.Id);
        }
    }
}
