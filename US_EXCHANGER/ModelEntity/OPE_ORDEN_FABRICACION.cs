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
    
    public partial class OPE_ORDEN_FABRICACION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OPE_ORDEN_FABRICACION()
        {
            this.OPE_DETALLE_ORDEN_FABRICACION = new HashSet<OPE_DETALLE_ORDEN_FABRICACION>();
        }
    
        public string codigo { get; set; }
        public System.DateTime fecha { get; set; }
        public string CDG_PLAN { get; set; }
        public string estado { get; set; }
        public Nullable<int> id_pedido { get; set; }
        public int ID_PRODUCTO { get; set; }
        public Nullable<decimal> a_producir { get; set; }
        public string CDG_CC { get; set; }
        public string id_parent { get; set; }
        public Nullable<decimal> producido { get; set; }
        public Nullable<decimal> secuencia { get; set; }
        public string ref1 { get; set; }
        public string ref2 { get; set; }
        public string ref3 { get; set; }
        public Nullable<decimal> costo_unitario { get; set; }
        public Nullable<System.DateTime> fecha_cierre { get; set; }
        public string usuario_creacion { get; set; }
        public System.DateTime fecha_creacion { get; set; }
        public string usuario_modificacion { get; set; }
        public Nullable<System.DateTime> fecha_modificacion { get; set; }
        public Nullable<System.DateTime> fecha_vencimiento { get; set; }
        public string TIPO_OF { get; set; }
        public string ALMACEN { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OPE_DETALLE_ORDEN_FABRICACION> OPE_DETALLE_ORDEN_FABRICACION { get; set; }
    }
}