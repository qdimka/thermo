using Microsoft.EntityFrameworkCore;
using Thermo.Web.Models;

namespace Thermo.Web.Dal
{
    public class TemperatureDbContext : DbContext
    {
        public DbSet<TemperatureSensor> TemperatureSensors { get; set; }
        
        public TemperatureDbContext(DbContextOptions<TemperatureDbContext> options)
            :base(options)
        {
        }
    }
}