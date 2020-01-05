using BL.Transportes.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Transportes.Conexion
{
    public class DatosDeInicio : CreateDatabaseIfNotExists<Context>
    {
        protected override void Seed(Context contexto)
        {
            //Usuario
            var usuarioAdmin = new Usuario();
            usuarioAdmin.Nombre = "admin";
            usuarioAdmin.Contrasenia = "123";
            usuarioAdmin.Activo = true;

            contexto.Usuarios.Add(usuarioAdmin);

            //Buses
            var Bus1 = new Cat_Buses();
            Bus1.Placa = "HN123";
            Bus1.Color = "Blanco";
            Bus1.CantAsientos = 26;

            var Bus2 = new Cat_Buses();
            Bus2.Placa = "HN124";
            Bus2.Color = "Rojo";
            Bus2.CantAsientos = 26;

            contexto.Buses.Add(Bus1);
            contexto.Buses.Add(Bus2);

            base.Seed(contexto);
        }
    }
}
