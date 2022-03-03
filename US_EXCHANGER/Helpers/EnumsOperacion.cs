using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace US_EXCHANGER.Helpers
{
    public enum Operacion
    {
        Primario = 0,
        CompraVentaEjecutante = 1,
        CompraVentaBeneficiario = 2
    }
    public static class EnumTipoPersona
    {
        public static string CLIENTE = "0002";
        public static string PROVEEDOR = "0001";
    }
}
