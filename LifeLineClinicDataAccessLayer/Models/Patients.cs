using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeLineClinicDataAccessLayer.Models
{
    public class Patients
    {
        [Key]
        [Required]
        public char PatientID { get; set; }
        public string PatientName { get; set; }
        public int Age { get; set; }
        public string Geder { get; set; }
        public double ContactNumber { get; set; }
    }
}
