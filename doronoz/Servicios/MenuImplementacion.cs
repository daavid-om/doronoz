using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doronoz.Servicios
{
    /// <summary>
    /// Implementación que relaciona la interfaz de la aplicación
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public void MostrarMensajeBienvenida()
        {
            string mensaje = "Bienvenido al stock del catering";
            Console.WriteLine(mensaje);
        }

        public int MostrarYMenu()
        {
            int mostrarMenu;

            Console.WriteLine("###############");
            Console.WriteLine("0. Cerrar menu");
            Console.WriteLine("1. Darse de alta nuevo elemento");
            Console.WriteLine("2. Modificar elementos");
            Console.WriteLine("###############");
            Console.WriteLine("Elija una opción (0, 1 o 2): ");

            return mostrarMenu = Console.ReadKey().KeyChar - ('0');
        }
    }
}
