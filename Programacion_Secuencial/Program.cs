using Programacion_Secuencial.Clases;
using System;

namespace Programacion_Secuencial
{
    public class Program
    {
        // Método principal que es el punto de entrada del programa
        static void Main(string[] args)
        {
            // Crea una instancia de la clase Menu
            Menu menu = new Menu();

            // Llama al método MenuProgram para mostrar el menú y manejar la selección del usuario
            menu.MenuProgram();
        }
    }
}
