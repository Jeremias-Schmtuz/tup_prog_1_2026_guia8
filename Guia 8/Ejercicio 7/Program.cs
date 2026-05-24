using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    internal class Program
    {

        #region Variables "LOCALES"
        static int cantidad1;
        static int cantidad2;
        static int cantidad3;
        static int cantidad4;
        static int cantidad5;
        static int numeroTransaccionMayor;
        static int contadorDeTransacciones;
        static double montoTransaccionMayor;
        static double porcentajeCantidadRubro1;
        static double porcentajeCantidadRubro2;
        static double porcentajeCantidadRubro3;
        static double porcentajeCantidadRubro4;
        static double porcentajeCantidadRubro5;
        static double recaudacionTotal;
        #endregion

        #region INICIALIZAR VARIABLES
        static void InicializarVariables()
        {
            cantidad1 = 0;
            cantidad2 = 0;
            cantidad3 = 0;
            cantidad4 = 0;
            numeroTransaccionMayor = 0;
            contadorDeTransacciones = 0;
            montoTransaccionMayor = 0;
            porcentajeCantidadRubro1 = 0;
            porcentajeCantidadRubro2 = 0;
            porcentajeCantidadRubro3 = 0;
            porcentajeCantidadRubro4 = 0;
            porcentajeCantidadRubro5 = 0;
            recaudacionTotal = 0;
        }
        #endregion

        #region EVALUAR TRANSACCION PUNTO DE VENTA
        static void EvaluarTransaccionPuntoDeVenta(int nroTransaccion, int rubro, int cantidad, double monto)
        {
            if (rubro == 1)
                cantidad1 += cantidad;
            else if (rubro == 2)
                cantidad2 += cantidad;
            else if (rubro == 3)
                cantidad3 += cantidad;
            else if (rubro == 4)
                cantidad4 += cantidad;
            else if (rubro == 5)
                cantidad5 += cantidad;

            if (monto > montoTransaccionMayor)
            {
                montoTransaccionMayor = monto;
                numeroTransaccionMayor = nroTransaccion;
            }

            recaudacionTotal += monto;
        }
        #endregion

        #region CALCULAR PORCENTAJES DE LA CANTIDAD DE VENTAS POR RUBRO
        static void CalcularPorcentajesCantidadVentasPorRubro()
        {
            int totalCantidad = cantidad1 + cantidad2 + cantidad3 + cantidad4 + cantidad5;
            porcentajeCantidadRubro1 = (double)cantidad1 / totalCantidad * 100;
            porcentajeCantidadRubro2 = (double)cantidad2 / totalCantidad * 100;
            porcentajeCantidadRubro3 = (double)cantidad3 / totalCantidad * 100;
            porcentajeCantidadRubro4 = (double)cantidad4 / totalCantidad * 100;
            porcentajeCantidadRubro5 = (double)cantidad5 / totalCantidad * 100;
        }
        #endregion

        #region REGISTRAR TRANSACCION
        static void MostrarPantallaRegistrarTransaccion()
        {
            Console.WriteLine("Ingrese el numero de transaccion");
            int nroTransaccion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el rubro (1-5)");
            int rubro = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de productos vendidos");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el monto total");
            double monto = Convert.ToDouble(Console.ReadLine());
            EvaluarTransaccionPuntoDeVenta(nroTransaccion, rubro, cantidad, monto);
        }
        #endregion

        #region MOSTRAR PORCENTAJES DE CANTIDADES POR RUBRO
        static void MostrarPantallaPorcentajeDeCantidadesPorRubro()
        {
            CalcularPorcentajesCantidadVentasPorRubro();
            Console.WriteLine("Rubro 1: " + porcentajeCantidadRubro1 + "%");
            Console.WriteLine("Rubro 2: " + porcentajeCantidadRubro2 + "%");
            Console.WriteLine("Rubro 3: " + porcentajeCantidadRubro3 + "%");
            Console.WriteLine("Rubro 4: " + porcentajeCantidadRubro4 + "%");
            Console.WriteLine("Rubro 5: " + porcentajeCantidadRubro5 + "%");
        }
        #endregion

        #region MOSTRAR MAYOR TRANSACCION + MONTO
        static void MostrarPantallaTransaccionMayorMonto()
        {
            Console.WriteLine("Numero de transaccion: " + numeroTransaccionMayor);
            Console.WriteLine("Monto: " + montoTransaccionMayor);
        }
        #endregion

        #region MOSTRAR MONTO RECAUDACION TOTAL
        static void MostrarPantallaMontoRecaudadoTotal()
        {
            Console.WriteLine("Recaudacion total: " + recaudacionTotal);
        }
        #endregion

        #region SOLICITAR OPCION MENU
        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.WriteLine("1-Ingresar un resumen de venta");
            Console.WriteLine("2-Mostrar numero de transaccion con mayor monto");
            Console.WriteLine("3-Mostrar porcentaje de cantidad por rubro");
            Console.WriteLine("4-Mostrar la recaudacion total");
            Console.WriteLine("5-Salir");
            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
        #endregion

        static void Main(string[] args)
        {
            InicializarVariables();
            int opcion;
            do
            {
                opcion = MostrarPantallaSolicitarOpcionMenu();
                switch (opcion)
                {
                    case 1:
                        {
                            MostrarPantallaRegistrarTransaccion(); break;
                        }
                    case 2:
                        {
                            MostrarPantallaTransaccionMayorMonto(); break;
                        }
                    case 3:
                        {
                            MostrarPantallaPorcentajeDeCantidadesPorRubro(); break;
                        }
                    case 4:
                        {
                            MostrarPantallaMontoRecaudadoTotal(); break;
                        }
                    case 5:
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
            while (opcion != 5);
        }
    }
}