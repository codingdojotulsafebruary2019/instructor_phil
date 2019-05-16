using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheDojoLeague.Models;
using TheDojoLeague.Factory;

namespace TheDojoLeague.Controllers
{
    public class HomeController : Controller
    {
        private readonly DojoFactory _dojoFactory;
        private readonly NinjaFactory _ninjaFactory;

        public HomeController(DojoFactory dFactory, NinjaFactory nFactory)
        {
            _dojoFactory = dFactory;
            _ninjaFactory = nFactory;
        }

        [Route("dojos")]
        [HttpGet]
        public IActionResult Dojo()
        { 
            DojoDisplay ViewModel = new DojoDisplay()
            {
                AllDojos = _dojoFactory.FindAllDojos()
            };
            return View(ViewModel);
        }

        [HttpPost("dojos")]
        public IActionResult AddDojo(DojoDisplay DojoDisplay)
        {
            Dojo Dojo = DojoDisplay.Dojo;
            // check for validations
            if(ModelState.IsValid)
            {
                // add to db
                _dojoFactory.Add(DojoDisplay.Dojo);
                return RedirectToAction("Dojo");
            } else {
                // display the validation errors
                DojoDisplay.AllDojos = _dojoFactory.FindAllDojos();
                return View("Dojo", DojoDisplay);
            }
        }

        [HttpGet("ninjas")]
        public IActionResult Ninja()
        {
            NinjaDisplay NinjaDisplay = new NinjaDisplay()
            {
                AllNinjas = _ninjaFactory.FindAllNinjas(),
                AllDojos = _dojoFactory.FindAllDojos()
            };

            return View(NinjaDisplay);
        }

        [HttpPost("ninjas")]
        public IActionResult AddNinja(NinjaDisplay NinjaDisplay)
        {
            Ninja Ninja = NinjaDisplay.Ninja;
            // check for validations
            if(ModelState.IsValid)
            {
                // add to db
                _ninjaFactory.Add(Ninja);
                return RedirectToAction("Ninja");
            } else {
                // display the validation errors
                NinjaDisplay.AllNinjas = _ninjaFactory.FindAllNinjas();
                NinjaDisplay.AllDojos = _dojoFactory.FindAllDojos();

                return View("Ninja", NinjaDisplay);
            }
        }

        [HttpGet("ninja/{ninja_id}")]
        public IActionResult ShowNinja(int ninja_id)
        {
            var ninja = _ninjaFactory.FindNinja(ninja_id);
            var dojo = _dojoFactory.FindOneById(ninja.Dojo_Id);
            ninja.Dojo = dojo;
            return View(ninja);
        }

        [HttpGet("dojo/{dojo_id}")]
        public IActionResult ShowDojo(int dojo_id)
        {
            Dojo dojo = _dojoFactory.FindDojo(dojo_id);
            return View(dojo);
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return RedirectToAction("Dojo");
        }
    }
}
