using System.Collections.Generic;
using System.Threading.Tasks;
using api.DAL.models;

namespace Cardiohelp.data.Interfaces
{
    public interface ICabgRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        Task<bool> SaveAll();
        Task<string> findCABG(List<Class_CABG> hosList);
        
    }

}