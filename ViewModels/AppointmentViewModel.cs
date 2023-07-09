using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_CRM.Models
{
    public class AppointmentViewModel
    {
        public int ID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string DoctorName { get; set; }
        public string DoctorSpecialization { get; set; }
        public string PatientName { get; set; }
        public string Notes { get; set; }
        public List<TreatmentViewModel> Treatments { get; set; }
    }



}
