using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TheDojoLeague.Models
{
    public class Dojo
    {
       [Key]
       public int Dojo_Id {get; set;}

       [Required(ErrorMessage="Name is required")]
       [Display(Name="Name:")]
       public string Name {get; set;}

       [Required(ErrorMessage="Location is required")]
        [Display(Name="Location:")]
       public string Location {get; set;}

       [Required(ErrorMessage="Description is required")]
        [Display(Name="Description:")]
       public string Description {get; set;}

       public IEnumerable<Ninja> Ninjas {get; set;}

       public DateTime Created_At {get; set;}
       public DateTime Updated_At {get; set;}

       public Dojo()
       {
           Ninjas = new List<Ninja>();
           Created_At = DateTime.Now;
           Updated_At = DateTime.Now;
       }
    }
}