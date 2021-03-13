using MarketUygulaması.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketUygulaması.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var course = new Course();
            course.Id = 1;
            course.Name = "Asp .NET Core";
            return View(course);
        }
    }
}
