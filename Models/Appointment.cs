using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointmentAutomation.Models
{
    public class Appointment
    {
        [Key]
        public string Id { get; set; }
        public Periyot Periyot { get; set; }
        public User Patient { get; set; }

    }

}
