# Photo Album Application

This project is a console application that prints all photo ids and titles in an album, given the albumId.

The application is written in C# .NET 6.0, and unit testing is done using MSTest in Visual Studio.

## Prerequisites

.NET 6.0 must be installed to build the project and run the application.

## Build

After .NET is installed, navigate to the repo source directory and use the command "dotnet build" to build the source files and dependencies.
Alternatively, the .sln file can be opened in Visual Studio and built from that app.

## Running

The executable photo-album.exe will be placed in the bin folder either under Debug or Release depending on the build configuration. From Visual Studio, attach the debugger to run the app. The app can also be run by navigating to the directory containing photo-album.exe and using the "photo-album" command. Command-line arguments can be appended, for example, "photo-album 2" to be passed to the app.

## Testing

Navigate to the repo source directory and use the command "dotnet test" to run the unit tests.
Alternatively, the .sln file can be opened in Visual Studio and select Test > Run All Tests.

## Author
David Trettin
