using System.Collections.Generic;

namespace IntroToEntity.Models
{
    public class CartForm
    {
        public Cart Cart {get; set;}
        public List<User> AllUsers {get; set;}
        public List<Product> AllProducts {get; set;}
    }
}