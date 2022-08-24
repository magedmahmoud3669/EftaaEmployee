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
    public class IEmpRegisterRep : IEmpRegister
    {
        ApplicationContext db;
        public  IEmpRegisterRep(ApplicationContext _db)
        {
            db = _db;

        }

     

        public async Task<Employees> CreateAsync(Employees obj)
        {
            await db.Employees.AddAsync(obj);
            await db.SaveChangesAsync();
            var data = await db.Employees.OrderByDescending(x => x.Id).FirstOrDefaultAsync();

            return data;
        }

        public async Task DeleteAsync(Employees obj)
        {
            var data = await db.Employees.FindAsync(obj.Id);
             db.Employees.Remove(data);
            await db.SaveChangesAsync();
        }

        public async Task<IEnumerable<Employees>> GetAsync(Expression<Func<Employees, bool>> filter = null)
        {
            if (filter == null)
            {
               var res = await db.Employees.Include(x => x.ScoialStatus).Include(x => x.CurrentFiqhSchool).Include(x => x.LastFiqhSchool).Include(x => x.FiqhInPreparatorySchool).Include(x => x.FiqhInSecondarySchool).Select(x => x).ToListAsync();
          //      var res = await db.Employees.Select(x => x).ToListAsync();

                return res;
            }
            else
            {
                var data = await db.Employees.Include(x => x.ScoialStatus).Include(x=>x.CurrentFiqhSchool).Include(x => x.LastFiqhSchool).Include(x => x.FiqhInPreparatorySchool).Include(x => x.FiqhInSecondarySchool).Where(filter).ToListAsync();
                return data;
            }
        }

        public async Task<Employees> GetByIdAsync(Expression<Func<Employees, bool>> filter)
        {
            var data= await db.Employees.Where(filter).Include(x => x.ScoialStatus).Include(x => x.CurrentFiqhSchool).Include(x => x.LastFiqhSchool).Include(x => x.FiqhInPreparatorySchool).Include(x => x.FiqhInSecondarySchool).FirstOrDefaultAsync();
            return data;
        }

        public async Task UpdateAsync(Employees obj)
        {
           db.Entry(obj).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }
    }
}
