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
    
    public partial class OPE_LIQUIDACIONM
    {
        public decimal ID_DOCUMENTO { get; set; }
        public string CODIGO { get; set; }
        public decimal ID_CLIENTE { get; set; }
        public System.DateTime FECHA_INICIO { get; set; }
        public System.DateTime FECHA_FIN { get; set; }
        public string SWT_PLOMO { get; set; }
        public string SWT_ZINC { get; set; }
        public string SWT_COBRE { get; set; }
        public string DATO_PROCESO { get; set; }
        public Nullable<decimal> TMH_PROCESADO { get; set; }
        public Nullable<decimal> TOTAL_INGRESADO { get; set; }
        public string MONEDA { get; set; }
        public decimal SUBTOTAL { get; set; }
        public decimal VALOR_VENTA { get; set; }
        public decimal IGV { get; set; }
        public decimal TOTAL { get; set; }
        public Nullable<decimal> IMP_ADEL1 { get; set; }
        public Nullable<decimal> IMP_ADEL2 { get; set; }
        public Nullable<decimal> IMP_ADEL3 { get; set; }
        public string OBSERVACIONES { get; set; }
        public string ESTADO { get; set; }
        public string USUARIO_CREACION { get; set; }
        public System.DateTime FECHA_CREACION { get; set; }
        public string USUARIO_MODIFICACION { get; set; }
        public Nullable<System.DateTime> FECHA_MODIFICACION { get; set; }
        public string USUARIO_APROBACION { get; set; }
        public Nullable<System.DateTime> FECHA_APROBACION { get; set; }
        public string USUARIO_AUTORIZA { get; set; }
        public Nullable<System.DateTime> FECHA_AUTORIZA { get; set; }
    }
}