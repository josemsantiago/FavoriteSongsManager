# FavoriteSongsManager

![C#](https://img.shields.io/badge/C%23-239120?logo=c-sharp&logoColor=white)
![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.7.2-512BD4?logo=.net)
![WebView2](https://img.shields.io/badge/WebView2-1.0-0078D6?logo=microsoft-edge)
![License](https://img.shields.io/badge/license-MIT-blue)
![Status](https://img.shields.io/badge/status-active-success)

A Windows Forms application built with .NET Framework and C# for managing your favorite songs with an embedded web browser using WebView2.

## Screenshots

> **Note:** Screenshots will be added soon. For now, follow the installation instructions below to see the application in action.

## Features

- Manage favorite songs list
- Embedded web browser using Microsoft WebView2
- Windows Forms interface
- Data persistence

## Technology Stack

- .NET Framework 4.7.2
- C# Windows Forms
- Microsoft WebView2 (v1.0.1823.32)

## Prerequisites

### Runtime Requirements
- **Windows OS**: Windows 7 or higher
- **.NET Framework**: 4.7.2 or higher ([Download](https://dotnet.microsoft.com/download/dotnet-framework))
- **Microsoft Edge WebView2 Runtime**: ([Download](https://developer.microsoft.com/microsoft-edge/webview2/))

### Development Requirements
- **Visual Studio**: 2015 or later (2019 or 2022 recommended)
- **NuGet Package Manager**: Included with Visual Studio
- **Git**: For cloning the repository

## How to Run

1. Open the solution file `SantiagoEchevarria_CourseProject.sln` in Visual Studio
2. Restore NuGet packages (WebView2)
3. Build the solution (F6)
4. Run the application (F5)

## Dependencies

- Microsoft.Web.WebView2 (v1.0.1823.32)

## Troubleshooting

### Common Issues

**Issue:** "WebView2 Runtime not found" error on startup

**Solution:** Install the Microsoft Edge WebView2 Runtime from [Microsoft's official site](https://developer.microsoft.com/microsoft-edge/webview2/). The Evergreen Standalone Installer is recommended.

---

**Issue:** Build error: "Could not resolve reference Microsoft.Web.WebView2"

**Solution:** Restore NuGet packages:
1. Right-click the solution in Visual Studio
2. Select "Restore NuGet Packages"
3. Rebuild the solution

---

**Issue:** WebView2 control not displaying web content

**Solution:** Ensure the WebView2 Runtime is installed and up to date. Check that your application has internet access if loading remote content.

---

**Issue:** "Access denied" when trying to save songs data

**Solution:** Run the application with appropriate permissions or ensure the application directory is writable.

For additional help, please open an issue in the repository issue tracker.

## Contributing

Contributions are welcome! Please follow these steps:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/YourFeature`)
3. Commit your changes (`git commit -m 'Add YourFeature'`)
4. Push to the branch (`git push origin feature/YourFeature`)
5. Open a Pull Request

### Coding Standards
- Follow C# naming conventions
- Use meaningful variable and method names
- Add XML documentation comments for public members
- Test WebView2 integration thoroughly
- Ensure code compiles without warnings

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Contact & Support

- **Author**: Jose Santiago Echevarria
- **Issues**: Please report bugs and feature requests via the repository issue tracker
- **Educational Context**: This project was developed as a course assignment demonstrating Windows Forms and WebView2 integration
