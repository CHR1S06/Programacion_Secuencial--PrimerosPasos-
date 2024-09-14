using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Programacion_Secuencial.Clases.Apps
{
    public class App1
    {
        // Variables para almacenar los números ingresados por el usuario
        private int PrimerNum, SegundoNum;

        // Método principal que maneja la entrada de datos y la lógica del programa
        public void SumaYProducto()
        {
            // Limpia la pantalla de la consola
            Console.Clear();
            // Muestra un mensaje de bienvenida al usuario
            Console.WriteLine("Bienvenido al programa de suma y producto.\n");

            // Solicita el primer número al usuario
            Console.Write("Introduzca el primer numero: ");
            while(true)
            {
                try
                {
                    // Lee la entrada del usuario y la convierte a un número entero
                    PrimerNum = Convert.ToInt32(Console.ReadLine());

                    // Verifica que el número no sea negativo
                    if (PrimerNum>=0)
                    {
                        break; // Sale del bucle si el número es válido
                    }
                    else
                    {
                        // Muestra un mensaje de error si el número es negativo
                        Console.WriteLine("Por favor introduzca un numero entero.");
                    }
                }
                catch(Exception ex)
                {
                    // Muestra el mensaje de error si ocurre una excepción
                    Console.WriteLine(ex.Message);
                }
            }

            // Solicita el segundo número al usuario
            Console.Write("Introduzca el segundo numero: ");
            while (true)
            {
                try
                {
                    // Lee la entrada del usuario y la convierte a un número entero
                    SegundoNum = Convert.ToInt32(Console.ReadLine());

                    // Verifica que el número sea no negativo
                    if (SegundoNum >= 0)
                    {
                        break; // Sale del bucle si el número es válido
                    }
                    else
                    {
                        // Muestra un mensaje de error si el número es negativo
                        Console.WriteLine("Por favor introduzca un numero entero.");
                    }
                }
                catch (Exception ex)
                {
                    // Muestra el mensaje de error si ocurre una excepción
                    Console.WriteLine(ex.Message);
                }
            }

            // Llama al método que muestra los resultados de las operaciones
            ComprobacionDeResultados();
        }

        // Método que calcula y muestra los resultados de la suma y el producto
        public void ComprobacionDeResultados()
        {
            // Hace una pausa de 3 segundos antes de continuar
            Thread.Sleep(3000);
            // Limpia la pantalla de la consola
            Console.Clear();

            // Calcula la suma y el producto de los dos números
            int suma = PrimerNum + SegundoNum;
            int producto = PrimerNum * SegundoNum;

            // Muestra los resultados en la consola
            Console.WriteLine($"La suma de esos dos numeros es: {suma}");
            Console.WriteLine($"El producto de estos numero es: {producto}");

            // Cambia el color del texto a verde para el mensaje final
            Console.ForegroundColor = ConsoleColor.Green;
            // Muestra un mensaje para que el usuario vuelva al menú
            Console.WriteLine("\nPara volver al menu presione cualquier tecla");
            // Restablece el color del texto a su valor predeterminado
            Console.ResetColor();
            // Espera a que el usuario presione una tecla
            Console.ReadKey();

            // Crea una nueva instancia del menú y lo muestra
            Menu menu = new Menu();
            menu.MenuProgram();
        }
    }
}
