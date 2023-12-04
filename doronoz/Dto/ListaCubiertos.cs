using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doronoz.Dto
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    internal class ListaCubiertos 
    {
        private long idElemento;
        private string codigoElemento;
        private string nombreElemento;
        private string descripcionElemento;
        private int cantidadElemento;

        public ListaCubiertos(){}

        public ListaCubiertos(long idElemento, string codigoElemento, string nombreElemento, string descripcionElemento, int cantidadElemento)
        {
            this.idElemento = idElemento;
            this.codigoElemento = codigoElemento;
            this.nombreElemento = nombreElemento;
            this.descripcionElemento = descripcionElemento;
            this.cantidadElemento = cantidadElemento;
        }

        public long IdElemento { get => idElemento; set => idElemento = value; }
        public string CodigoElemento { get => codigoElemento; set => codigoElemento = value; }
        public string NombreElemento { get => nombreElemento; set => nombreElemento = value; }
        public string DescripcionElemento { get => descripcionElemento; set => descripcionElemento = value; }
        public int CantidadElemento { get => cantidadElemento; set => cantidadElemento = value; }

        public override bool Equals(object? obj)
        {
            return obj is ListaCubiertos cubiertos &&
                   idElemento == cubiertos.idElemento &&
                   codigoElemento == cubiertos.codigoElemento &&
                   nombreElemento == cubiertos.nombreElemento &&
                   descripcionElemento == cubiertos.descripcionElemento &&
                   cantidadElemento == cubiertos.cantidadElemento;
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
