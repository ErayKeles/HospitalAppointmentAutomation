using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

using HospitalAppointmentAutomation.Models;

namespace HospitalAppointmentAutomation
{
    public partial class AppointmentPage : ContentPage
    {
        public AppointmentPage()
        {
            InitializeComponent();
            // Doktorları yüklemek ve randevuları almak için gereken kodlar buraya gelebilir
        }

        private async void OnBookAppointmentClicked(object sender, EventArgs e)
        {
            // Yeni bir randevu oluşturmak için kod burada olacak
            // Doktor, tarih ve saat bilgileri kullanılacak
            // İşlem tamamlandığında, randevu listesi güncellenebilir
        }

        private async void OnAppointmentSelected(object sender, SelectedItemChangedEventArgs e)
        {
            // Seçilen randevu ile ilgili detayları görüntülemek veya düzenlemek için kod burada olacak
        }
    }
}
