
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
    public class IlookupsValueRep : ILookupsValue
    {
        ApplicationContext db;
        public IlookupsValueRep(ApplicationContext _db)
        {
            db = _db;
        }
        public async Task<IEnumerable<LookupsValue>> GetAsync(Expression<Func<LookupsValue, bool>> filter = null)
        {
            var res = await db.LookupsValue.Include("Lookups").Where(filter).Select(x => x).ToListAsync();
            return res;
        }

        public async Task<LookupsValue> GetByIdAsync(Expression<Func<LookupsValue, bool>> filter)
        {
            var data = await db.LookupsValue.Where(filter).Include("Lookups").FirstOrDefaultAsync();
            return data;
        }
    }
}
