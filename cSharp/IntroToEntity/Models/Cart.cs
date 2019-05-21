using System;
using System.ComponentModel.DataAnnotations;

namespace IntroToEntity.Models
{
    // joining table, that connect many users can have many products
    public class Cart
    {
        [Key]
        public int CartId {get; set;}

        public int UserId {get; set;}
        public User User {get; set;}

        public int ProductId {get; set;}
        public Product Product {get; set;}
    }
}