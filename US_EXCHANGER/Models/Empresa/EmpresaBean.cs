using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace US_EXCHANGER.Models.Empresa
{
    public class EmpresaBean
    {
        public string codi_empr { get; set; }

        public string ruc_empr { get; set; }

        public string razo_soci { get; set; }

        public string nomb_come { get; set; }

        public string ubigeo { get; set; }

        public string dire_empr { get; set; }

        public string urba_empr { get; set; }

        public string prov_empr { get; set; }

        public string dpto_empr { get; set; }

        public string dist_empr { get; set; }

        public string fono1 { get; set; }

        public string fono2 { get; set; }

        public string fax_empr { get; set; }

        public string correo_empr { get; set; }

        public string repr_lega { get; set; }

        public string dni_repr_lega { get; set; }

        public byte[] logo_empr { get; set; }

        public string nomb_logo { get; set; }

        public string usuario_sol { get; set; }

        public string clave_sol { get; set; }

        public byte[] firma_digi { get; set; }

        public string nomb_firm { get; set; }

        public string clave_firma { get; set; }

        public string serv_smtp { get; set; }

        public int? ancho { get; set; }

        public int? alto { get; set; }

        public string resolucion { get; set; }

        public string ruta_archivo { get; set; }

        public string web_empr { get; set; }

        public string usua_crea { get; set; }

        public DateTime? fech_crea { get; set; }

        public string usua_modi { get; set; }

        public DateTime? fech_modi { get; set; }

        public string estado { get; set; }

        public string puerto { get; set; }

        public string correofe { get; set; }

        public string pass_corr { get; set; }

        public string cc_correo { get; set; }

        public decimal? ssl { get; set; }


        public int QtyDCantidad { get; set; }   
        public int QtyDPorcentaje { get; set; }
        public int QtyDtipoCambio { get; set; }
        public int QtyDCompras { get; set; }
        public int QtyDVentas { get; set; }
        public int QtyDRepCon { get; set; }


    }


}
