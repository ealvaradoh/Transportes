using BL.Transportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transportes
{
    public partial class frmLogin : Form
    {
        public frmMenu MenuPrincipal { get; set; }
        UsuariosBL _usuarios;

        public frmLogin()
        {
            InitializeComponent();
            _usuarios = new UsuariosBL();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            var resultado = _usuarios.AutorizarIngreso();
            if (resultado.Exitoso == true)
            {
                MenuPrincipal.DesbloqueaControles();
                Console.Write(resultado.Mensaje);
                this.Close();
            }
            else
                MessageBox.Show(resultado.Mensaje);
        }
    }
}
