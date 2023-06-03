using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HospitalAppointmentAutomation.Models;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using HospitalAppointmentAutomation.Services;

namespace HospitalAppointmentAutomation.Services
{
    public class DoctorService : IDoctorService
    {
        private HttpClient _client;

        public DoctorService()
        {
            _client = new HttpClient();
        }

        public async Task<List<Doctor>> GetDoctorsAsync()
        {
            var response = await _client.GetAsync("https://localhost:7113/api/doctor");
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Doctor>>(content);
        }

        public async Task<Doctor> GetDoctorAsync(int id)
        {
            var response = await _client.GetAsync($"https://localhost:7113/api/doctor/{id}");
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Doctor>(content);
        }
        public async Task<bool> AddDoctorAsync(Doctor doctor)
        {
            var json = JsonConvert.SerializeObject(doctor);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("https://localhost:7113/api/doctor", data);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateDoctorAsync(Doctor doctor)
        {
            var json = JsonConvert.SerializeObject(doctor);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PutAsync($"https://localhost:7113/api/docto/{doctor.Id}", data);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteDoctorAsync(int id)
        {
            var response = await _client.DeleteAsync($"https://localhost:7113/api/doctor/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}
