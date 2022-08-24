using Dal.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bl.Interface
{
    public interface ILookupsValue
    {
        Task<IEnumerable<LookupsValue>> GetAsync(Expression<Func<LookupsValue, bool>> filter = null);
        Task<LookupsValue> GetByIdAsync(Expression<Func<LookupsValue, bool>> filter);
    }
}
