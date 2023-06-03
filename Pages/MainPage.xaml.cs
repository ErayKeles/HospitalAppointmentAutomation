using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using System;

namespace HospitalAppointmentAutomation
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new LoginPage();
        }

        private async void OnRegisterClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new RegisterPage();
        }

    }
}
