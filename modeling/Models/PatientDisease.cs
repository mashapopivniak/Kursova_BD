using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modeling.Models
{
    public class PatientDisease
    {
        public int PatientDiseaseID { get; set; }
        public int PatientID { get; set; }
        public int DoctorID { get; set; }
        public int DiseaseID { get; set; }
        public DateTime DiseaseBegin { get; set; }
        public DateTime DiseaseEnd { get; set; }
        public int Rating { get; set; }
        public Boolean Cured { get; set; }
        public Boolean Accounting { get; set; }

        // Властивості навігації
        public virtual Patient Patient { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual Disease Disease { get; set; }
    }
}
