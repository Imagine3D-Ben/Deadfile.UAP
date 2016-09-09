using Deadfile.Eyeglass.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadfile.Eyeglass.Entity
{
    public partial class Job
    {
        public int Id { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
        [Required, MaxLength(200, ErrorMessage = "Address line 1 is expected to be shorter than 200 characters")]
        public string AddressLine1 { get; set; }
        [MaxLength(200, ErrorMessage = "Address line 2 is expected to be shorter than 200 characters")]
        public string AddressLine2 { get; set; }
        [MaxLength(50, ErrorMessage = "Address town is expected to be shorter than 50 characters")]
        public string AddressTown { get; set; }
        [Required, RegularExpression("[A-Z]{1,3}[0-9]{1,2} ?[A-Z]{1-3}[0-9]{1,2}", ErrorMessage = "Not a valid UK postcode")]
        public string AddressPostCode { get; set; }
        [Required]
        public JobState State { get; set; }
        [Required]
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
        public virtual List<PlanningApplication> PlanningApplications { get; set; }
        public virtual List<Invoice> Invoices { get; set; }
    }
}
