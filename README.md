# Car Maintenance Tracker (.NET MAUI)

A cross-platform mobile app built with .NET MAUI for iPhone and Android to efficiently manage car maintenance activities, track oil changes, and monitor service schedules.

![License](https://img.shields.io/badge/license-MIT-blue.svg)
![.NET](https://img.shields.io/badge/.NET-8.0+-purple.svg)
![Platform](https://img.shields.io/badge/platform-iOS%20%7C%20Android-green.svg)

## ✨ Features

- **Track Oil Changes**: Log oil change activities with date, mileage, and notes
- **Smart Reminders**: Get suggested maintenance intervals based on completed oil change history
- **Activity Management**: Mark activities as completed or pending with status toggling
- **Quick Delete**: Swipe to delete entries that are no longer needed
- **Persistent Storage**: All entries are saved locally on your device
- **Clean UI**: Modern, intuitive interface optimized for mobile devices
- **Cross-Platform**: Works seamlessly on both iOS and Android

## 🎯 Key Capabilities

### Oil Change Tracking
- Add oil change entries with specific date and mileage
- Store detailed notes about the service (e.g., oil type, filter replacement)
- Default interval calculation: 5,000 miles between oil changes
- View next recommended oil change mileage at a glance

### Activity Management
- **Status Tracking**: Toggle between "Pending" and "Completed" status
- **Entry Deletion**: Swipe left on any entry to remove it
- **Chronological View**: Latest entries appear first
- **Detailed Information**: Full view of all service records

## 📋 Project Structure

```
CarMaintenanceApp/
├── Models/
│   └── OilChangeEntry.cs          # Data model for oil change entries
├── ViewModels/
│   └── OilChangeViewModel.cs       # Business logic and state management
├── Views/
│   ├── MainPage.xaml               # Main user interface
│   └── MainPage.xaml.cs            # Code-behind
├── Services/
│   └── MaintenanceStorageService.cs  # Local data persistence
├── App.xaml                        # Application-wide resources
├── App.xaml.cs                     # Application startup logic
├── AppShell.xaml                   # Shell navigation structure
├── MauiProgram.cs                  # MAUI configuration and setup
└── CarMaintenanceApp.csproj        # Project configuration
```

## 🛠️ Build Prerequisites

### Requirements
- **.NET SDK 8.0+** - Download from [dotnet.microsoft.com](https://dotnet.microsoft.com)
- **MAUI Workload** - Required for cross-platform development
- **Xcode 14.3+** (for iOS development)
- **Android SDK 24+** (for Android development)

### Installation

1. **Install MAUI Workload**:
```bash
dotnet workload install maui
```

2. **Verify Installation**:
```bash
dotnet workload list
```

## 🚀 Getting Started

### Clone and Build

```bash
# Clone the repository
git clone https://github.com/qmmughal/car-maintenance.git
cd car-maintenance

# Restore dependencies
cd CarMaintenanceApp
dotnet restore
```

### Run on Android

```bash
# Build and run on connected Android device
dotnet build -f net8.0-android -c Release

# Or use the shorthand with -t Run
dotnet build -t Run -f net8.0-android
```

### Run on iOS

```bash
# Build and run on iOS simulator or connected device
dotnet build -f net8.0-ios -c Release

# Or use the shorthand with -t Run
dotnet build -t Run -f net8.0-ios
```

### Debug Locally

```bash
# Using Visual Studio 2022
# - Open CarMaintenanceApp.csproj
# - Select Android (or iOS) from the debug target dropdown
# - Press F5 to start debugging

# Using VS Code
# - Install C# Dev Kit extension
# - Press F5 to launch the debugger
# - Choose your target platform
```

## 🎨 UI/UX Design

The app follows modern mobile design principles:

- **Responsive Layout**: Adapts to different screen sizes
- **Accessible Colors**: High contrast for readability
- **Gesture Support**: Swipe-to-delete for intuitive interaction
- **Touch-Friendly**: Buttons and input fields optimized for touch
- **Data Visualization**: Clear display of maintenance schedules

### Color Scheme
- Primary: `#2563EB` (Blue) - Main action buttons
- Success: `#0F766E` (Teal) - Suggested mileage highlight
- Danger: `#DC2626` (Red) - Delete action
- Neutral: `#334155` (Slate) - Secondary buttons

## 📱 Technical Details

### Architecture
- **MVVM Pattern**: Clean separation between UI and business logic
- **Binding Context**: Automatic UI updates via data binding
- **ObservableCollection**: Real-time UI synchronization

### Data Model
```csharp
public class OilChangeEntry
{
    public Guid Id { get; set; }
    public DateTime Date { get; set; }
    public int OdometerMiles { get; set; }
    public string Notes { get; set; }
    public bool IsCompleted { get; set; }
    public string Status { get; } // "Completed" or "Pending"
}
```

### State Management
- **BindableObject**: Implements `INotifyPropertyChanged` for reactive updates
- **Commands**: User interactions trigger business logic through ICommand implementations
- **Local Storage**: Data persisted using device-specific storage

## 🔐 Data Privacy

- All data is stored **locally on your device**
- No cloud synchronization or external servers
- No personal information is transmitted
- Full user control over data

## 🐛 Troubleshooting

### Common Issues

**MAUI Workload Not Found**
```bash
# Update .NET SDK
dotnet sdk check

# Reinstall MAUI workload
dotnet workload restore
```

**Build Fails on Android**
- Ensure Android SDK is installed (API 24+)
- Check `ANDROID_SDK_ROOT` environment variable

**iOS Build Issues**
- Update Xcode to latest version
- Run `xcrun xcode-select --reset` to reset Xcode path
- Ensure iOS deployment target matches project settings (14.2+)

## 📈 Future Enhancements

- [ ] Multiple maintenance types (tire rotation, filter changes, etc.)
- [ ] Maintenance reminders and notifications
- [ ] Data export to CSV/PDF
- [ ] Cloud sync across devices
- [ ] Expense tracking and reports
- [ ] Fuel economy monitoring
- [ ] Service history analytics
- [ ] Dark mode support

## 🤝 Contributing

Contributions are welcome! Please feel free to submit a Pull Request with improvements.

### Development Guidelines
- Follow C# naming conventions (PascalCase for public members)
- Write clean, readable code with meaningful comments
- Test changes on both iOS and Android platforms
- Update documentation for new features

## 📄 License

This project is open-source and available under the [MIT License](LICENSE).

## 💡 Tips & Best Practices

### Tracking Oil Changes
1. Always record the **actual odometer reading** at service
2. Keep notes about the **oil type and brand** used
3. Mark activities as **completed** after service confirmation
4. Review the **suggested mileage** regularly for upcoming maintenance

### Maintenance Intervals
- Standard intervals: 3,000-5,000 miles (conventional oil)
- Synthetic oil: 5,000-7,500 miles
- Full synthetic: 7,500-10,000 miles
- *Consult your vehicle manual for specific recommendations*

## 📞 Support & Contact

For issues, feature requests, or questions:
- Open a GitHub issue: [GitHub Issues](https://github.com/qmmughal/car-maintenance/issues)
- Start a discussion: [GitHub Discussions](https://github.com/qmmughal/car-maintenance/discussions)

---

**Happy Maintenance Tracking! 🚗**
