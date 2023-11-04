using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1EstructuradeDatos
{
    internal class Clsproductos
    {
        //Propiedades
        public static int codigo { get; set; }
        public static string nombre { get; set; }
        public static string tipo { get; set; }

        //contructor
        public Clsproductos(int codigo, string nombre, string tipo)
        {
            codigo = codigo;
            nombre = nombre;
            tipo = tipo;
        }
    }
}
