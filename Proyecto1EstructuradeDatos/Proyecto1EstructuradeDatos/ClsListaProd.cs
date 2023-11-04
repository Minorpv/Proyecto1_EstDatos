using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1EstructuradeDatos
{
    internal class ClsListaProd
    {
        //propiedades o atributos
        public static List<Clsproductos> Lista_prod { get; set; }
        public static int prod_codigo { get; set; }
        public static string prod_nombre { get; set; }
        public static string prod_tipo { get; set; }

        //constructor
        public ClsListaProd(List<Clsproductos> lista_prod, string prod_codigo, string prod_nombre, string prod_tipo)
        {
            Lista_prod = lista_prod;
            prod_codigo = prod_codigo;
            prod_nombre = prod_nombre;
            prod_tipo = prod_tipo;
        }
        //metodos
        public static void inicializarLista() 
        {
            //Al entrar al programa inicializa la lista con estos dato:
            ClsListaProd.Lista_prod = new List<Clsproductos>();
            Lista_prod.Add(new Clsproductos(1, "Pollo", "Plato fuerte"));
            Lista_prod.Add(new Clsproductos(2, "Cerdo", "Plato fuerte"));
            Lista_prod.Add(new Clsproductos(3, "Pescado", "Plato fuerte"));
            Lista_prod.Add(new Clsproductos(4, "Lasagna", "Plato fuerte"));
            Lista_prod.Add(new Clsproductos(5, "Espaguetti", "Plato fuerte"));
            Lista_prod.Add(new Clsproductos(6, "Bebida natural", "Bebida"));
            Lista_prod.Add(new Clsproductos(7, "Agua", "Bebida"));
            Lista_prod.Add(new Clsproductos(8, "Gaseosa", "Bebida"));
            Lista_prod.Add(new Clsproductos(9, "Té", "Bebida"));
            Lista_prod.Add(new Clsproductos(10, "Café", "Bebida"));
        }
        public static void agregaraLista(Clsproductos p) 
        {
            // agrega 
            Lista_prod.Add(p);
        }

        public static string modListaNom(int selecionMod) 
        {
            string infoNom = "";
            string infoCod = "";
            string infoTipo = "";
            foreach (Clsproductos p in Lista_prod)
            {
                if (selecionMod + 1 == ClsListaProd.prod_codigo)
                {
                    //Datos actuales de la lista en esa posición
                    string datoNomMod = ClsListaProd.prod_nombre;
                    infoNom = datoNomMod;
                }
            }

            return infoNom;
        }
        public static string modListaTipo(int selecionMod)
        {
            string infoTipo = "";
            foreach (Clsproductos p in Lista_prod)
            {
                if (selecionMod + 1 == ClsListaProd.prod_codigo)
                {
                    //Datos actuales de la lista en esa posición
                    string datoTipoMod = ClsListaProd.prod_tipo;
                    infoTipo = datoTipoMod;
                }
            }

            return infoTipo;
        }
        public static void ModLista(int seleccionMod, string infoNom, string infoTipo)
        {

        }
    }
}
