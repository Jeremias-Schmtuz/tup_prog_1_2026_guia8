using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Program
    {

        #region Variables "LOCALES"
        static string jugador1;
        static string jugador2;
        static int setGanados1;
        static int setGanados2;
        #endregion

        #region REGISTRAR JUGADORES
        static void RegistrarJugadores(string nombre1, string nombre2)
        {
            jugador1 = nombre1;
            jugador2 = nombre2;
        }
        #endregion

        #region REGISTRAR RESULTADOS SETS
        static void RegistrarResultadosSets(int resultado1, int resultado2)
        {
            if (resultado1 > resultado2)
            {
                setGanados1++;
            }
            else
            {
                setGanados2++;
            }
        }
        #endregion

        #region DETERMINAR GANADOR
        static string DeterminarGanador()
        {
            if (setGanados1 > setGanados2)
            {
                return jugador1;
            }
            else
            {
                return jugador2;
            }
        }
        #endregion

        #region SOLICITAR OPCION MENU
        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.WriteLine("1-Ingresar los nombres de los juegadores");
            Console.WriteLine("2-Ingresar los resultados de cada set de los jugadores");
            Console.WriteLine("3-Mostrar el ganador");
            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
        #endregion

        #region SOLICITAR NOMBRE DE LOS JUGADORES
        static void MostrarPantallaSolicitarNombreJugadores()
        {
            Console.WriteLine("-REGISTRO DE JUGADORES-");
            Console.WriteLine("Ingrese nombre de jugador 1");
            string nombre1 = Console.ReadLine();
            Console.WriteLine("Ingrese nombre de jugdaor 2");
            string nombre2 = Console.ReadLine();
            RegistrarJugadores(nombre1, nombre2);
        }
        #endregion

        #region SOLICITAR RESULTADOS
        static void MostrarPantallaSolicitarResultados()
        {
            for(int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"-REGISTRAR RESULTADOS SET {i}-");
                Console.Write("Ingrese el resultado del jugador 1:");
                int resultado1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese el resultado del jugador 2:");
                int resultado2 = Convert.ToInt32(Console.ReadLine());
                RegistrarResultadosSets(resultado1, resultado2);
            }
        }
        #endregion

        #region MOSTRAR GANADOR
        static void MostrarPantallaGanador()
        {
            Console.WriteLine("El ganador es: " + DeterminarGanador());
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
                            MostrarPantallaSolicitarNombreJugadores(); break;
                        }
                    case 2:
                        {
                            MostrarPantallaSolicitarResultados(); break;
                        }
                    case 3:
                        {
                            MostrarPantallaGanador(); break;
                        }
                    case 4:
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
            while (opcion != 4);
        }
    }
}