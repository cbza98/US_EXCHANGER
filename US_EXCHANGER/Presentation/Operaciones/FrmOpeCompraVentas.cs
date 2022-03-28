using Dapper;
using HRA.UTIL;
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
using US_EXCHANGER.Models.Maestros.TablasBasicas;
using US_EXCHANGER.Models.Persona.Entidad;
using US_EXCHANGER.Presentation.Maestros;
using US_EXCHANGER.Presentation.UsersControls.MessageBox;
using static US_EXCHANGER.Models.OperacionCambio.DIVI_OPERACIONBean;
using Microsoft.VisualBasic.CompilerServices;
using System.Runtime.CompilerServices;

namespace US_EXCHANGER.Presentation.Operaciones
{
    public partial class FrmOpeCompraVentas : Form
    {
        _OPERACION objOperacion = null;
        List<OPE_PERSONASDTO2> _Cliente = null;

        public FrmOpeCompraVentas()
        {
            InitializeComponent();
        }
        private void FrmOpeCompraVentas_Load(object sender, EventArgs e)
        {
            InicializacionComponentes();
            CargarGridCambios();
            LoadTaxRate();
        }
        public List<OPE_DETALLE_TABLADTO_OPE_DIVISA> LoadTipoOperacion()
        {
            List<OPE_DETALLE_TABLADTO_OPE_DIVISA> listado1 = null;
            string cnn = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString))

            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                var procedure = "GetTipoOpeDivisas";
                DynamicParameters cmd = new DynamicParameters();
                cmd.Add("@CODIGO", "CDG_TIOP");
                listado1 = db.Query<OPE_DETALLE_TABLADTO_OPE_DIVISA>(procedure, cmd, commandType: System.Data.CommandType.StoredProcedure).ToList();
                db.Dispose();
            }
            return new List<OPE_DETALLE_TABLADTO_OPE_DIVISA>(listado1);

        }
        public List<OPE_DETALLE_TABLADTO> LoadTipoComprobante()
        {
            List<OPE_DETALLE_TABLADTO> listado1 = null;
            string cnn = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString))

            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                var procedure = "GetDataDTabla";
                DynamicParameters cmd = new DynamicParameters();
                cmd.Add("@CODIGO", "TIPO_DOCU");
                listado1 = db.Query<OPE_DETALLE_TABLADTO>(procedure, cmd, commandType: System.Data.CommandType.StoredProcedure).ToList();
                db.Dispose();
            }
            return new List<OPE_DETALLE_TABLADTO>(listado1);

        }
        public List<OPE_DETALLE_TABLADTO> LoadCondPagos()
        {
            List<OPE_DETALLE_TABLADTO> listado1 = null;
            string cnn = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString))

            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                var procedure = "GetDataDTabla";
                DynamicParameters cmd = new DynamicParameters();
                cmd.Add("@CODIGO", "COND_PAGO");
                listado1 = db.Query<OPE_DETALLE_TABLADTO>(procedure, cmd, commandType: System.Data.CommandType.StoredProcedure).ToList();
                db.Dispose();
            }
            return new List<OPE_DETALLE_TABLADTO>(listado1);

        }
        public List<OPE_DETALLE_TABLADTO> LoadDivisas()
        {
            List<OPE_DETALLE_TABLADTO> listado1 = null;
            string cnn = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString))

            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                var procedure = "GetDataDTabla";
                DynamicParameters cmd = new DynamicParameters();
                cmd.Add("@CODIGO", "MONEDA");
                listado1 = db.Query<OPE_DETALLE_TABLADTO>(procedure, cmd, commandType: System.Data.CommandType.StoredProcedure).ToList();
                db.Dispose();
            }
            return new List<OPE_DETALLE_TABLADTO>(listado1);

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
        public void CargarGridCambios()
        {
            string cnn = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString))

            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                SqlCommand comando = new SqlCommand(Properties.Resources.US_SQL_CONSULTATIPOCAMBIO, db);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dtListado.DataSource = tabla;
                db.Dispose();
            }

        }
        public void InicializacionComponentes()
        {

            //Combo Tipo operacion
            cmbTipoOpe.DataSource = LoadTipoOperacion();
            cmbTipoOpe.DisplayMember = "NOMBRE";
            cmbTipoOpe.ValueMember = "REFERENCIA26";
            //Combo Tipo Comprobante
            cmbTipoDocu.DataSource = LoadTipoComprobante();
            cmbTipoDocu.DisplayMember = "NOMBRE";
            cmbTipoDocu.ValueMember = "NUMERO";
            //Combo CondicionPago
            cmbCondPago.DataSource = LoadCondPagos();
            cmbCondPago.DisplayMember = "NOMBRE";
            cmbCondPago.ValueMember = "NUMERO";
            //Combo Divisa de Compra
            CmbMonedaCompra.DataSource = LoadDivisasnotDefault();
            CmbMonedaCompra.DisplayMember = "NOMBRE";
            CmbMonedaCompra.ValueMember = "NUMERO";
            //Combo Divisa de Cambio
            cmbMonedaCambio.DataSource = LoadDivisas();
            cmbMonedaCambio.DisplayMember = "NOMBRE";
            cmbMonedaCambio.ValueMember = "NUMERO";
            //Combo Documento Identidad
            cmbDocuIdenEje.DataSource = LoadDocuIdentidad();
            cmbDocuIdenEje.DisplayMember = "NOMBRE";
            cmbDocuIdenEje.ValueMember = "NUMERO";

            cmbTipodocubenefi.DataSource = LoadDocuIdentidad();
            cmbTipodocubenefi.DisplayMember = "NOMBRE";
            cmbTipodocubenefi.ValueMember = "NUMERO";


        }
        private void metroTextBox2_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTipoCambio.Text))
            {

                var Valuea = Helpers.Utils.Returndecimal(txtTipoCambio.Text);
                txtTipoCambio.Text = Helpers.Utils.Returnstringtodecimalmount(Valuea);
            }

        }
        private void txtCantidadCompra_Validated(object sender, EventArgs e)
        {
            CalcularTaxRate();

        }
        private void txtTipoCambio_Validated(object sender, EventArgs e)
        {
            CalcularTaxRate();
        }
        private void txtimporterecibido_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtimporterecibido.Text))
            {
                var Valuea = Helpers.Utils.Returndecimal(txtimporterecibido.Text);
                txtimporterecibido.Text = Helpers.Utils.Returnstringtodecimalmount(Valuea);
            }

            if (!string.IsNullOrEmpty(txtimporterecibido.Text) && !string.IsNullOrEmpty(txtTotal.Text))
            {
                var Valuea = Helpers.Utils.Returndecimal(txtimporterecibido.Text);
                var Valueb =Helpers.Utils.Returndecimal(txtTotal.Text);
                var Valuec = Helpers.Utils.CalcularDevuelto(Valuea, Valueb);
                txtvueltoaentregar.Text = Helpers.Utils.Returnstringtodecimalmount(Valuec);
            }

        }
        private void cmbTipoOpe_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (cmbTipoOpe.SelectedValue)
            {
                case "VE":
                    txtimporterecibido.Visible = true;
                    txtvueltoaentregar.Visible = true;
                    lblimporterecibido.Visible = true;
                    lblvueltoaentregar.Visible = true;
                    lblDescripOpe.Text = "El cliente debe entregar";
                    LoadTaxRate();
                    CalcularTaxRate();

                    break;
                case "CO":
                    txtimporterecibido.Visible = false;
                    txtvueltoaentregar.Visible = false;
                    lblimporterecibido.Visible = false;
                    lblvueltoaentregar.Visible = false;
                    lblDescripOpe.Text = "El cliente debe recibir";
                    LoadTaxRate();
                    CalcularTaxRate();
                    break;
                default:
                    break;
            }
        }
        private void chckMpersona_CheckedChanged(object sender, EventArgs e)
        {

            switch (chckMpersona.Checked)
            {
                case true:
                    txtNombreBenefi.Enabled = false;
                    txtRucBenefi.Enabled = false;
                    cmbTipodocubenefi.Enabled = false;
                    txtDirecBene.Enabled = false;
                    break;
                case false:
                    txtNombreBenefi.Enabled = true;
                    txtRucBenefi.Enabled = true;
                    cmbTipodocubenefi.Enabled = true;
                    txtDirecBene.Enabled = true;
                    break;

                default:
                    break;
            }
        }
        private void RegistarOperacion()
        {
            try
            {
                _OPERACION objOperacion = new _OPERACION();
                objOperacion.cod_empresa = "0001";
                objOperacion.cod_moneda = CmbMonedaCompra.SelectedValue.ToString();
                objOperacion.cod_moneda_cambio = cmbMonedaCambio.SelectedValue.ToString();
                objOperacion.estado = "1";
                objOperacion.fecha = DateTime.Now.ToUniversalTime();
                objOperacion.fecha_operacion = DateTime.Now.ToUniversalTime();
                objOperacion.monto = HRA.UTIL.dbUtility.NullToZero(txtTotal.Text);
                objOperacion.cod_tipo_cambio = 0;
                objOperacion.monto_tipo_cambio = HRA.UTIL.dbUtility.NullToZero(txtTipoCambio.Text);
                objOperacion.cod_detalle_corte = 0;
                objOperacion.cot_cierre = 0.0;
                objOperacion.cot_apertura = 0.0;
                objOperacion.porc_descuento = 0.0;
                objOperacion.impor_descuento = 0.0;
                objOperacion.cod_ejecutante = null;
                objOperacion.cod_documento_ejecutante = HRA.UTIL.dbUtility.NullToString(cmbDocuIdenEje.SelectedValue.ToString());
                objOperacion.num_documento_ejecutante = HRA.UTIL.dbUtility.NullToString(txtDocuEje.Text);
                objOperacion.nombre_ejecutante = HRA.UTIL.dbUtility.NullToString((object)txtNombreEje.Text);
                objOperacion.direccion_ejecutante = HRA.UTIL.dbUtility.NullToString((object)txtDireEje.Text);
                objOperacion.cod_beneficiario = null;
                if (this.chckMpersona.Checked)
                {
                    //this.btnEjecutante.Checked = true;
                    objOperacion.cod_documento_beneficiario = HRA.UTIL.dbUtility.NullToString(cmbDocuIdenEje.SelectedValue.ToString());
                    objOperacion.num_documento_beneficiario = HRA.UTIL.dbUtility.NullToString(txtDocuEje.Text);
                    objOperacion.nombre_beneficiario = HRA.UTIL.dbUtility.NullToString((object)txtNombreEje.Text);
                    objOperacion.direccion_beneficiario = HRA.UTIL.dbUtility.NullToString((object)txtDireEje.Text);
                }
                else
                {
                    //this.btnBeneficiario.Checked = true;
                    objOperacion.cod_documento_beneficiario = HRA.UTIL.dbUtility.NullToString(cmbTipodocubenefi.SelectedValue.ToString());
                    objOperacion.num_documento_beneficiario = HRA.UTIL.dbUtility.NullToString(txtRucBenefi.Text);
                    objOperacion.nombre_beneficiario = HRA.UTIL.dbUtility.NullToString((object)txtNombreBenefi.Text);
                    objOperacion.direccion_beneficiario = HRA.UTIL.dbUtility.NullToString((object)txtDirecBene.Text);
                }
                objOperacion.cod_forma_pago = HRA.UTIL.dbUtility.NullToString(cmbCondPago.SelectedValue);

                objOperacion.cod_documento_operacion = HRA.UTIL.dbUtility.NullToString(cmbComprobante.SelectedValue);
                objOperacion.num_documento_operacion = "0";
                objOperacion.importe_entregado = HRA.UTIL.dbUtility.NullToZero(txtimporterecibido.Text);
                objOperacion.vuelto = HRA.UTIL.dbUtility.NullToZero(txtvueltoaentregar.Text);

                RegistrarCompraVenta(objOperacion);
            }
            catch (Exception ex)
            {
                //  ProjectData.SetProjectError(ex);
                throw ex;
            }
        }
        private List<OPE_PERSONASDTO2> ObtenerClientebyID(string _ID)
        {

            List<OPE_PERSONASDTO2> listado1 = null;
            string cnn = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString))

            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                var procedure = "OPESS_OBTENER_PERSONA_CAMBIOBYID";
                DynamicParameters cmd = new DynamicParameters();
                cmd.Add("@TIPO", EnumTipoPersona.CLIENTE);
                cmd.Add("@CODIGO", _ID);
                listado1 = db.Query<OPE_PERSONASDTO2>(procedure, cmd, commandType: System.Data.CommandType.StoredProcedure).ToList();
                db.Dispose();
            }
            return new List<OPE_PERSONASDTO2>(listado1);

        }
        private void RegistrarCompraVenta(_OPERACION objDev)
        {
            using (IDbConnection cnn = (IDbConnection)new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString))
            {
                cnn.Open();
                using (SqlTransaction sqlTransaction = (SqlTransaction)cnn.BeginTransaction())
                {
                    try
                    {
                        DynamicParameters dynamicParameters1 = new DynamicParameters();
                        dynamicParameters1.Add("@COD_COMPAÑIA", (object)objDev.cod_empresa);
                        dynamicParameters1.Add("@COD_USER", (object)objDev.cod_usuario);
                        dynamicParameters1.Add("@COD_MONEDA", (object)objDev.cod_moneda);
                        dynamicParameters1.Add("@ESTADO", (object)objDev.estado);
                        dynamicParameters1.Add("@TIPO", (object)objDev.tipo);
                        dynamicParameters1.Add("@CREATEDATE", (object)objDev.fecha);
                        dynamicParameters1.Add("@MONTO", (object)objDev.monto);
                        dynamicParameters1.Add("@COD_TIPO_CAMBIO", (object)objDev.cod_moneda_cambio);
                        dynamicParameters1.Add("@MONTO_TIPO_CAMBIO", (object)objDev.monto_tipo_cambio);
                        dynamicParameters1.Add("@COD_EJECUTANTE", (object)objDev.cod_ejecutante);
                        dynamicParameters1.Add("@COD_BENEFICIARIO", (object)objDev.cod_beneficiario);
                        dynamicParameters1.Add("@COD_FORMA_PAGO", (object)objDev.cod_forma_pago);
                        dynamicParameters1.Add("@COD_DOCUMENTO", (object)objDev.cod_documento_operacion);
                        dynamicParameters1.Add("@FECHA_OPERACION", (object)objDev.fecha_operacion);
                        dynamicParameters1.Add("@IMPORTE_ENTREGADO", (object)objDev.importe_entregado);
                        dynamicParameters1.Add("@IMPORTE_VUELTO", (object)objDev.vuelto);
                        dynamicParameters1.Add("@declaracion_jurada", (object)objDev.flag_declaracion_jurada);
                        dynamicParameters1.Add("@COD_MONEDA_CAMBIO", (object)objDev.cod_moneda_cambio);
                        dynamicParameters1.Add("@NOMBRE_EJECUTANTE", (object)objDev.nombre_ejecutante);
                        dynamicParameters1.Add("@NOMBRE_BENEFICIARIO", (object)objDev.nombre_beneficiario);
                        dynamicParameters1.Add("@TIPODOCU_EJECUTANTE", (object)objDev.cod_documento_ejecutante);
                        dynamicParameters1.Add("@TIPODOCU_BENEFICIARIO", (object)objDev.cod_documento_ejecutante);

                        int num = cnn.ExecuteScalar<int>("DIVI_INSERTOPERACION", (object)dynamicParameters1, (IDbTransaction)sqlTransaction, commandType: new CommandType?(CommandType.StoredProcedure));
                        sqlTransaction.Commit();

                        USMessageBox.Show($"Registro Exitoso...... Nro de Operacion:{num}",
                                               "Notificación    ",
                                               MessageBoxButtons.OK,
                                               MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        sqlTransaction.Rollback();

                        USMessageBox.Show($"Ha Ocurrido un Error: {ex.Message}",
                                             "Notificación Error    ",
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Error);
                        throw;
                    }
                }
            }
        }
        private void usButton1_Click(object sender, EventArgs e)
        {
            RegistarOperacion();
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            FrmListadoClientesProveedores _FrmClientes = new FrmListadoClientesProveedores(EnumTipoPersona.CLIENTE);
            _FrmClientes.Hijo = true;
            DialogResult _Persona = _FrmClientes.ShowDialog();
            if (_Persona == DialogResult.OK)
            {

                string resultado = _FrmClientes.Docu;
                _Cliente = ObtenerClientebyID(resultado);
                foreach (var item in _Cliente)
                {
                    txtDocuEje.Text = item.Documento;
                    txtNombreEje.Text = item.Nombre;
                    cmbDocuIdenEje.SelectedValue = item.TIPO_DOCUMENTO;
                    txtDireEje.Text = item.Direccion;
                }
            }
        }
        private void iconButton2_Click(object sender, EventArgs e)
        {
            FrmListadoClientesProveedores _FrmClientes = new FrmListadoClientesProveedores(EnumTipoPersona.CLIENTE);
            _FrmClientes.Hijo = true;
            DialogResult _Persona = _FrmClientes.ShowDialog();
            if (_Persona == DialogResult.OK)
            {

                string resultado = _FrmClientes.Docu;
                _Cliente = ObtenerClientebyID(resultado);
                foreach (var item in _Cliente)
                {
                    txtRucBenefi.Text = item.Documento;
                    txtNombreBenefi.Text = item.Nombre;
                    cmbTipodocubenefi.SelectedValue = item.TIPO_DOCUMENTO;
                    txtDireEje.Text = item.Direccion;
                }
            }
        }
        private void usButton1_Click_1(object sender, EventArgs e)
        {
            RegistarOperacion();
        }
        private void usButton2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void chckMpersona_CheckedChanged_1(object sender, EventArgs e)
        {
            switch (chckMpersona.Checked)
            {
                case true:
                    txtNombreBenefi.Enabled = false;
                    txtRucBenefi.Enabled = false;
                    cmbTipodocubenefi.Enabled = false;
                    txtDirecBene.Enabled = false;
                    iconButton2.Enabled = false;
                    break;
                case false:
                    txtNombreBenefi.Enabled = true;
                    txtRucBenefi.Enabled = true;
                    cmbTipodocubenefi.Enabled = true;
                    txtDirecBene.Enabled = true;
                    iconButton2.Enabled = true;
                    break;

                default:
                    break;
            }
        }
        //private void mostrarTipoCambio()
        //{
        //    try
        //    {
        //        int num1 = checked(dtListado.Rows.Count - 1);
        //        int index1 = 0;
        //        while (index1 <= num1)
        //        {
        //            if (dtListado.Rows[index1].Cells["Simbolo"].Value, HRA.UTIL.dbUtility.NullToString(dtMoneda.Rows[cmbMonedaCambio.SelectedIndex]["Numero"])), false))
        //            {
        //                if (dbUtility.NullToBool(RuntimeHelpers.GetObjectValue(this.dtMonedaTipoCambio.Rows[this.cboTipoCambio.SelectedIndex]["flag_default"])))
        //                {
        //                    if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.cboTipoOperacion.SelectedItem, (object)"COMPRA", false))
        //                    {
        //                        this.txtTipoCambio.Value = new Decimal(Conversions.ToDouble(this.dgvTipoCambio.Rows[index1].Cells["p_compra"].Value));
        //                        break;
        //                    }
        //                    if (cboTipoOperacion.SelectedItem, (object)"VENTA", false))
        //                    {
        //                        this.txtTipoCambio.Value = new Decimal(Conversions.ToDouble(this.dgvTipoCambio.Rows[index1].Cells["p_venta"].Value));
        //                        break;
        //                    }
        //                }
        //                else
        //                {
        //                    string Right = dbUtility.NullToString(RuntimeHelpers.GetObjectValue(this.dtMonedaTipoCambio.Rows[this.cboTipoCambio.SelectedIndex]["cod_moneda"]));
        //                    double zero1 = dbUtility.NullToZero(RuntimeHelpers.GetObjectValue(this.dgvTipoCambio.Rows[index1].Cells["p_compra"].Value));
        //                    double zero2 = dbUtility.NullToZero(RuntimeHelpers.GetObjectValue(this.dgvTipoCambio.Rows[index1].Cells["p_venta"].Value));
        //                    double num2 = 1.0;
        //                    double num3 = 1.0;
        //                    int num4 = checked(this.dgvTipoCambio.Rows.Count - 1);
        //                    int index2 = 0;
        //                    while (index2 <= num4)
        //                    {
        //                        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.dgvTipoCambio.Rows[index2].Cells["cod_moneda"].Value, (object)Right, false))
        //                        {
        //                            num2 = dbUtility.NullToZero(Monitor.Rows[index2].Cells["p_compra"].Value));
        //                            num3 = dbUtility.NullToZero(RuntimeHelpers.GetObjectValue(this.dgvTipoCambio.Rows[index2].Cells["p_venta"].Value));
        //                            break;
        //                        }
        //                        checked { ++index2; }
        //                    }
        //                    if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.cboTipoOperacion.SelectedItem, (object)"COMPRA", false))
        //                        this.txtTipoCambio.Value = zero1 < num2 ? new Decimal(num2 / zero1) : new Decimal(zero1 / num2);
        //                    if (!Operators.ConditionalCompareObjectEqual(this.cboTipoOperacion.SelectedItem, (object)"VENTA", false))
        //                        break;
        //                    if (zero2 >= num3)
        //                    {
        //                        this.txtTipoCambio.Value = new Decimal(zero2 / num3);
        //                        break;
        //                    }
        //                    this.txtTipoCambio.Value = new Decimal(num3 / zero2);
        //                    break;
        //                }
        //            }
        //            checked { ++index1; }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //ProjectData.SetProjectError(ex);
        //        throw ex;
        //    }
        //}
        private void LoadTaxRate()
        {
                try
                {
                    int num = dtListado.Rows.Count - 1;
                    for (int index = 0; index <= num; index++)
                    {
                        if (dtListado.Rows[index].Cells["Numero"].Value == dbUtility.NullToString(cmbMonedaCambio.SelectedValue))
                        {
                            continue;
                        }
                        if (Aplicacion.oCompañia.COD_MONEDA_SYS == cmbMonedaCambio.SelectedValue)
                        {
                            if (Operators.ConditionalCompareObjectEqual(cmbTipoOpe.SelectedValue, "CO", false))
                            {
                                txtTipoCambio.Text = Double.Parse(dtListado.Rows[index].Cells["Compra"].Value.ToString(), Aplicacion.oCulture).ToString();
                                break;
                            }
                            if (Operators.ConditionalCompareObjectEqual(cmbTipoOpe.SelectedValue, "VE", false))
                            {
                                txtTipoCambio.Text = txtTipoCambio.Text = Double.Parse(dtListado.Rows[index].Cells["Venta"].Value.ToString(), Aplicacion.oCulture).ToString();
                                break;
                            }
                            continue;
                        }
                        string cod_moneda_tipo_cambio = dbUtility.NullToString(cmbMonedaCambio.SelectedValue);
                        string cod_moneda_tipo_compra = dbUtility.NullToString(CmbMonedaCompra.SelectedValue);
                        double precio_compra_cantidad = dbUtility.NullToZero(RuntimeHelpers.GetObjectValue(dtListado.Rows[index].Cells["Compra"].Value));
                        double precio_venta_cantidad = dbUtility.NullToZero(RuntimeHelpers.GetObjectValue(dtListado.Rows[index].Cells["Venta"].Value));
                        double precio_compra_tc = 1.0;
                        double precio_venta_tc = 1.0;
                        int num2 = dtListado.Rows.Count - 1;
                        int num3 = dtListado.Rows.Count - 1;
                        // Calculo Tipo de Cambio cuando Moneda sea distinta a la del SYS
                        for (int index2 = 0; index2 <= num2; index2++)
                        {
                            if (Operators.ConditionalCompareObjectEqual(dtListado.Rows[index2].Cells["Numero"].Value.ToString(), cod_moneda_tipo_cambio, false))
                            {
                                precio_compra_tc = dbUtility.NullToZero(RuntimeHelpers.GetObjectValue(dtListado.Rows[index2].Cells["Compra"].Value.ToString()));
                                precio_venta_tc = dbUtility.NullToZero(RuntimeHelpers.GetObjectValue(dtListado.Rows[index2].Cells["Venta"].Value.ToString()));
                                break;
                            }
                        }
                        for (int index3 = 0; index3 <= num3; index3++)
                        {
                            if (Operators.ConditionalCompareObjectEqual(dtListado.Rows[index3].Cells["Numero"].Value.ToString(), cod_moneda_tipo_compra, false))
                            {
                                precio_compra_cantidad = dbUtility.NullToZero(RuntimeHelpers.GetObjectValue(dtListado.Rows[index3].Cells["Compra"].Value.ToString()));
                                precio_venta_cantidad = dbUtility.NullToZero(RuntimeHelpers.GetObjectValue(dtListado.Rows[index3].Cells["Venta"].Value.ToString()));
                                break;
                            }
                        }
                        // Calculo Segun Operacion
                        if (Operators.ConditionalCompareObjectEqual(cmbTipoOpe.SelectedValue, "CO", false))
                        {
                            if (precio_compra_cantidad >= precio_compra_tc)
                            {
                                txtTipoCambio.Text = new decimal(precio_compra_cantidad / precio_compra_tc).ToString();
                            }
                            else
                            {
                                txtTipoCambio.Text = new decimal(precio_compra_tc / precio_compra_cantidad).ToString();
                            }
                        }
                        if (Operators.ConditionalCompareObjectEqual(cmbTipoOpe.SelectedValue, "VE", false))
                        {
                            if (precio_venta_cantidad >= precio_venta_tc)
                            {
                                txtTipoCambio.Text = new decimal(precio_venta_cantidad / precio_venta_tc).ToString();
                            }
                            else
                            {
                                txtTipoCambio.Text = new decimal(precio_venta_tc / precio_venta_cantidad).ToString();
                            }
                        }
                        break;
                    }
                }
                catch (Exception ex2)
                {
                    ProjectData.SetProjectError(ex2);
                    Exception ex = ex2;
                    throw ex;
                }
        }

        private void CmbMonedaCompra_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadTaxRate();
        }

        private void cmbMonedaCambio_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadTaxRate();
        }


        private void CalcularTaxRate()
        {
            if (!string.IsNullOrEmpty(txtCantidadCompra.Text))
            {
                var Valuea = Helpers.Utils.Returndecimal(txtCantidadCompra.Text);
                txtCantidadCompra.Text = Helpers.Utils.Returnstringtodecimalmount(Valuea);
            }
            if (!string.IsNullOrEmpty(txtTipoCambio.Text) && !string.IsNullOrEmpty(txtCantidadCompra.Text))
            {
                var Valuea = Helpers.Utils.Returndecimal(txtTipoCambio.Text);
                var Valueb = Helpers.Utils.Returndecimal(txtCantidadCompra.Text);
                var Valuec = Helpers.Utils.CalcularCambio(Valuea, Valueb);
                txtTipoCambio.Text = Helpers.Utils.Returnstringtodecimalmount(Valuea);
                txtTotal.Text = Helpers.Utils.Returnstringtodecimalmount(Valuec);
            }
        }

        private void txtTipoCambio_TextChanged(object sender, EventArgs e)
        {
            CalcularTaxRate();
        }
    }
}
