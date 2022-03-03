using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace US_EXCHANGER.Presentation.Configuracion
{
    public partial class FrmMaestroEmpresa : FrmScheme
    {
        public FrmMaestroEmpresa()
        {
            InitializeComponent();
        }

        private void FrmMaestroEmpresa_Load(object sender, EventArgs e)
        {
            var List = CultureInfo.GetCultures(CultureTypes.AllCultures);
            cmbPais.DataSource = List;
            cmbPais.DisplayMember = "DisplayName";
            cmbPais.ValueMember = "Name";
        }
        public static  void CargarConfiguracionRegional()
        {

        }
    }
}
