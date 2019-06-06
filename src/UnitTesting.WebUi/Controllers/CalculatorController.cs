using Microsoft.AspNetCore.Mvc;
using System;
using UnitTesting.WebUi.Models;

namespace UnitTesting.WebUi.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            var model = new CalculatorViewModel();

            return View(model);
        }
    }
}