using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.DAL;
using api.DAL.models;
using Cardiohelp.data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cardiohelp.data.Implementations{
    public class HospitalRepository : IHospitalRepository
    {
        private dataContext _context;
        public HospitalRepository(dataContext context)
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

        public async Task<string> findHospital(List<Class_Hospital> hosList)
        {
            foreach(Class_Hospital hos in hosList){
            if(await _context.Hospitals
            .Where(x => x.HospitalNo == hos.HospitalNo)
            .AnyAsync()){ Update(hos);}else{Add(hos);}}
            return "Ok";
        }
    }
}