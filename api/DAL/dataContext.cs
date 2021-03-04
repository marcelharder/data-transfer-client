
using api.DAL.models;
using Microsoft.EntityFrameworkCore;

namespace api.DAL
{

    public class dataContext : DbContext
    {
        public dataContext(DbContextOptions<dataContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Class_Hospital> Hospitals { get; set; }
        public DbSet<Class_Employee> Employees { get; set; }
         public DbSet<Class_CABG> Cabgs { get; set; }
        
         
       
    }

}