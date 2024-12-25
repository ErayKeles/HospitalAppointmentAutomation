# Hospital Appointment Automation MAUI Application

## Overview
The **Hospital Appointment Automation MAUI Application** is a cross-platform mobile and desktop application designed to simplify hospital operations. Built with **.NET MAUI**, this application ensures seamless integration with the Hospital Appointment Automation API, offering real-time management of hospital appointments, doctors, users, and schedules.

## Features
- **Cross-Platform Compatibility**: Runs on Android, iOS, Windows, and macOS.
- **User-Friendly Interface**: Intuitive UI built with XAML.
- **Appointment Management**: Manage patient appointments easily.
- **Doctor Management**: Access and update doctor information.
- **User Management**: Handle patient and admin profiles.
- **Real-Time Synchronization**: Integrates seamlessly with RESTful APIs.
- **Modular Architecture**: Implements MVVM (Model-View-ViewModel) for clean and maintainable code.

## Project Structure
```
HospitalAppointmentAutomation
│
├── App.xaml                          # Application root and resources
├── App.xaml.cs                       # Application lifecycle events
├── MauiProgram.cs                    # MAUI app initialization
│
├── Models                            # Data models
│   ├── Admin.cs
│   ├── Appointment.cs
│   ├── Doctor.cs
│   ├── Periyot.cs
│   ├── User.cs
│
├── Pages                             # UI pages
│   ├── AdminPage.xaml                # Admin-related operations
│   ├── AppointmentPage.xaml          # Appointment management
│   ├── DoctorPage.xaml               # Doctor management
│   ├── LoginPage.xaml                # User login page
│   ├── MainPage.xaml                 # Home/dashboard page
│   ├── PeriyotPage.xaml              # Time slot management
│   ├── RegisterPage.xaml             # User registration
│   ├── UserPage.xaml                 # User profile page
│
├── Platforms                         # Platform-specific implementations
│   ├── Android
│   ├── iOS
│   ├── MacCatalyst
│   ├── Windows
│
├── Resources                         # UI resources
│   ├── Fonts
│   ├── Images
│   ├── Styles
│
├── Services                          # Business logic services
│   ├── AdminService.cs
│   ├── AppointmentService.cs
│   ├── DoctorService.cs
│   ├── PeriyotService.cs
│   ├── UserService.cs
│
├── ViewModels                        # MVVM ViewModels
│   ├── AdminViewModel.cs
│   ├── AppointmentViewModel.cs
│   ├── DoctorViewModel.cs
│   ├── LoginViewModel.cs
│   ├── MainViewModel.cs
│   ├── PeriyotViewModel.cs
│   ├── RegisterViewModel.cs
│
└── HospitalAppointmentAutomation.csproj  # Project file
```

## Technologies Used
- **Framework**: .NET MAUI
- **Frontend**: XAML
- **Architecture**: MVVM (Model-View-ViewModel)
- **API Integration**: RESTful APIs for backend communication
- **Data Storage**: SQLite (if required)

## Getting Started

### Prerequisites
Ensure you have the following tools installed:
- **.NET 6.0 SDK or later**
- **Visual Studio 2022** (with .NET MAUI workload)

### Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/HospitalAppointmentAutomation.git
   cd HospitalAppointmentAutomation
   ```

2. Open the solution file:
   ```
   HospitalAppointmentAutomation.sln
   ```

3. Build the project:
   ```
   Run the build command in Visual Studio.
   ```

4. Run the application:
   - Choose your target platform (Android, iOS, Windows, or macOS).
   - Press `F5` to run the application.

### Configuration
- Update API endpoint URLs in `App.xaml.cs` or a configuration file.
- Ensure the API is running for full functionality.

## Usage
- **Login/Register**: Access the application by registering or logging in.
- **Manage Appointments**: Schedule, update, or delete appointments.
- **Doctor Profiles**: View and edit doctor-related information.
- **User Management**: Update profiles and manage settings.

## Contribution
Contributions are welcome! Follow these steps:
1. Fork the repository.
2. Create a new feature branch: `git checkout -b feature-name`
3. Commit your changes: `git commit -m 'Add feature'`
4. Push to the branch: `git push origin feature-name`
5. Submit a pull request.

## License
This project is licensed under the MIT License. See the `LICENSE` file for details.

## Contact
For any inquiries or feedback, feel free to reach out:
- **Email**: eraykelesk@gmail.com
- **LinkedIn**: [Eray Keleş](https://linkedin.com/in/eraykeles)
