﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Logic
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class KsiegarniaEntities : DbContext
    {
        public KsiegarniaEntities()
            : base("name=KsiegarniaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Administrator> Administrator { get; set; }
        public virtual DbSet<ArchiwumZamowien> ArchiwumZamowien { get; set; }
        public virtual DbSet<PozycjaZamowienie> PozycjaZamowienie { get; set; }
        public virtual DbSet<Pracownik> Pracownik { get; set; }
        public virtual DbSet<Produkt> Produkt { get; set; }
        public virtual DbSet<StatusZamowienie> StatusZamowienie { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Zamowienie> Zamowienie { get; set; }
    }
}
