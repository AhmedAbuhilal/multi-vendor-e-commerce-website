﻿using Microsoft.AspNetCore.Mvc;

namespace MVC_Project.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Product(int id)
        {
            return View();
        }
    }
}
