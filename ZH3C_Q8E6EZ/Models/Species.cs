using System;
using System.Collections.Generic;

namespace ZH3C_Q8E6EZ.Models
{
    public partial class Species
    {
        public Species()
        {
            Animals = new HashSet<Animal>();
        }

        public int SpeciesSk { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Animal> Animals { get; set; }
    }
}
