# School Fees Management System

This is a Windows Desktop Application built with **.NET 8 WPF** and **SQLite**.

## Prerequisites
- Windows 10 or 11
- .NET 8 SDK
- Visual Studio 2022 (with .NET Desktop Development workload)

## How to Run
1.  Open the solution file `SchoolFeesManager/SchoolFeesManager.sln` in **Visual Studio 2022**.
2.  Right-click on the `SchoolFeesManager` project in Solution Explorer and select **Set as Startup Project**.
3.  Press **F5** or click the **Start** button to run the application.

## Troubleshooting
- If you see build errors about missing packages, right-click the solution and select **Restore NuGet Packages**.
- Ensure you have the **SQLite** libraries installed (usually handled by `sqlite-net-pcl` NuGet package automatically).

## Notes
- This application uses a local SQLite database (`SchoolFees.db3`) located in your AppData folder (`%LocalAppData%\SchoolFeesManager`).
