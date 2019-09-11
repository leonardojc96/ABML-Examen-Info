using System;
using System.Collections.Generic;
using System.Text;

namespace ABML2
{
    class Persona
    {
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public bool Hombre { get; set; }
        public TipoPersona tipo { get; set; }
        public Carrera carrera { get; set; }

        public string sexo (bool hombre)
        {
            if (hombre) return "Hombre";

            return "Mujer";
        }


        public override string ToString()
        {
            return DNI +", "+ Nombre + " " + Apellido + ", " + sexo(Hombre) + ", carrera: "+carrera.nombre+", "+tipo.tipoPersona;
        }
    }
}
