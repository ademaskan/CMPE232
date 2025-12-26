# Dance Academy Management System

A Blazor Server web application for managing a dance academy, including members, employees, courses, branches, and financial records.

## Libraries Used

### DanceAcademy (Main Web Project) - .NET 8.0

| Library | Version | Purpose |
|---------|---------|---------|
| **Radzen.Blazor** | 5.* | UI component library providing rich Blazor components (charts, grids, dialogs, etc.) |
| **Microsoft.EntityFrameworkCore.SqlServer** | 8.0.22 | Entity Framework Core provider for SQL Server database |
| **Microsoft.EntityFrameworkCore.Tools** | 8.0.22 | EF Core tools for migrations and scaffolding |
| **Microsoft.AspNetCore.Components.QuickGrid.EntityFrameworkAdapter** | 8.0.22 | QuickGrid data grid component with EF Core integration |
| **Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore** | 8.0.22 | Database error page middleware for development |
| **Microsoft.VisualStudio.Web.CodeGeneration.Design** | 8.0.22 | Code scaffolding tools for generating CRUD pages |

### DataAccess (Data Layer Project) - .NET Framework 4.8

| Library | Version | Purpose |
|---------|---------|---------|
| **EntityFramework** | 6.5.1 | Entity Framework 6 for entity models generated from EDMX |

## Prerequisites

Before running the application, ensure you have the following installed:

1. **Visual Studio 2022** (or later) with the following workloads:
   - ASP.NET and web development
   - .NET desktop development

2. **.NET 8.0 SDK** - [Download here](https://dotnet.microsoft.com/download/dotnet/8.0)

3. **SQL Server** (LocalDB, Express, or full version)
   - The application is configured to use `(local)` as the data source

4. **Database**: A SQL Server database named `CMPE232` must exist with the required schema

## How to Run the Application

### Step 1: Clone or Download the Project

Ensure you have the complete solution including both:
- `DanceAcademy` (main web project)
- `DataAccess` (data access library project)

### Step 2: Configure the Database Connection

1. Open `DanceAcademy/appsettings.json`
2. Modify the connection string if needed:
   ```json
   {
     "ConnectionStrings": {
       "DanceAcademyContext": "Data Source=(local);Initial Catalog=CMPE232;Integrated Security=True;MultipleActiveResultSets=True;Encrypt=False;"
     }
   }
   ```
3. Update `Data Source` to match your SQL Server instance (e.g., `localhost`, `.\\SQLEXPRESS`, etc.)
4. Update `Initial Catalog` if your database has a different name

### Step 3: Restore NuGet Packages

#### Using Visual Studio:
1. Open the solution file (`CMPE232.sln`) in Visual Studio
2. Right-click on the solution in Solution Explorer
3. Select **Restore NuGet Packages**

#### Using Command Line:
```bash
cd c:\Users\adem\source\repos\CMPE232
dotnet restore
```

### Step 4: Build the Solution

#### Using Visual Studio:
1. Press `Ctrl + Shift + B` or go to **Build > Build Solution**

#### Using Command Line:
```bash
dotnet build
```

### Step 5: Run the Application

#### Using Visual Studio:
1. Set `DanceAcademy` as the startup project (right-click > Set as Startup Project)
2. Press `F5` (with debugging) or `Ctrl + F5` (without debugging)

#### Using Command Line:
```bash
cd DanceAcademy
dotnet run
```

### Step 6: Access the Application

Once running, the application will be available at:
- **HTTPS**: `https://localhost:5001` (or the port shown in the console)
- **HTTP**: `http://localhost:5000`

## Project Structure

```
CMPE232/
├── DanceAcademy/           # Main Blazor Server Web Application
│   ├── Components/         # Razor components and pages
│   │   ├── Layout/         # Layout components (NavMenu, MainLayout)
│   │   └── Pages/          # Feature pages (Members, Employees, Branches, etc.)
│   ├── Data/               # DbContext and data configurations
│   ├── Services/           # Business logic services
│   ├── wwwroot/            # Static files (CSS, JS, images)
│   ├── Program.cs          # Application entry point
│   └── appsettings.json    # Configuration settings
│
└── DataAccess/             # Data Access Layer
    └── DataAccess/         # Entity models generated from EDMX
```

## Troubleshooting

### Common Issues:

1. **Connection String Error**
   - Ensure SQL Server is running
   - Verify the database `CMPE232` exists
   - Check that Integrated Security works or provide SQL credentials

2. **Package Restore Failed**
   - Ensure you have internet connectivity
   - Try clearing NuGet cache: `dotnet nuget locals all --clear`

3. **Build Errors**
   - Ensure both .NET 8.0 SDK and .NET Framework 4.8 are installed
   - The DataAccess project requires .NET Framework 4.8

4. **Port Already in Use**
   - Change the port in `Properties/launchSettings.json`
   - Or stop other applications using the same port

## Features

- **Member Management**: Create, read, update, and delete member records
- **Employee Management**: Manage dance instructors and staff
- **Branch Management**: Handle multiple dance academy locations
- **Course Management**: Organize dance courses and enrollments
- **Financial Records**: Track payments and financial transactions
- **Dashboard**: Visual analytics with charts and statistics
