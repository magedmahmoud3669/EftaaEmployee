using Dal.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bl.Interface
{
    public interface IEmpRegister
    {
        Task<IEnumerable<Employees>> GetAsync(Expression<Func<Employees, bool>> filter = null);
        Task<Employees> GetByIdAsync(Expression<Func<Employees, bool>> filter);
        Task<Employees> CreateAsync(Employees obj);
        Task UpdateAsync(Employees obj);
        Task DeleteAsync(Employees obj);
    }
}
