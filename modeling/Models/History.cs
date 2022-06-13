using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modeling.Models
{
    public class History
    {        
        public int HistoryID { get; set; }
        public DateTime AppDate { get; set; }
        public int PatientID { get; set; }
        public int DoctorID { get; set; }
        public int DiseaseID { get; set; }
        public string Comment { get; set; }

        // Властивості навігації
        public virtual Patient Patient { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual Disease Disease { get; set; }
        //public virtual ICollection<MedUse> MedUses { get; set; }
        private readonly ObservableListSource<MedUse> medUses = new ObservableListSource<MedUse>();
        public virtual ObservableListSource<MedUse> MedUses { get { return medUses; } }
    }
}
