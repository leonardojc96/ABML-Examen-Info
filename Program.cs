using System;
using ABMLEmpleados;

namespace ABML2
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu m = new Menu();
            m.CargarMenu();
        }
    }

    class Menu
    {
        ABMLAlumno abml = new ABMLAlumno();

        public void CargarMenu()
        {
            int opcion;
            do
            {
                Console.WriteLine("Menu principal.");
                Console.WriteLine();
                Console.WriteLine("1-Nuevo Alumno.");
                Console.WriteLine("2-Consultar Alumno.");
                Console.WriteLine("3-Modificar Alumno.");
                Console.WriteLine("4-Listar Alumnos.");
                Console.WriteLine("5-Cargar tipo de persona.");
                Console.WriteLine("6-Cargar carrera.");
                Console.WriteLine("0-Salir.");
                opcion = Validaciones.ANumeroEntero(Console.ReadLine());
                Console.Clear();
                OpcionMenu(opcion);
            } while (opcion != 0);
        }

        public void OpcionMenu(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    abml.CargarEmpleado();
                    break;
                case 2:
                    string dni = Validaciones.ValidaDNI(Console.ReadLine());
                    abml.ConsultaAlumno(dni);
                    break;
                case 3:
                    Console.WriteLine("Modificar");
                    break;
                case 4:
                    abml.ListaEmpleado();
                    break;
                case 5:
                    abml.CargarTipo();
                    break;
                case 6:
                    abml.CargarCarrera();
                    break;
                default:
                    if (opcion != 0)
                    {
                        Console.WriteLine("Fuera de rango");
                    }
                    break;
            }
        }
    }
}
