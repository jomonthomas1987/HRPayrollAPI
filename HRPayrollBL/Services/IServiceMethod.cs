using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrollBL.Services
{
    public interface IServiceMethod
    {
        string GenerateToken(string requestUserName);
    }
}
