using CalculatorClassLibrary;
using CalculatorWebApp.DataAccess;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        CalculatorDataAccessLayer objCalculator = new CalculatorDataAccessLayer();


        //    //[HttpGet]
        //    //[Route("api/Calculator/Index")]
        //    //public IEnumerable<Calculator> Index()
        //    //{
        //    //    return objCalculator.GetAllCalculators();
        //    //}

        [HttpPost]
        [Route("api/Calculator/Create")]
        public void Create([FromBody] Calculator calculator)
        {
            objCalculator.AddCalculator(calculator);
        }
    }
}





     