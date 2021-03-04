using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.DAL;
using api.DAL.models;
using Cardiohelp.data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Cardiohelp.data.Implementations
{
    public class CabgRepository : ICabgRepository
    {

        private dataContext _context;
        public CabgRepository(dataContext context)
        {
            _context = context;
        }
        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);

        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }
        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }
        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
        
         public async Task<string> findCABG(List<Class_CABG> cabgList)
        {
            foreach (Class_CABG emp in cabgList)
            {
                if (await _context.Cabgs
                .Where(x => x.Id == emp.Id)
                .AnyAsync())
                {
                    Update(emp);
                    await SaveAll();
                }
                else
                {
                    Add(emp);
                    await SaveAll();
                }
            }
            return "Ok";
        }

       
    }
}