﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Logistica.DbLogistica
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class logisticaEntities : DbContext
    {
        public logisticaEntities()
            : base("name=logisticaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<alertas> alertas { get; set; }
        public virtual DbSet<community> community { get; set; }
        public virtual DbSet<compound> compound { get; set; }
        public virtual DbSet<evaluation> evaluation { get; set; }
        public virtual DbSet<evaluationType> evaluationType { get; set; }
        public virtual DbSet<ficha> ficha { get; set; }
        public virtual DbSet<fichaFlights> fichaFlights { get; set; }
        public virtual DbSet<itinerary> itinerary { get; set; }
        public virtual DbSet<kitchenFood> kitchenFood { get; set; }
        public virtual DbSet<kitchenTools> kitchenTools { get; set; }
        public virtual DbSet<programs> programs { get; set; }
        public virtual DbSet<securityEquipments> securityEquipments { get; set; }
        public virtual DbSet<securityMedicines> securityMedicines { get; set; }
        public virtual DbSet<spokenLanguage> spokenLanguage { get; set; }
        public virtual DbSet<staff> staff { get; set; }
        public virtual DbSet<university> university { get; set; }
        public virtual DbSet<vehicles> vehicles { get; set; }
        public virtual DbSet<volunteers> volunteers { get; set; }
        public virtual DbSet<roles> roles { get; set; }
    }
}
