# Crystal Report Templates

The WinForms application loads Crystal Reports at runtime from this directory. Create the following `.rpt` files using the Crystal Reports designer in Visual Studio and ensure that the field names in each report match the generated datasets:

- `EmployeeDirectory.rpt`
  - Expected columns: `EmployeeCode`, `FullName`, `Department`, `Position`, `Email`, `PhoneNumber`, `HireDate`, `IsActive`
- `AttendanceSummary.rpt`
  - Expected columns: `EmployeeId`, `AttendanceDate`, `CheckIn`, `CheckOut`, `HoursWorked`, `Notes`
- `PayrollSummary.rpt`
  - Expected columns: `Employee`, `PayPeriodStart`, `PayPeriodEnd`, `BaseHours`, `OvertimeHours`, `GrossPay`, `Taxes`, `TotalDeductions`, `NetPay`, `Notes`

> Tip: Create a new Crystal Report using the Standard layout, add the fields above to the Details section, and apply grouping/summary as desired. Copy the compiled `.rpt` files into this folder so the application can load them at runtime.
