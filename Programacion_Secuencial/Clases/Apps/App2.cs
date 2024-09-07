using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Programacion_Secuencial.Clases.Apps
{
    public class App2
    {
        public static double PrecioArt;
        public static int CantidadArt;

        public static void TotalAPagar()
        {
            Console.Clear();
            Console.WriteLine("Bienvenido al programa de compra de articulos.\n");

            Console.Write("Favor introducir el precio del articulo: ");

            while (true)
            {
                try
                {
                    PrecioArt = Convert.ToDouble(Console.ReadLine());

                    if (PrecioArt >= 1)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Por favor introduzca una cantidad valida.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine("\nFavor introducir la cantidad del articulo a comprar: ");

            while (true)
            {
                try
                {
                    CantidadArt = Convert.ToInt32(Console.ReadLine());

                    if (CantidadArt >= 1)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Por favor introduzca una cantidad valida.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            ComprobacionDeAbono();
        }

        public static void ComprobacionDeAbono()
        {
            Thread.Sleep(3000);
            Console.Clear();
            double abono = PrecioArt * CantidadArt;
            Console.WriteLine($"La cantidad a abonar de parte del comprador es: {abono:F2}");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nPara volver al menu presione cualquier tecla");
            Console.ResetColor();
            Console.ReadKey();
            Menu.MenuProgram();
        }
    }
}
