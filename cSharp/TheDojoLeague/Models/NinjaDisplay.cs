using System.Collections.Generic;

namespace TheDojoLeague.Models
{
    public class NinjaDisplay
    {
        public Ninja Ninja {get; set;}
        public IEnumerable<Ninja> AllNinjas {get; set;}
        public IEnumerable<Dojo> AllDojos {get; set;}

    }
}