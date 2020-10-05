using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CoreApp.Models;
using CoreApp.Data;
using Microsoft.EntityFrameworkCore;

namespace CoreApp.Controllers
{
    public class HomeController : Controller
    {
        public static string UserName;
       
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
        public IActionResult Index(string Name, bool Check)
        {
            if (Check==true)
            {
                HomeController.UserName = Name;
                return RedirectToAction("Show");
            }
            else
            {
                //ModelState.AddModelError("Fuck","Поставьте галочку");
                return View();
            }
               
            
               
        }

        public async Task<IActionResult> Show()
        {
            Random random = new Random();
            int rnd = random.Next(0, 51);
            NickName NN = await db.NickNames.FirstOrDefaultAsync(p => p.Id == rnd);
            ViewData["Nick"] =  NN.Nick;
            ViewData["Name"] = HomeController.UserName;
            return View();
            
        }

        
    }
}
