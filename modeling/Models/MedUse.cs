using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modeling.Models
{
    public class MedUse
    {
        public int MedUseID { get; set; }
        public int HistoryID { get; set; }
        public int MedicationID { get; set; }

        // Властивості навігації
        public virtual History History { get; set; }
        public virtual Medication Medication { get; set; }
    }
}
