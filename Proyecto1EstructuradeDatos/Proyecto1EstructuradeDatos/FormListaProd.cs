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

        //Eventos

        private void FormListaProd_Load(object sender, EventArgs e)
        {
            //Se inicializa la lista en la pestaña ClslistaProd
            int[] arraycod = ClsProductos.InicializarArrayCod();
            string[] arrayNomPlato = ClsProductos.InicializarArrayNomProd();
            string[] arrayTipo = ClsProductos.InicializarArrayTipo();
            // se coloca el menu base que se implementó
            for (int i = 0; i < arraycod.Length; i++) 
            {
                string cod = arraycod[i].ToString();
                string nomPlato = arrayNomPlato[i].ToString();
                string tipo = arrayTipo[i].ToString();
                listBox_Prod.Items.Add($"{cod} |  {nomPlato}        {tipo}");
            }
            //Se pone siempre al ingresar a la pestaña el mouse en la textbox del codigo
            textBox_CodProd.Focus();
        }

        
        private void button_AgregarProd_Click(object sender, EventArgs e)
        {
            //Se recogen los textos de las textbox y la combobox en las siguientes variables:
            int cod = int.Parse(textBox_CodProd.Text);
            string nom = textBox_NombreProd.Text;
            string tipo = comboBox_TipoProd.Text;
            //Se toman los datos de las textbox se agrupan en un string y se añade a la listbox
            string dato_prod = string.Concat(textBox_CodProd.Text, " ||", textBox_NombreProd.Text, "       ", comboBox_TipoProd.Text);
            //Se añade la información en la listbox
            listBox_Prod.Items.Add(dato_prod);
            //Se limpia la información de las textbox
            textBox_CodProd.Clear();
            textBox_NombreProd.Clear();
            comboBox_TipoProd.Text = "";

        }

        private void button_ModProd_Click(object sender, EventArgs e)
        {

        }
    }
}
