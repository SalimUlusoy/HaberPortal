﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HaberPortal.Database.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HaberlerEntities1 : DbContext
    {
        public HaberlerEntities1()
            : base("name=HaberlerEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<isimler> isimler { get; set; }
        public virtual DbSet<Soyisimler> Soyisimler { get; set; }
        public virtual DbSet<tbl_Begeni> tbl_Begeni { get; set; }
        public virtual DbSet<tbl_Haberler> tbl_Haberler { get; set; }
        public virtual DbSet<tbl_HaberResim> tbl_HaberResim { get; set; }
        public virtual DbSet<tbl_Kategori> tbl_Kategori { get; set; }
        public virtual DbSet<tbl_Paylasildi> tbl_Paylasildi { get; set; }
        public virtual DbSet<tbl_Trafik> tbl_Trafik { get; set; }
        public virtual DbSet<tbl_Uye> tbl_Uye { get; set; }
        public virtual DbSet<tbl_Yazarlar> tbl_Yazarlar { get; set; }
        public virtual DbSet<tbl_Yorum> tbl_Yorum { get; set; }
    }
}