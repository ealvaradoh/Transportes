using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Transportes
{
    public class UsuariosBL
    {
        Context _context;
        public BindingList<Usuario> ListaUsuarios { get; set; }

        public UsuariosBL()
        {
            _context = new Context();
            ListaUsuarios = new BindingList<Usuario>();
        }

        public BindingList<Usuario> ObtenerUsuarios()
        {
            ListaUsuarios = _context.Usuarios.Local.ToBindingList();
            return ListaUsuarios;
        }

        public ResultadoBL AutorizarIngreso()
        {
            ObtenerUsuarios();
            var resultado = new ResultadoBL();
            var usuarios = _context.Usuarios.ToList();

            resultado.Exitoso = true;
            resultado.Mensaje = "Ingresando al sistema";

            return resultado;
        }
    }

    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contrasenia { get; set; }
        public bool Activo { get; set; }
    }
}
