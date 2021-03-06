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
    
    public partial class PLAN_PRESUPUESTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PLAN_PRESUPUESTO()
        {
            this.PLAN_DETALLE_PRESUPUESTO = new HashSet<PLAN_DETALLE_PRESUPUESTO>();
        }
    
        public decimal ID_PRESUPUESTO { get; set; }
        public string CODIGO { get; set; }
        public decimal ID_CLIENTE { get; set; }
        public string ID_REQUERIMIENTO { get; set; }
        public string CATEGORIA { get; set; }
        public string SERVICIO { get; set; }
        public string CDG_ING { get; set; }
        public string MONEDA { get; set; }
        public decimal ID_PARENT { get; set; }
        public string ESTADO { get; set; }
        public decimal COSTO { get; set; }
        public decimal VALOR_VENTA { get; set; }
        public decimal TIPO_CAMBIO { get; set; }
        public string OBSERVACION { get; set; }
        public string OBSERVACION2 { get; set; }
        public string SWT_MAIN { get; set; }
        public int CANTIDAD { get; set; }
        public string USUARIO_CREACION { get; set; }
        public System.DateTime FECHA_CREACION { get; set; }
        public string USUARIO_MODIFICACION { get; set; }
        public Nullable<System.DateTime> FECHA_MODIFICACION { get; set; }
        public Nullable<System.DateTime> FECHA_REGISTRO { get; set; }
        public Nullable<decimal> GASTO_ADMINISTRATIVO { get; set; }
        public Nullable<decimal> GASTO_GENERAL { get; set; }
        public Nullable<decimal> MARGEN { get; set; }
        public Nullable<decimal> IMPORTE_ADMINISTRATIVO { get; set; }
        public Nullable<decimal> IMPORTE_GENERAL { get; set; }
        public Nullable<decimal> IMPORTE_MARGEN { get; set; }
        public string SUCURSAL { get; set; }
        public string SUB_TIPO_SERVICIO { get; set; }
        public Nullable<System.DateTime> FECHA_INICIO { get; set; }
        public Nullable<System.DateTime> FECHA_TERMINO { get; set; }
        public Nullable<decimal> CANTIDAD_SERVICIO { get; set; }
        public Nullable<decimal> FRECUENCIA_SERVICIO { get; set; }
        public Nullable<decimal> TIEMPO_ONSIDE { get; set; }
        public Nullable<decimal> CANT_MESES_FACT { get; set; }
        public string RENOVACION { get; set; }
        public Nullable<decimal> ID_FACTURAR { get; set; }
        public string SWT_PRES { get; set; }
        public Nullable<decimal> ID_OPORTUNIDAD { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PLAN_DETALLE_PRESUPUESTO> PLAN_DETALLE_PRESUPUESTO { get; set; }
    }
}
