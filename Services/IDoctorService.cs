using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalAppointmentAutomation.Models;

namespace HospitalAppointmentAutomation.Services
{
    public interface IDoctorService
    {
        Task<List<Doctor>> GetDoctorsAsync();
        Task<Doctor> GetDoctorAsync(int id);
        Task<bool> AddDoctorAsync(Doctor doctor);
        Task<bool> UpdateDoctorAsync(Doctor doctor);
        Task<bool> DeleteDoctorAsync(int id);
    }
}
