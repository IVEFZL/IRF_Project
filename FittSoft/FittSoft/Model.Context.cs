﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FittSoft
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DWEntities : DbContext
    {
        public DWEntities()
            : base("name=DWEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<D_GYAKORLAT> D_GYAKORLAT { get; set; }
        public virtual DbSet<D_KATEGORIA> D_KATEGORIA { get; set; }
        public virtual DbSet<F_EDZES> F_EDZES { get; set; }
        public virtual DbSet<F_EDZES_GYAKORLAT> F_EDZES_GYAKORLAT { get; set; }
        public virtual DbSet<F_MERES> F_MERES { get; set; }
    }
}
