using System;
using System.Collections.Generic;
using System.Text;

namespace ABML2
{
    class Carrera
    {
        public string nombre { get; set; }
        public int años { get; set; }
        public int idCarrera { get; set; }

        public override string ToString()
        {
            return idCarrera + ": " + nombre;
        }
    }
}
