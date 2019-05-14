using System;
using System.ComponentModel.DataAnnotations;

namespace TheDojoLeague.Models
{
    public class Ninja
    {
       [Key]
       public int Ninja_Id {get; set;}

       [Required(ErrorMessage="Name is required")]
       [Display(Name="Name:")]
       public string Name {get; set;}

        [Required(ErrorMessage="Level is required")]
        [Display(Name="Level:")]
       public int Level {get; set;}

       [Required(ErrorMessage="Description is required")]
        [Display(Name="Description:")]
       public string Description {get; set;}

        [Display(Name="Dojo:")]
       public int Dojo_Id {get; set;}
       public Dojo Dojo {get; set;}

       public DateTime Created_At {get; set;}
       public DateTime Updated_At {get; set;}

       public Ninja()
       {
           Created_At = DateTime.Now;
           Updated_At = DateTime.Now;
       }
    }
}