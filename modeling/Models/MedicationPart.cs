using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modeling.Models
{
    public class MedicationPart
    {
        public int MedicationPartID { get; set; }
        public int MedicationID { get; set; }
        public int IncludeID { get; set; }

        // Властивості навігації
        public virtual Medication Medication { get; set; }
    }
}
