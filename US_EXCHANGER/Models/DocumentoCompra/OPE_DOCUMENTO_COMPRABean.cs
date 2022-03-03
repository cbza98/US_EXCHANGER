using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace US_EXCHANGER.Models.DocumentoCompra
{
    public  class OPE_DOCUMENTO_COMPRABean
    {
       public string CODIGO_EMPRESA { get; set; }

        public decimal ID_DOCUMENTO { get; set; }

        public string NUMERO { get; set; }

        public DateTime FECHA_DOCUMENTO { get; set; }

        public DateTime FECHA_REGISTRO { get; set; }

        public DateTime FECHA_VENCIMIENTO { get; set; }

        public int? ID_PROVEEDOR { get; set; }

        public string ID_MONEDA { get; set; }

        public string ID_FORMA_PAGO { get; set; }

        public decimal TIPO_CAMBIO { get; set; }

        public string DEPARTAMENTO_PARTIDA { get; set; }

        public string PROVINCIA_PARTIDA { get; set; }

        public string UBIGEO_PARTIDA { get; set; }

        public string DEPARTAMENTO_LLEGADA { get; set; }

        public string PROVINCIA_LLEGADA { get; set; }

        public string UBIGEO_LLEGADA { get; set; }

        public string ESTADO { get; set; }

        public string TIPO_DOCUMENTO { get; set; }

        public string TIPO_MOVIMIENTO { get; set; }

        public string GLOSA { get; set; }

        public string USUARIO_CREACION { get; set; }

        public DateTime FECHA_CREACION { get; set; }

        public string USUARIO_MODIFICACION { get; set; }

        public DateTime? FECHA_MODIFICACION { get; set; }

        public string ES_TRASLADO { get; set; }

        public string CODIGO_SUCURSAL_ORIGEN { get; set; }

        public string CODIGO_SUCURSAL_DESTINO { get; set; }

        public string FLAG1 { get; set; }

        public string CODIGO_EMPRESA_DESTINO { get; set; }

        public int? ID_DOCUMENTO_PARENT { get; set; }

        public string TIPO_GUIA { get; set; }

        public string CODIGO_GENERADO { get; set; }

        public decimal? ID_OC { get; set; }

        public decimal? ID_PEDIDO { get; set; }

        public string RUC_TRANSPORTISTA { get; set; }

        public string LICENCIA { get; set; }

        public string PLACA { get; set; }

        public string CHOFER { get; set; }

        public string LUGAR_ENTREGA { get; set; }

        public string LUGAR_PARTIDA { get; set; }

        public string PUNTO_VENTA { get; set; }

        public string NUM_ORIG { get; set; }

        public string NUM_VOUC { get; set; }

        public string CDG_OS { get; set; }

        public string CDG_OP { get; set; }

        public string SWT_ING { get; set; }

        public string VEHICULO { get; set; }

        public string CDG_OT { get; set; }

        public string CDG_REF { get; set; }

        public string NUM_FRE { get; set; }

        public string NUM_REF { get; set; }

        public DateTime? FECHA_ENTREGA_CLIENTE { get; set; }

        public string CERTIFICADO_INSCRIPCION { get; set; }

        public decimal? NUM_BULTOS { get; set; }

        public string NUM_ALU { get; set; }

        public string NUM_DELIVERY { get; set; }

        public string SWT_AUTORIZACION { get; set; }

        public string USUARIO_AUTORIZACION { get; set; }

        public DateTime? FECHA_AUTORIZACION { get; set; }

        public string SWT_CUO { get; set; }

        public string TRANSPORTISTA { get; set; }

        public string CDG_CC { get; set; }

        public string SCDG_CC { get; set; }

        public decimal? ID_DOCUMENTO_PARENT2 { get; set; }

        public string SWT_WEB { get; set; }

        public string SWT_WS { get; set; }

        public string NODO_DESPACHO { get; set; }

        public string CDG_CECO_D { get; set; }

        public string CDG_SCECO_D { get; set; }

        public string SWT_FE { get; set; }

        public bool? FLAG_ERROR { get; set; }

        public bool? FLAG_ENVIO { get; set; }

        public string SWT_BJ { get; set; }

        public DateTime? FECHA_ENVIO { get; set; }

        public string USUARIO_ENVIO { get; set; }

        public string M_ERROR { get; set; }

        public string M_EXITO { get; set; }

        public string VALOR_RESUMEN { get; set; }

        public string NUM_REQ { get; set; }

        public decimal? ID_REQ_EM { get; set; }

        public string ERR_ST { get; set; }

 


}
}
