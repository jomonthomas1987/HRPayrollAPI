using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrollModel.Domain
{
    public class EmployeePayrollMonthly
    {
        [Key]
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        [NotMapped]
        public string EmployeeName { get; set; }
        public float Basicpay { get; set; }
        public float HRA { get; set; }
        public float ConveyanceAllowance { get; set; }
        public float DeductionAmount { get; set; }
        public float DeductionReason { get; set; }
        public float Salary { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Active { get; set; }

    }
}
