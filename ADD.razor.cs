using CalculatorClassLibrary;
using MongoDB.Bson;
using System.Net.Http;

namespace WebApp.Pages
{
    public partial class ADD
    {
        int num1 = 0;
        int num2 = 0;
        string finalresult;
        public CalculatorClassLibrary.Calculator calculator { get; set; }
        void AddNumbers()
        {
            finalresult = (Convert.ToDouble(num1) + Convert.ToDouble(num2)).ToString();
            var r = SaveCalculator("+");
        }
        void SubtractNumbers()
        {
            finalresult = (Convert.ToDouble(num1) - Convert.ToDouble(num2)).ToString();
            var r = SaveCalculator("-");
        }
        void MultiplyNumbers()
        {
            finalresult = (Convert.ToDouble(num1) * Convert.ToDouble(num2)).ToString();
            var r = SaveCalculator("*");
        }
        void DivideNumbers()
        {
            if (Convert.ToDouble(num2) != 0)
            {
                finalresult = (Convert.ToDouble(num1) / Convert.ToDouble(num2)).ToString();
                var r = SaveCalculator("/");
            }
            else
            {
                finalresult = "Cannot Divide by Zero";
            }
        }
        private async Task<Calculator> SaveCalculator(string o)
        {
            CalcEntity calc = new CalcEntity();
            calc.Firstnum = Convert.ToInt32(num1);
            calc.SecondNum = Convert.ToInt32(num2);
            calc.Operator = o;
            calc.Result =Convert.ToInt32(finalresult);
            calc.CreatedOn = DateTime.Now;
            
            await Http.PostAsJsonAsync("http://localhost:5289/api/Calculator/api/Calculator/Create", calc);

            //num1= calculator.
            
            //calculator = new calculator();

            return null;
        }

    }

    public class CalcEntity
    {
        public int id { get; set; }
        public int Firstnum { get; set; }
        public int  SecondNum { get; set; }
        public string Operator { get; set; }
        public int Result { get; set; }
        public DateTime CreatedOn { get; set; }

    }

}


