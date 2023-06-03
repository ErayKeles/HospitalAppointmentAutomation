using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalAppointmentAutomation.Models;
namespace HospitalAppointmentAutomation.Services
{
    public interface IAppointmentService
    {
        Task<List<Appointment>> GetAppointmentsAsync();
        Task<Appointment> GetAppointmentAsync(int id);
        Task<bool> AddAppointmentAsync(Appointment appointment);
        Task<bool> UpdateAppointmentAsync(Appointment appointment);
        Task<bool> DeleteAppointmentAsync(int id);
    }
}
