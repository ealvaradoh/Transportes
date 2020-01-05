using BL.Transportes;
using BL.Transportes.BusinessLayer;
using BL.Transportes.Conexion;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Transportes
{
    public class Context: DbContext
    {
        public Context(): base("data source = NETO-PC; initial catalog = TransportesDB; user id = sa; password = 1802net%")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            Database.SetInitializer(new DatosDeInicio());
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cat_Buses> Buses { get; set; }
    }
}
