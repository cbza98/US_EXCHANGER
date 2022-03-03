using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using US_EXCHANGER.Models.Maestros.TablasBasicas;

namespace US_EXCHANGER.Presentation.Configuracion
{
    public partial class FrmTablasBasicas : FrmPopUpScheme
    {
        public FrmTablasBasicas()
        {
            InitializeComponent();
        }
        public static List<OPE_TABLABean> CargarListadoCabecera()
        {
            List<OPE_TABLABean> listado1 = null;
            string cnn = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString))
             
                { 
                if(db.State == ConnectionState.Closed)
                    db.Open();
                var procedure = "GetDataTablas";
                   DynamicParameters cmd = new DynamicParameters();
                listado1 =  db.Query<OPE_TABLABean>(procedure, cmd, commandType: System.Data.CommandType.StoredProcedure).ToList();
            }
            return new List<OPE_TABLABean>(listado1);
 }
        public  void CargarCabecera()
        {
            dataGridView1.DataSource = CargarListadoCabecera();
            dataGridView1.AutoResizeColumns();


        }
        public static List<OPE_DETALLE_TABLABean> CargarListadoDetalle(string CodigoTabla)
        {
            List<OPE_DETALLE_TABLABean> listado = null;
            string cnn = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            using (IDbConnection db2 = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString))

            {
                if (db2.State == ConnectionState.Closed)
                    db2.Open();
                var procedure = "GetDataDTabla";
                DynamicParameters cmd = new DynamicParameters();
                cmd.Add("@CODIGO", CodigoTabla);
                listado = db2.Query<OPE_DETALLE_TABLABean>(procedure, cmd, commandType: System.Data.CommandType.StoredProcedure).ToList();
            }
            return new List<OPE_DETALLE_TABLABean>(listado);
        }
        public void CargarDetalle(string CodigoTabla)
        {
            grdDetalleTabla.DataSource = CargarListadoDetalle(CodigoTabla);
            grdDetalleTabla.AutoResizeColumns();

        }
        private void FrmTablasBasicas_Load(object sender, EventArgs e)
        {
            CargarCabecera();

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    string valorCelda = dataGridView1.Rows[e.RowIndex].Cells["CODIGO"].Value.ToString();

                    CargarDetalle(valorCelda);
                }

            }
            catch (Exception ex)
            {

                throw;
            }
           
        }
    }
}
