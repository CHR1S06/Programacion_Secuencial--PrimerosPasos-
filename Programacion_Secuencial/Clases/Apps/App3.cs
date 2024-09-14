using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Programacion_Secuencial.Clases.Apps
{
    public class App3
    {
        // Variables para almacenar la suma, el promedio y el número ingresado por el usuario
        private double suma;
        private double promedio;
        private double respuestaNum;
        private int cantidadNumeros;

        // Método principal que calcula la suma y el promedio de 4 números
        public void SumaYPromedio()
        {
            // Limpia la pantalla de la consola
            Console.Clear();
            // Muestra un mensaje de bienvenida al usuario
            Console.WriteLine("Bienvenido al programa de suma y promedio de 4 numeros.\n");

            // Bucle que itera 4 veces para pedir al usuario que ingrese 4 números
            for (int i = 1; i <= 4; i++)
            {
                // Solicita al usuario que introduzca el número correspondiente
                Console.Write($"Por favor digite el {i} numero: ");
                while (true)
                {
                    try
                    {
                        // Lee la entrada del usuario y la convierte a un número decimal
                        respuestaNum = Convert.ToDouble(Console.ReadLine());
                        break; // Sale del bucle si la entrada es válida
                    }
                    catch (Exception ex)
                    {
                        // Muestra un mensaje de error si ocurre una excepción
                        Console.WriteLine(ex.Message);
                    }
                }

                // Incrementa el contador de números
                cantidadNumeros++;
                // Suma el número ingresado a la variable suma
                suma += respuestaNum;
            }

            // Calcula el promedio dividiendo la suma entre la cantidad de números
            promedio = suma / cantidadNumeros;

            // Llama al método que muestra los resultados
            ComprobacionSumaYPromedio();
        }

        // Método que muestra la suma y el promedio de los números ingresados
        public void ComprobacionSumaYPromedio()
        {
            // Hace una pausa de 3 segundos antes de continuar
            Thread.Sleep(3000);
            // Limpia la pantalla de la consola
            Console.Clear();
            // Muestra la suma de los números
            Console.WriteLine($"La suma de esos numeros es: {suma}");
            // Muestra el promedio de los números, formateado a un decimal
            Console.WriteLine($"El promedio de estos numero es: {promedio:F1}");

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
