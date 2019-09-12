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
        public string fechaNac { get; set; }
        public string direccion { get; set; }
        public bool Hombre { get; set; }
        public TipoPersona tipo { get; set; }
        public List<Carrera> carreras = new List<Carrera>();

        public string sexo (bool hombre)
        {
            if (hombre) return "Hombre";

            return "Mujer";
        }

      

        public void agregarCarrera(Carrera car)
        {
            carreras.Add(car);
        }

        public void mostrarCarreras()
        {
            foreach (Carrera carrera in carreras)
            {
                Console.Write(carrera.nombre +", "); 
            }
            Console.WriteLine();
        }

        public override string ToString()
        {
            return DNI +", "+ Nombre + " " + Apellido + ", " + sexo(Hombre) +", "+tipo.tipoPersona+ ".";
        }
    }
}
