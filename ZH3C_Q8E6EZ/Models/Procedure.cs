using System;
using System.Collections.Generic;

namespace ZH3C_Q8E6EZ.Models
{
    public partial class Procedure
    {
        public Procedure()
        {
            ProcedureDones = new HashSet<ProcedureDone>();
        }

        public int ProcedureSk { get; set; }
        public string? Name { get; set; }
        public string? Unit { get; set; }
        public decimal? Price { get; set; }

        public virtual ICollection<ProcedureDone> ProcedureDones { get; set; }
    }
}
