using System;
using System.Collections.Generic;
using System.Text;
using Programacion_Secuencial.Clases.Apps;

namespace Programacion_Secuencial.Clases
{
    public class Menu
    {
        // Variable para almacenar la opción seleccionada por el usuario en el menú
        private int RespuestaMenu;

        // Método que muestra el menú y maneja la selección del usuario
        public void MenuProgram()
        {
            // Limpia la pantalla de la consola
            Console.Clear();
            // Muestra el menú con las opciones disponibles
            Console.WriteLine(@"Bienvenido al programa de Programacion Secuencial

1- (App 1) SumaYProducto.
2- (App 2) TotalAPagar.
3- (App 3) SumaYPromedio.
4- Salir del programa");

            // Solicita al usuario que ingrese su respuesta
            Console.Write("\nDigite su respuesta aqui: ");

            while (true)
            {
                try
                {
                    // Lee la entrada del usuario y la convierte a un número entero
                    RespuestaMenu = Convert.ToInt32(Console.ReadLine());

                    // Verifica si la opción ingresada está dentro del rango permitido
                    if (RespuestaMenu >= 1 && RespuestaMenu <= 4)
                    {
                        // Ejecuta el programa correspondiente basado en la opción seleccionada
                        switch (RespuestaMenu)
                        {
                            case 1:
                                // Crea una instancia de App1 y llama al método SumaYProducto
                                App1 app1 = new App1();
                                app1.SumaYProducto();
                                break;

                            case 2:
                                // Crea una instancia de App2 y llama al método TotalAPagar
                                App2 app2 = new App2();
                                app2.TotalAPagar();
                                break;

                            case 3:
                                // Crea una instancia de App3 y llama al método SumaYPromedio
                                App3 app3 = new App3();
                                app3.SumaYPromedio();
                                break;

                            case 4:
                                // Sale del programa si el usuario selecciona la opción 4
                                return;
                        }
                        // Sale del bucle si la opción es válida
                        break;
                    }
                    else
                    {
                        // Muestra un mensaje de error si la opción no está dentro del rango permitido
                        Console.WriteLine("Por favor limitese a digitar uno de los numeros mostrados en pantalla");
                    }
                }
                catch (Exception ex)
                {
                    // Muestra un mensaje de error si ocurre una excepción
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
