using Dal.Entity;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bl.Interface
{
    public interface ILookups
    {
        Task<IEnumerable<Lookups>> GetAsync(Expression<Func<Lookups, bool>> filter = null);
        Task<Lookups> GetByIdAsync(Expression<Func<Lookups, bool>> filter);
    }
}
