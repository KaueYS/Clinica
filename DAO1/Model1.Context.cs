﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class banco : DbContext
    {
        public banco()
            : base("name=banco")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tb_atendimento> tb_atendimento { get; set; }
        public virtual DbSet<tb_cliente> tb_cliente { get; set; }
        public virtual DbSet<tb_colaborador> tb_colaborador { get; set; }
        public virtual DbSet<tb_servico> tb_servico { get; set; }
        public virtual DbSet<tb_usuario> tb_usuario { get; set; }
    }
}