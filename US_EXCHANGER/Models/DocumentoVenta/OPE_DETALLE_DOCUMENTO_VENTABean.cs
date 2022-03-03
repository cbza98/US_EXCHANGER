using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace US_EXCHANGER.Models.DocumentoVenta
{
    public class OPE_DETALLE_DOCUMENTO_VENTABean
    { 
    public decimal ID_DETALLLE { get; set; }

    public decimal ID_DOCUMENTO { get; set; }

    public decimal ID_PRODUCTO { get; set; }

    public decimal CANTIDAD { get; set; }

    public decimal PRECIO_UNITARIO { get; set; }

    public decimal MONTO_EMPRESA { get; set; }

    public decimal MONTO_TRABAJADOR { get; set; }

    public decimal SUB_TOTAL { get; set; }

    public int SECUENCIA { get; set; }

    public string NUMERO_COMANDA { get; set; }

    public string COMENTARIO { get; set; }

    public string INICIO { get; set; }

    public string FIN { get; set; }

    public decimal? COSTO { get; set; }

    public string TIPO { get; set; }

    public decimal? DSCTO { get; set; }

    public decimal? IMPORTE_DSCTO { get; set; }

    public decimal? PRECIO_ORIGINAL { get; set; }

    public decimal? IGV { get; set; }

    public string CDG_PROD { get; set; }

    public decimal? COMISION { get; set; }

    public decimal? MARGEN { get; set; }

    public decimal? IMPORTE_MARGEN { get; set; }

    public decimal? ID_PEDIDO { get; set; }

    public decimal? ID_DOCU { get; set; }

    public string TIPO_LISTA { get; set; }

    public decimal? ID_PRODUCTO_PARENT { get; set; }

    public string UNIDAD { get; set; }

    public decimal? POR_PERCEPCION { get; set; }

    public decimal? PERCEPCION { get; set; }

    public string OS { get; set; }

    public string FLAG_ADD { get; set; }

    public decimal? VALOR_VEN { get; set; }

    public string UNID_VEN { get; set; }

    public DateTime? FECHA_VEN { get; set; }

    public string CDG_KIT { get; set; }

    public string SWT_PIGV { get; set; }

    public string SWT_PROM { get; set; }

    public string SWT_IMP { get; set; }

    public decimal? CANT_KIT { get; set; }

    public string SWT_DCOM { get; set; }

    public string SWT_FREE { get; set; }

    public string NOM_IMP { get; set; }

    public decimal? SEC_PROD { get; set; }

    public string TIPO_AFEC_IGV { get; set; }

    public string CDG_TIPO_DETR { get; set; }

    public string GRUP_TIPO_AFEC_IGV { get; set; }

    public decimal? POR_DETRACCION { get; set; }

    public decimal? DETRACCION { get; set; }

    public string REFERENCIA1 { get; set; }

    public decimal? POR_IGV { get; set; }

    public decimal? VV { get; set; }

    public string CDG_VEND { get; set; }

}


}
