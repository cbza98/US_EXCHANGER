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
    
    public partial class OPE_PRODUCTO_SUCURSAL
    {
        public string CODIGO_EMPRESA { get; set; }
        public string CODIGO_SUCURSAL { get; set; }
        public int ID_PRODUCTO { get; set; }
        public decimal PAGO_TRABAJADOR { get; set; }
        public string ID_UNIDAD_PAGO_TRABAJADOR { get; set; }
        public decimal PAGO_EMPRESA { get; set; }
        public string ID_UNIDAD_PAGO_EMPRESA { get; set; }
        public string USUARIO_CREACION { get; set; }
        public System.DateTime FECHA_CREACION { get; set; }
        public string USUARIO_MODIFICACION { get; set; }
        public Nullable<System.DateTime> FECHA_MODIFICACION { get; set; }
    }
}
