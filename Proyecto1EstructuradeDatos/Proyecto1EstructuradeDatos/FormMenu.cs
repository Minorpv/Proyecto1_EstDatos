﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto1EstructuradeDatos
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            //Inicialización de los componentes del form
            InitializeComponent();
            FormMenu.CodPedido = "0";
            Queue ColaPedidosFinal = FormListaPedidos.inicializarCola(FormListaPedidos.ColaPedidos);
            Stack PilaProd = FormProdCocina.inicializarStack(FormProdCocina.PilaProd);
            FormProdCocina.PilaProd = PilaProd;
            FormListaPedidos.ColaPedidos = ColaPedidosFinal;
        }

        //Propiedad para el cálculo de la cantidad de pedidos (Funciona como contador)
        public static string CodPedido { get; set; }

        //Eventos
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            listBoxProdPedidos.Items.Add(comboBoxAgregarPlato.Text);
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            //Creador del timer para obtener la hora
            timer1.Start();
            textBoxHora.Text = DateTime.Now.ToString("hh:mm:ss");
            //Agregar los nombres de la lista al combo box
            string[] ArrayNomPlato = ClsProductos.InicializarArrayNomProd();
            ArrayList arrayListNom = new ArrayList();
            arrayListNom.AddRange(ArrayNomPlato);
            for (int i = 0; i < arrayListNom.Capacity; i++)
            {
                comboBoxAgregarPlato.Items.Add(arrayListNom[i]);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBoxHora.Text = DateTime.Now.ToString("hh:mm:ss");
            timer1.Start();
        }
        //Fin del creador del timer
        private void button_lista_prod_Click(object sender, EventArgs e)
        {
            //Botón para abrir la pestaña de la lista de productos
            FormListaProd formListaProd = new FormListaProd();
            formListaProd.ShowDialog();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            int indice = listBoxProdPedidos.SelectedIndex;
            // Verificar que haya un elemento seleccionado
            if (indice != -1)
            {
                // Eliminar el elemento del índice
                listBoxProdPedidos.Items.RemoveAt(indice);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            string pedido = creacionPedido();
            FormListaPedidos.Encolar(pedido, FormListaPedidos.ColaPedidos);
            string listProd = "";
            foreach (var item in listBoxProdPedidos.Items)
            {
                string prod = item.ToString();
                listProd = prod;
                FormProdCocina.PushStack(listProd, FormProdCocina.PilaProd);
            }
            listBoxProdPedidos.Items.Clear();
            textBoxNombreMenu.Text = "";
            comboBoxAgregarPlato.Text = "";
        }

        private void buttonListPedido_Click(object sender, EventArgs e)
        {
            FormListaPedidos formListaProd = new FormListaPedidos();
            formListaProd.Show();
        }


        //Métodos
        public string creacionPedido()
        {
            int numPedido = int.Parse(FormMenu.CodPedido);
            numPedido = numPedido + 1;
            FormMenu.CodPedido = numPedido.ToString();
            //Se crea la variable para almacenar las variables de los pedidos
            string platosPed = "";
            foreach (var item in listBoxProdPedidos.Items)
            {
                string productos = item + ", \n";
                platosPed += productos;
            }
            //Se establece el nombre del cliente con el texto de su respectiva textbox en el menu
            string NomPedido = textBoxNombreMenu.Text;
            //Ciclo foreach para colocar todos los productos de la listboxx en un solo string
            //Captura la hora en el string
            string horaRebPedido = textBoxHora.Text;
            FormStats.HoraEntrada = horaRebPedido;
            ClsPedidos Pedidos= new ClsPedidos(numPedido, NomPedido, platosPed, horaRebPedido);
            //Se coloca todo el pedido en un solo string
            string Pedido = $"Pedido#: {FormMenu.CodPedido} \n Nombre: {NomPedido} \nPlatos: {platosPed} \n Hora: {horaRebPedido}";
            return Pedido;
        }

        private void buttonProdCocina_Click(object sender, EventArgs e)
        {
            FormProdCocina formProdCocina = new FormProdCocina();
            formProdCocina.Show();
        }

        private void buttonStats_Click(object sender, EventArgs e)
        {
            FormStats formStats = new FormStats();
            formStats.Show();
        }
    }
}
