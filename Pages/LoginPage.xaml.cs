using Microsoft.Maui.Controls;
using System;
using Microsoft.Maui.Graphics;
using HospitalAppointmentAutomation.ViewModels;
using HospitalAppointmentAutomation.Services;
using HospitalAppointmentAutomation.Pages;


namespace HospitalAppointmentAutomation
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            var email = EmailEntry.Text;
            var password = PasswordEntry.Text;

            // Kullanıcı adı ve parola doğrulama işlemini burada yapabilirsiniz.
            // Örnek olarak, basit bir doğrulama işlemi gerçekleştirilmiştir.
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                await DisplayAlert("Error", "Username or password cannot be empty.", "OK");
                return;
            }

            // Kullanıcının rolünü belirleme işlemi
            string userRole = await GetUserRoleAsync(email, password);

            // Yönlendirme işlemini gerçekleştirme
            switch (userRole)
            {
                case "admin":
                    Application.Current.MainPage = new AdminPage();
                    break;
                case "doctor":
                    Application.Current.MainPage = new DoctorPage();
                    break;
                case "user":
                    Application.Current.MainPage = new UserPage();
                    break;
                default:
                    await DisplayAlert("Error", "Invalid email or password.", "OK");
                    break;
            }
        }

        private async Task<string> GetUserRoleAsync(string email, string password)
        {
            var adminService = new AdminService();
            var admins = await adminService.GetAdminsAsync();

            var admin = admins.FirstOrDefault(u => u.Email == email && u.Password == password);
            if (admin != null)
            {
                return "admin";
            }

            var doctorService = new DoctorService();
            var doctors= await doctorService.GetDoctorsAsync();

            var doctor = doctors.FirstOrDefault(u => u.Email == email && u.Password == password);
            if (doctor != null)
            {
                return "doctor";
            }
            
            var userService = new UserService();
            var users = await userService.GetUsersAsync();

            var user = users.FirstOrDefault(u => u.Email == email && u.Password == password);
            if (user != null)
            {
                return "user";
            }

            return string.Empty; // Geçersiz kullanıcı adı veya parola durumu
        }




        private async void OnCancelClicked(object sender, EventArgs e)
            {
                Application.Current.MainPage = new MainPage();
            }
    }
}
