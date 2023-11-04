using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1EstructuradeDatos
{
    internal class ClsPedidos
    {
        public int codigo { get; set; }
        public string cliente { get; set; }
        public string productos { get; set; }
        public string horaComienzo { get; set; }

        public ClsPedidos(string cliente, string productos, string horaComienzo)
        {
            this.codigo = codigo;
            this.cliente = cliente;
            this.productos = productos;
            this.horaComienzo = horaComienzo;
        }
    }

}
