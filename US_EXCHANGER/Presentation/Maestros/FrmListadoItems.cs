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
using US_EXCHANGER.Models.Productos;

namespace US_EXCHANGER.Presentation.Maestros
{
    public partial class FrmListadoItems : FrmSchemeListado
    {
        #region Atributos
        string _Persona = null;
        public bool Hijo = false;
        List<OPE_PRODUCTODTO> _ListItem = new List<OPE_PRODUCTODTO>();
        List<OPE_DETALLE_TABLADTO> _ListTipo = new List<OPE_DETALLE_TABLADTO>();
        List<OPE_DETALLE_TABLADTO> _ListCategoria = new List<OPE_DETALLE_TABLADTO>();
        DataTable dt;
        Helpers.Operacion _Operativa = 0;
        public string Docu = null;
        public static string Nombre = null;
        public static string CodDocu = null;
        private static OPE_PRODUCTODTO _OPE_PRODUCTODTO;
        #endregion




        public FrmListadoItems()
        {
            InitializeComponent();
        }
        public List<OPE_DETALLE_TABLADTO> LoadTipo()
        {
            List<OPE_DETALLE_TABLADTO> listado1 = null;
            string cnn = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString))

            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                var procedure = "GetDataDTabla";
                DynamicParameters cmd = new DynamicParameters();
                cmd.Add("@CODIGO", "TIPO_PROD");
                listado1 = db.Query<OPE_DETALLE_TABLADTO>(procedure, cmd, commandType: System.Data.CommandType.StoredProcedure).ToList();
                db.Dispose();
            }
            return new List<OPE_DETALLE_TABLADTO>(listado1);

        }
        public List<OPE_DETALLE_TABLADTO> LoadCategoria()
        {
            List<OPE_DETALLE_TABLADTO> listado1 = null;
            string cnn = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString))

            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                var procedure = "GetDataDTabla";
                DynamicParameters cmd = new DynamicParameters();
                cmd.Add("@CODIGO", "TIPO_IDEN");
                listado1 = db.Query<OPE_DETALLE_TABLADTO>(procedure, cmd, commandType: System.Data.CommandType.StoredProcedure).ToList();
                db.Dispose();
            }
            return new List<OPE_DETALLE_TABLADTO>(listado1);

        }
        private void FrmListadoItems_Load(object sender, EventArgs e)
        {

        }
    }
}
