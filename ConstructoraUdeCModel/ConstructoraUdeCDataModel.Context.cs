﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConstructoraUdeCModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ConstructoraUdeCEntities : DbContext
    {
        public ConstructoraUdeCEntities()
            : base("name=ConstructoraUdeCEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BLOCK> BLOCK { get; set; }
        public virtual DbSet<CITY> CITY { get; set; }
        public virtual DbSet<COUNTRY> COUNTRY { get; set; }
        public virtual DbSet<CUSTOMER> CUSTOMER { get; set; }
        public virtual DbSet<FINANCIAL_INFORMATION> FINANCIAL_INFORMATION { get; set; }
        public virtual DbSet<PAYMENT> PAYMENT { get; set; }
        public virtual DbSet<PROJECT> PROJECT { get; set; }
        public virtual DbSet<PROPERTY> PROPERTY { get; set; }
        public virtual DbSet<RECEIPT> RECEIPT { get; set; }
        public virtual DbSet<REQUEST> REQUEST { get; set; }
        public virtual DbSet<SEC_ROLE> SEC_ROLE { get; set; }
        public virtual DbSet<SEC_SESSION> SEC_SESSION { get; set; }
        public virtual DbSet<SEC_USER> SEC_USER { get; set; }
        public virtual DbSet<SEC_USER_ROLE> SEC_USER_ROLE { get; set; }
        public virtual DbSet<STATUSREQUEST> STATUSREQUEST { get; set; }
    }
}