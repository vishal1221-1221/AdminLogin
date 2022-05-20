using AdminLogin.Database.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AdminLogin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminLogin : ControllerBase
    {
        public List<AdminLoginModel> adminList = new List<AdminLoginModel>()
        {
            new AdminLoginModel
            {
                UserName="Admin",
                Password="Admin"
            }
            
        };


        // [System.Web.Http.Route("Login")]

        [HttpPost]
        public IActionResult AdminAuten(AdminLoginModel login)
        {

            //var log = ln.Login(login.UserName, login.Password);
            //var log = db.users.Where(x => x.UserName.Equals(login.UserName) && x.Password.Equals(login.Password)).FirstOrDefault();
            var log = adminList.Find(x => x.UserName == login.UserName && x.Password == login.Password);
            if (log == null)
            {
                return Ok(new { Status = "Invalid", Message = "Invalid User" });
            }
            else
            {



                return Ok(new { Status = "Success", Message = "Login Success", });
            }
        }

    }
}
