using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IntroToEntity.Models;
using Microsoft.EntityFrameworkCore;

namespace IntroToEntity.Controllers
{
    public class HomeController : Controller
    {
        private Context _context;

        public HomeController(Context context)
        {
            _context = context;
        }

        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            List<User> Users = _context.Users.Include(user => user.Products).ToList();
            // List<Product> Products = _context.Products.Include(product => product.User).ToList();
            // User user = new User()
            // {
            //     Name="Phil",
            //     Email="phil@krull.com",
            //     Password="password",
            //     Age=20
            // };
            // _context.Add(user);
            // _context.SaveChanges();

            // Product product = new Product()
            // {
            //     Name="table",
            //     UserId=1
            // };
            // _context.Add(product);
            // _context.SaveChanges();
            Console.WriteLine(Users[0].Products[0].Name);
            Console.WriteLine(Users[0].Products[1].Name);

            return View();
        }

    }
}
