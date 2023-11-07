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
            //Inicializador del timer
            timer1.Start();
            textBoxHora.Text = DateTime.Now.ToString("hh:mm:ss");
            //Se llama al método que imprime los datos de la cola en la listBox
            imprimirColaPedidos(ColaPedidos);
        }

        private void buttonPedidoComp_Click(object sender, EventArgs e)
        {
            //Se establece el índice seleccionado en la listBox a un int
            int indice = listBoxColaPedido.SelectedIndex;
            //Se aumento el contador de pedido en 1
            FormStats.cantPedListos++;
            //Se guarda la hora en la que el pedido salió
            FormStats.HoraSalida = textBoxHora.Text;
            //Se calcula el tiempo que se tardó haciendo el pedido en minutos
            FormStats.calcMinEspera();
            //Se saca de la cola el pedido
            sacardeCola(ColaPedidos);
        }

        //Metodos
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //Establecimiento del timer
            textBoxHora.Text = DateTime.Now.ToString("hh:mm:ss");
            timer1.Start();
        }

        //Metodos
        public static Queue inicializarCola( Queue ColaPedido) 
        {
            //Se inicializa la cola
            Queue ColaPedidos = new Queue(10);
            return ColaPedidos;
        }
        public static void Encolar (string pedido, Queue ColaPedido)
        {
            //Se agrega a la cola
            ColaPedido.Enqueue(pedido);
        }

        public void sacardeCola(Queue ColaPedido) 
        {
            //Se toma el primer valor de la cola y se guarda en un string
            string pedidotext = ColaPedido.Peek().ToString();
            //Ese string se agrega al array de pedidos completados
            FormStats.agregarArrayPed(pedidotext);
            //Se saca el pedido de la lista de pedidos por hacer
            ColaPedido.Dequeue();
            //Se  guarada el index selecionado de la listBox en un int
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
            //Ciclo foreach de cada pedido dentro de la cola
            foreach (string pedido in Cola)
            {
                listBoxColaPedido.Items.Add(pedido);
            }
        }


    }
}
