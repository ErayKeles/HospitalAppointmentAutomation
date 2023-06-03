using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HospitalAppointmentAutomation.Models;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace HospitalAppointmentAutomation.Services
{
    public class AppointmentService : IAppointmentService
    {
        private HttpClient _client;

        public AppointmentService()
        {
            _client = new HttpClient();
        }

        public async Task<List<Appointment>> GetAppointmentsAsync()
        {
            var response = await _client.GetAsync("https://localhost:7113/api/appointment");
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Appointment>>(content);
        }

        public async Task<Appointment> GetAppointmentAsync(int id)
        {
            var response = await _client.GetAsync($"https://localhost:7113/api/appointment/{id}");
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Appointment>(content);
        }

        public async Task<bool> AddAppointmentAsync(Appointment appointment)
        {
            var json = JsonConvert.SerializeObject(appointment);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("https://localhost:7113/api/appointment", data);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateAppointmentAsync(Appointment appointment)
        {
            var json = JsonConvert.SerializeObject(appointment);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PutAsync($"https://localhost:7113/api/appointment/{appointment.Id}", data);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteAppointmentAsync(int id)
        {
            var response = await _client.DeleteAsync($"https://localhost:7113/api/appointment/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}
