﻿using Microsoft.AspNetCore.Mvc;

namespace UltraGreateDivanShop.Web.Controllers;

public class ProfileController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}