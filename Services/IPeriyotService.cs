using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalAppointmentAutomation.Models;
namespace HospitalAppointmentAutomation.Services
{
    public interface IPeriyotService
    {
        Task<List<Periyot>> GetPeriyotsAsync();
        Task<Periyot> GetPeriyotAsync(int id);
        Task<bool> AddPeriyotAsync(Periyot periyot);
        Task<bool> UpdatePeriyotAsync(Periyot periyot);
        Task<bool> DeletePeriyotAsync(int id);
    }
}
