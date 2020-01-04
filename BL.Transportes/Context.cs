using BL.Transportes;
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
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
