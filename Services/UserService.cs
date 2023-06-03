using System.Collections.Generic;
using System.Threading.Tasks;
using HospitalAppointmentAutomation.Models;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace HospitalAppointmentAutomation.Services
{
    public class UserService : IUserService
    {
        private HttpClient _client;

        public UserService()
        {
            _client = new HttpClient();
        }
        public async Task<bool> CheckEmailExistsAsync(string email)
        {
            var users = await GetUsersAsync();
            var user = users.FirstOrDefault(u => u.Email == email);
            return user != null;
        }
        public async Task<List<User>> GetUsersAsync()
        {
            var response = await _client.GetAsync("https://localhost:7113/api/User");
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<User>>(content);
        }

        public async Task<User> GetUserAsync(int id)
        {
            var response = await _client.GetAsync($"https://localhost:7113/api/User{id}");
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<User>(content);
        }

        public async Task<bool> AddUserAsync(User user)
        {
            var json = JsonConvert.SerializeObject(user);
            var data = new StringContent(json, Encoding.UTF8, new MediaTypeHeaderValue("application/json"));
            var response = await _client.PostAsync("https://localhost:7113/api/User", data);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateUserAsync(User user)
        {
            var json = JsonConvert.SerializeObject(user);
            var data = new StringContent(json, Encoding.UTF8, new MediaTypeHeaderValue("application/json"));
            var response = await _client.PutAsync($"https://localhost:7113/api/User/{user.Id}", data);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteUserAsync(int id)
        {
            var response = await _client.DeleteAsync($"https://localhost:7113/api/User/{id}");
            return response.IsSuccessStatusCode;
        }
        
    }
}
