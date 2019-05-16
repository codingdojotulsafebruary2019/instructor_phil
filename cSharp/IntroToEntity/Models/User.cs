using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IntroToEntity.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }

        public List<Product> Products {get; set;}

        public User()
        {
            Products = new List<Product>();
        }
    }
}