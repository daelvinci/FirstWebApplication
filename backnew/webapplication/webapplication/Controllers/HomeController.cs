﻿using Microsoft.AspNetCore.Mvc;

namespace webapplication.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }

}
