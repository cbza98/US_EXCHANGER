using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace US_EXCHANGER.Models.Persona
{
    public class Asistencia
    {
        string Ruc { get; set; }
        string Nombre { get; set; }
        string TIPO_DOCUMENTO { get; set; }
        byte[] PERSONA_FINGER { get; set; }
    }
}
