using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace US_EXCHANGER.Models.Caja.APERTURA
{
    public class OPE_ARQUEO_CAJABean
    {
            public decimal ID_ARQUEO { get; set; }

            public string CODIGO_EMPRESA { get; set; }

            public string CODIGO_SUCURSAL { get; set; }

            public string CODIGO_CAJERO { get; set; }

            public string TURNO { get; set; }

            public string MAQUINA { get; set; }

            public int BILLETE200 { get; set; }

            public int BILLETE100 { get; set; }

            public int BILLETE50 { get; set; }

            public int BILLETE20 { get; set; }

            public int BILLETE10 { get; set; }

            public int MONEDA5 { get; set; }

            public int MONEDA1 { get; set; }

            public int MONEDA05 { get; set; }

            public int MONEDA005 { get; set; }

            public int MONEDA001 { get; set; }

            public decimal SALDO_INICIAL { get; set; }

            public decimal TOTAL_BILLETE { get; set; }

            public decimal TOTAL_MONEDA { get; set; }

            public decimal TOTAL_INGRESO { get; set; }

            public decimal TOTAL_RETIRO { get; set; }

            public decimal TOTAL_SISTEMA { get; set; }

            public string OBSERVACION { get; set; }

            public DateTime FECHA_ARQUEO { get; set; }

            public DateTime? FECHA_CIERRE { get; set; }

            public string ESTADO { get; set; }

            public string MONEDA { get; set; }

            public decimal? EFECTIVO { get; set; }

            public decimal? VISA { get; set; }

            public decimal? MASTERCARD { get; set; }

            public decimal? RIPLEY { get; set; }

            public decimal? SAGA { get; set; }

            public decimal? OTROS { get; set; }

            public decimal? CONTADO { get; set; }

            public decimal? CREDITO { get; set; }

            public string USUARIO_CREACION { get; set; }

            public DateTime FECHA_CREACION { get; set; }

            public string USUARIO_MODIFICACION { get; set; }

            public DateTime? FECHA_MODIFICACION { get; set; }

            public int? MONEDA010 { get; set; }

            public decimal? COBRADO_POR_CREDITO { get; set; }

        }

    }

