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
    
    public partial class OPE_CLISTA_PRECIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OPE_CLISTA_PRECIO()
        {
            this.OPE_LISTA_PRECIO2 = new HashSet<OPE_LISTA_PRECIO2>();
        }
    
        public string CODIGO { get; set; }
        public string MONEDA { get; set; }
        public string NOMBRE { get; set; }
        public string ESTADO { get; set; }
        public decimal FACTOR { get; set; }
        public System.DateTime FECHA_INICIO { get; set; }
        public System.DateTime FECHA_FIN { get; set; }
        public string METODO_REDONDEO { get; set; }
        public string CODIGO_BASE { get; set; }
        public string GRUPO_USUARIO { get; set; }
        public string USUARIO_CREACION { get; set; }
        public System.DateTime FECHA_CREACION { get; set; }
        public string USUARIO_MODIFICACION { get; set; }
        public Nullable<System.DateTime> FECHA_MODIFICACION { get; set; }
        public string TIPO_CLIENTE { get; set; }
        public string TIPO { get; set; }
        public string SWT_WEB { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OPE_LISTA_PRECIO2> OPE_LISTA_PRECIO2 { get; set; }
    }
}