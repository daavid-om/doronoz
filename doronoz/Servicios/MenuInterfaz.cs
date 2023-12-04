using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doronoz.Servicios
{
    /// <summary>
    /// Interfaz que relaciona la funcionalidad de la aplicación
    /// 041223 - dom
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Método que muestra un mensaje de bienvenida
        /// 041223 - dom
        /// </summary>
        public void MostrarMensajeBienvenida();

        /// <summary>
        /// Método que muestra un menú y recoge la opción del usuario
        /// 041223 - dom
        /// </summary>
        /// <returns></returns>
        public int MostrarYMenu();
    }
}
