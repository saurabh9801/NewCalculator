using CalculatorClassLibrary;

namespace WebApp.Services
{
    public interface ICalculatorService
    {
        Task<IEnumerable<Calculator>> GetCalculators();
        //List<Calculator> Get();
        //Calculator Get(int _id);
        //Calculator Create(Calculator calculator);
        //void Update(int  id, Calculator calculator);
        //void Remove(int id);

    }

    
}
