﻿using Microsoft.AspNetCore.Mvc;

namespace assignment_29.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}
