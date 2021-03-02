using api.DAL.data;
using Microsoft.EntityFrameworkCore;

namespace api.DAL
{

    public class dataSOAContext : DbContext
    {
        public dataSOAContext(DbContextOptions<dataContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<hospital> Hospitals { get; set; }
        public DbSet<Cardio> Cardios { get; set; }
         
       
    }

}