using System;
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
    public partial class FormStats : Form
    {
        public FormStats()
        {
            InitializeComponent();
        }
         //Propiedades de la clase
        public static int cantPedListos { get; set; } = 0;

        public static float PromEspera { get; set; }

        public static string HoraEntrada { get; set; }

        public static string HoraSalida { get; set; }

        public static int[] tiempoDeEspera = new int[50];
        public static int indiceArrayTP { get; set; }

        public static float PedxHora { get; set; }

        public static string[] Pedidos = new string[50];

        public static int indiceArrayPed = 0;

        //Eventos
        private void button1_Click(object sender, EventArgs e)
        {
            //Lista de pedidos realizados
            foreach (var pedido in Pedidos)
            {
                if (pedido != null) 
                {
                    listBoxPedRealizado.Items.Add(pedido);
                }
                
            }

            //Impresión de cantidad de pedidos
            textBoxPedHechos.Text = $"{cantPedListos.ToString()} Pedidos";

            //Impresión de promedio de tiempo de espera
            foreach (var min in tiempoDeEspera)
            {
                PromEspera = PromEspera + min;
            }
            int cant = tiempoDeEspera.Length + 1;
            PromEspera = PromEspera / cant;
            textBoxPromEspera.Text = $"{PromEspera.ToString()} Mins";

            //Impresión en textbox de los pedidos realizados x hora
            float CantPedXHora = CicloPedXHora();
            textBoxPedxHora.Text = $"{CantPedXHora} Pedidos por hora";
            

        }

        //Métodos
        public static void calcMinEspera() 
        {
            //Minutos de entrada
            string[] partes = HoraEntrada.Split(':');
            int horasEnt = int.Parse(partes[0]);
            int minutosEnt = int.Parse(partes[1]);
            int segundosEnt = int.Parse(partes[2]);
            int HoraAMinEntrada = horasEnt * 60;
            int SecAMinEntrada = segundosEnt / 60;
            int TotalMinEntrada = minutosEnt + HoraAMinEntrada + SecAMinEntrada;

            // Minutos de salida
            string[] partes1 = HoraEntrada.Split(':');
            int horasSal = int.Parse(partes1[0]);
            int minutosSal = int.Parse(partes1[1]);
            int segundosSal = int.Parse(partes1[2]);
            int HoraAMinSalida = horasSal * 60;
            int SecAMinSalida = segundosSal / 60;
            int TotalMinSalida = minutosSal + HoraAMinEntrada + SecAMinEntrada;

            // Minutos de espera
            int MinEspera = TotalMinSalida - HoraAMinEntrada;
            tiempoDeEspera[indiceArrayTP] = MinEspera;
            indiceArrayTP++;
        }

        public float CicloPedXHora() 
        {
            //Caluclo del los pedidos x hora
            float PromEsperaXHora = PromEspera * 60;
            PedxHora = PromEsperaXHora / cantPedListos;
            return PedxHora;
        }

        public static void agregarArrayPed(string pedidotext) 
        {
            //Método para agregar pedidos al array de Pedidos Completados
            Pedidos[indiceArrayPed] = pedidotext;
            indiceArrayPed = indiceArrayPed+1;
        }

        private void FormStats_Load(object sender, EventArgs e)
        {

        }
    }
}
