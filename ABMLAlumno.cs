using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ABMLEmpleados;

namespace ABML2
{
    class ABMLAlumno
    {
        List<Persona> alumnos = new List<Persona>();
        List<TipoPersona> tipos = new List<TipoPersona>();
        List<Carrera> carreras = new List<Carrera>();


        public void CargarEmpleado()
        {
            Console.WriteLine("Ingrese el DNI");
            string dni = Console.ReadLine();

            if (!existe(dni))
            {
                Persona alumno = new Persona();

                alumno.DNI = dni;

                Console.WriteLine("Ingrese el nombre");
                alumno.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el apellido");
                alumno.Apellido = Console.ReadLine();
                Console.WriteLine("Ingrese el sexo, 1: Hombre, 2: Mujer");
                int sexo = Validaciones.ValidaSexo(Console.ReadLine());
                Console.WriteLine("Ingresa el id del tipo.");

                foreach(TipoPersona tipo in tipos)
                {
                    Console.WriteLine(tipo.ToString());
                }

                int idTipo = Validaciones.ANumeroEntero(Console.ReadLine());
                int indexTipo = tipos.FindIndex(tip => tip.idTipo == idTipo);
                alumno.tipo = tipos.ElementAt(indexTipo);
                Console.WriteLine("Ingrese el id de la carrera.");

                foreach (Carrera car in carreras)
                {
                    Console.WriteLine(car.ToString());
                }

                int idCarrera = Validaciones.ANumeroEntero(Console.ReadLine());
                int indexCarrera = carreras.FindIndex(car => car.idCarrera == idCarrera);
                alumno.carrera = carreras.ElementAt(indexCarrera);


                if(sexo == 1)
                {
                    alumno.Hombre = true;
                }
                else
                {
                    alumno.Hombre = false;
                }

                alumnos.Add(alumno);
            }
            else
            {
                Console.WriteLine("Ya existe empleado con ese DNI");
            }

        }

        public void CargarTipo()
        {
            TipoPersona t = new TipoPersona();
            Console.WriteLine("Ingrese el tipo de persona.");
            t.tipoPersona = Validaciones.ValidaNombre(Console.ReadLine());
            Console.WriteLine("Ingrese el id.");
            t.idTipo = Validaciones.ANumeroEntero(Console.ReadLine());
            tipos.Add(t);
        }

        public void CargarCarrera()
        {
            Carrera c = new Carrera();
            Console.WriteLine("Ingrese la carrera.");
            c.nombre = Validaciones.ValidaNombre(Console.ReadLine());
            Console.WriteLine("Ingrese el id.");
            c.idCarrera = Validaciones.ANumeroEntero(Console.ReadLine());
            carreras.Add(c);
        }

        public void ListaEmpleado()
        {
            foreach (Persona alumno in alumnos)
            {
                Console.WriteLine(alumno.ToString());
            }
        }

        public bool existe(string dni)
        {
            if (alumnos.Exists(alu => alu.DNI == dni))
            {
                return true;
            }
            return false;
        }
    }
}
