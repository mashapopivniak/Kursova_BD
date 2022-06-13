using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modeling.Models
{
    public class Medication
    {
        public int MedicationID { get; set; }
        public string MedicationName { get; set; }

        // Властивості навігації
        //public virtual ICollection<MedicationPart> MedicationParts { get; set; }
        private readonly ObservableListSource<MedicationPart>
        medicationParts = new ObservableListSource<MedicationPart>();
        public virtual ObservableListSource<MedicationPart> MedicationParts { get { return medicationParts; } }
        public virtual ICollection<MedUse> MedUses { get; set; }
        public virtual ICollection<Contraindication> Contraindications { get; set; }
    }
}
