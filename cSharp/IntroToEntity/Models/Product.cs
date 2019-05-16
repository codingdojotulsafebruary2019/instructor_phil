using System;
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
    }
}