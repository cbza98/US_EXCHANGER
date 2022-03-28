using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using US_EXCHANGER.Presentation.UsersControls.MessageBox;

namespace US_EXCHANGER.Presentation
{
    public partial class FrmMaestroEmpleado : FrmPopUpScheme
    {
        public FrmMaestroEmpleado()
        {
            InitializeComponent();
        }

        private void usButton5_Click(object sender, EventArgs e)
        {
            FrmCapturarHuella _CapHuella = new FrmCapturarHuella();
            _CapHuella.ShowDialog();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            FrmListadoEmpleados frmListadoEmpleados = new FrmListadoEmpleados();
            frmListadoEmpleados.ShowDialog();   
        }

        private void usButton3_Click(object sender, EventArgs e)
        {
            USMessageBox.Show($"Registro verificado...... Empleado Hebert Ruiz Amaya",
                "Notificación    ",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
