using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_CRM.Models
{
    public class Treatment
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal Cost { get; set; }
    }
}
