using Deadfile.Eyeglass.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadfile.Eyeglass.Interfaces
{
    public interface IDeadfileContext
    {
        DbSet<Client> Clients { get; set; }
        DbSet<Job> Jobs { get; set; }
        DbSet<PlanningApplication> PlanningApplications { get; set; }
        DbSet<Invoice> Invoices { get; set; }
    }
}
