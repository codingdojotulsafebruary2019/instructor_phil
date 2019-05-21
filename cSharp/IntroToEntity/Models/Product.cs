using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IntroToEntity.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public List<Cart> CartItems {get; set;}

        public Product()
        {
            CartItems = new List<Cart>();
        }
    }
}