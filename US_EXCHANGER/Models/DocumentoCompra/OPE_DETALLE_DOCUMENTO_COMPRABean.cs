using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace US_EXCHANGER.Models.DocumentoCompra
{
    public class OPE_DETALLE_DOCUMENTO_COMPRABean
    {

        public decimal ID_DETALLLE { get; set; }

        public decimal ID_DOCUMENTO { get; set; }

        public decimal ID_PRODUCTO { get; set; }

        public decimal CANTIDAD { get; set; }

        public decimal? PRECIO_COMPRA { get; set; }

        public decimal? IMPORTE { get; set; }

        public decimal? IGV_PORCENTAJE { get; set; }

        public decimal? IGV { get; set; }

        public decimal? DESCUENTO_PORCENTAJE { get; set; }

        public decimal? DESCUENTO { get; set; }

        public string DESCRIPCION_EXTENDIDA { get; set; }

        public string ID_SUCURSAL { get; set; }

        public int SECUENCIA { get; set; }

        public decimal? CANTIDAD_INOUT { get; set; }

        public decimal? SALDO { get; set; }

        public decimal? COSTO { get; set; }

        public string CODIGO_UNIDAD { get; set; }

        public decimal? COSTOF { get; set; }

        public decimal? COSTOL { get; set; }

        public string CDG_PROD { get; set; }

        public decimal? COSTOD { get; set; }

        public decimal? PRECIO_COMPRAD { get; set; }

        public string UNIDAD_EQUI { get; set; }

        public decimal? FACTOR { get; set; }

        public int? SEC_REQ { get; set; }

        public string REQ { get; set; }

        public decimal? ID_OC { get; set; }

        public string COMENTARIO { get; set; }

        public string SWT_IMP { get; set; }

        public decimal? ID_RECETA { get; set; }

        public decimal? SEC_RECETA { get; set; }

        public string CDG_CC { get; set; }

        public string SCDG_CC { get; set; }

        public string CDG_ZONA { get; set; }

        public string FILA { get; set; }

        public string COLUMNA { get; set; }

    }
}
