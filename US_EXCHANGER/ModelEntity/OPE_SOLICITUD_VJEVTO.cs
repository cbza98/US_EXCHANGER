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
    
    public partial class OPE_SOLICITUD_VJEVTO
    {
        public decimal ID_SOLICITUD { get; set; }
        public string CODIGO { get; set; }
        public System.DateTime FECHA_SOLICITUD { get; set; }
        public System.DateTime FECHA_REQUERIDA { get; set; }
        public string TIPO_ANAL { get; set; }
        public string CODIGO_ANAL { get; set; }
        public string MONEDA { get; set; }
        public string ESTADO { get; set; }
        public decimal TOTAL { get; set; }
        public string MOTIVO { get; set; }
        public decimal ID_CLIENTE { get; set; }
        public decimal TOTAL_VIAJE { get; set; }
        public decimal TOTAL_VIATICO { get; set; }
        public string OBSERVACION { get; set; }
        public string COMENTARIO { get; set; }
        public Nullable<decimal> ID_PROYECTO { get; set; }
        public string USUARIO_CREACION { get; set; }
        public System.DateTime FECHA_CREACION { get; set; }
        public string USUARIO_MODIFICACION { get; set; }
        public Nullable<System.DateTime> FECHA_MODIFICACION { get; set; }
        public string USUARIO_APROBACION { get; set; }
        public Nullable<System.DateTime> FECHA_APROBACION { get; set; }
        public string MOTIVO_RECHAZO { get; set; }
        public string USUARIO_RECHAZO { get; set; }
        public Nullable<System.DateTime> FECHA_RECHAZO { get; set; }
        public Nullable<decimal> TOTAL_ADICIONAL { get; set; }
    }
}
