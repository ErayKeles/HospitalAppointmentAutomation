using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HospitalAppointmentAutomation.Models;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace HospitalAppointmentAutomation.Services
{
    public class AdminService : IAdminService
    {
        private HttpClient _client;

        public AdminService()
        {
            _client = new HttpClient();
        }
        //Admin methods
        public async Task<List<Admin>> GetAdminsAsync()
        {
            var response = await _client.GetAsync("https://localhost:7113/api/admin");
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Admin>>(content);
        }

        public async Task<Admin> GetAdminAsync(int id)
        {
            var response = await _client.GetAsync($"https://localhost:7113/api/admin/{id}");
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Admin>(content);
        }

        public async Task<bool> AddAdminAsync(Admin admin)
        {
            var json = JsonConvert.SerializeObject(admin);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("https://localhost:7113/api/admin", data);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateAdminAsync(Admin admin)
        {
            var json = JsonConvert.SerializeObject(admin);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PutAsync($"https://localhost:7113/api/admin/{admin.Id}", data);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteAdminAsync(int id)
        {
            var response = await _client.DeleteAsync($"https://localhost:7113/api/admin/{id}");
            return response.IsSuccessStatusCode;
        }
        //Doktor işlemleri admin yetkısınede verıldı
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
            var response = await _client.PutAsync($"https://localhost:7113/api/doctor/{doctor.Id}", data);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteDoctorAsync(int id)
        {
            var response = await _client.DeleteAsync($"https://localhost:7113/api/doctor/{id}");
            return response.IsSuccessStatusCode;
        }

        // Appointment methods
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

        //Periyot işlemleri admin yetkisine verildi
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
