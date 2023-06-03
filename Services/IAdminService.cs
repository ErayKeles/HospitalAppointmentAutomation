using HospitalAppointmentAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalAppointmentAutomation.Models;

namespace HospitalAppointmentAutomation.Services
{
    public interface IAdminService
    {
        Task<List<Admin>> GetAdminsAsync();
        Task<Admin> GetAdminAsync(int id);
        Task<bool> AddAdminAsync(Admin admin);
        Task<bool> UpdateAdminAsync(Admin admin);
        Task<bool> DeleteAdminAsync(int id);

        // For doctors
        Task<List<Doctor>> GetDoctorsAsync();
        Task<Doctor> GetDoctorAsync(int id);
        Task<bool> AddDoctorAsync(Doctor doctor);
        Task<bool> UpdateDoctorAsync(Doctor doctor);
        Task<bool> DeleteDoctorAsync(int id);

        // For appointments
        Task<List<Appointment>> GetAppointmentsAsync();
        Task<Appointment> GetAppointmentAsync(int id);
        Task<bool> AddAppointmentAsync(Appointment appointment);
        Task<bool> UpdateAppointmentAsync(Appointment appointment);
        Task<bool> DeleteAppointmentAsync(int id);

        // For periyot
        Task<List<Periyot>> GetPeriyotsAsync();
        Task<Periyot> GetPeriyotAsync(int id);
        Task<bool> AddPeriyotAsync(Periyot periyot);
        Task<bool> UpdatePeriyotAsync(Periyot periyot);
        Task<bool> DeletePeriyotAsync(int id);
    }
}
