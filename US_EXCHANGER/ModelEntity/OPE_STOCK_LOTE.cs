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
    
    public partial class OPE_STOCK_LOTE
    {
        public string CODIGO_EMPRESA { get; set; }
        public string CODIGO_SUCURSAL { get; set; }
        public int ID_PRODUCTO { get; set; }
        public string LOTE { get; set; }
        public decimal CANTIDAD_INGRESADA { get; set; }
        public decimal CANTIDAD_SALIDA { get; set; }
        public decimal STOCK_ACTUAL { get; set; }
        public string CODIGO_UNIDAD { get; set; }
        public string SERIE { get; set; }
    }
}
