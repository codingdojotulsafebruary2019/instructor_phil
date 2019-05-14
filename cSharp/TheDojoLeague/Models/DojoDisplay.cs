using System;
using System.Collections.Generic;

namespace TheDojoLeague.Models
{
    public class DojoDisplay
    {
        // Dojo for the form
        public Dojo Dojo {get; set;}
        // List of dojos to display
        public IEnumerable<Dojo> AllDojos {get; set;}
    }
}