using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointmentAutomation.Models
{
    public enum Roles
    {
        Kardiyoloji,
        BeyinCerrahi,
        Stajyer
    }
    public class Doctor : User
    {

        public Roles Role { get; set; }
    }

}
