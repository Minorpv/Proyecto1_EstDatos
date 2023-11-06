using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1EstructuradeDatos
{
    internal class ClsProductos
    {
        public static string codigo { get; set; }
        public static string Nombre { get; set; }
        public static string Tipo { get; set;}

        public static int[] InicializarArrayCod()
        {
            int[] CodArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            return CodArray;
        }
        public static string[] InicializarArrayNomProd()
        {
            string[] NomArray = { "Pollo", "Cerdo", "Pescado", "Lasagna", "Espaguetti", "Bebida natural", "Agua", "Gaseosa", "Té", "Café" };
            return NomArray;
        }
        public static string[] InicializarArrayTipo()
        {
            string[] NomArray = { "Plato fuerte", "Plato fuerte" , "Plato fuerte" , "Plato fuerte" , "Plato fuerte" , "Bebida", "Bebida" , "Bebida" , "Bebida" , "Bebida" };
            return NomArray;
        }
    }

}
