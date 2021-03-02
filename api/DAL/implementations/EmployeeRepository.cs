using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.DAL;
using api.DAL.models;
using Cardiohelp.data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Cardiohelp.data.Implementations{
    public class EmployeeRepository : IEmployeeRepository
    {
        private dataContext _context;
        public EmployeeRepository(dataContext context)
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

        public async Task<string> findEmployee(List<Class_Employee> empList)
        {
            foreach(Class_Employee emp in empList){
            if(await _context.Employees
            .Where(x => x.Id == emp.Id)
            .AnyAsync()){ Update(emp);}else{Add(emp);}}
            return "Ok";
        }
    }
}