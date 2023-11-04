using System;
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
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            //Hace que lo que se selecionó en la comboboxAgregar se añada automaticamente
            // en la comboboxMod para poder despues modificarlo.
            comboBoxMod.Items.Add(comboBoxAgregar.Text);
        }

        //Creador del timer para obtener la hora
        private void FormMenu_Load(object sender, EventArgs e)
        {
            timer1.Start();
            textBoxHora.Text = DateTime.Now.ToString("hh:mm:ss");
            ClsListaProd.inicializarLista();


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
        
    }
}
