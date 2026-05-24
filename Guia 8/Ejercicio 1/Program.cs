using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {
        #region variables "LOCALES"
        static int acumulador = 0;
        static int contador = 0;
        static int maximo = 0;
        static int minimo = 0;
        #endregion

        #region MENU DE OPCIONES
        static int MostrarMenuPantallaSolicitarOpcion()
        {
            Console.Clear();
            Console.WriteLine("1. Procesar un solo numero");
            Console.WriteLine("2. Procesar varios numeros");
            Console.WriteLine("3. Mostrar maximo y minimo");
            Console.WriteLine("4. Mostrar promedio");
            Console.WriteLine("5. Mostrar cantidad de numeros ingresados");
            Console.WriteLine("6. Reiniciar variables");
            Console.WriteLine("7. Salir");
            int opcion = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            return opcion;
        }
        #endregion

        #region SOLICITAR NUMERO
        static void MostrarPantallaSolicitarNumero()
        {
            Console.WriteLine("Ingrese un numero");
            int valor = Convert.ToInt32(Console.ReadLine());
            RegistrarValor(valor);
            Console.Clear();
        }
        #endregion

        #region REGISTRAR VALOR
        static void RegistrarValor(int valor)
        {
            acumulador += valor;
            contador++;
            if (contador == 1 || valor > maximo)
            {
                maximo = valor;
            }
            if (contador == 1 || valor < minimo)
            {
                minimo = valor;
            }
            Console.Clear();
        }
        #endregion

        #region SOLICITAR VARIOS NUMEROS
        static void MostrarPantallaSolicitarVariosNumeros()
        {
            string respuesta;
            do
            {
                MostrarPantallaSolicitarNumero();
                Console.WriteLine("¿Ingresar otro numero?(si-no)");
                respuesta = Console.ReadLine();
                Console.Clear();
            }
            while (respuesta == "si");
            Console.Clear();
        }
        #endregion

        #region MOSTRAR MAXIMO Y MINIMO
        static void MostrarPantallaMaximoYMinimo()
        {
            Console.Clear();
            Console.WriteLine("Maximo: " + maximo);
            Console.WriteLine("Minimo: " + minimo);
            Console.WriteLine("Presione cualquier tecla para volver al menu de opciones.");
            Console.ReadKey();
        }
        #endregion

        #region CALCULAR PROMEDIO
        static double CalcularPromedio()
        {
            return (double)acumulador / contador;
        }
        #endregion

        #region MOSTRAR PROMEDIO
        static void MostrarPantallaMostrarPromedio()
        {
            Console.Clear();
            double promedio = CalcularPromedio();
            Console.WriteLine("Promedio: " + promedio);
            Console.WriteLine("Presione cualquier tecla para volver al menu de opciones.");
            Console.ReadKey();
        }
        #endregion

        #region MOSTRAR CANTIDAD NUMEROS INGRESADOS
        static void MostrarPantallaCantidad()
        {
            Console.Clear();
            Console.WriteLine("Cantidad de numeros ingresados: " + contador);
            Console.WriteLine("Presione cualquier tecla para volver al menu de opciones.");
            Console.ReadKey();
        }
        #endregion

        #region MOSTRAR INICIAR VARIABLES
        static void MostrarIniciarVariables()
        {
            Console.Clear();
            acumulador = 0;
            contador = 0;
            maximo = 0;
            minimo = 0;
            Console.WriteLine("Variables reiniciadas.");
            Console.WriteLine("Presione cualquier tecla para volver al menu de opciones.");
            Console.ReadKey();
        }
        #endregion

        static void Main(string[] args)
        {
            int opcion;
            do
            {
                opcion = MostrarMenuPantallaSolicitarOpcion();
                switch (opcion)
                {
                    case 1:
                        {
                            MostrarPantallaSolicitarNumero(); break;
                        }
                    case 2:
                        {
                            MostrarPantallaSolicitarVariosNumeros(); break;
                        }
                    case 3:
                        {
                            MostrarPantallaMaximoYMinimo(); break;
                        }
                    case 4:
                        {
                            MostrarPantallaMostrarPromedio(); break;
                        }
                    case 5:
                        {
                            MostrarPantallaCantidad(); break;
                        }
                    case 6:
                        {
                            MostrarIniciarVariables(); break;
                        }
                    case 7:
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
            while (opcion != 7);
        }
    }
}