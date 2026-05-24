using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        #region Variables "LOCALES"
        static int edad1;
        static int edad2;
        static int edad3;
        static int edad4;
        static int edad;
        static double monto;
        static double porcentaje1;
        static double porcentaje2;
        static double porcentaje3;
        static double porcentaje4;
        static double monto1;
        static double monto2;
        static double monto3;
        static double monto4;
        #endregion

        #region REGISTRAR MONTO A REPARTIR
        static void RegistrarMontoARepartir()
        {
            monto = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
        }
        #endregion

        #region REGISTRAR EDAD
        static double RegistrarEdad()
        {
            edad1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            edad2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            edad3 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            edad4 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            edad = edad1 + edad2 + edad3 + edad4;
            return edad;
        }
        #endregion

        #region CALCULAR MONTOS Y PORCENTAJES
        static void CalcularMontosYPorcentajesARepartir()
        {
            if (edad != 0)
            {
                porcentaje1 = ((double)edad1 / edad) * 100;
                porcentaje2 = ((double)edad2 / edad) * 100;
                porcentaje3 = ((double)edad3 / edad) * 100;
                porcentaje4 = ((double)edad4 / edad) * 100;
                monto1 = (porcentaje1 / 100) * monto;
                monto2 = (porcentaje2 / 100) * monto;
                monto3 = (porcentaje3 / 100) * monto;
                monto4 = (porcentaje4 / 100) * monto;
            }
        }
        #endregion

        #region MOSTRAR MENU Y SOLICITAR OPCION
        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.WriteLine("1-Ingresar monto a repartir");
            Console.WriteLine("2-Ingresar edad por niña");
            Console.WriteLine("3-Mostrar monto y porcentajes que corresponden a cada niña");
            Console.WriteLine("4-Salir");
            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
        #endregion

        #region SOLICITAR MONTO
        static void MostrarPantallaSolicitarMontoARepartir()
        {
            Console.Clear();
            Console.WriteLine("Ingrese monto a repartir");
        }
        #endregion

        #region SOLICITAR EDADES(NIÑAS)
        static void MostrarPantallaSolicitarEdadesNiñas()
        {
            Console.Clear();
            Console.WriteLine("Ingrese la edad de las 4 niñas");
        }
        #endregion

        #region MOSTRAR MONTO Y PORCENTAJE(POR NIÑA)
        static void MostrarPantallaMostrarMontoYPorcentajePorNiña()
        {
            Console.Clear();
            Console.WriteLine("El monto de la niña 1 es: " + monto1 + " , y el porcentaje es: " + porcentaje1);
            Console.WriteLine("El monto de la niña 2 es: " + monto2 + " , y el porcentaje es: " + porcentaje2);
            Console.WriteLine("El monto de la niña 3 es: " + monto3 + " , y el porcentaje es: " + porcentaje3);
            Console.WriteLine("El monto de la niña 4 es: " + monto4 + " , y el porcentaje es: " + porcentaje4);
            Console.WriteLine("Precione cualquier tecla para voler al menu de opciones.");
            Console.ReadKey();
            Console.Clear();
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
                            MostrarPantallaSolicitarMontoARepartir();
                            RegistrarMontoARepartir(); break;
                        }
                    case 2:
                        {
                            MostrarPantallaSolicitarEdadesNiñas();
                            RegistrarEdad(); break;
                        }
                    case 3:
                        {
                            if (monto > 0 && edad > 0)
                            {
                                CalcularMontosYPorcentajesARepartir();
                                MostrarPantallaMostrarMontoYPorcentajePorNiña(); break;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Monto o edades no ingresadas anteriormente");
                                Console.WriteLine("Redirigiendo al menu de opciones...");
                                Thread.Sleep(2500);
                                Console.Clear();
                            }
                            ; break;
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