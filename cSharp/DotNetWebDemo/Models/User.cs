using System.ComponentModel.DataAnnotations;

namespace DotNetWebDemo.Models
{
    public class User
    {
        [Required]
        public string FirstName {get; set;}

        [Required(ErrorMessage="Last Name is required!")]
        [MinLength(2, ErrorMessage="Min Length is 2!")]
        public string LastName {get; set;}
    }
}