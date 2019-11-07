using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PersonalSite2019.DATA.EF//.Metadata
{
    public class ResourceMetadata
    {
        [StringLength(50, ErrorMessage = "** Max 50 Characters **")]
        [Required]
        [Display(Name = "Title")]
        public string ResourceTitle { get; set; }
        [StringLength(100, ErrorMessage = "** Max 100 Characters **")]
        [Required]
        [Display(Name = "URL")]
        public string ResourceUrl { get; set; }
        [DisplayFormat(NullDisplayText = "No Image Provided")]
        [StringLength(100, ErrorMessage = "** Max 100 Characters **")]
        [Display(Name = "Image")]
        public string ResourceImage { get; set; }
    }

    [MetadataType(typeof(ResourceMetadata))]
    public partial class Resource
    {

    }
}
