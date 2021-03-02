using System.Collections.Generic;
using System.Threading.Tasks;
using api.DAL.models;

namespace Cardiohelp.data.Interfaces
{
    public interface IUser
    {
        Task<string> findUser(List<User> userlist);
        Task<bool> SaveAll();
        void Delete<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Add<T>(T entity) where T : class;
    }
}