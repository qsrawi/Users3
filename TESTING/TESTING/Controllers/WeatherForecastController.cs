using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TESTING.Controllers.models;

namespace TESTING.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        IUserservice userservice = null;

        public WeatherForecastController(IUserservice userservice)
        {
            this.userservice = userservice;

        }
        [HttpGet]
        public List<Users> get()
        {
            return userservice.get();
        }
        [HttpGet("{id}")]
        public Users get(int id)
        {
            return userservice.get(id);
        }
        [HttpPost]
        public void Post(Users user)
        {
            userservice.Post(user);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            userservice.Delete(id);
        }
    }
}
