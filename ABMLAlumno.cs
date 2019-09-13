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
                alumno.Nombre = Validaciones.ValidaNombre(Console.ReadLine());
                Console.WriteLine("Ingrese el apellido");
                alumno.Apellido = Validaciones.ValidaNombre(Console.ReadLine());
                Console.WriteLine("Ingrese el sexo, 1: Hombre, 2: Mujer");
                int sexo = Validaciones.ValidaSexo(Console.ReadLine());
                Console.WriteLine("Ingrese la fecha de nacimiento");
                alumno.fechaNac = Console.ReadLine();
                Console.WriteLine("Ingrese la direccion.");
                alumno.direccion = Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine("Ingresa el tipo de persona.");

                foreach(TipoPersona tipo in tipos)
                {
                    Console.WriteLine(tipo.ToString());
                }

                int idTipo = Validaciones.ANumeroEntero(Console.ReadLine());
                try
                {
                    if (tipos.Exists(t => t.idTipo == idTipo))
                    {
                        int indexTipo = tipos.FindIndex(tip => tip.idTipo == idTipo);
                        alumno.tipo = tipos.ElementAt(indexTipo);
                    }
                    else
                    {
                        Console.WriteLine("No existe ese tipo de persona, se le asignara el primer tipo encontrado.");
                        alumno.tipo = tipos.ElementAt(0);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("No se encontro ningun tipo, se asignara tipo vacio.");
                    alumno.tipo = new TipoPersona();
                }

                Console.WriteLine();
                Console.WriteLine("Ingrese la carrera.");

                foreach (Carrera car in carreras)
                {
                    Console.WriteLine(car.ToString());
                }

                int idCarrera = Validaciones.ANumeroEntero(Console.ReadLine());

                try
                {
                    if (carreras.Exists(c => c.idCarrera == idCarrera))
                    {
                        int indexCarrera = carreras.FindIndex(car => car.idCarrera == idCarrera);
                        alumno.agregarCarrera(carreras.ElementAt(indexCarrera));
                    }
                    else
                    {
                        Console.WriteLine("No existe esa carrera, se le asigno la primera carrera encontrada.");
                        alumno.agregarCarrera(carreras.ElementAt(0));
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("No se encontro ninguna, se le asignara una carrera vacia.");
                    alumno.agregarCarrera(new Carrera());
                }

                if (sexo == 1)
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
                Console.WriteLine("Ya existe alumno con ese DNI");
            }

        }

        public void ModificarAlumno(string dni)
        {
            if (existe(dni))
            {

            }
        }

        public void ConsultaAlumno(string dni)
        {
            if (existe(dni))
            {
                int index = alumnos.FindIndex(alu => alu.DNI == dni);
                Console.WriteLine(alumnos.ElementAt(index).ToString());
                alumnos.ElementAt(index).mostrarCarreras();
            }
        }

        public void CargarTipo()
        {
            TipoPersona t = new TipoPersona();
            Console.WriteLine("Ingrese el tipo de persona.");
            t.tipoPersona = Validaciones.ValidaNombre(Console.ReadLine());
            tipos.Add(t);
        }

        public void CargarCarrera()
        {
            Carrera c = new Carrera();

            Console.WriteLine("Ingrese el nombre de la carrera.");
            c.nombre = Validaciones.ValidaNombre(Console.ReadLine());
            Console.WriteLine("Ingrese años de duracion.");
            c.años = Validaciones.ANumeroEntero(Console.ReadLine());
            Console.WriteLine("Ingrese descripcion.");
            c.descripcion = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad de materias.");
            c.cantidadMaterias = Validaciones.ANumeroEntero(Console.ReadLine());
            carreras.Add(c);
        }

        public void ListaEmpleado()
        {
            foreach (Persona alumno in alumnos)
            {
                Console.Write(alumno.ToString()+ " ");
                alumno.mostrarCarreras();
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
