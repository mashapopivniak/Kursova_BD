using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modeling.Models
{
    public class Doctor
    {
        public int DoctorID { get; set; }
        public string DoctorName { get; set; }
        public string Address { get; set; }
        public int SpecializationID { get; set; }

        // Властивості навігації
        public virtual ICollection<History> Histories { get; set; }
        public virtual ICollection<PatientDisease> PatientDiseases { get; set; }
        public virtual Specialization Specialization { get; set; }

    }
}
