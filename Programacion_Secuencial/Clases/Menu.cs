using System;
using System.Collections.Generic;
using System.Text;
using Programacion_Secuencial.Clases.Apps;

namespace Programacion_Secuencial.Clases
{
    public class Menu
    {
        public static int RespuestaMenu;
        public static void MenuProgram()
        {
            Console.Clear();
            Console.WriteLine(@"Bienvenido al programa de Programacion Secuencial

1- (App 1) SumaYProducto.
2- (App 2) TotalAPagar.
3- (App 3) SumaYPromedio.
4- Salir del programa");

            Console.Write("\nDigite su respuesta aqui: ");

            while (true)
            {
                try
                {
                    RespuestaMenu = Convert.ToInt32(Console.ReadLine());

                    if (RespuestaMenu >= 1 && RespuestaMenu <= 4)
                    {
                        switch (RespuestaMenu)
                        {
                            case 1:
                                App1.SumaYProducto();
                                break;

                            case 2:
                                App2.TotalAPagar();
                                break;

                            case 3:
                                App3.SumaYPromedio();
                                break;

                            case 4:
                                break;
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Por favor limitese a digitar uno de los numeros mostrados en pantalla");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }
    }
}
