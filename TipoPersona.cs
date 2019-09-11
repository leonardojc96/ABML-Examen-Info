using System;
using System.Collections.Generic;
using System.Text;

namespace ABML2
{
    class TipoPersona
    {
        public string tipoPersona { get; set; }
        public int idTipo { get; set; }

        public override string ToString()
        {
            return idTipo+": "+tipoPersona;
        }
    }
}
