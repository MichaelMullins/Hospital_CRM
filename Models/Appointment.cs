using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_CRM.Models
{
    public class Appointment
    {
        public int ID { get; set; }
        public int PatientID { get; set; }
        public int DoctorID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string? Notes { get; set; }

        public List<int>? TreatmentIDs { get; set; }
    }

}
