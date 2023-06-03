using System;
using Microsoft.Maui.Controls;
using HospitalAppointmentAutomation.ViewModels;
using HospitalAppointmentAutomation.Models;
using HospitalAppointmentAutomation.Services;

namespace HospitalAppointmentAutomation
{
    public partial class RegisterPage : ContentPage
    {
        private RegisterViewModel _viewModel;
        private UserService _userService;

        public RegisterPage()
        {
            InitializeComponent();

            _viewModel = new RegisterViewModel();
            _userService = new UserService();
            BindingContext = _viewModel;
        }

        private async void OnRegisterClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(_viewModel.Email)
                && !string.IsNullOrWhiteSpace(_viewModel.Password)
                && !string.IsNullOrWhiteSpace(_viewModel.ConfirmPassword)
                && !string.IsNullOrWhiteSpace(_viewModel.Username)
                && _viewModel.Password == _viewModel.ConfirmPassword
                )
            {
                // Check if the email already exists in the database
                bool isEmailExists = await _userService.CheckEmailExistsAsync(_viewModel.Email);

                if (isEmailExists)
                {
                    await DisplayAlert("Error", "This email is already registered. Please use a different email.", "OK");
                    return;
                }

                // Validate email format
                if (!IsValidEmail(_viewModel.Email))
                {
                    await DisplayAlert("Error", "Please enter a valid email address.", "OK");
                    return;
                }

                // Create a new User object from the ViewModel
                User newUser = new User
                {
                    Username = _viewModel.Username, // Set the username as the email
                    Email = _viewModel.Email,
                    Password = _viewModel.Password
                };

                // Register the user here
                bool isSuccess = await _userService.AddUserAsync(newUser);

                if (isSuccess)
                {
                    await DisplayAlert("Success", "User registered successfully!", "OK");
                    await Navigation.PopToRootAsync();
                }
                else
                {
                    await DisplayAlert("Failure", "Registration failed. Please try again later.", "OK");
                }
            }
            else
            {
                await DisplayAlert("Error", "Please make sure all fields are filled out and the passwords match.", "OK");
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private async void OnCancelClicked(object sender, EventArgs e)
        {
            // Navigate to the MainPage
            Application.Current.MainPage = new MainPage();
        }
    }
}
