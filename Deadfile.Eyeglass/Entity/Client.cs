using Deadfile.Eyeglass.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadfile.Eyeglass.Entity
{
    public partial class Client
    {
        public int Id { get; set; }
        [Required, MaxLength(30, ErrorMessage = "First names are expected to be shorter than 30 characters")]
        public string FirstName { get; set; }
        [MaxLength(60, ErrorMessage = "Middle names are expected to be shorter than 60 characters")]
        public string MiddleName { get; set; }
        [Required, MaxLength(30, ErrorMessage = "Last names are expected to be shorter than 30 characters")]
        public string LastName { get; set; }
        [Required, MaxLength(200, ErrorMessage = "Address line 1 is expected to be shorter than 200 characters")]
        public string AddressLine1 { get; set; }
        [MaxLength(200, ErrorMessage = "Address line 2 is expected to be shorter than 200 characters")]
        public string AddressLine2 { get; set; }
        [MaxLength(50, ErrorMessage = "Address town is expected to be shorter than 50 characters")]
        public string AddressTown { get; set; }
        [Required, RegularExpression("[A-Z]{1,3}[0-9]{1,2} ?[A-Z]{1-3}[0-9]{1,2}", ErrorMessage = "Not a valid UK postcode")]
        public string AddressPostCode { get; set; }
        [Required, RegularExpression("[0-9]{11,17}", ErrorMessage = "Not a valid UK phone number")]
        public string PhoneNumber1 { get; set; }
        [RegularExpression("[0-9]{11,17}", ErrorMessage = "Not a valid UK phone number")]
        public string PhoneNumber2 { get; set; }
        [RegularExpression("[0-9]{11,17}", ErrorMessage = "Not a valid UK phone number")]
        public string PhoneNumber3 { get; set; }
        [Required, EmailAddress]
        public string EmailAddress { get; set; }
        [Required]
        public ClientState State { get; set; }
        [MaxLength(500, ErrorMessage = "The notes field is expected to be shorter than 500 characters")]
        public string Notes { get; set; }
        public virtual List<Job> Jobs { get; set; }
    }
}
