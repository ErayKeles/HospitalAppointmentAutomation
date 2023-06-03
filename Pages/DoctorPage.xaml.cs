using System;
using HospitalAppointmentAutomation.Models;
using HospitalAppointmentAutomation.ViewModels;
using Microsoft.Maui.Controls;

namespace HospitalAppointmentAutomation
{
    public partial class DoctorPage : ContentPage
    {
        DoctorViewModel viewModel;

        public DoctorPage()
        {
            InitializeComponent();

            viewModel = new DoctorViewModel();
            BindingContext = viewModel;
        }

        void OnDoctorSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var doctor = (Doctor)e.SelectedItem;

            // Handle the event. For example, you might want to navigate to a new page that
            // provides details about the selected doctor.
            // Navigation.PushAsync(new DoctorDetailPage(doctor));
        }
    }
}
