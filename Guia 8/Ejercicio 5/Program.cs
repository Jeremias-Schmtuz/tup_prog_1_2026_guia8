using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    internal class Program
    {

        #region DETERMINAR LOS DIAS DEL MES
        static int DeterminarLosDiasDelMes(int mes, int año)
        {
            int dias;
            if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
            {
                dias = 31;
            }
            else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
            {
                dias = 30;
            }
            else
            {
                if (DeterminarSiEsBisiesto(año))
                {
                    dias = 29;
                }
                else
                {
                    dias = 28;
                }
            }
            return dias;
        }
        #endregion

        #region DETERMINAR SI ES BISIESTO
        static bool DeterminarSiEsBisiesto(int año)
        {
            if (año % 4 == 0 && año % 100 != 0)
            {
                return true;
            }
            else if (año % 400 == 0)
                return true;
            else
            {
                return false;
            }
        }
        #endregion

        #region SOLICITAR OPCION MENU
        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.WriteLine("1-Determinar cantidad de dias del mes");
            Console.WriteLine("2-Determinar si el año es bisiesto");
            Console.WriteLine("3-Salir");
            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
        #endregion

        #region SOLICITAR MES DEL AÑO Y DETERMINAR DIAS
        static void MostrarPantallaSolicitarMesAñoYDeterminarDias()
        {
            Console.WriteLine("Ingrese el mes");
            int mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el año");
            int año = Convert.ToInt32(Console.ReadLine());
            int dias = DeterminarLosDiasDelMes(mes, año);
            Console.WriteLine("El mes tiene " + dias + " dias");
        }
        #endregion

        #region VERIFICAR SI EL AÑO ES BISIESTO
        static void MostrarPantallaVerifcarSiElAñoEsBisiesto()
        {
            Console.WriteLine("Ingrese el año");
            int año = Convert.ToInt32(Console.ReadLine());
            if (DeterminarSiEsBisiesto(año))
            {
                Console.WriteLine("El año " + año + " es bisiesto");
            }
            else
            {
                Console.WriteLine("El año " + año + " no es bisiesto");
            }
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
                            MostrarPantallaSolicitarMesAñoYDeterminarDias(); break;
                        }
                    case 2:
                        {
                            MostrarPantallaVerifcarSiElAñoEsBisiesto(); break;
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
            } while (opcion != 3);
        }
    }
}
