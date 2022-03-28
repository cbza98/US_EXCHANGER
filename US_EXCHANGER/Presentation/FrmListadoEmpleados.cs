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

namespace US_EXCHANGER.Presentation
{
    public partial class FrmListadoEmpleados : FrmSchemeListado
    {
        public FrmListadoEmpleados()
        {
            InitializeComponent();
        }

        string _Persona = null;
        public bool Hijo = false;
        List<Models.Persona.Asistencia> _Listpersonas = new List<Models.Persona.Asistencia>();

        DataTable dt;
        Helpers.Operacion _Operativa = 0;
        public string Docu = null;
        public static string Nombre = null;
        public static string CodDocu = null;
        private static Models.Persona.Asistencia _oPE_PERSONASDTO;
        public Models.Persona.Asistencia OPE_PERSONASDTO
        {
            get { return _oPE_PERSONASDTO; }
            set
            {
                _oPE_PERSONASDTO = value;
            }
        }


        private List<Models.Persona.Asistencia> CargarListEmpleados()
        {

            List<Models.Persona.Asistencia> listado1 = null;
            string cnn = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            using (IDbConnection db = new SqlConnection(cnn))

            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                var procedure = "GetdataRRHH";
                DynamicParameters cmd = new DynamicParameters();
                listado1 = db.Query<Models.Persona.Asistencia>(procedure, cmd, commandType: System.Data.CommandType.StoredProcedure).ToList();
                db.Dispose();
            }
            return new List<Models.Persona.Asistencia>(listado1);

        }
        public void CargarCabecera()
        {
            SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);
            SqlCommand comando = new SqlCommand(Properties.Resources.GetRRHHEmpleado, cnn);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dtListado.DataSource = tabla;
            dtListado.AutoSize = true;
        }

        private void FrmListadoEmpleados_Load(object sender, EventArgs e)
        {
            CargarCabecera();
        }
    }
}
