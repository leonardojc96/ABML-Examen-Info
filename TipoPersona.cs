using System;
using System.Collections.Generic;
using System.Text;

namespace ABML2
{
    class TipoPersona
    {
        public string tipoPersona { get; set; }
        static int cantTipos = 0;
        public int idTipo { get; set; }

        public TipoPersona()
        {
            cantTipos++;
            idTipo = cantTipos;
        }

        public override string ToString()
        {
            return idTipo+"- "+tipoPersona+".";
        }
    }
}
