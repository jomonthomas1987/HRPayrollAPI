using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrollModel.DTO
{
    public class LoginResponseDto: BaseResponseDto
    {
        public string Token { get; set; }
    }
}
