﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vize
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AgesofttEntities1 : DbContext
    {
        public AgesofttEntities1()
            : base("name=AgesofttEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_calisanlar> tbl_calisanlar { get; set; }
        public virtual DbSet<tbl_masalar> tbl_masalar { get; set; }
        public virtual DbSet<tbl_musteri> tbl_musteri { get; set; }
        public virtual DbSet<tbl_siparisler> tbl_siparisler { get; set; }
        public virtual DbSet<tbl_urun> tbl_urun { get; set; }
    }
}
