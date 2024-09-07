using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Programacion_Secuencial.Clases.Apps
{
    public class App3
    {
        public static double suma;
        public static double promedio;
        public static double respuestaNum;
        public static int cantidadNumeros;

        public static void SumaYPromedio()
        {
            Console.Clear();
            Console.WriteLine("Bienvenido al programa de suma y promedio de 4 numeros.\n");

            for (int i = 1; i <= 4; i++)
            {
                Console.Write($"Por favor digite el {i} numero: ");
                while(true)
                {
                    try
                    {
                        respuestaNum = Convert.ToDouble(Console.ReadLine());
                        break;
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                cantidadNumeros++;
                suma += respuestaNum;
            }

            promedio = suma / cantidadNumeros;

            ComprobacionSumaYPromedio();
        }

        public static void ComprobacionSumaYPromedio()
        {
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine($"La suma de esos numeros es: {suma}");
            Console.WriteLine($"El promedio de estos numero es: {promedio:F1}");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nPara volver al menu presione cualquier tecla");
            Console.ResetColor();
            Console.ReadKey();
            Menu.MenuProgram();
        }
    }
}
