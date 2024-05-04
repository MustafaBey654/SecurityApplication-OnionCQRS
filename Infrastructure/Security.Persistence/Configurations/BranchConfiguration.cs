
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Security.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Persistence.Configurations
{
    public class BranchConfiguration : IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> builder)
        {
            builder.Property(b=>b.BranchName).HasMaxLength(256);

        
            builder.HasData(

                new Branch { Id = 1, BranchName = "İdari Mali İşler Şube Müdürlüğü"},
                new Branch { Id = 2, BranchName = "Destek Hizmetleri Şube Müdürlüğü" },
                new Branch { Id = 3, BranchName = "Personel Şube Müdürlüğü"},
                new Branch { Id = 4, BranchName = "Eğitim Şube Müdürlüğü" },
                new Branch { Id = 5, BranchName = "Öğrenci İşleri Şube Müdürlüğü" },
                new Branch { Id = 6,BranchName = "Pomem Şube Müdürlüğü"}
                );
        }
    }
}
