using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Security.Domain.Entities;

namespace Security.Persistence.Configurations
{
    public class UnitConfiguration : IEntityTypeConfiguration<Unit>
    {
        public void Configure(EntityTypeBuilder<Unit> builder)
        {
            builder.HasData(

                new Unit { Id = 1, BranchId = 1, UnitName = "Satın Alma Büro Amirliği"  },
                new Unit { Id = 2, BranchId = 1, UnitName = "Tahakkuk Büro Amirliği" },
                new Unit { Id = 3, BranchId = 2, UnitName = "Atış Büro Amirliği" },
                new Unit { Id = 4, BranchId = 3, UnitName = "Personel Kayıt Amirliği" },
                new Unit { Id = 5, BranchId = 4, UnitName = "Öğrenci Özlük Amirliği" },
                new Unit { Id = 6, BranchId = 6, UnitName = "Belge Yönetimi Amirliği" }

                );
        }
    }
}
