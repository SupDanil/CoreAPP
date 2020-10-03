using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CoreApp.Models;
using CoreApp.Data;

namespace CoreApp.Controllers
{
    public class HomeController : Controller
    {
         //var rnd = new Random(DateTime.Now.Millisecond);
        private readonly NickNameContext db;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, NickNameContext context)
        {
            _logger = logger;
            db = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string Name)
        {
            
            return View();
        }


    }
}
