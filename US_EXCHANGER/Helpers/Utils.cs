using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using US_EXCHANGER.Models.ConsultaDocIdent.Ruc;
using US_EXCHANGER.Presentation.UsersControls.MessageBox;

namespace US_EXCHANGER.Helpers
{
    public static class Utils
    {
        public static decimal Returndecimal(string value)
        {
            decimal valuea = 0;
            valuea = decimal.Parse(value, Aplicacion.oCulture.NumberFormat);
            return valuea;
        }
        public static string Returnstringtodecimalmount(decimal _Value)
        {
            string valuea = string.Empty;
            valuea = _Value.ToString($"N{ Aplicacion.oCulture.NumberFormat.CurrencyDecimalDigits}", Aplicacion.oCulture);
            return valuea;
        }
        public static decimal CalcularCambio(decimal Valor, decimal TipoCambio)
        {
            decimal valorFinal = Valor * TipoCambio;
            return valorFinal;
        }
        public static decimal CalcularDevuelto(decimal Valorbase, decimal ValorTotal)
        {
            decimal valorFinal = Valorbase - ValorTotal;
            return valorFinal;
        }
        public static decimal Cargartipodecambio()
        {
            decimal valorFinal = 0;
            return valorFinal;
        }
        public static bool IsValidDecimal(string _ValorNumero)
        {
            bool isValid = false;
            Regex regex = new Regex(@"^\d+([,\.]\d{1,2})?$");

            if (regex.IsMatch(_ValorNumero))
            {
                return isValid = true;
            }
            else
            {
                return isValid;
            }

        }
        public static DataTable ToDataTable<T>(this IList<T> data)
        {
            PropertyDescriptorCollection props =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, prop.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }

        public static bool CheckForInternetConnection()
        {
            try
            {
                USMessageBox.Show($"Validando conexion a internet......",
                                            "Consulta Ruc    ",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);


                using (var client = new WebClient())
                using (client.OpenRead("http://google.com/generate_204"))
                    return true;
            }
            catch
            {
                USMessageBox.Show("No se puede establecer conexion con internet",
"Error-Stop Icon",
MessageBoxButtons.RetryCancel,

MessageBoxIcon.Error);


                return false;
            }
        }

        public static string castURL(string url, string finalChar)
        {
            string finalUrl = url;
            try
            {
                if (url.Length > 0)
                {
                    string lastChar = url.Substring(url.Length - 1);
                    if (!lastChar.Equals(finalChar))
                        finalUrl += finalChar;
                }
            }
            catch (Exception ex)
            {
                //MainProcess.log.Error("Util > castURL() > " + ex.Message);
            }

            return finalUrl;
        }

        public static string replaceEscChar(string data)
        {
            string newData = data;

            if (newData.Length > 0)
            {
                newData = newData.Replace("\"", "");
                newData = newData.Replace(@"\", "");
                newData = newData.Replace("\r\\", "");
                newData = newData.Replace("\\", "");
                newData = newData.Replace("{", "");
                newData = newData.Replace("}", "");
                newData = newData.Replace("[", "");
                newData = newData.Replace("]", "");
                newData = newData.Replace("'", "");
                newData = Regex.Replace(newData, @"\t|\n|\r", "");
            }

            return newData.Trim();
        }


        public static void GetRuc(GetRucBean ruc)
        {



        }

        public static IRestResponse GetRucV2(GetRucBean ruc)
        {
            try
            {


                IRestResponse response = RestCall.RequestUS(Aplicacion.mConn.urlConsultaDocIden, Method.POST, ruc);
                return response;
            }
            catch (Exception ex)
            {
                //MainProcess.log.Error("LoginDAO > iniciarSesion() > " + ex.Message);
                return null;
            }
        }

        #region MODEL_RESPONSE

        private class Response
        {
            public Object T { get; set; }
        }

        #endregion

    }
}
