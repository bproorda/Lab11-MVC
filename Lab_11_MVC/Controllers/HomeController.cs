using Lab_11_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_11_MVC.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(int StartYear, int EndYear)
        {
            // Don't show View() directly in a POST; redirect instead
            // return View();

            // Post - Redirect - Get
            return RedirectToAction("Adder", new { StartYear, EndYear });
        }

        // Model binding of all the applicable properties in the model type
        public IActionResult Adder(IndexViewModel viewModel)
        {
            return View(viewModel);
        }
    }
}
