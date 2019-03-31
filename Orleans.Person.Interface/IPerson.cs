using System.Threading.Tasks;

namespace Orleans.Person.Interface
{
    public interface IPersonGrain : IGrainWithStringKey
    {
        Task SayHelloAsync();
    }
}
