using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taverna
{
    public partial class carta_bebidas : Form
    {
        //Creamos un String que va a tener la dirección del fichero txt
        string file = ("bebidas.txt");
        public carta_bebidas()
        {
            InitializeComponent();
        }

        private void carta_bebidas_Load(object sender, EventArgs e)
        {

        }

        private void rollo_bebidas_Click(object sender, EventArgs e)
        {

        }

        private void cerveza_rubia_Click(object sender, EventArgs e)
        {

        }

        private void cerveza_tostada_Click(object sender, EventArgs e)
        {

        }

        private void mead_Click(object sender, EventArgs e)
        {

        }

        private void label_bebidas_Click(object sender, EventArgs e)
        {

        }

        private void cartel_volver_Click(object sender, EventArgs e)
        {

        }

        private void boton_volver_Click(object sender, EventArgs e)
        {
            //Volvemos a la pantalla del salón
            new salonTaberna().Show();
            this.Close();
        }

        private void boton_anadir_Click(object sender, EventArgs e)
        {
            //Sumamos los valores contenidos en los numericUpDown y los guarda en una varialbe int
            int suma = (int)(numeric_rubia.Value * 3 + numeric_tostada.Value * 4 + numeric_mead.Value * 5);
            //Guardamos el valor en una variable para poder escribirla en el fichero
            cuenta.Text = suma + "";
            //Lo escribimos en el fichero y lo cerramos
            StreamWriter sw = new StreamWriter(file);
            sw.WriteLine(cuenta.Text );
            sw.Close();
        }


        private void cuenta_TextChanged(object sender, EventArgs e)
        {
    
        }

        private void boton_salir_Click(object sender, EventArgs e)
        {
            //Salimos del programa
            this.Close();
        }

        private void boton_borrar_Click(object sender, EventArgs e)
        {
            //Reiniciamos el valor de los registros
            cuenta.Text = "";
            numeric_rubia.Value = 0;
            numeric_tostada.Value = 0;
            numeric_mead.Value = 0;
        }

        private void numeric_rubia_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numeric_tostada_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numeric_mead_ValueChanged(object sender, EventArgs e)
        {

        }

        private void precio_tostada_Click(object sender, EventArgs e)
        {

        }

        private void precio_mead_Click(object sender, EventArgs e)
        {

        }

        private void precio_rubia_Click(object sender, EventArgs e)
        {

        }

        private void label_total_Click(object sender, EventArgs e)
        {

        }

        private void carta_bebidas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.cerrar();
        }
    }
}
