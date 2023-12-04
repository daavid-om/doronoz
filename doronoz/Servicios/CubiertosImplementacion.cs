using doronoz.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doronoz.Servicios
{
    /// <summary>
    /// Implementacion que relaciona con la interfaz de las funciones de la aplicación
    /// 041223 - dom
    /// </summary>
    internal class CubiertosImplementacion : CubiertosInterfaz
    {
        public int DarAltaNuevoElemento()
        {
            int DarAlta;
        Console.WriteLine("Ingrese el nombre del cubierto: ");
            Console.WriteLine("Ingrese la cantidad del elemento");
            Console.WriteLine("Ingrese la descripción del elemento: ");
            Console.WriteLine("Ingrese el id del elemento: ");

            return DarAlta = Console.ReadKey().KeyChar - ('0');
        }

        public int ModificarStock()
        {

        }
    }
}
