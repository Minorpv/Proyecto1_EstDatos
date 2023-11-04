using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
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
            ClsListaProd.inicializarLista();
            // se coloca el menu base que se implementó
            listBox_Prod.Items.Add("01 ||  Pollo             Plato fuerte");
            listBox_Prod.Items.Add("02 ||  Cerdo             Plato fuerte");
            listBox_Prod.Items.Add("03 ||  Pescado           Plato fuerte");
            listBox_Prod.Items.Add("04 ||  Lasagna           Plato fuerte");
            listBox_Prod.Items.Add("05 ||  Espagueti         Plato fuerte");
            listBox_Prod.Items.Add("06 ||  Bebida natural    Bebida");
            listBox_Prod.Items.Add("07 ||  Agua              Bebida");
            listBox_Prod.Items.Add("08 ||  Gaseosa           Bebida");
            listBox_Prod.Items.Add("09 ||  Té                Bebida");
            listBox_Prod.Items.Add("10 ||  Café              Bebida");
            //Se pone siempre al ingresar a  la pestaña el mouse en la textbox del codigo
            textBox_CodProd.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_AgregarProd_Click(object sender, EventArgs e)
        {
            //Se toman los datos de las textbox se agrupan en un string y se añade a la listbox
            string dato_prod = string.Concat(textBox_CodProd.Text, " ||", textBox_NombreProd.Text, "       ", comboBox_TipoProd.Text);
            //Se añaden los datos a la listade productos
            Clsproductos p = new Clsproductos(int.Parse(textBox_CodProd.Text), textBox_NombreProd.Text, comboBox_TipoProd.Text);
            ClsListaProd.agregaraLista(p);
            //Se añade la información en la listbox
            listBox_Prod.Items.Add(dato_prod);
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

        public void copiarinfomod(string info) 
        { 
            //Se copia la información ingresada en la 
            listBox_Prod.SelectedItem = info;
        }

        private void listBox_Prod_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selecionMod = listBox_Prod.SelectedIndex;
            string infoNom = ClsListaProd.modListaNom(selecionMod);
            string infoTipo = ClsListaProd.modListaTipo(selecionMod);
            string info = $"{selecionMod + 1} || {infoNom}       {infoTipo}";
            copiarinfomod(info);
        }
    }
}
