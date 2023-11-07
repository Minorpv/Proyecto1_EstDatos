using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1EstructuradeDatos
{
    public partial class FormProdCocina : Form
    {
        public FormProdCocina()
        {
            InitializeComponent();
        }

        //Propiedades
        public static  Stack PilaProd { get; set; }

        //Eventos
        private void FormProdCocina_Load(object sender, EventArgs e)
        {
            //Se imprimen los adatos de la pila en la listBox
            imprimirColaProd(PilaProd);
        }

        private void buttonProdComp_Click(object sender, EventArgs e)
        {
            //Al presionar el botón se llama el proceso para sacar de la pila el producto
            PopStack(PilaProd);
        }

        //Métodos
        public void imprimirColaProd(Stack Pila)
        {
            //Cicloforeach para recabar los productos guardados en la pila y se añaden a la listbox
            foreach (string prod in Pila)
            {
                listBoxColaProd.Items.Add(prod);
            }
        }

        public static Stack inicializarStack(Stack Pila)
        {
            //Se inicializa el stack de la clase 
            Stack PilaProductos = new Stack(20);
            return PilaProductos;
        }

        public static void PushStack(string pedido, Stack Pila) 
        { 
            //Se agrega el producto a la pila
            Pila.Push(pedido);
        }

        public void PopStack(Stack Pila) 
        {
            //Se saca el producto de la pilar
            Pila.Pop();
            //Se guarda el índice seleccionado en una variable int
            int indice = listBoxColaProd.SelectedIndex;
            //Si el indice es distinto de 1 se remueve el item que esté en ese índice
            if (indice != -1)
            {
                // Eliminar el elemento del índice
                listBoxColaProd.Items.RemoveAt(indice);
            }
        }
    }
}
