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
    
    public partial class REP_VW_DETALLE_DOCUMENTO_COMPRA
    {
        public string NOMBRE { get; set; }
        public string NUM_DOCU { get; set; }
        public string PROVEEDOR { get; set; }
        public System.DateTime DD_FECHA_DOCUMENTO { get; set; }
        public System.DateTime DD_FECHA_VENCIMIENTO { get; set; }
        public Nullable<System.DateTime> DD_FECHA_CONTABILIZACION { get; set; }
        public string CONDICION_PAGO { get; set; }
        public string CORRELATIVO { get; set; }
        public string DESCRIPCION_CONCEPTO { get; set; }
        public string GLOSA { get; set; }
        public string CUENTA { get; set; }
        public string DEBE_HABER { get; set; }
        public string TIPO { get; set; }
        public string CON_SIN_IGV { get; set; }
        public string MONEDA { get; set; }
        public Nullable<decimal> CANTIDAD { get; set; }
        public Nullable<decimal> PRECIO { get; set; }
        public Nullable<decimal> IMPORTE { get; set; }
        public string CENTRO_COSTO { get; set; }
        public string USUARIO_CREACION { get; set; }
        public System.DateTime FECHA_CREACION { get; set; }
    }
}