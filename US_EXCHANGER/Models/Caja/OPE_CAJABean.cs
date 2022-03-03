using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace US_EXCHANGER.Models.Caja
{
    public class OPE_CAJABean
    {
        public string CDG_AREA { get; set; }

        public string NUM_CAJA { get; set; }

        public string NUM_CTA { get; set; }

        public string CDG_BCO { get; set; }

        public string CDG_FPAG { get; set; }

        public string NUM_CHEQ { get; set; }

        public string CDG_MON { get; set; }

        public DateTime FEC_CAJA { get; set; }

        public decimal SLD_CAJA { get; set; }

        public decimal IMP_CAJA { get; set; }

        public decimal TOT_CAJA { get; set; }

        public decimal MAX_CAJA { get; set; }

        public string SWT_CAJA { get; set; }

        public string CDG_TMOV { get; set; }

        public string NUM_COR { get; set; }

        public string USUARIO_CREACION { get; set; }

        public DateTime FECHA_CREACION { get; set; }

        public string USUARIO_MODIFICACION { get; set; }

        public DateTime? FECHA_MODIFICACION { get; set; }

        public DateTime? FEC_CIERRE { get; set; }

        public string OBSERVACION { get; set; }

        public string CDG_OP { get; set; }

        public string CDG_OS { get; set; }

        public string CODIGO_SUCURSAL { get; set; }

        public string NUM_REQUI { get; set; }
    }
}
