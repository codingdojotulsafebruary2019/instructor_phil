using System;
using Microsoft.AspNetCore.Mvc;

namespace DotNetWebDemo.Controllers
{
    public class HomeController:Controller
    {
        [HttpGet]
        [Route("")]
        public string Index()
        {
            return "Hello World from Index method in Home Controller!";
        }

        [HttpGet("success/{name}")]
        public IActionResult Process(string name)
        {
            Console.WriteLine($"Name is: {name}");
            ViewBag.UserName = name;
            return View("Success");
        }
    }
}