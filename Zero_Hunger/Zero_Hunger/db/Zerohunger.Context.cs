﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Zero_Hunger.db
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Zero_HungerEntities : DbContext
    {
        public Zero_HungerEntities()
            : base("name=Zero_HungerEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<dbDISTRIBUTION_List> dbDISTRIBUTION_List { get; set; }
        public virtual DbSet<dbEMPLOYEE_List> dbEMPLOYEE_List { get; set; }
        public virtual DbSet<dbFOODITEM_List> dbFOODITEM_List { get; set; }
        public virtual DbSet<dbNGO_List> dbNGO_List { get; set; }
        public virtual DbSet<dbRESTAURENT_List> dbRESTAURENT_List { get; set; }
        public virtual DbSet<dbTRACKCOLLECTION_List> dbTRACKCOLLECTION_List { get; set; }
        public virtual DbSet<NGO_RESTAURENT> NGO_RESTAURENT { get; set; }
    }
}
