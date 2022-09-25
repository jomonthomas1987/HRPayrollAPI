using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrollModel.Domain
{
    public class EmployeePayroll
    {
        public int EmployeeId { get; set; }
        [NotMapped]
        public string EmployeeName { get; set; }
        public float Basicpay { get; set; }
        public float HRA { get; set; }
        public float ConveyanceAllowance { get; set; }
        public float DeductionAmount { get; set; }
        public float DeductionReason { get; set; }
        public int Active { get; set; }

        public string Id { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}
