using HRPayrollDBL.Infrastructure.DBRepository;
using HRPayrollModel.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HRPayrollBL.Services
{
    public class EmployeeMethods : IEmployeeMethod
    {
        private readonly PayrollDBContext _dBContext;
        public EmployeeMethods(PayrollDBContext dBContext)
        {
            _dBContext = dBContext;
        }


        public string AddEmployee(Employee objEmp)
        {
            try
            {
                _dBContext.Employees.Add(objEmp);
                _dBContext.SaveChanges();
            }
            catch (Exception ex)
            {

            }

            return "Data updated successfully";
        }

        public string AddEmployeePayroll(EmployeePayroll objEmpPayroll)
        {
            try
            {
                _dBContext.EmployeePayrolls.Add(objEmpPayroll);
                _dBContext.SaveChanges();
            }
            catch (Exception ex)
            {

            }

            return "Data updated successfully";
        }

        public Employee ViewEmployee(int id)
        {
            Employee objEmp = new Employee();
            try
            {
                int empId = Convert.ToInt32(id);
                var emp = _dBContext.Employees.Find(empId);

                objEmp = emp;
            }
            catch (Exception ex)
            {

            }
            return objEmp;
        }

        public List<Employee> ViewAllEmployee()
        {
            List<Employee> objEmp = new List<Employee>();
            try
            {
                var emp = _dBContext.Employees.ToList();

                objEmp = emp;
            }
            catch (Exception ex)
            {

            }
            return objEmp;
        }

        public EmployeePayroll ViewEmployeePayroll(int id)
        {
            EmployeePayroll objEmpPayroll = new EmployeePayroll();
            try
            {
                int empId = Convert.ToInt32(id);
                var emp = _dBContext.EmployeePayrolls.Find(empId);

                objEmpPayroll = emp;
            }
            catch (Exception ex)
            {

            }
            return objEmpPayroll;
        }

        public List<EmployeePayroll> ViewAllEmployeePayroll()
        {
            List<EmployeePayroll> objEmpPayroll = new List<EmployeePayroll>();
            try
            {
                //var emp = _dBContext.EmployeePayrolls.Where(s => s.Active == 1).ToList();
                var emp = (from ep in _dBContext.EmployeePayrolls
                           join e in _dBContext.Employees on ep.EmployeeId.ToString() equals e.Id
                           where ep.Active == 1
                           select new EmployeePayroll
                           {
                               EmployeeId = ep.EmployeeId,
                               ConveyanceAllowance = ep.ConveyanceAllowance,
                               Basicpay = ep.Basicpay,
                               DeductionAmount = ep.DeductionAmount,
                               DeductionReason = ep.DeductionReason,
                               HRA = ep.HRA,
                               EmployeeName = e.FirstName + " " + e.LastName
                           }).ToList();

                objEmpPayroll = emp;
            }
            catch (Exception ex)
            {

            }
            return objEmpPayroll;
        }

        public string UpdateEmployee(Employee objEmp)
        {
            try
            {
                int empId = Convert.ToInt32(objEmp.Id);
                var data = _dBContext.Employees.Find(empId);

                if (data != null)
                {
                    data.FirstName = objEmp.FirstName;
                    data.LastName = objEmp.LastName;
                    data.Address = objEmp.Address;
                    data.Email = objEmp.Email;
                    data.Gender = objEmp.Gender;
                }
                _dBContext.SaveChanges();
            }
            catch (Exception ex)
            {

            }
            return "Data updated successfully";
        }

        public string UpdateEmployeePayroll(EmployeePayroll objEmpPayroll)
        {
            try
            {
                int empPayrollId = Convert.ToInt32(objEmpPayroll.Id);
                var data = _dBContext.EmployeePayrolls.Find(empPayrollId);

                if (data != null)
                {
                    data.EmployeeId = objEmpPayroll.EmployeeId;
                    data.ConveyanceAllowance = objEmpPayroll.ConveyanceAllowance;
                    data.Basicpay = objEmpPayroll.Basicpay;
                    data.DeductionAmount = objEmpPayroll.DeductionAmount;
                    data.DeductionReason = objEmpPayroll.DeductionReason;
                    data.HRA = objEmpPayroll.HRA;
                }
                _dBContext.SaveChanges();
            }
            catch (Exception ex)
            {

            }
            return "Data updated successfully";
        }

        public string GeneratePayrollForAllEmployee(int month, int year)
        {

            var allEmployeePayrollList = (from p in _dBContext.EmployeePayrolls
                                          where p.Active == 1
                                          select new EmployeePayroll { 
                                              Active = p.Active,
                                              Basicpay = p.Basicpay,
                                              ConveyanceAllowance = p.ConveyanceAllowance,
                                              DeductionAmount = p.DeductionAmount,
                                              DeductionReason = p.DeductionReason,
                                              EmployeeId = p.EmployeeId,
                                              HRA=p.HRA,
                                              Id = p.Id
                                          }).AsNoTracking().ToList();

            foreach (EmployeePayroll e in allEmployeePayrollList)
            {
                var ep = (from p in _dBContext.EmployeePayrollMonthly
                                              where p.Active == 1 && p.Month == month && p.Year == year && p.EmployeeId == e.EmployeeId
                                              select new { p.Active, p.Basicpay, p.ConveyanceAllowance, p.DeductionAmount, p.EmployeeId, p.HRA}).AsNoTracking().ToList();
                if (ep.Count == 0)
                {
                    EmployeePayrollMonthly em = new EmployeePayrollMonthly();

                    em.Active = e.Active;
                    em.Basicpay = e.Basicpay;
                    em.ConveyanceAllowance = e.ConveyanceAllowance;
                    em.DeductionAmount = e.DeductionAmount;
                    em.DeductionReason = e.DeductionReason;
                    em.EmployeeId = e.EmployeeId;
                    em.HRA = e.HRA;
                    em.Month = month;
                    em.Year = year;
                    em.Salary = e.Basicpay + e.ConveyanceAllowance + e.HRA - e.DeductionAmount;

                    _dBContext.EmployeePayrollMonthly.Add(em);
                }
            }
            _dBContext.SaveChanges();


            return "Data updated successfully";
        }

        public string GeneratePayrollForEmployee(int month, int year, int empId)
        {
            var allEmployeePayrollList = (from p in _dBContext.EmployeePayrollMonthly
                                          where p.Active == 1 && p.Month == month && p.Year == year && p.EmployeeId == empId
                                          select p).ToList();

            if(allEmployeePayrollList.Count ==0)
            {
                EmployeePayrollMonthly em = new EmployeePayrollMonthly();
                var e = (from p in _dBContext.EmployeePayrolls
                                              where p.Active == 1 && p.EmployeeId== empId
                         select p).FirstOrDefault();

                em.Active = e.Active;
                em.Basicpay = e.Basicpay;
                em.ConveyanceAllowance = e.ConveyanceAllowance;
                em.DeductionAmount = e.DeductionAmount;
                em.DeductionReason = e.DeductionReason;
                em.EmployeeId = e.EmployeeId;
                em.HRA = e.HRA;
                em.Month = month;
                em.Year = year;
                em.Salary = e.Basicpay + e.ConveyanceAllowance + e.HRA - e.DeductionAmount;
                _dBContext.SaveChanges();

                _dBContext.EmployeePayrollMonthly.Add(em);

            }

            return "Data updated successfully";
        }

        public List<EmployeePayrollMonthly> EmployePayrollReport()
        {
            //return (from p in _dBContext.EmployeePayrollMonthly
            //        where p.Active == 1
            //        select p).ToList();

            return  (from ep in _dBContext.EmployeePayrollMonthly
                     join e in _dBContext.Employees on ep.EmployeeId.ToString() equals e.Id
             where ep.Active == 1
             select new EmployeePayrollMonthly
             {
                 EmployeeId = ep.EmployeeId,
                 ConveyanceAllowance = ep.ConveyanceAllowance,
                 Basicpay = ep.Basicpay,
                 DeductionAmount = ep.DeductionAmount,
                 DeductionReason = ep.DeductionReason,
                 HRA = ep.HRA,
                 EmployeeName = e.FirstName + " " + e.LastName,
                 Salary = ep.Salary,
                 Year = ep.Year,
                 Month = ep.Month
             }).ToList();
        }
    }
}
