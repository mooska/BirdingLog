using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BirdingLog.Models
{
    public class BirdingLogContext : DbContext
    {
        private IConfigurationRoot _config;

        public BirdingLogContext(IConfigurationRoot config, DbContextOptions options) 
            : base(options)
        {
            _config = config;  
        }

        public DbSet<Photo> Photos { get; set; }
        public DbSet<Bird> Birds { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(_config["ConnectionStrings:BirdingLogConnection"]);
        }
    }
}
