using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadfile.Eyeglass.Entity
{
    public partial class Council
    {
        public int Id { get; set; }
        [Required, MaxLength(200, ErrorMessage = "Council name should be less than 200 characters")]
        public string Name { get; set; }
    }
}
