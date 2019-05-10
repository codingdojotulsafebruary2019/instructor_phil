using System;
using Microsoft.AspNetCore.Mvc;
using DotNetWebDemo.Models;

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
            int[] numbers = new int[]{2,3,4,5,6,7,8,9};
            return View("Success", numbers);
        }

        [HttpGet("user")]
        public IActionResult UserPage()
        {
            User ShowUser = new User();
            ShowUser.FirstName = "Phil";
            ShowUser.LastName = "Krull";
            return View(ShowUser);
        }

        [HttpGet("formUser")]
        public IActionResult New()
        {
            return View();
        }

        [HttpPost("users")]
        public IActionResult Create(User user)
        {
            if(ModelState.IsValid)
            {
                System.Console.WriteLine(user.FirstName);
                TempData["FirstName"]=user.FirstName;
                TempData["LastName"]=user.LastName;
                return RedirectToAction("UserPage");
            } else {
                return View("New");
            }
        }
    }
}