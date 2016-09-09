using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadfile.Eyeglass.Entity
{
    public partial class Invoice
    {
        public int Id { get; set; }
        [Required]
        public int JobId { get; set; }
        public virtual Job Job { get; set; }
    }
}
