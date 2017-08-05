using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace weatherStationServer.Model
{
    public class WSSContext : DbContext
    {
        public DbSet<WeatherData> weatherData { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=weatherstation.db");
        }
    }
}
