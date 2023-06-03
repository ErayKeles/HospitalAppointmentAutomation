using System.Collections.Generic;
using System.Threading.Tasks;
using HospitalAppointmentAutomation.Models;

namespace HospitalAppointmentAutomation.Services
{
    public interface IUserService
    {
        Task<List<User>> GetUsersAsync();
        Task<User> GetUserAsync(int id);
        Task<bool> AddUserAsync(User user);
        Task<bool> UpdateUserAsync(User user);
        Task<bool> DeleteUserAsync(int id);
        Task<bool> CheckEmailExistsAsync(string email);
    }
}
