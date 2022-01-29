using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstCoreAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        //private static readonly string[] Summaries = new[]
        //{
        //    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        //};

       // private readonly ILogger<WeatherForecastController> _logger;

        //public WeatherForecastController(ILogger<WeatherForecastController> logger)
        //{
        //    _logger = logger;
        //}

        [HttpGet]
        public string Get()
        {
            return "success";
           // List<employee> lst = new List<employee>() { new employee() { Name = "Raja1", Age = 38 } , new employee() { Name = "Raja2", Age = 38 } };
           // employee t=lst.First();

            //var rng = new Random();
            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateTime.Now.AddDays(index),
            //    TemperatureC = rng.Next(-20, 55),
            //    Summary = Summaries[rng.Next(Summaries.Length)]
            //})
            //.ToArray();
        }
        [HttpGet("/[controller]/Raja")]
        public string Raja()
        {
            return "I am Raja Mohamed";
        }
        [HttpGet("/[controller]/Raja/{id}")]
        public string Raja(string id)
        {
            return "I am Raja Mohamed" + id;
        }
        public class employee
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        [HttpGet("/[controller]/Employee")]
        public employee Emp()
        {
            return new employee() { Name = "Raja", Age = 38 };
        }
        [HttpGet("/[controller]/Employee/{empid}")]
        public ActionResult<employee> Emp(int empid)
        {
            if (empid == 1)
                return new employee() { Name = "Raja", Age = 38 };
            else
                return NotFound();
        }
        [HttpPost]
        public void TestPost(int id)
        {

        }
        [HttpPost("/[controller]/Employee")]
        public void Emp(employee emp)
        {

        }

        [HttpPost("/[controller]/Employee1")]
        public void Emp(string Name, int Age)
        {

        }
    }
}
