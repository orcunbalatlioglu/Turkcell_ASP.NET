﻿using Microsoft.AspNetCore.Mvc;

namespace First_Project.Controllers
{
    public class ViewController : Controller
    {
        public IActionResult WithLayoutExample()
        {
            return View();
        }
        public IActionResult NoLayoutExample()
        {
            return View();
        }
    }
}