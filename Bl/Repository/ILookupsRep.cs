using Bl.Interface;
using Dal.Database;
using Dal.Entity;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bl.Repository
{
    public class ILookupsRep : ILookups
    {
        ApplicationContext db;
        public Task<IEnumerable<Lookups>> GetAsync(Expression<Func<Lookups, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public async Task<Lookups> GetByIdAsync(Expression<Func<Lookups, bool>> filter)
        {
            var data = await db.Lookups.Where(filter).FirstOrDefaultAsync();
            return data;
        }
    }
}
