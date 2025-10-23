# WPF Albums Application

A Windows desktop application built with WPF, C#, and .NET 8 that displays albums from an external API with a professional user interface.

## Features

- **Modern UI Design** - Clean and professional interface
- **Albums Management** - View and browse albums from JSONPlaceholder API
- **Album Details** - Click on User ID to view detailed album information
- **Contact Page** - Static contact information page
- **MVVM Pattern** - Proper separation of concerns
- **Dependency Injection** - Modern dependency management
- **Professional Design** - Clean styling with proper layout

## Technologies Used

- **.NET 8.0** - Latest .NET framework
- **WPF (Windows Presentation Foundation)** - Desktop UI framework
- **C#** - Programming language
- **MVVM Pattern** - Architecture pattern
- **Dependency Injection** - Service management
- **HTTP Client** - API communication
- **JSON** - Data serialization

## Project Structure

```
WpfApp2/
├── Models/           # Data models
│   └── Album.cs        # Album data model
├── Views/           # User interface (XAML)
│   ├── MainWindow.xaml # Main window
│   ├── AlbumsPage.xaml # Albums listing page
│   ├── AboutPage.xaml  # Album details page
│   └── ContactUsPage.xaml # Contact information page
├── ModelViews/      # ViewModels (Business logic)
│   ├── MainViewModel.cs
│   ├── AlbumsPageViewModel.cs
│   └── AboutPageViewModel.cs
├── Services/        # Application services
│   └── ApiService.cs  # API communication service
└── Program.cs       # Application entry point
```

## Getting Started

### Prerequisites

- Visual Studio 2022 or later
- .NET 8.0 SDK
- Windows OS

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/yourusername/WpfApp2.git
   cd WpfApp2
   ```

2. **Open in Visual Studio**
   - Open `WpfApp2.sln` in Visual Studio
   - Restore NuGet packages if prompted

3. **Build and Run**
   - Press `F5` or click "Start" button
   - The application will launch

## How to Use

1. **Main Window** - Contains navigation buttons
2. **Albums Page** - Displays list of albums from API
3. **Album Details** - Click on User ID to view album details
4. **Contact Us** - View contact information

## Architecture

### MVVM Pattern Implementation

- **Model**: `Album.cs` - Represents album data
- **View**: XAML files - User interface
- **ViewModel**: ViewModel classes - Business logic and data binding

### Dependency Injection

All services and views are registered in `Program.cs`:

```csharp
services.AddSingleton<ApiService>();
services.AddTransient<AlbumsPage>();
services.AddTransient<ContactUsPage>();
```

### API Integration

The application fetches data from JSONPlaceholder API:
- **Get All Albums**: `https://jsonplaceholder.typicode.com/albums`
- **Get Album by ID**: `https://jsonplaceholder.typicode.com/albums/{id}`

## UI Features

- **Responsive Design** - Adapts to different window sizes
- **Professional Styling** - Modern colors and typography
- **Interactive Elements** - Clickable links and buttons
- **Data Grid** - Organized display of album information
- **Navigation** - Seamless page transitions

## Data Flow

```
API (JSONPlaceholder) → ApiService → ViewModel → View → User
```

## Development

### Adding New Features

1. Create new ViewModel in `ModelViews/` folder
2. Create new View in `Views/` folder
3. Register services in `Program.cs`
4. Update navigation in `MainWindow.xaml.cs`

### Code Structure

- **Models**: Data representation
- **Views**: User interface (XAML)
- **ViewModels**: Business logic
- **Services**: External integrations
- **Program.cs**: Application configuration

## Future Enhancements

- Search functionality for albums
- Filter albums by user
- Local data caching
- Dark mode theme
- Export to Excel
- Real-time data updates

## License

This project is open source and available under the MIT License.

## Contributing

1. Fork the project
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request
