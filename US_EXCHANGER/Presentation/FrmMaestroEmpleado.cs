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


        private void Inicializar()
        {
            DataTable table = new DataTable();
            DataTable table2 = new DataTable();
            table.Clear();
            table.Columns.Add("ID°", typeof(string));
            table.Columns.Add("TARIFA", typeof(string));
            table.Columns.Add("MONTO", typeof(string));

            DataRow _row = table.NewRow();
            _row["ID°"] = "8";
            _row["TARIFA"] = "ADULTO MAYOR";
            _row["MONTO"] = "S/. 15.00";
            table.Rows.Add(_row);



            _row = table.NewRow();
            _row["ID°"] = "5";
            _row["TARIFA"] = "ADULTO";
            _row["MONTO"] = "S/. 20.00";
            table.Rows.Add(_row);



            _row = table.NewRow();
            _row["ID°"] = "21";
            _row["TARIFA"] = "NIÑO";
            _row["MONTO"] = "S/. 10.00";
            table.Rows.Add(_row);
            dtListado.DataSource = table;
            dtListado.AutoResizeRow(0);
            dtListado.AutoResizeRow(1);
            dtListado.AutoResizeRow(2);
        }

        private void usButton5_Click(object sender, EventArgs e)
        {
            //FrmCapturarHuella _CapHuella = new FrmCapturarHuella();
            //_CapHuella.ShowDialog();
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

        private void FrmMaestroEmpleado_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void usButton1_Click(object sender, EventArgs e)
        {

        }

        private void usButton2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
