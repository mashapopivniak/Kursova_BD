using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modeling.Models
{
    public class Patient
    {
        public int PatientID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Address { get; set; }
        public string Comment { get; set; }

        // Властивості навігації
        //public virtual ICollection<History> Histories { get; set; }
        private readonly ObservableListSource<History>histories = new ObservableListSource<History>();
        public virtual ObservableListSource<History> Histories { get { return histories; } }

        //public virtual ICollection<PatientDisease> PatientDiseases { get; set; }
        private readonly ObservableListSource<PatientDisease> patientDiseases = new ObservableListSource<PatientDisease>();
        public virtual ObservableListSource<PatientDisease> PatientDiseases { get { return patientDiseases; } }

        //public virtual ICollection<Contraindication> Contraindication { get; set; }
        private readonly ObservableListSource<Contraindication> сontraindications = new ObservableListSource<Contraindication>();
        public virtual ObservableListSource<Contraindication> Сontraindications { get { return сontraindications; } }

    }
}
