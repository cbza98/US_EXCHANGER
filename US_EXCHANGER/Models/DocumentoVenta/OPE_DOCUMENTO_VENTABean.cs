using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace US_EXCHANGER.Models.DocumentoVenta
{
    public class OPE_DOCUMENTO_VENTABean
    {

        public string CODIGO_EMPRESA { get; set; }

        public string CODIGO_SUCURSAL { get; set; }

        public decimal ID_DOCUMENTO { get; set; }

        public DateTime FECHA_REGISTRO { get; set; }

        public string HORA { get; set; }

        public int ID_PERSONA { get; set; }

        public string CONDICION_PAGO { get; set; }

        public string TIPO_VENTA { get; set; }

        public string TIPO_DOCUMENTO { get; set; }

        public string NUMERO_SERIE { get; set; }

        public string MONEDA { get; set; }

        public decimal POR_IGV { get; set; }

        public decimal IGV { get; set; }

        public decimal SUB_TOTAL { get; set; }

        public decimal? TOTAL { get; set; }

        public decimal? VALOR_VENTA { get; set; }

        public decimal EFECTIVO { get; set; }

        public decimal ABONO { get; set; }

        public decimal VUELTO { get; set; }

        public string ESTADO { get; set; }

        public string NUMERO_MAQUINA { get; set; }

        public string MOZO { get; set; }

        public string TURNO { get; set; }

        public string CODIGO_CAJERO { get; set; }

        public DateTime FECHA_CREACION { get; set; }

        public string USUARIO_MODIFICACION { get; set; }

        public DateTime? FECHA_MODIFICACION { get; set; }

        public decimal? VISA { get; set; }

        public decimal? MASTERCARD { get; set; }

        public decimal? RIPLEY { get; set; }

        public decimal? SAGA { get; set; }

        public decimal? OTROS { get; set; }

        public string NUMERO_COMANDA { get; set; }

        public string RUC { get; set; }

        public string NOMBRE_PERSONA { get; set; }

        public string DIRECCION_PERSONA { get; set; }

        public decimal? COMISION_VISA { get; set; }

        public decimal? COMISION_MASTERCARD { get; set; }

        public decimal? COMISION_RIPLEY { get; set; }

        public decimal? COMISION_SAGA { get; set; }

        public decimal? COMISION_OTROS { get; set; }

        public decimal? DESCUENTO { get; set; }

        public decimal? ID_PEDIDO { get; set; }

        public decimal? ID_DOCUMENTO2 { get; set; }

        public string TIPO_DOCUMENTO2 { get; set; }

        public string TIPO_MOVIMIENTO { get; set; }

        public DateTime? FECHA_REFERENCIA { get; set; }

        public DateTime? FEC_VCTO { get; set; }

        public DateTime? FEC_CANC { get; set; }

        public string DOC_REF { get; set; }

        public string NUM_ORIG { get; set; }

        public string NUM_VOUC { get; set; }

        public decimal? TOT_COB { get; set; }

        public decimal? VAL_FPAG { get; set; }

        public string OBSERVACION { get; set; }

        public decimal? TIPO_CAMBIO { get; set; }

        public string REDONDEO { get; set; }

        public string ANTICIPO { get; set; }

        public decimal? ID_GUIA { get; set; }

        public string USUARIO_CREACION { get; set; }

        public decimal? VAL_ANTICIPO { get; set; }

        public decimal? VAL_PERCEPCION { get; set; }

        public string REF_ZONAS { get; set; }

        public decimal? ID_CHECKINOUT { get; set; }

        public decimal? ID_COTIZACION { get; set; }

        public DateTime? FECHA_ANULACION { get; set; }

        public string DEPARTAMENTO { get; set; }

        public string PROVINCIA { get; set; }

        public string DISTRITO { get; set; }

        public decimal? CANT_DECIMAL { get; set; }

        public DateTime? FECHA_APERTURA { get; set; }

        public string NOM_IMP { get; set; }

        public decimal? PROPINA { get; set; }

        public string CAJA { get; set; }

        public string SWT_CUO { get; set; }

        public string VALOR_RESUMEN { get; set; }

        public string TEXTO_IMPORTE { get; set; }

        public string VALOR_FIRMA { get; set; }

        public string M_ERROR { get; set; }

        public string M_EXITO { get; set; }

        public decimal? M_CONTINGENCIA { get; set; }

        public string USUARIO_CONTINGENCIA { get; set; }

        public DateTime? FECHA_CONTINGENCIA { get; set; }

        public string REFE_CORR { get; set; }

        public decimal? IMP_OPERACION_GRAVADA { get; set; }

        public decimal? IMP_OPERACION_INAFECTA { get; set; }

        public decimal? IMP_OPERACION_EXONERADA { get; set; }

        public decimal? IMP_OPERACION_EXPORTACION { get; set; }

        public string REFLETRA { get; set; }

        public string SWT_CC { get; set; }

        public string USUARIO_CAJA { get; set; }

        public string SWT_CANJE { get; set; }

        public decimal? ICBPER { get; set; }

        public bool? FLAG_ERROR { get; set; }

        public bool? FLAG_ENVIO { get; set; }

        public DateTime? FECHA_ENVIO { get; set; }

        public string USUARIO_ENVIO { get; set; }

        public string SWT_FE { get; set; }

        public string SWT_BJ { get; set; }

        public string SWT_GN { get; set; }

        public string STR_MOT { get; set; }

        public string DNI { get; set; }

        public string NOMBRE_APELLIDO { get; set; }

        public string TEL_CELULAR { get; set; }

        public string CDG_CECO { get; set; }

        public string CDG_SCECO { get; set; }

        public decimal? PTOS_VTA { get; set; }

        public decimal? DSCTO_PTOS_VTA { get; set; }

        public decimal? PTOS_VTA_APLICA { get; set; }

        public string TIPO_OPERACION { get; set; }

        public decimal? IMP_RED { get; set; }

        public string NUM_PLACA { get; set; }

        public decimal? IMP_CREDITO { get; set; }

        public string FECHA_INGRESO { get; set; }

        public string FECHA_SALIDA { get; set; }

        public string TEXTO_CONTRATO { get; set; }

        public string TEXTO_CONTRATO2 { get; set; }

        public decimal? MINUTOS { get; set; }

        public decimal? HORAS { get; set; }

        public decimal? MINUTOSE { get; set; }

        public decimal? HORASE { get; set; }

        public decimal? MINUTOSST { get; set; }

        public decimal? HORASST { get; set; }

        public decimal? TARIFA { get; set; }

        public decimal? CANT_HS { get; set; }

        public decimal? TARIFA_PLANA { get; set; }

        public decimal? ID_CONTRATO { get; set; }

        public string NOM_DELIVERY { get; set; }

        public decimal? POR_RETENCION { get; set; }

        public decimal? IMP_RETENCION { get; set; }

        public decimal? POR_RETENCION_OTRO { get; set; }

        public decimal? IMP_RETENCION_OTRO { get; set; }

        public decimal? ID_MEDICO { get; set; }

        public string CDG_ESPE { get; set; }


    }
}
