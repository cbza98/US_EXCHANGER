using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using US_EXCHANGER.connection;
using US_EXCHANGER.Models.Empresa;
using US_EXCHANGER.Models.Login;

namespace US_EXCHANGER
{
    public class Aplicacion
    {
        #region Atributos
        public static Connection mConn;
        #endregion
        public static EmpresaBean oCompañia = null;
        OPE_USUARIOBean oUsuario = null;
        public static CultureInfo oCulture = null;
        public static void IniciarParametros()
        {
            oCulture = new CultureInfo("es-PE");
            oCulture.NumberFormat.NumberDecimalSeparator = ".";
            oCulture.NumberFormat.NumberGroupSeparator = ",";
            oCulture.NumberFormat.CurrencyDecimalSeparator = ".";
            oCulture.NumberFormat.CurrencyGroupSeparator = ",";
            oCulture.NumberFormat.PercentDecimalDigits = 4;
            oCulture.NumberFormat.CurrencyDecimalDigits = 4;
            oCulture.NumberFormat.NumberDecimalDigits = 4;
            System.Threading.Thread.CurrentThread.CurrentCulture = oCulture;
        }
        #region CREACIÓN DE TABLA DE VERSIÓN, VALIDACIÓN Y REGISTRO DE VERSIÓN ACTUAL
        private bool registrarTablaVersion()
        {
            var res = true;
            try
            {
                // Validar si la tabla de versión del AddOn ha sido creada, si no, crearla
                string query = "select \"TableName\" from OUTB where \"TableName\" = '{0}'";
        //        if (!Consultas.consultarSiExiste(string.Format(query, oTablaADDON.nombre)))
         //           res = crearTablaUDT(oTablaADDON);
            }
            catch (Exception ex)
            {
                res = false;
              //  BarraEstado.mostrarError(ex);
            }
            return res;
        }

        private bool esNuevaVersion()
        {
            var res = true;
            try
            {
                string query = "select \"Code\" from \"@{0}\" where \"Code\" = '{1}'";
               // res = !Consultas.consultarSiExiste(string.Format(query, oTablaADDON.nombre, Comunes.mVersionAddOn));
                if (res)
                {
                  //  BarraEstado.mostrarMensaje("Se detectó una nueva versión del AddOn. Se actualizará la estructura de datos...");
                    res = registrarVersion();
                }
            }
            catch (Exception ex)
            {
               // BarraEstado.mostrarError(ex);
            }
            return res;
        }

        private bool registrarVersion()
        {
         //   SAPbobsCOM.UserTable oUT = null;
            var res = true;
            try
            { var a = 1;
                //string version = Comunes.mVersionAddOn;
                //oUT = Aplicacion.SBO_Company.UserTables.Item(oTablaADDON.nombre);
                //oUT.Code = version;
                //oUT.Name = string.Format("{0} V-{1}", oTablaADDON.nombre, version);
                if (a  == 0)
                {

                }
             //       BarraEstado.mostrarMensajeExito("Se ingresó la nueva versión del AddOn.");
                else
                {
                    //var errMsg = string.Format("Error al ingresar la nueva versión ({0}) del AddOn {1}: {2}",
                    //    version, oTablaADDON.nombre, Aplicacion.SBO_Company.GetLastErrorDescription());
                    //res = false;
                    //BarraEstado.mostrarError(errMsg);
                    //Aplicacion.log.Error(errMsg);
                }
            }
            catch (Exception ex)
            {
            //   BarraEstado.mostrarError(ex);
            }
            finally
            {
                //if (oUT != null)
               //     Comunes.LiberarObjetoGenerico(oUT);
            }
            return res;
        }
        #endregion
        public void Obtenerdatosempresa()
        {

        }
        public void Obtenerdatosusuario()
        {

        }
        private static List<EmpresaBean> ExtraerEmpresa()
        {

            List<EmpresaBean> listado1 = null;
            string cnn = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString))

            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                var procedure = "OBTENER_EMPRESA_CAMBIO";
                DynamicParameters cmd = new DynamicParameters();

                listado1 = db.Query<EmpresaBean>(procedure, cmd, commandType: System.Data.CommandType.StoredProcedure).ToList();
                db.Dispose();
            }
            return new List<EmpresaBean>(listado1);

        }
        public static void ObtenerEmpresa()
        {
            List<EmpresaBean> _List = new List<EmpresaBean>();
            _List= ExtraerEmpresa().ToList();
            foreach (var item in _List)
            {
                oCompañia = new EmpresaBean();
                oCompañia.COD_MONEDA_SYS = item.COD_MONEDA_SYS.ToString();
                oCompañia.NOMBRE_MONEDA_SYS = item.NOMBRE_MONEDA_SYS.ToString();
            }
            oCompañia.codi_empr = "0001";

        }
        public static void ObtenerXmlConnection()
        {
            mConn = Connection.Instance;
        }
    }
}
