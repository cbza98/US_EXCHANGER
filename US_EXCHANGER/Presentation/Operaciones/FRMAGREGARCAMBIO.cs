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
using static US_EXCHANGER.Models.OperacionCambio.DIVI_OPERACIONBean;

namespace US_EXCHANGER.Presentation.Operaciones
{
    public partial class FRMAGREGARCAMBIO : FrmPopUpScheme
    {
        public FRMAGREGARCAMBIO()
        {
            InitializeComponent();
        }
        public void Inicializacion()
        {
            //Combo Divisa de Compra
            CmbMonedaCompra.DataSource = LoadDivisasnotDefault();
            CmbMonedaCompra.DisplayMember = "NOMBRE";
            CmbMonedaCompra.ValueMember = "NUMERO";



            CmbMonedaConsulta.DataSource = LoadDivisasnotDefault();
            CmbMonedaConsulta.DisplayMember = "NOMBRE";
            CmbMonedaConsulta.ValueMember = "NUMERO";
        }
        public List<OPE_DETALLE_TABLADTO> LoadDivisasnotDefault()
        {
            List<OPE_DETALLE_TABLADTO> listado1 = null;
            string cnn = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString))

            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                var procedure = "GetMonedasCambio";
                DynamicParameters cmd = new DynamicParameters();
                cmd.Add("@CODIGO", "MONEDA");
                listado1 = db.Query<OPE_DETALLE_TABLADTO>(procedure, cmd, commandType: System.Data.CommandType.StoredProcedure).ToList();
                db.Dispose();
            }
            return new List<OPE_DETALLE_TABLADTO>(listado1);

        }
        public void CargarGridCambios()
        {
            DataSet objDataSet = new DataSet();
            SqlConnection objConn = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);

            SqlCommand objComm = new SqlCommand(Properties.Resources.US_SQL_CONSULTATIPOCAMBIO, objConn);

            SqlDataAdapter objDataAdapter = new SqlDataAdapter(objComm);

            if (objConn.State == ConnectionState.Closed)
            {
                objConn.Open();
            }

            objDataAdapter.Fill(objDataSet);
            dtListado.DataSource = objDataSet;
            objConn.Dispose();

        }
        private void FRMAGREGARCAMBIO_Load(object sender, EventArgs e)
        {
            Inicializacion();
            CargarGridCambios();
        }
        //private void RegistarOperacion()
        //{
        //    try
        //    {
        //        _TIPO_CAMBIO objOperacion = new _TIPO_CAMBIO();
        //        objOperacion.cod_empresa = "0001";
        //        objOperacion.cod_moneda = CmbMonedaCompra.SelectedValue.ToString();
        //        objOperacion.cod_moneda_cambio = cmbMonedaCambio.SelectedValue.ToString();
        //        objOperacion.estado = "1";
        //        objOperacion.fecha = DateTime.Now.ToUniversalTime();
        //        objOperacion.fecha_operacion = DateTime.Now.ToUniversalTime();
        //        objOperacion.monto = HRA.UTIL.dbUtility.NullToZero(txtTotal.Text);
        //        objOperacion.cod_tipo_cambio = 0;
        //        objOperacion.monto_tipo_cambio = HRA.UTIL.dbUtility.NullToZero(txtTipoCambio.Text);
        //        objOperacion.cod_detalle_corte = 0;
        //        objOperacion.cot_cierre = 0.0;
        //        objOperacion.cot_apertura = 0.0;
        //        objOperacion.porc_descuento = 0.0;
        //        objOperacion.impor_descuento = 0.0;
        //        objOperacion.cod_ejecutante = null;
        //        objOperacion.cod_documento_ejecutante = HRA.UTIL.dbUtility.NullToString(cmbDocuIdenEje.SelectedValue.ToString());
        //        objOperacion.num_documento_ejecutante = HRA.UTIL.dbUtility.NullToString(txtDocuEje.Text);
        //        objOperacion.nombre_ejecutante = HRA.UTIL.dbUtility.NullToString((object)txtNombreEje.Text);
        //        objOperacion.direccion_ejecutante = HRA.UTIL.dbUtility.NullToString((object)cmbDireccionEje.SelectedValue);
        //        objOperacion.cod_beneficiario = null;
        //        if (this.chckMpersona.Checked)
        //        {
        //            //this.btnEjecutante.Checked = true;
        //            objOperacion.cod_documento_beneficiario = HRA.UTIL.dbUtility.NullToString(cmbDocuIdenEje.SelectedValue.ToString());
        //            objOperacion.num_documento_beneficiario = HRA.UTIL.dbUtility.NullToString(txtDocuEje.Text);
        //            objOperacion.nombre_beneficiario = HRA.UTIL.dbUtility.NullToString((object)txtNombreEje.Text);
        //            objOperacion.direccion_beneficiario = HRA.UTIL.dbUtility.NullToString((object)cmbDireccionEje.SelectedValue);
        //        }
        //        else
        //        {
        //            //this.btnBeneficiario.Checked = true;
        //            objOperacion.cod_documento_beneficiario = HRA.UTIL.dbUtility.NullToString(cmbTipodocubenefi.SelectedValue.ToString());
        //            objOperacion.num_documento_beneficiario = HRA.UTIL.dbUtility.NullToString(txtRucBenefi.Text);
        //            objOperacion.nombre_beneficiario = HRA.UTIL.dbUtility.NullToString((object)txtNombreBenefi.Text);
        //            objOperacion.direccion_beneficiario = HRA.UTIL.dbUtility.NullToString((object)cmbDireccionbenefi.SelectedValue);
        //        }
        //        objOperacion.cod_forma_pago = HRA.UTIL.dbUtility.NullToString(cmbCondPago.SelectedValue);

        //        objOperacion.cod_documento_operacion = HRA.UTIL.dbUtility.NullToString(cmbComprobante.SelectedValue);
        //        objOperacion.num_documento_operacion = "0";
        //        objOperacion.importe_entregado = HRA.UTIL.dbUtility.NullToZero(txtimporterecibido.Text);
        //        objOperacion.vuelto = HRA.UTIL.dbUtility.NullToZero(txtvueltoaentregar.Text);

        //        RegistrarCompraVenta(objOperacion);
        //    }
        //    catch (Exception ex)
        //    {
        //        //  ProjectData.SetProjectError(ex);
        //        throw ex;
        //    }
        //}
        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
