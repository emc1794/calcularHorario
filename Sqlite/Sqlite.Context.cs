﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sqlite
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PruebaEntities : DbContext
    {
        public PruebaEntities()
            : base("name=PruebaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Area> Area { get; set; }
        public virtual DbSet<Area_Categoria> Area_Categoria { get; set; }
        public virtual DbSet<Asueto> Asueto { get; set; }
        public virtual DbSet<personaNombreCompleto> personaNombreCompleto { get; set; }
        public virtual DbSet<Fecha> Fecha { get; set; }
        public virtual DbSet<Area_Persona> Area_Persona { get; set; }
        public virtual DbSet<calculo> calculo { get; set; }
    }
}
