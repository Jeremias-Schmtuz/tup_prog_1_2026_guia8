using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Program
    {
        #region Variables "LOCALES"
        static string nombre1;
        static string nombre2;
        static string nombre3;
        static int numeroLibreta1;
        static int numeroLibreta2;
        static int numeroLibreta3;
        static int orden;
        #endregion

        #region REGISTRAR NOMBRES Y NUMEROS DE LIBRETAS
        static void RegistrarNombresYNumerosDeLibretas()
        {
            nombre1 = Program.MostrarPantallaSolicitarAlumno();
            numeroLibreta1 = Program.SolicitarNumeroDeLibretas();
            nombre2 = Program.MostrarPantallaSolicitarAlumno();
            numeroLibreta2 = Program.SolicitarNumeroDeLibretas();
            nombre3 = Program.MostrarPantallaSolicitarAlumno();
            numeroLibreta3 = Program.SolicitarNumeroDeLibretas();
        }
        #endregion

        #region SOLICITAR ALUMNNO
        static string MostrarPantallaSolicitarAlumno()
        {
            string nombre;
            Console.WriteLine("Ingrese nombre del alumno");
            nombre = Console.ReadLine();
            return nombre;
        }
        #endregion

        #region SOLICITAR NUMERO DE LIBRETA
        static int SolicitarNumeroDeLibretas()
        {
            int numeroLibreta;
            Console.WriteLine("Ingrese numero de libreta del alumno");
            numeroLibreta = Convert.ToInt32(Console.ReadLine());
            return numeroLibreta;
        }
        #endregion

        #region MOSTRAR LISTA ORDENADA
        static void MostrarPantallaMostrarListaOrdenada()
        {
            if (numeroLibreta1 > numeroLibreta2 && numeroLibreta1 > numeroLibreta3)
            {
                if (numeroLibreta2 > numeroLibreta3)
                {
                    Console.WriteLine(nombre1 + " / " + numeroLibreta1 + "\n" + nombre2 + " / " + numeroLibreta2 + "\n" + nombre3 + " / " + numeroLibreta3);
                }
                else
                {
                    Console.WriteLine(nombre1 + " / " + numeroLibreta1 + "\n" + nombre3 + " / " + numeroLibreta3 + "\n" + nombre2 + " / " + numeroLibreta2);
                }
            }
            else if (numeroLibreta2 > numeroLibreta1 && numeroLibreta2 > numeroLibreta3)
            {
                if (numeroLibreta1 > numeroLibreta3)
                {
                    Console.WriteLine(nombre2 + " / " + numeroLibreta2 + "\n" + nombre1 + " / " + numeroLibreta1 + "\n" + nombre3 + " / " + numeroLibreta3);
                }
                else
                {
                    Console.WriteLine(nombre2 + " / " + numeroLibreta2 + "\n" + nombre3 + " / " + numeroLibreta3 + "\n" + nombre1 + " / " + numeroLibreta1);
                }
            }
            else if (numeroLibreta3 > numeroLibreta1 && numeroLibreta3 > numeroLibreta2)
            {
                if (numeroLibreta1 > numeroLibreta2)
                {
                    Console.WriteLine(nombre3 + " / " + numeroLibreta3 + "\n" + nombre1 + " / " + numeroLibreta1 + "\n" + nombre2 + " / " + numeroLibreta2);
                }
                else
                {
                    Console.WriteLine(nombre3 + " / " + numeroLibreta3 + "\n" + nombre2 + " / " + numeroLibreta2 + "\n" + nombre1 + " / " + numeroLibreta1);
                }
            }
        }
        #endregion

        #region SOLICITAR OPCION
        static int MostrarPantallaSolicitarOpcion()
        {
            int opcion;
            Console.WriteLine("1-Ingresar las notas de los 3 alumnos + numero de libretas");
            Console.WriteLine("2-Mostrar lista ordenada");
            Console.WriteLine("3-Salir");
            opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
        #endregion

        static void Main(string[] args)
        {
            int opcion;
            do
            {
                opcion = MostrarPantallaSolicitarOpcion();
                switch (opcion)
                {
                    case 1:
                        {
                            RegistrarNombresYNumerosDeLibretas(); break;
                        }
                    case 2:
                        {
                            MostrarPantallaMostrarListaOrdenada(); break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Saliendo..."); Thread.Sleep(500); break;
                        }
                    default:
                        {
                            Console.WriteLine("Opcion invalida");
                            Console.WriteLine("Redirigiendo al menu de opciones...");
                            Thread.Sleep(2500);
                            break;
                        }
                }
            }
            while (opcion != 3);
        }
    }
}