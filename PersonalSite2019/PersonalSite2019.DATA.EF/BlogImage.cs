//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PersonalSite2019.DATA.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class BlogImage
    {
        public int BlogImageId { get; set; }
        public int BlogId { get; set; }
        public int ImageId { get; set; }
    
        public virtual Blog Blog { get; set; }
        public virtual Image Image { get; set; }
    }
}
