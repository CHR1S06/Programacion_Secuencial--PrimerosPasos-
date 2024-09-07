using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Programacion_Secuencial.Clases.Apps
{
    public class App1
    {
        public static int PrimerNum, SegundoNum;
        public static void SumaYProducto()
        {
            Console.Clear();
            Console.WriteLine("Bienvenido al programa de suma y producto.\n");

            Console.Write("Introduzca el primer numero: ");
            while(true)
            {
                try
                {
                    PrimerNum = Convert.ToInt32(Console.ReadLine());
                    
                    if(PrimerNum>=0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Por favor introduzca un numero entero.");
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.Write("Introduzca el segundo numero: ");
            while (true)
            {
                try
                {
                    SegundoNum = Convert.ToInt32(Console.ReadLine());

                    if (SegundoNum >= 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Por favor introduzca un numero entero.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            ComprobacionDeResultados();
        }

        public static void ComprobacionDeResultados()
        {
            Thread.Sleep(3000);
            Console.Clear();
            int suma = PrimerNum + SegundoNum;
            int producto = PrimerNum * SegundoNum;
            Console.WriteLine($"La suma de esos dos numeros es: {suma}");
            Console.WriteLine($"El producto de estos numero es: {producto}");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nPara volver al menu presione cualquier tecla");
            Console.ResetColor();
            Console.ReadKey();
            Menu.MenuProgram();
        }
    }
}
