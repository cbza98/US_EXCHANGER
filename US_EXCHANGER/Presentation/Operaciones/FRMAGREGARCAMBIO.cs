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
using US_EXCHANGER.Models.OperacionCambio;
using US_EXCHANGER.Presentation.UsersControls.MessageBox;
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
        private List<_TIPO_CAMBIO_DTO> _ListCambio()
        {
            List<_TIPO_CAMBIO_DTO> listado1 = null;
            string cnn = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString))

            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                var procedure = "LISTARCAMBIOS";
                DynamicParameters cmd = new DynamicParameters();
                listado1 = db.Query<_TIPO_CAMBIO_DTO>(procedure, cmd, commandType: System.Data.CommandType.StoredProcedure).ToList();
                db.Dispose();
            }
            return new List<_TIPO_CAMBIO_DTO>(listado1);
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
                dtListado.AutoSize = true;
                db.Dispose();
            }

            }
        public void CargarGridCambios(string Fechadesde, string Fechahasta, string Divisa)
        {
            using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                string _query1 = Properties.Resources.US_SQL_CONSULTATIPOCAMBIOPARAMETROS.Replace("[US_FECHA_DESDE]", dtFechadesde.Value.ToString("yyyy-MM-dd"));
                string _query2 = _query1.Replace("[US_FECHA_HASTA]", dtFechahasta.Value.ToString("yyyy-MM-dd"));
                string _query3 = _query2.Replace("[US_COD_MONEDA]", CmbMonedaConsulta.SelectedValue.ToString());
                SqlCommand comando = new SqlCommand(_query2, db);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dtListado.DataSource = tabla;
                db.Dispose();
            }
        }
        public void CargarGridCambios(string Fechadesde, string Fechahasta)
        {
            using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString))

            {
                if (db.State == ConnectionState.Closed)
                db.Open();
                string _query1 = Properties.Resources.US_SQL_CONSULTATIPOCAMBIOPARAMETROSSD.Replace("[US_FECHA_DESDE]", dtFechadesde.Value.ToString("yyyy-MM-dd"));
                string _query2 = _query1.Replace("[US_FECHA_HASTA]", dtFechahasta.Value.ToString("yyyy-MM-dd"));
                SqlCommand comando = new SqlCommand(_query2, db);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dtListado.DataSource = tabla;
                db.Dispose();
            }
        }
        private void FRMAGREGARCAMBIO_Load(object sender, EventArgs e)
        {
            Inicializacion();
            CargarGridCambios();
            dtFecha.Value = DateTime.UtcNow;
        }
        private void RegistarOperacion()
        {
            try
            {
                


                if (string.IsNullOrEmpty(txtPrecioCompra.Text.ToString()) || string.IsNullOrEmpty(txtPrecioVenta.Text.ToString()) || string.IsNullOrWhiteSpace(txtPrecioCompra.Text.ToString()) || string.IsNullOrWhiteSpace(txtPrecioVenta.Text.ToString()))
                {
                    USMessageBox.Show("Ingrese valores válidos en precio compra y venta........",
                                      "Notificación    ",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Error);
                }
                
                else if(!Helpers.Utils.IsValidDecimal(txtPrecioCompra.Text.ToString()) || !Helpers.Utils.IsValidDecimal(txtPrecioVenta.Text.ToString()))
                {
                    USMessageBox.Show("Ingrese valores válidos en precio compra y venta........",
                  "Notificación    ",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);

                }

                else
                {


                    decimal PrecioCompra = decimal.Parse(HRA.UTIL.dbUtility.NullToString(txtPrecioCompra.Text.ToString().Trim()), Aplicacion.oCulture);
                    decimal PrecioVenta = decimal.Parse(HRA.UTIL.dbUtility.NullToString(txtPrecioVenta.Text.ToString().Trim()), Aplicacion.oCulture);
                    if (this.CmbMonedaCompra.Items.Count == 0)

                        USMessageBox.Show("Ingrese moneda en configuración.......",
                                        "Notificación    ",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);

                    else if (Decimal.Compare(PrecioCompra, 0M) == 0 | Decimal.Compare(PrecioVenta, 0M) == 0)

                        USMessageBox.Show("Ingrese valores válidos en precio compra y venta........",
                                          "Notificación    ",
                                          MessageBoxButtons.OK,
                                          MessageBoxIcon.Error);



                    else if (Decimal.Compare(PrecioCompra, PrecioVenta) >= 0)
                    {

                        USMessageBox.Show("Precio de Venta tiene que ser mayor a compra.........",
                                      "Notificación    ",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Error);


                    }
                    else
                    {                //Set Object 
                        _TIPO_CAMBIODTO objTipoCambio = new _TIPO_CAMBIODTO();

                        objTipoCambio.cod_moneda = HRA.UTIL.dbUtility.NullToString(CmbMonedaCompra.SelectedValue.ToString());
                        objTipoCambio.p_compra = PrecioCompra;
                        objTipoCambio.p_venta = PrecioVenta;
                        objTipoCambio.fecha = dtFecha.Value.Date;
                        objTipoCambio.cod_usuario = Aplicacion.oCompañia.usua_crea;
                        objTipoCambio.cod_moneda_default = Aplicacion.oCompañia.COD_MONEDA_SYS;
                        objTipoCambio.cod_empresa = "0001";
                        GuardarTipoCambio(objTipoCambio);

                    }
                }

            }
            catch (Exception ex)
            {
                //  ProjectData.SetProjectError(ex);
                throw ex;
            }
        }
        private void GuardarTipoCambio(_TIPO_CAMBIODTO objDev)
        {
            var Result = USMessageBox.Show("Desea agregar un nuevo tipo de cambio al sistema?......",
                    "Advertencia Unosoft    ",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Exclamation);

            if (Result == DialogResult.Yes)
            {
                using (IDbConnection cnn = (IDbConnection)new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString))
                {
                    cnn.Open();
                    using (SqlTransaction sqlTransaction = (SqlTransaction)cnn.BeginTransaction())
                    {
                        try
                        {
                            DynamicParameters dynamicParameters1 = new DynamicParameters();
                            dynamicParameters1.Add("@COD_MONEDA_CAMBIO", (object)objDev.cod_moneda);
                            dynamicParameters1.Add("@COD_MONEDA_SYS", (object)objDev.cod_moneda_default);
                            dynamicParameters1.Add("@CREATEDATE", (object)objDev.fecha);
                            dynamicParameters1.Add("@PRECIO_COMPRA", (object)objDev.p_compra);
                            dynamicParameters1.Add("@PRECIO_VENTA", (object)objDev.p_venta);
                            dynamicParameters1.Add("@COD_USER", (object)objDev.cod_usuario);
                            dynamicParameters1.Add("@COD_COMPAÑIA", (object)objDev.cod_empresa);

                            int num = cnn.ExecuteScalar<int>("INSERT_TIPO_CAMBIO_DIVISA", (object)dynamicParameters1, (IDbTransaction)sqlTransaction, commandType: new CommandType?(CommandType.StoredProcedure));
                            sqlTransaction.Commit();

                            USMessageBox.Show($"Registro Exitoso......",
                                                   "Notificación    ",
                                                   MessageBoxButtons.OK,
                                                   MessageBoxIcon.Information);
                            CargarGridCambios();
                        }
                        catch (Exception ex)
                        {
                            sqlTransaction.Rollback();

                            USMessageBox.Show($"Ha Ocurrido un Error: {ex.Message}",
                                                 "Notificación Error    ",
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
                            cnn.Dispose();
                            throw;
                        }
                    }
                }
            }
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
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            RegistarOperacion();
        }
    }
}
