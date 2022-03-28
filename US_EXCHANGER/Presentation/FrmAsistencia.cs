using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace US_EXCHANGER.Presentation
{
    public partial class FrmAsistencia : FrmScheme
    {
        public FrmAsistencia()
        {
            InitializeComponent();
        }

        private void btnCompraVenta_Click(object sender, EventArgs e)
        {
            FrmTomarAsistencia _Asistencia = new FrmTomarAsistencia();
            _Asistencia.ShowDialog();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            FrmMaestroEmpleado _Empleado = new FrmMaestroEmpleado();
            _Empleado.ShowDialog();
        }
    }
}
