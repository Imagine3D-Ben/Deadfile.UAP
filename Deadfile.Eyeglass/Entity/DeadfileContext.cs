using Deadfile.Eyeglass.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadfile.Eyeglass.Entity
{
    public partial class DeadfileContext : DbContext, IDeadfileContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=DeadfileLite.db");
        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<PlanningApplication> PlanningApplications { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
    }
}
