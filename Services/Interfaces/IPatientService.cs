using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_CRM.Services.Interfaces
{
    public interface IPatientService
    {
        Patient GetPatientById(int id);
        void AddPatient(Patient patient);
        
    }
}
