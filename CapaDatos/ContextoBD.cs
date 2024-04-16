using CapaEntidades;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Data.Entity;
using System.Linq;

namespace CapaDatos
{
    public partial class ContextoBD : DbContext
    {
        public ContextoBD()
            : base(ConfigurationManager.ConnectionStrings["ContextoBD"].ConnectionString)
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public virtual DbSet<Venta> Ventas { get; set;}
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<DetalleVenta> DetalleVentas { get; set; }

    }
}
