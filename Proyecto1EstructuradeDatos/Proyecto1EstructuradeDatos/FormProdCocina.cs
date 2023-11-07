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
            imprimirColaProd(PilaProd);
        }
        public void imprimirColaProd(Stack Pila)
        {
            foreach (string prod in Pila)
            {
                listBoxColaProd.Items.Add(prod);
            }
        }

        //Métodos
        public static Stack inicializarStack(Stack Pila)
        {
            Stack PilaProductos = new Stack(20);
            return PilaProductos;
        }

        public static void PushStack(string pedido, Stack Pila) 
        { 
            Pila.Push(pedido);
        }

        public void PopStack(Stack Pila) 
        {
            Pila.Pop();
            int indice = listBoxColaProd.SelectedIndex;
            if (indice != -1)
            {
                // Eliminar el elemento del índice
                listBoxColaProd.Items.RemoveAt(indice);
            }
        }

        private void buttonProdComp_Click(object sender, EventArgs e)
        {
            PopStack(PilaProd);
        }
    }
}
