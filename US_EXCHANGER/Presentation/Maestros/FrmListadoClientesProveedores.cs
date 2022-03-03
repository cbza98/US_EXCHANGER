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
using US_EXCHANGER.Models.Persona.Entidad;

namespace US_EXCHANGER.Presentation.Maestros
{
    public partial class FrmListadoClientesProveedores : FrmScheme
    {

        string _Persona = null;
        public bool Hijo = false;
        Helpers.Operacion _Operativa = 0;
        public string Docu = null;
        public static string Nombre = null;
        public static string CodDocu = null;
        private static OPE_PERSONASDTO _oPE_PERSONASDTO;
        public OPE_PERSONASDTO OPE_PERSONASDTO
        {
            get { return _oPE_PERSONASDTO; }
            set
            {
                _oPE_PERSONASDTO = value;
            }
        }
        public FrmListadoClientesProveedores(string TipoPersona)
        {
            _Persona = TipoPersona;
            InitializeComponent();
        }
        private void FrmListadoClientesProveedores_Load(object sender, EventArgs e)
        {
            CargarCabecera();
            switch (Hijo)
            {
                case true:
                    btnSiguiente.Visible = true;
                    break;
                default:
                    btnSiguiente.Visible = false;
                    break;
            }

        }
        private List<OPE_PERSONASDTO> CargarListClientes()
        {

            List<OPE_PERSONASDTO> listado1 = null;
            string cnn = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString))

            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                var procedure = "OPESS_OBTENER_PERSONA_CAMBIO";
                DynamicParameters cmd = new DynamicParameters();
                cmd.Add("@TIPO", _Persona);
                listado1 = db.Query<OPE_PERSONASDTO>(procedure, cmd, commandType: System.Data.CommandType.StoredProcedure).ToList();
                db.Dispose();
            }
            return new List<OPE_PERSONASDTO>(listado1);

        }
        public void CargarCabecera()
        {
            DataTable dt = Helpers.Utils.ToDataTable<OPE_PERSONASDTO>(CargarListClientes().ToList());

            dtListado.DataSource = dt;
            dtListado.AutoResizeColumns();
        }
        private void dtListado_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
        private void dtListado_DoubleClick(object sender, EventArgs e)
        {

            if (dtListado.SelectedCells.Count > 0)
            {
                int selectedrowindex = dtListado.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dtListado.Rows[selectedrowindex];
                Docu = Convert.ToString(selectedRow.Cells["Documento"].Value);
                Nombre = Convert.ToString(selectedRow.Cells["Nombre"].Value);
                _oPE_PERSONASDTO = new OPE_PERSONASDTO();
                _oPE_PERSONASDTO.Nombre = Nombre;
                _oPE_PERSONASDTO.Documento = Docu;

                //   CodDocu = Convert.ToString(selectedRow.Cells["enter column name"].Value);
            }
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            var Persona = OPE_PERSONASDTO;
        }
        private void dtListado_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (dtListado.SelectedCells.Count > 0)
            {
                int selectedrowindex = dtListado.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dtListado.Rows[selectedrowindex];
                Docu = Convert.ToString(selectedRow.Cells["Codigo"].Value);
                switch (Hijo)
                {
                    case true:
                        btnSiguiente.PerformClick();
                        break;
                    default:
                        break;
                }

                this.Dispose();
                //   CodDocu = Convert.ToString(selectedRow.Cells["enter column name"].Value);
            }
        }
    }
}
