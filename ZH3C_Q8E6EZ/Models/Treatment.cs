using System;
using System.Collections.Generic;

namespace ZH3C_Q8E6EZ.Models
{
    public partial class Treatment
    {
        public Treatment()
        {
            ProcedureDones = new HashSet<ProcedureDone>();
        }

        public int TreatmentSk { get; set; }
        public int? AnimalFk { get; set; }
        public DateTime? Date { get; set; }
        public bool? Paid { get; set; }

        public virtual Animal? AnimalFkNavigation { get; set; }
        public virtual ICollection<ProcedureDone> ProcedureDones { get; set; }
    }
}
