using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_CRM.Models
{
    public class PatientViewModel
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string GenderDisplay { get; set; }
        public List<AppointmentSummaryViewModel> Appointments { get; set; }

        public void CalculateAge(DateTime dateOfBirth)
        {
            var today = DateTime.Today;
            Age = today.Year - dateOfBirth.Year;

            // If the birthday hasn't occurred yet this year, subtract one.
            if (dateOfBirth.Date > today.AddYears(-Age)) Age--;
        }
    }


}
