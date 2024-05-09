using Bogus;
using Bogus.Extensions.Sweden;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Security.Domain.Entities;

namespace Security.Persistence.Configurations
{
    public class VisitorConfiguration : IEntityTypeConfiguration<Visitor>
    {
        public void Configure(EntityTypeBuilder<Visitor> builder)
        {
            Faker faker = new("tr");

            builder.HasData(
                
                new Visitor {
                    Id = 1,
                    FirstName = faker.Person.FirstName,
                    LastName = faker.Person.LastName,
                     IdentityNumber = faker.Person.Personnummer(),
                     PersonelId = 1,
                     BranchId = 1
                },
                 new Visitor
                 {
                     Id = 2,
                     FirstName = faker.Person.FirstName,
                     LastName = faker.Person.LastName,
                     IdentityNumber = faker.Person.Personnummer(),
                     PersonelId = 1,
                     UnitId = 2,
                     ReleaseDate = DateTime.Now,
                 },
                  new Visitor
                  {
                      Id = 3,
                      FirstName = faker.Person.FirstName,
                      LastName = faker.Person.LastName,
                      IdentityNumber = faker.Person.Personnummer(),
                      PersonelId = 1,
                      BranchId = 3,
                      IsDeleted = true
                  },
                   new Visitor
                   {
                       Id = 4,
                       FirstName = faker.Person.FirstName,
                       LastName = faker.Person.LastName,
                       IdentityNumber = faker.Person.Personnummer(),
                       PersonelId = 1,
                       UnitId = 4,
                       ReleaseDate = DateTime.Now,
                   },
                    new Visitor
                    {
                        Id = 5,
                        FirstName = faker.Person.FirstName,
                        LastName = faker.Person.LastName,
                        IdentityNumber = faker.Person.Personnummer(),
                        PersonelId = 1,
                        BranchId = 2,
                        ReleaseDate = DateTime.Now,
                    },
                     new Visitor
                     {
                         Id = 6,
                         FirstName = faker.Person.FirstName,
                         LastName = faker.Person.LastName,
                         IdentityNumber = faker.Person.Personnummer(),
                         PersonelId = 1,
                         BranchId = 5,
                         IsDeleted = true
                     }

                );
        }
    }
}
