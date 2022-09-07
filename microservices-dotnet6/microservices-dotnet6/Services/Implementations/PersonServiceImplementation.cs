using microservices_dotnet6.Models;

namespace microservices_dotnet6.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(int Id)
        {
            
        }

        public List<Person> FindAll()
        {
            return new List<Person>()
            {
                new Person
                {
                    Id = 1,
                    FirstName = "Luan",
                    LastName = "Prado",
                    Address = "São Paulo - São Paulo - Brasil",
                    Gender = "Masculino"
                }
            };
        }

        public Person FindById(int Id)
        {
            return new Person
            {
                Id = 1,
                FirstName = "Luan",
                LastName = "Prado",
                Address = "São Paulo - São Paulo - Brasil",
                Gender = "Masculino"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }
    }
}
