using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modeling.Models
{
    public class Disease
    {
        public int DiseaseID { get; set; }
        public string DiseaseName { get; set; }

        // Властивості навігації
        public virtual ICollection<PatientDisease> PatientDiseases { get; set; }
        public virtual ICollection<History> Histories { get; set; }

    }
}
