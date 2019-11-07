using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PersonalSite2019.DATA.EF//.Metadata
{
    public class ImageMetaData
    {
        [Required]
        [StringLength(100, ErrorMessage = "** Max 100 Characters **")]
        [Display(Name = "Image URL")]
        public string ImageURL { get; set; }
        [Display(Name = "Cover Photo")]
        public Nullable<bool> IsCoverPhoto { get; set; }
    }

    [MetadataType(typeof(ImageMetaData))]
    public partial class Image
    {

    }
}
