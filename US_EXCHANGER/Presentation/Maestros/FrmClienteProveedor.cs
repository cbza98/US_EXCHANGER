using Dapper;
using Newtonsoft.Json;
using RestSharp;
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
using US_EXCHANGER.Helpers;
using US_EXCHANGER.Models.ConsultaDocIdent.Ruc;
using US_EXCHANGER.Models.Maestros.TablasBasicas;
using US_EXCHANGER.Presentation.UsersControls.MessageBox;

namespace US_EXCHANGER.Presentation.Maestros
{
    public partial class FrmClienteProveedor : FrmPopUpScheme
    {
        #region Atributos
        string _Persona = null;
        #endregion
        public FrmClienteProveedor()
        {
            InitializeComponent();
        }

        public void Inicializacion()
        {
            InicializacionComponentes();
        }
        public void InicializacionComponentes()
        {

            InicializacionComboIdentidad();
            InicializacionComboDepartamento();
            InicializacionComboProvincia();
            InicializacionComboDistrito();

        }

        private void InicializacionComboDepartamento()
        {          
            //Combo Departamento
            cmbUbiDepa.DataSource = LoadDepartamento();
            cmbUbiDepa.DisplayMember = "NOMBRE";
            cmbUbiDepa.ValueMember = "NUMERO";



        }

        private void InicializacionComboProvincia()
        {
            //Combo Provincia
            cmbUbiProvincia.DataSource = LoadProvincia();
            cmbUbiProvincia.DisplayMember = "NOMBRE";
            cmbUbiProvincia.ValueMember = "NUMERO";



        }

        private void InicializacionComboDistrito()
        {
            //Combo Distrito
            cmbUbiDistrito.DataSource = LoadDistrito();
            cmbUbiDistrito.DisplayMember = "NOMBRE";
            cmbUbiDistrito.ValueMember = "NUMERO";



        }
        public List<OPE_DETALLE_TABLADTO> LoadDocuIdentidad()
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
        public List<OPE_DETALLE_TABLADTO> LoadDepartamento()
        {
            List<OPE_DETALLE_TABLADTO> listado1 = null;
            string cnn = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString))

            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                var procedure = "GetDataMaestro";
                DynamicParameters cmd = new DynamicParameters();
                cmd.Add("@CODIGO", "DEPARTAMENTO");
                listado1 = db.Query<OPE_DETALLE_TABLADTO>(procedure, cmd, commandType: System.Data.CommandType.StoredProcedure).ToList();
                db.Dispose();
            }
            return new List<OPE_DETALLE_TABLADTO>(listado1);

        }
        public List<OPE_DETALLE_TABLADTO> LoadProvincia()
        {
            try
            {
                string _Departamento = cmbUbiDepa.SelectedValue.ToString();
                List<OPE_DETALLE_TABLADTO> listado1 = null;
                string cnn = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString))

                // Conexion DB
                {
                    if (!string.IsNullOrEmpty(_Departamento) || !string.IsNullOrWhiteSpace(_Departamento))
                    {
                        if (db.State == ConnectionState.Closed)
                            db.Open();
                        var procedure = "GetDataMaestro_Provincia";
                        DynamicParameters cmd = new DynamicParameters();
                        cmd.Add("@CODIGO", "PROVINCIA");
                        cmd.Add("@CODIGO_DEPA", _Departamento);
                        listado1 = db.Query<OPE_DETALLE_TABLADTO>(procedure, cmd, commandType: System.Data.CommandType.StoredProcedure).ToList();
                        db.Dispose();

                    }
                    else
                    {


                        USMessageBox.Show("Para cargar la provincia por favor ingrese un departamento.......",
                                        "Notificación    ",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }


                }
                return new List<OPE_DETALLE_TABLADTO>(listado1);
            }
            catch (Exception)
            {

                throw;
            }
           

        }
        public List<OPE_DETALLE_TABLADTO> LoadDistrito()
        {
            try
            {
                string _Departamento = cmbUbiDepa.SelectedValue.ToString();
                string _Provincia = cmbUbiProvincia.SelectedValue.ToString();
                List<OPE_DETALLE_TABLADTO> listado1 = null;
                string cnn = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString))

                // Conexion DB
                {
                    if (!string.IsNullOrEmpty(_Departamento) || !string.IsNullOrWhiteSpace(_Departamento))
                    {
                        if (db.State == ConnectionState.Closed)
                            db.Open();
                        DynamicParameters cmd = new DynamicParameters();
                        cmd.Add("@CODIGO", "UBIGEO");
                        cmd.Add("@CODIGO_DEPA", _Departamento);
                        cmd.Add("@CODIGO_PROVINCIA", _Provincia);
                        var procedure = "GetDataMaestro_distrito";
                        listado1 = db.Query<OPE_DETALLE_TABLADTO>(procedure, cmd, commandType: System.Data.CommandType.StoredProcedure).ToList();
                        db.Dispose();

                    }
                    else
                    {


                        USMessageBox.Show("Para cargar el distrito por favor ingrese una provincia.......",
                                        "Notificación    ",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }


                }
                return new List<OPE_DETALLE_TABLADTO>(listado1);
            }
            catch (Exception)
            {

                throw;
            }

        }
        public void InicializacionComboIdentidad()
        {           
            //Combo Documento Identidad
            cmbDocIdent.DataSource = LoadDocuIdentidad();
            cmbDocIdent.DisplayMember = "NOMBRE";
            cmbDocIdent.ValueMember = "NUMERO";


        }
        private void FrmClientesProveedores_Load(object sender, EventArgs e)
        {
            Inicializacion();
        }

        private void metroTextBox9_Click(object sender, EventArgs e)
        {

        }

        private void usButton5_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtDocIdent.Text) || !string.IsNullOrWhiteSpace(txtDocIdent.Text))
            {
                GetRucBean _Ruc = new GetRucBean();
                GetRucDTO _RucResponse = new GetRucDTO();
                var _Doc = txtDocIdent.Text.Trim();
                _Ruc.ruc = _Doc.ToString();
                _Ruc.token = Aplicacion.mConn.tokenGetDocIdent.ToString();
                try
                {
                  var Valid =   Utils.CheckForInternetConnection();
                    if (Valid)
                    {


                        IRestResponse response = Utils.GetRucV2(_Ruc);
                        if (response.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            _RucResponse = JsonConvert.DeserializeObject<GetRucDTO>(response.Content);

                            USMessageBox.Show($"Nombre{_RucResponse.nombre_o_razon_social},  NRuc:{_RucResponse.nombre_o_razon_social}",
                            "Consulta Ruc    ",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {


                    USMessageBox.Show(ex.Message,
"Error-Stop Icon",
MessageBoxButtons.RetryCancel,

MessageBoxIcon.Error);

                    throw;
                }
            }
        }

        private void cmbUbiDepa_SelectedIndexChanged(object sender, EventArgs e)
        {
            InicializacionComboProvincia();
        }

        private void cmbUbiProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            InicializacionComboDistrito();
        }

        private void txtDocIdent_Click(object sender, EventArgs e)
        {

        }

        private void cmbDocIdent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_Click(object sender, EventArgs e)
        {

        }
    }
}
