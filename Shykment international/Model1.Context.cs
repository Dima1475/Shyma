﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Shykment_international
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Shykment_internationalEntities : DbContext
    {
        public Shykment_internationalEntities()
            : base("name=Shykment_internationalEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Administators> Administators { get; set; }
        public virtual DbSet<Airlines> Airlines { get; set; }
        public virtual DbSet<Arrivals> Arrivals { get; set; }
        public virtual DbSet<Cities> Cities { get; set; }
        public virtual DbSet<Departures> Departures { get; set; }
        public virtual DbSet<Dispatcher> Dispatcher { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
