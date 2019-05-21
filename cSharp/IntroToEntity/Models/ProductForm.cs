using System.Collections.Generic;

namespace IntroToEntity.Models
{
    public class ProductForm
    {
        public Product Product {get; set;}
        public List<User> AllUsers {get; set;}
    }
}