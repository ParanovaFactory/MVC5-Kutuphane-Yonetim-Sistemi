﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kutuphane.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DbKutuphaneEntities : DbContext
    {
        public DbKutuphaneEntities()
            : base("name=DbKutuphaneEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblCeza> tblCeza { get; set; }
        public virtual DbSet<tblHareket> tblHareket { get; set; }
        public virtual DbSet<tblKasa> tblKasa { get; set; }
        public virtual DbSet<tblKategori> tblKategori { get; set; }
        public virtual DbSet<tblKitap> tblKitap { get; set; }
        public virtual DbSet<tblPersonel> tblPersonel { get; set; }
        public virtual DbSet<tblUyeler> tblUyeler { get; set; }
        public virtual DbSet<tblYazar> tblYazar { get; set; }
        public virtual DbSet<tblHakkimizda> tblHakkimizda { get; set; }
        public virtual DbSet<tblIlestisim> tblIlestisim { get; set; }
        public virtual DbSet<tblGaleri> tblGaleri { get; set; }
        public virtual DbSet<tblOkul> tblOkul { get; set; }
        public virtual DbSet<tblMesajlar> tblMesajlar { get; set; }
        public virtual DbSet<tblDuyurular> tblDuyurular { get; set; }
        public virtual DbSet<tblAdmin> tblAdmin { get; set; }
    
        public virtual ObjectResult<string> EnFazlaKitapYazar()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("EnFazlaKitapYazar");
        }
    
        public virtual ObjectResult<string> EnYayınEvi()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("EnYayınEvi");
        }
    
        public virtual ObjectResult<string> EnOkunan()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("EnOkunan");
        }
    
        public virtual ObjectResult<string> EnAktifUye()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("EnAktifUye");
        }
    
        public virtual ObjectResult<string> EnBaşarılıPer()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("EnBaşarılıPer");
        }
    
        public virtual ObjectResult<Nullable<int>> BugunKitap()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("BugunKitap");
        }
    
        public virtual ObjectResult<Nullable<int>> Okul()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("Okul");
        }
    
        public virtual ObjectResult<string> okul1()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("okul1");
        }
    }
}
