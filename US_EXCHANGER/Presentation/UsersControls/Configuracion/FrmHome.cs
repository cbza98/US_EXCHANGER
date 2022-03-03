using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace US_EXCHANGER.Presentation.UsersControls.Configuracion
{
    public partial class FrmHome : UserControl
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void btnCompraVenta_Click(object sender, EventArgs e)
        {
            new Operaciones.FrmOpeCompraVentas().Show();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            new Operaciones.FRMAGREGARCAMBIO().Show();
        }
    }
}
