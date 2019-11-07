using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PersonalSite2019.DATA.EF//.Metadata
{
    public class BlogMetadata
    {
        [Required]
        [Display(Name = "Blog Title")]
        [StringLength(25, ErrorMessage = "**25 Characters Max Length**")]
        public string BlogName { get; set; }
        [Display(Name = "Blog Description")]
        public string BlogDescription { get; set; }
        [UIHint("MultilineText")]
        [Required]
        [Display(Name = "Body")]
        
        public string BlogBody { get; set; }
        [DisplayFormat(NullDisplayText = "No Date Given", DataFormatString = "{0:d}")]
        [Display(Name = "Date Created")]
        public Nullable<System.DateTime> DateCreated { get; set; }
        [Display(Name = "Featured")]
        public bool IsFeatured { get; set; }
        [Display(Name = "Active")]
        public bool IsActive { get; set; }
    }

    [MetadataType(typeof(BlogMetadata))]
    public partial class Blog
    {

    }
}
