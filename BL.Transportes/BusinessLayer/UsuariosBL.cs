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
            _context.Usuarios.Load();
            ListaUsuarios = _context.Usuarios.Local.ToBindingList();
            return ListaUsuarios;
        }

        public Resultado AutorizarIngreso(string usuario, string contrasenia)
        {
            var resultado = new Resultado();
            var usuarios = _context.Usuarios.ToList();

            foreach (var usuarioDB in usuarios)
            {
                if (usuario == usuarioDB.Nombre && contrasenia == usuarioDB.Contrasenia)
                {
                    resultado.Exitoso = true;
                    resultado.Mensaje = "Ingresando al sistema";
                    return resultado;
                }
            }
            resultado.Exitoso = false;
            resultado.Mensaje = "Usuario o contraseña es incorrecto";

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
