using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeLineClinicDataAccessLayer.Models
{
    public class Appointments
    {
        [Key]
        [Required]
        public int AppointmentNo { get; set; }
        public string PatientID { get; set; }
        public string DoctorID { get; set; }
        public DateTime DateOfAppointment { get; set; }
    }
}
