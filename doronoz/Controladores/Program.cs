using doronoz.Dto;
using doronoz.Servicios;

namespace doronoz
{
    /// <summary>
    /// Clase principal de la aplicación
    /// 041223 - dom
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método principal de la aplicación
        /// 041223 - dom
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args, List<ListaCubiertos> list)
        {
            List<string> value = ["Elemento", "Nombre", "Cantidad"];
            List<string> names = value;
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            //creamos los objetos
            MenuInterfaz mi = new MenuImplementacion();
            CubiertosInterfaz ci = new CubiertosImplementacion();

            //variable que controla la entrada y salida del menú
            bool cerrarMenu = false;

            int opcionIntroducida;

            int opcion1;

            int opcion2;
            while (!cerrarMenu)
            {
                opcionIntroducida = mi.MostrarYMenu();
                opcion1 = ci.DarAltaNuevoElemento();
                opcion2 = ci.ModificarStock();

                switch (opcionIntroducida)
                {
                   case 0:
                        Console.WriteLine(" [INFO] Se cierra la aplicación");
                        cerrarMenu = true;
                        break;
                        case 1:
                        Console.WriteLine(" [INFO] Se ejecuta la opción 1.");
                        opcion1 ;
                        break;
                        case 2:
                        Console.WriteLine(" [INFO] Se ejecuta la opción 2.");
                        
                        break;
                        
                }
            }
        }
    }
}