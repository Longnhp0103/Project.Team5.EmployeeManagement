﻿using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Api.Controllers
{
    public class TeamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
