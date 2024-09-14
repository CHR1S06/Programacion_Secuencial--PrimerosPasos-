using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Programacion_Secuencial.Clases.Apps
{
    public class App2
    {
        // Variables para almacenar el precio y la cantidad del artículo
        private double PrecioArt;
        private int CantidadArt;

        // Método principal que maneja la entrada de datos y el cálculo del total a pagar
        public void TotalAPagar()
        {
            // Limpia la pantalla de la consola
            Console.Clear();
            // Muestra un mensaje de bienvenida al usuario
            Console.WriteLine("Bienvenido al programa de compra de articulos.\n");

            // Solicita el precio del artículo al usuario
            Console.Write("Favor introducir el precio del articulo: ");

            while (true)
            {
                try
                {
                    // Lee la entrada del usuario y la convierte a un número decimal
                    PrecioArt = Convert.ToDouble(Console.ReadLine());

                    // Verifica que el precio sea mayor o igual a 1
                    if (PrecioArt >= 1)
                    {
                        break; // Sale del bucle si el precio es válido
                    }
                    else
                    {
                        // Muestra un mensaje de error si el precio es menor que 1
                        Console.WriteLine("Por favor introduzca una cantidad valida.");
                    }
                }
                catch (Exception ex)
                {
                    // Muestra el mensaje de error si ocurre una excepción
                    Console.WriteLine(ex.Message);
                }
            }

            Console.Write("");//salto de linea
            // Solicita la cantidad del artículo al usuario
            Console.Write("Favor introducir la cantidad del articulo a comprar: ");

            while (true)
            {
                try
                {
                    // Lee la entrada del usuario y la convierte a un número entero
                    CantidadArt = Convert.ToInt32(Console.ReadLine());

                    // Verifica que la cantidad sea mayor o igual a 1
                    if (CantidadArt >= 1)
                    {
                        break; // Sale del bucle si la cantidad es válida
                    }
                    else
                    {
                        // Muestra un mensaje de error si la cantidad es menor que 1
                        Console.WriteLine("Por favor introduzca una cantidad valida.");
                    }
                }
                catch (Exception ex)
                {
                    // Muestra el mensaje de error si ocurre una excepción
                    Console.WriteLine(ex.Message);
                }
            }

            // Llama al método que calcula y muestra el total a pagar
            ComprobacionDeAbono();
        }

        // Método que calcula y muestra el total a pagar
        public void ComprobacionDeAbono()
        {
            // Hace una pausa de 3 segundos antes de continuar
            Thread.Sleep(3000);
            // Limpia la pantalla de la consola
            Console.Clear();
            // Calcula el total a pagar multiplicando el precio por la cantidad
            double abono = PrecioArt * CantidadArt;
            // Muestra el total a pagar en la consola, formateado a dos decimales
            Console.WriteLine($"La cantidad a abonar de parte del comprador es: {abono:F2}");

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
