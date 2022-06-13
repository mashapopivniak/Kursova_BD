using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modeling.Models
{
    public class Specialization
    {
        public int SpecializationID { get; set; }
        public string SpecializationName { get; set; }

        // Властивості навігації
        public virtual ICollection<Doctor> Doctors { get; set; }
    }
}
