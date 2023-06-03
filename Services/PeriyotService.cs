using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HospitalAppointmentAutomation.Models;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace HospitalAppointmentAutomation.Services
{
    public class PeriyotService : IPeriyotService
    {
        private HttpClient _client;

        public PeriyotService()
        {
            _client = new HttpClient();
        }

        public async Task<List<Periyot>> GetPeriyotsAsync()
        {
            var response = await _client.GetAsync("https://localhost:7113/api/periyot");
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Periyot>>(content);
        }

        public async Task<Periyot> GetPeriyotAsync(int id)
        {
            var response = await _client.GetAsync($"https://localhost:7113/api/periyot/{id}");
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Periyot>(content);
        }

        public async Task<bool> AddPeriyotAsync(Periyot periyot)
        {
            var json = JsonConvert.SerializeObject(periyot);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("https://localhost:7113/api/periyot", data);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdatePeriyotAsync(Periyot periyot)
        {
            var json = JsonConvert.SerializeObject(periyot);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PutAsync($"https://localhost:7113/api/periyot/{periyot.Id}", data);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeletePeriyotAsync(int id)
        {
            var response = await _client.DeleteAsync($"https://localhost:7113/api/periyot/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}
