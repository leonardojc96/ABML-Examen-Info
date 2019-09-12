using System;
using System.Collections.Generic;
using System.Text;

namespace ABML2
{
    class Carrera
    {
        public string nombre { get; set; }
        public int años { get; set; }
        public string descripcion { get; set; }
        public int cantidadMaterias { get; set; }
        public int idCarrera { get; set; }
        public bool activo { get; set; }

        public override string ToString()
        {
            return "ID "+idCarrera + ": " + nombre+".";
        }
    }
}
