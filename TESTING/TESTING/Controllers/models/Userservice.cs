using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TESTING.Controllers.models
{

    public class Userservice : IUserservice
    {
        List<Users> aa = new List<models.Users>
        {
            new Users(1,"oday","059574","ooo",DateTime.Now),
            new Users(2,"uu","059574","ooao", DateTime.Now),
           new Users(3,"oday","059574","ooo", DateTime.Now),
        new Users(4,"oday","059574","ooo", DateTime.Now),
        new Users(5,"oday","059574","ooo", DateTime.Now)

             };
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var z = aa.FirstOrDefault(i => i.Id == id);
            aa.Remove(z);
        }
        [HttpGet]
        public List<Users> get()
        {
            return aa;
        }
        [HttpGet("{id}")]
        public Users get(int id)
        {
            return aa.FirstOrDefault(i => i.Id == id);
        }
        [HttpPost]
        public void Post(Users user)
        {
            aa.Add(user);
        }
    }
}
