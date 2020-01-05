using BL.Transportes.BusinessLayer;
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
    public partial class frmCatBuses : Form
    {
        Cat_BusesBL _buses;

        public frmCatBuses()
        {
            InitializeComponent();
            _buses = new Cat_BusesBL();
            cat_BusesBindingSource.DataSource = _buses.ObtenerBuses();
        }

        private void frmCatBuses_Load(object sender, EventArgs e)
        {
             
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _buses.AgregarBus();
            cat_BusesBindingSource.MoveLast();

            
        }
    }
}
