using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modeling.Models
{
    public class Contraindication
    {
        public int ContraindicationID { get; set; }
        public int PatientID { get; set; }
        public int MedicationID { get; set; }

        // Властивості навігації
        public virtual Patient Patient { get; set; }
        public virtual Medication Medication { get; set; }
    }
}
