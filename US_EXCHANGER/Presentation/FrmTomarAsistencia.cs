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
    public partial class FrmTomarAsistencia : FrmSchemeListado
    {
        public FrmTomarAsistencia()
        {
            InitializeComponent();
        }



        private void Inicializar()
        {
            DataTable table = new DataTable();
            DataTable table2 = new DataTable();
            table.Clear();
            table.Columns.Add("N°", typeof(string));
            table.Columns.Add("DNI", typeof(string));
            table.Columns.Add("REGISTRO", typeof(DateTime));
            table.Columns.Add("V. HUELLA", typeof(string));

            DataRow _row = table.NewRow();
            _row["N°"] = "8";
            _row["DNI"] = "25861137";
            _row["V. HUELLA"] = "TKNTUzIxAAAF4OIECAUHCc7QAAAp4XYBAAAAhQ04tuDQACgMsABzACnsegDrADEPagAS4Z8MuwAcAdkNYuABAS8P7wBlACrvBgHWAK8MOgAC4asPYgCXAJEPAeEbAaEP6AD9AYzvQgAQAT4LYgBU4ZIPbQBmAKAPouBnAYcCCgGJAXrtBQFBAB0PcQAb4IIPqgDMAPcMlODGADkPegB8AEPvwQATAaMNOQDk4CkM3QAWAWAPlOCFAGEPxgDuAZnufAAnAakPywH84KkPBwGSAOwPOuCtAFcOgQCCAZ3v0ABLAYkP3QEz4YcIdgBNADMP9uBnAXwKkQDvAH3vVAAdAPUHfwDe4K8JtQChALQN5uCyAK0PagAVAEDvXgDBAEwPCwCN4CcPngArAWUPUODqAEgP2QDvAZ3vpgBqAHcPMwAs4ZQPAwEoAVwPM+DqAFYLYQD4AZPvLACaAF8KYgBE4H8PoQArAMMP1uAqABUP7PtFfxAfHL6h/pEHdAf/DNPq9IfZ/IQDPZv1g42B9ev0A8cSqIY9C+4K9IgP6RoFDQm5BdcQnx5XE3ILJQhQ";
            _row["REGISTRO"] = DateTime.Parse("2021-12-30 07:00");
            table.Rows.Add(_row);
            DataRow _row2 = table.NewRow();
            _row2["N°"] = "8";
            _row2["DNI"] = "25861137";
            _row2["V. HUELLA"] = "TKNTUzIxAAAF4OIECAUHCc7QAAAp4XYBAAAAhQ04tuDQACgMsABzACnsegDrADEPagAS4Z8MuwAcAdkNYuABAS8P7wBlACrvBgHWAK8MOgAC4asPYgCXAJEPAeEbAaEP6AD9AYzvQgAQAT4LYgBU4ZIPbQBmAKAPouBnAYcCCgGJAXrtBQFBAB0PcQAb4IIPqgDMAPcMlODGADkPegB8AEPvwQATAaMNOQDk4CkM3QAWAWAPlOCFAGEPxgDuAZnufAAnAakPywH84KkPBwGSAOwPOuCtAFcOgQCCAZ3v0ABLAYkP3QEz4YcIdgBNADMP9uBnAXwKkQDvAH3vVAAdAPUHfwDe4K8JtQChALQN5uCyAK0PagAVAEDvXgDBAEwPCwCN4CcPngArAWUPUODqAEgP2QDvAZ3vpgBqAHcPMwAs4ZQPAwEoAVwPM+DqAFYLYQD4AZPvLACaAF8KYgBE4H8PoQArAMMP1uAqABUP7PtFfxAfHL6h/pEHdAf/DNPq9IfZ/IQDPZv1g42B9ev0A8cSqIY9C+4K9IgP6RoFDQm5BdcQnx5XE3ILJQhQ";
            _row2["REGISTRO"] = DateTime.Parse("2021-12-31 08:45");
            table.Rows.Add(_row2);

            DataRow _row3 = table.NewRow();
            _row3["N°"] = "7";
            _row3["DNI"] = "24761137";
            _row3["V. HUELLA"] = "TKNTUzIxAAAF4OIECAUHCc7QAAAp4XYBAAAAhQ04tuDQACgMsABzACnsegDrADEPagAS4Z8MuwAcAdkNYuABAS8P7wBlACrvBgHWAK8MOgAC4asPYgCXAJEPAeEbAaEP6AD9AYzvQgAQAT4LYgBU4ZIPbQBmAKAPouBnAYcCCgGJAXrtBQFBAB0PcQAb4IIPqgDMAPcMlODGADkPegB8AEPvwQATAaMNOQDk4CkM3QAWAWAPlOCFAGEPxgDuAZnufAAnAakPywH84KkPBwGSAOwPOuCtAFcOgQCCAZ3v0ABLAYkP3QEz4YcIdgBNADMP9uBnAXwKkQDvAH3vVAAdAPUHfwDe4K8JtQChALQN5uCyAK0PagAVAEDvXgDBAEwPCwCN4CcPngArAWUPUODqAEgP2QDvAZ3vpgBqAHcPMwAs4ZQPAwEoAVwPM+DqAFYLYQD4AZPvLACaAF8KYgBE4H8PoQArAMMP1uAqABUP7PtFfxAfHL6h/pEHdAf/DNPq9IfZ/IQDPZv1g42B9ev0A8cSqIY9C+4K9IgP6RoFDQm5BdcQnx5XE3ILJQhQ";
            _row3["REGISTRO"] = DateTime.Parse("2022-01-22 08:00");
            table.Rows.Add(_row3);

       
            DataRow _row4 = table.NewRow();
            _row4["N°"] = "9";
            _row4["DNI"] = "45987456";
            _row4["V. HUELLA"] = "TKNTUzIxAAAF4OIECAUHCc7QAAAp4XYBAAAAhQ04tuDQACgMsABzACnsegDrADEPagAS4Z8MuwAcAdkNYuABAS8P7wBlACrvBgHWAK8MOgAC4asPYgCXAJEPAeEbAaEP6AD9AYzvQgAQAT4LYgBU4ZIPbQBmAKAPouBnAYcCCgGJAXrtBQFBAB0PcQAb4IIPqgDMAPcMlODGADkPegB8AEPvwQATAaMNOQDk4CkM3QAWAWAPlOCFAGEPxgDuAZnufAAnAakPywH84KkPBwGSAOwPOuCtAFcOgQCCAZ3v0ABLAYkP3QEz4YcIdgBNADMP9uBnAXwKkQDvAH3vVAAdAPUHfwDe4K8JtQChALQN5uCyAK0PagAVAEDvXgDBAEwPCwCN4CcPngArAWUPUODqAEgP2QDvAZ3vpgBqAHcPMwAs4ZQPAwEoAVwPM+DqAFYLYQD4AZPvLACaAF8KYgBE4H8PoQArAMMP1uAqABUP7PtFfxAfHL6h/pEHdAf/DNPq9IfZ/IQDPZv1g42B9ev0A8cSqIY9C+4K9IgP6RoFDQm5BdcQnx5XE3ILJQhQ";
            _row4["REGISTRO"] = DateTime.Parse("2022-01-24 10:00");
            table.Rows.Add(_row4);

            DataRow _row5 = table.NewRow();
            _row5["N°"] = "12";
            _row5["DNI"] = "45176328";
            _row5["V. HUELLA"] = "TKNTUzIxAAAF4OIECAUHCc7QAAAp4XYBAAAAhQ04tuDQACgMsABzACnsegDrADEPagAS4Z8MuwAcAdkNYuABAS8P7wBlACrvBgHWAK8MOgAC4asPYgCXAJEPAeEbAaEP6AD9AYzvQgAQAT4LYgBU4ZIPbQBmAKAPouBnAYcCCgGJAXrtBQFBAB0PcQAb4IIPqgDMAPcMlODGADkPegB8AEPvwQATAaMNOQDk4CkM3QAWAWAPlOCFAGEPxgDuAZnufAAnAakPywH84KkPBwGSAOwPOuCtAFcOgQCCAZ3v0ABLAYkP3QEz4YcIdgBNADMP9uBnAXwKkQDvAH3vVAAdAPUHfwDe4K8JtQChALQN5uCyAK0PagAVAEDvXgDBAEwPCwCN4CcPngArAWUPUODqAEgP2QDvAZ3vpgBqAHcPMwAs4ZQPAwEoAVwPM+DqAFYLYQD4AZPvLACaAF8KYgBE4H8PoQArAMMP1uAqABUP7PtFfxAfHL6h/pEHdAf/DNPq9IfZ/IQDPZv1g42B9ev0A8cSqIY9C+4K9IgP6RoFDQm5BdcQnx5XE3ILJQhQ";
            _row5["REGISTRO"] = DateTime.Parse("2022-01-25 09:45");
            table.Rows.Add(_row5);

            dtListado.DataSource = table;
        }

        private void FrmTomarAsistencia_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void usButton1_Click(object sender, EventArgs e)
        {
            USMessageBox.Show($"Dispositivo conectado exitosamente......",
                      "Notificación    ",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information);

        }

        private void usButton3_Click(object sender, EventArgs e)
        {
            USMessageBox.Show($"Dispositivo conectado exitosamente......",
          "Notificación    ",
          MessageBoxButtons.OK,
          MessageBoxIcon.Information);
        }

        private void usButton1_Click_1(object sender, EventArgs e)
        {
            USMessageBox.Show("asistencia registrada correctamente.....",
                            "Notificación    ",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
    }
}
