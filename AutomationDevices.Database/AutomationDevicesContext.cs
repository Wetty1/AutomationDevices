using AutomationDevice.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDevices.Database
{
    public class AutomationDevicesContext: DbContext
    {
        public virtual DbSet<Device> Devices { get; set; }
        public virtual DbSet<Event> Events { get; set; }

        public AutomationDevicesContext()
        {

        }

        public AutomationDevicesContext(DbContextOptions<AutomationDevicesContext> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString: "Integrated Security=SSPI;" +
                                                          "Persist Security Info=False;" +
                                                          "Initial Catalog=AutomationDevices;" +
                                                          "Data Source=DESKTOP-F0G0H3H");
        }

    }
}
