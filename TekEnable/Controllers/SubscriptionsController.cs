﻿using Microsoft.AspNetCore.Mvc;

namespace TekEnable.Controllers
{
    public class SubscriptionsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
