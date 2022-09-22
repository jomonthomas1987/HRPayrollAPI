using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrollModel.DTO
{
    public class EmployeePayrollDto
    {
        public int SalaryId { get; set; }
        public int EmployeeId { get; set; }
        public float Basicpay { get; set; }
        public float HRA { get; set; }
        public float ConveyanceAllowance { get; set; }
        public float DeductionAmount { get; set; }
        public float DeductionReason { get; set; }
        public int Active { get; set; }
    }
}
