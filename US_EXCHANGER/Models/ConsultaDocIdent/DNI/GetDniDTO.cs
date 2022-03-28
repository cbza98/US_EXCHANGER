using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace US_EXCHANGER.Models.ConsultaDocIdent.DNI
{
    public class GetDniDTO
    {
        public bool Success { get; set; }
        public string Dni { get; set; }
        public string Nombre_completo { get; set; }
    }
}
