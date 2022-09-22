using HRPayrollModel.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrollBL.Services
{
    public interface IEmployeeMethod
    {
        string AddEmployee(Employee objEmp);
        string AddEmployeePayroll(EmployeePayroll objEmpPayroll);
        Employee ViewEmployee(int id);
        EmployeePayroll ViewEmployeePayroll(int id);
        string UpdateEmployee(Employee objEmp);
        string UpdateEmployeePayroll(EmployeePayroll objEmpPayroll);
        string GeneratePayrollForAllEmployee(int month, int year);
        string GeneratePayrollForEmployee(int month, int year, int empId);
        List<EmployeePayrollMonthly> EmployePayrollReport();
        List<Employee> ViewAllEmployee();

    }
}
