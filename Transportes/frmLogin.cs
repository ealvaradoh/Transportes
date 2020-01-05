using BL.Transportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

            List<TextBox> servidorTlist = new List<TextBox>();
            List<string> servidorsSlist = new List<String>();
            servidorTlist.Add(txtServidor);
            servidorsSlist.Add("Servidor");
            SetCueBanner(ref servidorTlist, servidorsSlist);

            List<TextBox> usuarioTlist = new List<TextBox>();
            List<string> usuarioSlist = new List<String>();
            usuarioTlist.Add(txtUsuario);
            usuarioSlist.Add("Usuario");
            SetCueBanner(ref usuarioTlist, usuarioSlist);

            List<TextBox> contrasenaTlist = new List<TextBox>();
            List<string> contrasenaSlist = new List<String>();
            contrasenaTlist.Add(txtContrasenia);
            contrasenaSlist.Add("Contraseña");
            SetCueBanner(ref contrasenaTlist, contrasenaSlist);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint msg, IntPtr i, string str);

        void SetCueBanner(ref List<TextBox> textBox, List<string> CueText)
        {
            for (int x = 0; x < textBox.Count; x++)
            {
                SendMessage(textBox[x].Handle, 0x1501, (IntPtr)1, CueText[x]);
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static string servidorLog;
        public static string usuarioLog;
        public static string contraseniaLog;
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            servidorLog = txtServidor.Text;
            usuarioLog = txtUsuario.Text;
            contraseniaLog = txtContrasenia.Text;

            var resultado = _usuarios.AutorizarIngreso(usuarioLog, contraseniaLog);
            if (resultado.Exitoso == true)
            {
                MenuPrincipal.DesbloqueaControles();
                MenuPrincipal.DatosDeConexion();
                this.Close();
            }
            else
                MessageBox.Show(resultado.Mensaje);
        }

        private void btnMostrarUsuarios_Click(object sender, EventArgs e)
        {
            var usuarios = _usuarios.ObtenerUsuarios();

        }
    }
}
