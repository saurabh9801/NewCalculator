using CalculatorClassLibrary;
using CalculatorWebApp.DataAccess;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace WebAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public  class CalculatorController : ControllerBase
    {
        CalculatorDataAccessLayer objCalculator = new CalculatorDataAccessLayer();

        public int FirstNum { get;  set; }
        public int SecondNum { get;  set; }
        public object Result { get;  set; }

        //[HttpGet("{id}")]
        ////[Route("api/Calculator/Index")]
        //public IEnumerable<Calculator> Index()
        //{
        //    return objCalculator.GetAllCalculators();

        //}

        [HttpPost]
        [Route("api/Calculator/Create")]
        public object Create([FromBody] Calculator calculator)
        {
            objCalculator.AddCalculator(calculator);



            Calculator calculator1 = new Calculator();
           calculator1.Id = "1";
            calculator1.FirstNum = 5;
            calculator1.SecondNum = 10;
            calculator1.Operator = "";
            //calculator1.Result = 15;
            calculator1.Result = FirstNum + SecondNum;
            calculator1.Result = FirstNum - SecondNum;
            calculator1.Result = FirstNum * SecondNum;
            calculator1.Result = FirstNum / SecondNum;
            return Result;


        }


    }
}


    






     