using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Transportes
{
    public class UsuariosBL
    {
        public ResultadoBL AutorizarIngreso()
        {
            var resultado = new ResultadoBL();
            resultado.Exitoso = true;

            if (resultado.Exitoso == true)
                resultado.Mensaje = "Ingresando al sistema";
            else
                resultado.Mensaje = "No se puede ingresar al sistema";

            return resultado;
        }

        public class Usuario
        {
            public int IdUsuario { get; set; }
            public string Nombre { get; set; }
            public string Contrasenia { get; set; }
            public bool Activo { get; set; }
        }
    }
}
