using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using US_EXCHANGER.Models.Empresa;
using US_EXCHANGER.Models.Login;

namespace US_EXCHANGER
{
    public class Aplicacion
    {

        EmpresaBean oCompañia = null;
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

    }
}
