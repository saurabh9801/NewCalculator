using CalculatorClassLibrary;
using CalculatorWebApp.Models;
using MongoDB.Driver;

namespace CalculatorWebApp.DataAccess
{
    public class CalculatorDataAccessLayer
    {
        CalculatorDBContext db = new CalculatorDBContext();


        public List<Calculator> GetAllCalculators()
        {
            try
            {
                return db.CalculatorRecord.Find(_ => true).ToList();
            }
            catch
            {
                throw;
            }
        }

        //To Add new employee record         
        public void AddCalculator(Calculator calculator)
        {
            try
            {
                db.CalculatorRecord.InsertOne(calculator);
            }
            catch
            {
                throw;
            }
        }
    }
}
