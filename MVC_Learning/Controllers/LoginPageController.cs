using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVC_Learning.Controllers
{
    public class LoginPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       
        
    }
}