using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.DAL;
using api.DAL.helpers;
using api.DAL.models;
using Cardiohelp.data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Cardiohelp.data.Implementations
{
    public class UserRepository : IUser
    {
        private dataContext _context;

        public UserRepository(dataContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<string> findUser(List<User> userlist)
        {
            foreach (User us in userlist)
            {
                if (await _context.Users
                           .Where(x => x.UserId == us.UserId)
                           .AnyAsync()) { Update(us); }
                else { Add(us); }
            }

            return "Ok";
        }


        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }
    }
}