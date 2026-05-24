using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    internal class Program
    {

        #region Variables "LOCALES"
        static int indecisos;
        static int negativos;
        static int positivos;
        static double porcentajeIndecisos;
        static double porcentajeNegativos;
        static double porcentajePositivos;
        #endregion

        #region REGISTRAR OPCION
        static void RegistrarOpcion(int opcion)
        {
            if (opcion == 0)
            {
                positivos++;
            }
            else if (opcion == 1)
            {
                negativos++;
            }
            else if (opcion == 2)
            {
                indecisos++;
            }
        }
        #endregion

        #region PROCESAR ENCUESTA
        static void ProcesarEncuesta()
        {
            int total = positivos + negativos + indecisos;
            porcentajePositivos = ((double)positivos / total) * 100;
            porcentajeNegativos = ((double)negativos / total) * 100;
            porcentajeIndecisos = ((double)positivos / total) * 100;
        }
        #endregion

        #region SOLICITAR OPCION MENU
        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.WriteLine("1-Ingresar opinion");
            Console.WriteLine("2-Procesar y mostrar resultados encuesta");
            Console.WriteLine("3-Salir");
            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
        #endregion

        #region REGISTRAR ENCUESTA
        static void MostrarPantallaRegistrarEncuesta()
        {
            Console.WriteLine("0-Positivo");
            Console.WriteLine("1-Negativo");
            Console.WriteLine("2-Indeciso");
            Console.Write("Ingrese su opinion");
            int opinion = Convert.ToInt32(Console.ReadLine());
            RegistrarOpcion(opinion);
        }
        #endregion

        #region MOSTRAR RESULTADOS DE LA ENCUESTA
        static void MostrarPantallaProcesarMostrarResultadosEncuesta()
        {
            ProcesarEncuesta();
            Console.WriteLine("Positivos: " + porcentajePositivos + "%");
            Console.WriteLine("Negativos: " + porcentajeNegativos + "%");
            Console.WriteLine("Indecisos: " + porcentajeIndecisos + "%");
        }
        #endregion

        static void Main(string[] args)
        {
            int opcion;
            do
            {
                opcion = MostrarPantallaSolicitarOpcionMenu();
                switch (opcion)
                {
                    case 1:
                        {
                            MostrarPantallaRegistrarEncuesta(); break;
                        }
                    case 2:
                        {
                            MostrarPantallaProcesarMostrarResultadosEncuesta(); break;
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
