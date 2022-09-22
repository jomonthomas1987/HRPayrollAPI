using HRPayrollBL.Services;
using HRPayrollModel.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrollAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeMethod _employeeMethod;

        public EmployeeController(IEmployeeMethod employeeMethod)
        {
            _employeeMethod = employeeMethod;
        }

        [Authorize]
        [HttpPost("AddEmployee")]
        public string AddEmployee(Employee objEmp)
        {
            return _employeeMethod.AddEmployee(objEmp);
        }

        [Authorize]
        [HttpPost("AddEmployeePayroll")]
        public string AddEmployeePayroll(EmployeePayroll objEmpPayroll)
        {
            return _employeeMethod.AddEmployeePayroll(objEmpPayroll);
        }

        [Authorize]
        [HttpPost("ViewEmployee")]
        public Employee ViewEmployee(int id)
        {
            return _employeeMethod.ViewEmployee(id);
        }

        [Authorize]
        [HttpPost("ViewAllEmployee")]
        public List<Employee> ViewEmployee()
        {
            return _employeeMethod.ViewAllEmployee();
        }

        [Authorize]
        [HttpPost("ViewEmployeePayroll")]
        public EmployeePayroll ViewEmployeePayroll(int id)
        {
            return _employeeMethod.ViewEmployeePayroll(id);
        }

        [Authorize]
        [HttpPost("UpdateEmployee")]
        public string UpdateEmployee(Employee objEmp)
        {
            return _employeeMethod.UpdateEmployee(objEmp);
        }

        [Authorize]
        [HttpPost("UpdateEmployeePayroll")]
        public string UpdateEmployeePayroll(EmployeePayroll objEmpPayroll)
        {
            return _employeeMethod.UpdateEmployeePayroll(objEmpPayroll);
        }

        [Authorize]
        [HttpPost("GeneratePayrollForAllEmployee")]
        public string GeneratePayrollForAllEmployee(int month, int year)
        {
            return _employeeMethod.GeneratePayrollForAllEmployee(month, year);
        }

        [Authorize]
        [HttpPost("GeneratePayrollForEmployee")]
        public string GeneratePayrollForEmployee(int month, int year, int empId)
        {
            return _employeeMethod.GeneratePayrollForEmployee(month, year, empId);
        }

        [Authorize]
        [HttpPost("EmployePayrollReport")]
        public List<EmployeePayrollMonthly> EmployePayrollReport()
        {
            return _employeeMethod.EmployePayrollReport();
        }
    }
}
