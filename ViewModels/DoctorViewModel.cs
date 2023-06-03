using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using HospitalAppointmentAutomation.Models;

namespace HospitalAppointmentAutomation.ViewModels
{
    public class DoctorViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Doctor> _doctors;

        public ObservableCollection<Doctor> Doctors
        {
            get { return _doctors; }
            set
            {
                if (_doctors != value)
                {
                    _doctors = value;
                    OnPropertyChanged();
                }
            }
        }

        public DoctorViewModel()
        {
            // Populate your doctor list here.
            // In a real application, this would likely be loaded from a database.
            Doctors = new ObservableCollection<Doctor>();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
