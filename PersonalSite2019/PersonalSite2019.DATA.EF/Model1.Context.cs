﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PersonalSiteEntities1 : DbContext
    {
        public PersonalSiteEntities1()
            : base("name=PersonalSiteEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BlogImage> BlogImages { get; set; }
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<EmailSignup> EmailSignups { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<Resource> Resources { get; set; }
    }
}
