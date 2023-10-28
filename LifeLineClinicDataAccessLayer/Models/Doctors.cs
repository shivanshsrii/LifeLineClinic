using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeLineClinicDataAccessLayer.Models
{
    public class Doctors
    {
        [Key] [Required]
        public char DoctorID { get; set; }
        public string Specialization { get; set; }
        public string DoctorName { get; set; }
        public decimal Fees { get; set; }
    }
}
