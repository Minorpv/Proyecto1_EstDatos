using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1EstructuradeDatos
{
    public partial class FormListaProd : Form
    {
        public FormListaProd()
        {
            InitializeComponent();
        }

        private void FormListaProd_Load(object sender, EventArgs e)
        {
            //Se inicializa la lista en la pestaña ClslistaProd
            int[] arraycod = ClsProductos.InicializarArrayCod();
            string[] arrayNomPlato = ClsProductos.InicializarArrayNomProd();
            string[] arrayTipo = ClsProductos.InicializarArrayTipo();
            for (int i = 0; i < arraycod.Length; i++) 
            {
                string cod = arraycod[i].ToString();
                string nomPlato = arrayNomPlato[i].ToString();
                string tipo = arrayTipo[i].ToString();
                listBox_Prod.Items.Add($"{cod} |  {nomPlato}        {tipo}");
            }
            // se coloca el menu base que se implementó

            //Se pone siempre al ingresar a  la pestaña el mouse en la textbox del codigo
            textBox_CodProd.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_AgregarProd_Click(object sender, EventArgs e)
        {
            int cod = int.Parse(textBox_CodProd.Text);
            string nom = textBox_NombreProd.Text;
            string tipo = comboBox_TipoProd.Text;
            //Se toman los datos de las textbox se agrupan en un string y se añade a la listbox
            string dato_prod = string.Concat(textBox_CodProd.Text, " ||", textBox_NombreProd.Text, "       ", comboBox_TipoProd.Text);
            listBox_Prod.Items.Add(dato_prod);
            //Se añade la información en la listbox
            //Clsproductos.agregarArray(cod, nom, tipo);
            //Se limpia la información de las textbox
            textBox_CodProd.Clear();
            textBox_NombreProd.Clear();
            comboBox_TipoProd.Text = "";

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button_ModProd_Click(object sender, EventArgs e)
        {

        }

        private void listBox_Prod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
