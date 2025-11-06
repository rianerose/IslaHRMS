# Hotel HR Management System (VB.NET WinForms)

This repository contains a Windows Forms application built with VB.NET (.NET 8) that delivers a human resource management platform for hotel operations. Core features include employee CRUD management, daily attendance capture, payroll generation, and Crystal Reports integration backed by a MySQL database.

## Solution Overview

- **Project**: `HotelHRMS.sln`
- **Target Framework**: `.NET 8.0-windows`
- **UI**: Windows Forms, VB.NET 16
- **Database**: MySQL 8 (via `MySqlConnector` NuGet package)
- **Reporting**: Crystal Reports runtime (`SAPCrystalReports.*` packages)

## Getting Started

1. **Prerequisites**
   - Visual Studio 2022 v17.8 or later with **.NET Desktop Development** workload
   - SAP Crystal Reports developer runtime (install prior to building the project)
   - MySQL Server 8 (or compatible) and MySQL Workbench / CLI

2. **Clone & Restore**
   ```bash
   git clone <repo-url>
   cd HotelHRMS
   ```

3. **Database Setup**
   - Execute `database/schema.sql` to create the schema
   - Optionally load seed data via `database/sample-data.sql`
   - Update the connection string in `App.config` (defaults to `hr_admin` / `ChangeMe123!`)

4. **Crystal Report Templates**
   - Design the `.rpt` files listed in `Reports/README.md`
   - Copy the compiled reports into the `Reports` directory before running the application

5. **Run the Application**
   - Open `HotelHRMS.sln` in Visual Studio 2022
   - Restore NuGet packages
   - Set `HotelHRMS` as the startup project and press `F5`

## Application Features

- **Dashboard**: Real-time connection status, quick navigation, employee KPIs
- **Employee Management**: CRUD with validation, live search, inactivity toggle, CSV export of grid
- **Attendance Tracking**: Date range filter, employee filter, time validation, CSV export for HR audits
- **Payroll Generation**: Configurable tax/deduction rates, payroll preview, batch persistence, CSV export
- **Crystal Reporting**: Launch templated reports with PDF export support
- **Quality-of-life Enhancements**:
  - Busy cursor during long-running operations
  - Consistent dialog messaging via `DialogService`
  - ErrorProvider-based validation feedback
  - Configurable defaults via `My.Settings`
  - CSV export using `CsvHelper`

## Key Files & Folders

| Path | Description |
|------|-------------|
| `HotelHRMS/MainForm.vb` | Application shell with dashboard and navigation |
| `HotelHRMS/Forms/` | Feature-specific WinForms (Employee, Attendance, Payroll, Reports) |
| `HotelHRMS/Data/` | Repositories and data models wrapping MySQL operations |
| `HotelHRMS/Utilities/` | Shared services (validation, dialogs, CSV export, form helpers) |
| `database/` | Schema and seed scripts for MySQL |
| `Reports/README.md` | Crystal Report template guidance |

## Known Limitations & Follow-up Tasks

- Crystal Reports templates are not included; create them using the field lists provided
- No authentication/authorization layer is built in
- Business rules assume salaried staff with a default 22 work days per month (see `PayrollRepository`)
- Automated tests are not supplied; validate critical flows manually after configuring the database

## Support

For integration issues or enhancement requests, collect the log files generated under `%LocalAppData%\HotelHRMS\Logs` and include reproduction steps.
