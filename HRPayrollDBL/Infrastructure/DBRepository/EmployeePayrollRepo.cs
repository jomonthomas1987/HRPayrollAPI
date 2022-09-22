using HRPayrollDBL.Infrastructure.DBRepository;
using HRPayrollModel.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrollDBL.Infrastructure.DBContext
{
    public class EmployeePayrollRepo : HybridRepositoryBase<Employee>, IEmployeeRepository
    {
        private readonly PayrollDBContext _dbContext;
        public EmployeePayrollRepo(PayrollDBContext dbContext, IDbConnection dbConnection)
          : base(dbContext, dbConnection)
        {
            _dbContext = dbContext;
        }

        //public async Task<EmployeePayroll> GetCounterInfoByType(string type)
        //{
        //    //return await _dbContext.Counter.Where(c => c.Type == type).SingleOrDefaultAsync();
        //}


    }
}
