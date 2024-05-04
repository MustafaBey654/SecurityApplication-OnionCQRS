using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Security.Domain.Entities;

namespace Security.Persistence.Configurations
{
    public class CarPlateConfiguration : IEntityTypeConfiguration<CarPlate>
    {
        public void Configure(EntityTypeBuilder<CarPlate> builder)
        {
            builder.HasData(

                new CarPlate { Id = 1, PlateName = "69 AAA 13", IsPersonel=true},
                new CarPlate { Id = 2, PlateName = "69 AB 25" },
                new CarPlate { Id = 3, PlateName = "25 ACH 361", IsPersonel = true },
                new CarPlate { Id = 4, PlateName = "34 PLK 45" },
                new CarPlate { Id = 5, PlateName = "69 AS 89" }

                );
        }
    }
}
