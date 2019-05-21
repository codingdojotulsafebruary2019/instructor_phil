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

            Console.WriteLine(Users[0].Products[0].Name);
            Console.WriteLine(Users[0].Products[1].Name);

            return View(Users);
        }

        [HttpGet("users/{user_id}")]
        public IActionResult Show(int user_id)
        {
            IntroToEntity.Models.User User = _context.Users
            .Include(user=>user.Products)
            .Include(user=>user.CartItems)
            // .ThenInclude(cartItem=>cartItem.Product)
            .FirstOrDefault(user=>user.UserId == user_id);
            return View(User);
        }

        [HttpGet("cart")]
        public IActionResult Cart()
        {
            // a list of products
            // list of users
            // cart form
            CartForm ViewModel = new CartForm()
            {
                AllProducts = _context.Products.ToList(),
                AllUsers = _context.Users.ToList()
            };

            return View(ViewModel);
        }

        [HttpGet("users/new")]
        public IActionResult NewUser()
        {
            return View();
        }

        [HttpGet("products/new")]
        public IActionResult NewProduct()
        {
            ProductForm PForm = new ProductForm()
            {
                AllUsers = _context.Users.ToList()
            };

            return View(PForm);
        }

        [HttpPost("users")]
        public IActionResult AddUser(User User)
        {
            if(ModelState.IsValid)
            {
                _context.Add(User);
                _context.SaveChanges();
                return RedirectToAction("Index");
            } else {
                return View("NewUser");
            }
        }

        [HttpPost("products")]
        public IActionResult AddProduct(Product Product)
        {
            if(ModelState.IsValid)
            {
                _context.Add(Product);
                _context.SaveChanges();
                return RedirectToAction("Index");
            } else {
                return View("NewProduct");
            }
        }

        [HttpPost("cart")]
        public IActionResult AddUserToPrduct(CartForm CartForm)
        {
            Cart Cart = CartForm.Cart;
            if(ModelState.IsValid)
            {
                _context.Add(Cart);
                _context.SaveChanges();
                return RedirectToAction("Index");
            } else {
                CartForm ViewModel = new CartForm()
                {
                    AllProducts = _context.Products.ToList(),
                    AllUsers = _context.Users.ToList(),
                    Cart = Cart
                };
                return View("Cart", ViewModel);
            }
        }
    }
}
