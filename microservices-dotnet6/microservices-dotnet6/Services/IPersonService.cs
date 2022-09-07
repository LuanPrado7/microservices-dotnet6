using microservices_dotnet6.Models;

namespace microservices_dotnet6.Services
{
    public interface IPersonService
    {
        Person Create(Person person);

        Person Update(Person person);

        void Delete(int Id);

        Person FindById(int Id);

        List<Person> FindAll();
    }
}
