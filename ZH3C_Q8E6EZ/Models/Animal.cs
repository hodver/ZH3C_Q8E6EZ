using System;
using System.Collections.Generic;

namespace ZH3C_Q8E6EZ.Models
{
    public partial class Animal
    {
        public Animal()
        {
            Treatments = new HashSet<Treatment>();
        }

        public int AnimalSk { get; set; }
        public string? Name { get; set; }
        public int? OwnerFk { get; set; }
        public short? BirthYear { get; set; }
        public int? SpeciesFk { get; set; }

        public virtual Species? SpeciesFkNavigation { get; set; }
        public virtual ICollection<Treatment> Treatments { get; set; }
    }
}
