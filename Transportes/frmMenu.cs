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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void loguearse()
        {
            var frmLogin = new frmLogin();
            frmLogin.MenuPrincipal = this;
            frmLogin.ShowDialog();
        }

        public void DatosDeConexion()
        {
            string servidor = frmLogin.servidorLog;
            string usuario = frmLogin.usuarioLog;
            string contrasenia = frmLogin.contraseniaLog;

            tssUsuario.Text = tssUsuario.Text + " " + usuario;
            tssServidor.Text = tssServidor.Text + " " + servidor;
        }

        private void BloqueaControles()
        {
            foreach (Control control in Controls)
                if (control is MenuStrip)
                    control.Enabled = false;
        }

        public void DesbloqueaControles()
        {
            foreach (Control control in Controls)
            {
                if (control is MenuStrip)
                    control.Enabled = true;
            }
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            BloqueaControles();
            loguearse();
        }

        private frmCatBuses frmCatBuses;
        private void busesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmCatBuses == null)
            {
                frmCatBuses = new frmCatBuses();
                frmCatBuses.MdiParent = this;
                frmCatBuses.Show();
            }
            else if (frmCatBuses.IsDisposed)
            {
                frmCatBuses = new frmCatBuses();
                frmCatBuses.MdiParent = this;
                frmCatBuses.Show();
            }
            else
                frmCatBuses.Activate();
        }
    }
}
