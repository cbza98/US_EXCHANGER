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
    using System.Collections.Generic;
    
    public partial class OPE_CUOTA_PEDIDO
    {
        public decimal ID_PEDIDO { get; set; }
        public decimal CUOTA { get; set; }
        public string LETRA { get; set; }
        public System.DateTime FECHA_VENCIMIENTO { get; set; }
        public int DIAS { get; set; }
        public decimal IMPORTE { get; set; }
        public decimal INTERES { get; set; }
        public decimal IMPORTE_INTERES { get; set; }
        public decimal IMPORTE_TOTAL { get; set; }
        public string TIPO_DOCUMENTO { get; set; }
        public string USUARIO_CREACION { get; set; }
        public System.DateTime FECHA_CREACION { get; set; }
        public string USUARIO_MODIFICACION { get; set; }
        public Nullable<System.DateTime> FECHA_MODIFICACION { get; set; }
        public Nullable<decimal> INTERES_SIGV { get; set; }
        public Nullable<decimal> AMORTIZACION { get; set; }
        public Nullable<decimal> VALOR_INAFECTO { get; set; }
        public Nullable<decimal> IGV { get; set; }
        public Nullable<decimal> IGV50 { get; set; }
        public Nullable<decimal> CAPITAL_FINAL { get; set; }
        public Nullable<decimal> CAPITAL_AMORTIZADO { get; set; }
        public Nullable<decimal> VALOR_AFECTO { get; set; }
    }
}
