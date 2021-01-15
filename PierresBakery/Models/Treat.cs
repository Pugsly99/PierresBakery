using System.Collections.Generic;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PierresBakery.Models
{
    public class Treat
    {
        public Treat()
        {
            this.JoinEntries = new HashSet<TreatFlavor>(); 
        }
        public int TreatId { get; set; }

        [DisplayName("Treat Name")]
        public string TreatName { get; set; }

        public virtual string User { get; set; }
        public virtual ICollection<TreatFlavor> JoinEntries { get; set; } 
    }
}

