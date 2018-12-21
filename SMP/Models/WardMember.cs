using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SMP.Models
{
    public class WardMember
    {
        public int WardMemberID { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Please enter valid Last Name between 2 and 20 characters")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Calling")]
        public string Calling { get; set; }


        public string IsBishopricMember { get; set; }
    }
}
