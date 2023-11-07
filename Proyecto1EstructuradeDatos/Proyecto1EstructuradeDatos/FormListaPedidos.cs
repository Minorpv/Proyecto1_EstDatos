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
    public partial class FormListaPedidos : Form
    {
        //Inicialización de componenetes
        public FormListaPedidos()
        {
            InitializeComponent();
        }
        //Propiedad de cola
        public static Queue ColaPedidos {  get; set; }

        //Eventos
        private void FormListaPedidos_Load(object sender, EventArgs e)
        {
            timer1.Start();
            textBoxHora.Text = DateTime.Now.ToString("hh:mm:ss");
            imprimirColaPedidos(ColaPedidos);
        }

        //Metodos
        public static Queue inicializarCola( Queue ColaPedido) 
        {
            Queue ColaPedidos = new Queue(10);
            return ColaPedidos;
        }
        public static void Encolar (string pedido, Queue ColaPedido)
        {
            ColaPedido.Enqueue(pedido);
        }

        public void sacardeCola(Queue ColaPedido) 
        {
            string pedidotext = ColaPedido.Peek().ToString();
            FormStats.agregarArrayPed(pedidotext);
            ColaPedido.Dequeue();
            int indice = listBoxColaPedido.SelectedIndex;
            // Verificar que haya un elemento seleccionado
            if (indice != -1)
            {
                // Eliminar el elemento del índice
                listBoxColaPedido.Items.RemoveAt(indice);
            }

        }

        public void imprimirColaPedidos(Queue Cola)
        {
            foreach (string pedido in Cola)
            {
                listBoxColaPedido.Items.Add(pedido);
            }
        }

        private void buttonPedidoComp_Click(object sender, EventArgs e)
        {
            int indice = listBoxColaPedido.SelectedIndex;
            FormStats.cantPedListos++;
            FormStats.HoraSalida =textBoxHora.Text;
            FormStats.calcMinEspera();
            sacardeCola(ColaPedidos);
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            textBoxHora.Text = DateTime.Now.ToString("hh:mm:ss");
            timer1.Start();
        }
    }
}
