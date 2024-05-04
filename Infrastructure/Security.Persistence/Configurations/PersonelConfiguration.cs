using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Security.Domain.Entities;

namespace Security.Persistence.Configurations
{
    public class PersonelConfiguration : IEntityTypeConfiguration<Personel>
    {
        public void Configure(EntityTypeBuilder<Personel> builder)
        {
            
            Faker faker = new Faker("tr");

            builder.HasData(

                new Personel  { Id = 1, FirstName = faker.Person.FirstName,LastName= faker.Person.LastName},
                 new Personel { Id = 2, FirstName = faker.Person.FirstName, LastName = faker.Person.LastName },
                 new Personel { Id = 3, FirstName = faker.Person.FirstName, LastName = faker.Person.LastName },
                 new Personel { Id = 4, FirstName = faker.Person.FirstName, LastName = faker.Person.LastName },
                 new Personel { Id = 5, FirstName = faker.Person.FirstName, LastName = faker.Person.LastName , IsDeleted=true },
                 new Personel { Id = 6, FirstName = faker.Person.FirstName, LastName = faker.Person.LastName },
                 new Personel { Id = 7, FirstName = faker.Person.FirstName, LastName = faker.Person.LastName },
                 new Personel { Id = 8, FirstName = faker.Person.FirstName, LastName = faker.Person.LastName },
                 new Personel { Id = 9, FirstName = faker.Person.FirstName, LastName = faker.Person.LastName },
                 new Personel { Id = 10, FirstName = faker.Person.FirstName, LastName = faker.Person.LastName, IsDeleted = true }



                );
        }
    }
}
