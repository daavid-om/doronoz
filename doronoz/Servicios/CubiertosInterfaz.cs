using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doronoz.Servicios
{
    /// <summary>
    /// Interfaz que complementa la funcionalidad de las opciones del menu
    /// 041223 - dom
    /// </summary>
    internal interface CubiertosInterfaz
    {
        /// <summary>
        /// Método que permite dar de alta un nuevo elemento
        /// 041223 - dom
        /// </summary>
        /// <returns></returns>
        public int DarAltaNuevoElemento();

        /// <summary>
        /// Método que permite modificar el stock del catering
        /// 041223 - dom
        /// </summary>
        /// <returns></returns>
        public int ModificarStock();
    }
}
