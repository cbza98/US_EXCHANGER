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
    
    public partial class OPESS_OBTENER_COBRANZA_DOCUMENTO_Result
    {
        public int ID_DOCUMENTO { get; set; }
        public decimal ID_PERSONA { get; set; }
        public string NUM_REG { get; set; }
        public System.DateTime FECHA_CONTABLE { get; set; }
        public System.DateTime FECHA_DOCUMENTO { get; set; }
        public System.DateTime FECHA_VCTO { get; set; }
        public string TDOC { get; set; }
        public string CDG_TDOC { get; set; }
        public string NUM_DOCU { get; set; }
        public string RUC { get; set; }
        public string CLIENTE { get; set; }
        public string CONDICION_PAGO { get; set; }
        public string MON { get; set; }
        public Nullable<decimal> TOTAL { get; set; }
        public Nullable<decimal> INTERES { get; set; }
        public Nullable<decimal> IMPTOTAL { get; set; }
        public string BANCO { get; set; }
        public string NUM_CTA { get; set; }
        public string NUM_COR { get; set; }
        public string USUARIO_CREACION { get; set; }
        public System.DateTime FECHA_CREACION { get; set; }
        public string SUCURSAL { get; set; }
        public string ESTADO { get; set; }
        public string MONEDA { get; set; }
        public string VENDEDOR { get; set; }
    }
}