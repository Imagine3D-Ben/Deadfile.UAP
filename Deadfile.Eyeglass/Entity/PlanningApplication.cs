using Deadfile.Eyeglass.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadfile.Eyeglass.Entity
{
    public partial class PlanningApplication
    {
        public int Id { get; set; }
        [Required]
        public PlanningApplicationType Type { get; set; }
        [Required]
        public DateTime DateSent { get; set; }
        [Required]
        public DateTime DateExpected { get; set; }
        [MaxLength(50, ErrorMessage = "Planning application reference is expected to be shorter than 50 characters")]
        public string Reference { get; set; }
        public DateTime DateDecided { get; set; }
        public PlanningApplicationDecision Decision { get; set; }
        [MaxLength(500, ErrorMessage = "The notes field is expected to be shorter than 500 characters")]
        public string Notes { get; set; }
        public int CouncilId { get; set; }
        public virtual Council Council { get; set; }
        [Required]
        public int JobId { get; set; }
        public virtual Job Job { get; set; }
    }
}
