using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace US_EXCHANGER.Helpers
{
    public static class Utils
    {
        public static decimal Returndecimal (string value)
        {
            decimal valuea = 0;
            valuea  = decimal.Parse(value, Aplicacion.oCulture.NumberFormat);
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

    }
}
