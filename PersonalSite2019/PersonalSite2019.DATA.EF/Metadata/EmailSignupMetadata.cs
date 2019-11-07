using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PersonalSite2019.DATA.EF//.Metadata
{
    public class EmailSignupMetadata
    {
        [Required]
        [StringLength(50, ErrorMessage = "** Max 50 Characters **")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50, ErrorMessage = "** Max 50 Characters **")]
        public string LastName { get; set; }
        [Required]
        [StringLength(75, ErrorMessage = "** Max 75 Characters **")]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }
        [Display(Name = "Active")]
        public bool IsActive { get; set; }
    }

    [MetadataType(typeof(EmailSignupMetadata))]
    public partial class EmailSignup
    {

    }
}
