//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace US_EXCHANGER.ModelEntity
{
    using System;
    
    public partial class OPESS_OBTENER_COTIZACION_COMPRA_Result
    {
        public string ID_DOCUMENTO { get; set; }
        public string CDG_VEND { get; set; }
        public string VENDEDOR { get; set; }
        public string CDG_TD { get; set; }
        public string FECHA { get; set; }
        public string T_D { get; set; }
        public string DOCUMENTO { get; set; }
        public string RUC { get; set; }
        public string ESTADO { get; set; }
        public Nullable<decimal> VALOR_VENTA { get; set; }
        public Nullable<decimal> IGV { get; set; }
        public Nullable<decimal> TOTAL { get; set; }
        public Nullable<decimal> VALOR_VENTA_SOLES { get; set; }
        public Nullable<decimal> IGV_SOLES { get; set; }
        public Nullable<decimal> TOTAL_SOLES { get; set; }
        public Nullable<decimal> VALOR_VENTA_DOLAR { get; set; }
        public Nullable<decimal> IGV_DOLAR { get; set; }
        public Nullable<decimal> TOTAL_DOLAR { get; set; }
        public Nullable<int> ID_PERSONA { get; set; }
        public int POR_COMISION { get; set; }
        public int COMISION { get; set; }
        public string CDG_MON { get; set; }
        public string CDG_ESTA { get; set; }
    }
}