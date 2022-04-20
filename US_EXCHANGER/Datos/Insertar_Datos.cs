using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using US_EXCHANGER.Presentation.UsersControls.MessageBox;
using static US_EXCHANGER.Models.OperacionCambio.DIVI_OPERACIONBean;

namespace US_EXCHANGER.Datos
{
    public class Insertar_Datos
    {
        // DIVISAS TIPO DE CAMBIO
        public static bool INSERTAR_TIPOCAMBIO_OPE(_TIPO_CAMBIODTO objDev)
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
                        dynamicParameters1.Add("@COD_TIPO_CAMBIO", (object)objDev.tipo_cambio_operativa);
                        int num = cnn.ExecuteScalar<int>("INSERT_TIPO_CAMBIO_DIVISA", (object)dynamicParameters1, (IDbTransaction)sqlTransaction, commandType: new CommandType?(CommandType.StoredProcedure));
                        sqlTransaction.Commit();




                        USMessageBox.Show($"Registro Exitoso......",
                                               "Notificación    ",
                                               MessageBoxButtons.OK,
                                               MessageBoxIcon.Information);
                        return true;
                    }
                    catch (Exception ex)
                    {
                        USMessageBox.Show($"Ha Ocurrido un Error: {ex.Message}",
                                             "Notificación Error    ",
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Error);
                        
                        sqlTransaction.Rollback();
                    
                        cnn.Dispose();
                        return false;
                        //throw;
                    }
                }
            }
        }
        // CAJA CHICA
        // COMPRA VENTA DIVISA
        public static void RegistrarCompraVenta(_OPERACION objDev)
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
        // MAESTROS SOCIOS DE NEGOCIOS
        // MAESTROS TABLAS BASICAS
    }
}
