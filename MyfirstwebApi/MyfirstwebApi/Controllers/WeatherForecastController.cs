using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web;
using System.Net;
using System.IO;


    namespace MyfirstwebApi.Controllers
    {
        [ApiController]
        [Route("[controller]/[Action]")]
        public class WeatherForecastController : ControllerBase
        {
            private static readonly string[] Summaries = new[]
            {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

            private readonly ILogger<WeatherForecastController> _logger;
            private List<Employee> employee = new List<Employee>() {
        new Employee{Id =100,Name="manisha",Address="vizag"},
        new Employee{Id=101,Name="sowji",Address="ramataxies"}};


            public WeatherForecastController(ILogger<WeatherForecastController> logger)
            {
                _logger = logger;
            }
        //private string SayHello(string name)
        //{
        //    return $"Hi {name}";
        //}
        //[HttpGet]
        //public ActionResult Get()
        //{
        //    return Ok(SayHello("manisha"));
        //}

        //[HttpPost]
        //public ActionResult Post()
        //{
        //    return Ok("Inside Post");
        //}

        [HttpGet]
        public ActionResult GetAllEmployee()
        {
            employee = new List<Employee>();
            employee.Add(new Employee { Id = 100, Name = "manisha", Address = "vizag" });
            return Ok(employee);
        }
        [HttpGet]
            public ActionResult GetFromUri([FromQuery] int id)
            {
                var emp = employee.Where(x => x.Id == id).FirstOrDefault();
                return Ok(emp);
            }
        [HttpGet]
        public ActionResult GetFrombody([System.Web.Http.FromBody] int id,string Name,string Address)
        {

            Employee employees = new Employee();
            employees.Id = employees.Id;
            employees.Name = Name;
            employees.Address = Address;
            var serialized = JsonConvert.SerializeObject(employees);
            return Ok(serialized);
        }
        [HttpGet("{id}/{Name}/{Address}")]
        public ActionResult GetfromRouter( int Id, string Name, [FromQuery] string Address)
        {
            return Ok($"my id is:{Id} my name is:{Name} i live at {Address}");
        }

        [HttpPut]
        public ActionResult Putbyid()
        {
            var emp = employee.Where(x => x.Id == 100).First();
            if (employee == null)
            {
                return BadRequest();
            }
            emp.Name = "manisha";
            emp.Address = "vizag";
            return Ok(employee);
        }
        [HttpPut]
        public ActionResult PutFromUri([FromQuery] int id)
        {
            var emp = employee.Where(x => x.Id == id).FirstOrDefault();
            if (emp == null)
            {
                return NoContent();
            }
            emp.Name = "mani";
            emp.Address = "hyd";
            return Ok(employee);
        }

        [HttpDelete]
        public ActionResult Deletebyid()
        {
            var emp = employee.Where(x => x.Id == 100).First();
            if (emp == null)
            {
                return BadRequest();
            }
            employee.Remove(emp);
            return Ok(employee);
        }

        [HttpPost]
        public ActionResult Postemployee()
        {
            employee.Add(new Employee { Id = 100, Name = "manisha", Address = "vizag" });
            return Ok(employee);
        }
        [HttpPost]
        public ActionResult PostfromUri([FromQuery] string Name, [FromQuery] string Address)
        {
            Employee employees = new Employee();
            employees.Id = employees.Id;
            employees.Name = Name;
            employees.Address = Address;
            var serialized = JsonConvert.SerializeObject(employees);
            return Ok(serialized);
        }

    }
}



