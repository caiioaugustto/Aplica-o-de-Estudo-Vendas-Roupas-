using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace EstudosVendasRoupas.Entidades
{
    public class Context : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.Conventions.Remove<PluralizingTableNameConvention>();
            builder.Entity<Venda>().HasRequired(m => m.Cliente);
        }
    }
}