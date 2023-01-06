using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taverna
{
    public partial class carta_comidas : Form
    {
        //Creamos un String que va a tener la dirección del fichero txt
        String file = ("comidas.txt");
        public carta_comidas()
        {
            InitializeComponent();
        }

        private void carta_comidas_Load_1(object sender, EventArgs e)
        {

        }

        private void cartel_volver_Click(object sender, EventArgs e)
        {

        }

        private void boton_volver_Click(object sender, EventArgs e)
        {
            //Volvemos a la pantalla salón
            new salonTaberna().Show();
            this.Close();
        }

        private void label_comidas_Click(object sender, EventArgs e)
        {

        }

        private void foto_alitas_Click(object sender, EventArgs e)
        {

        }

        private void foto_burger_Click(object sender, EventArgs e)
        {

        }

        private void foto_patatas_Click(object sender, EventArgs e)
        {

        }

        private void boton_anadir_Click(object sender, EventArgs e)
        {
            //Sumamos los valores contenidos en los numericUpDown y los guarda en una varialbe int
            int suma = (int)(numeric_burger.Value * 6 + numeric_alitas.Value * 8 + numeric_patatas.Value * 8);
            //Guardamos el valor en una variable para poder escribirla en el fichero
            cuenta.Text = suma + "";
            //Lo escribimos en el fichero y lo cerramos
            StreamWriter sw = new StreamWriter(file);
            sw.WriteLine(cuenta.Text);
            sw.Close();
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
            numeric_burger.Value = 0;
            numeric_alitas.Value = 0;
            numeric_patatas.Value = 0;
        }

        private void numeric_alitas_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numeric_burger_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numeric_patatas_ValueChanged(object sender, EventArgs e)
        {

        }

        private void precio_burger_Click(object sender, EventArgs e)
        {

        }

        private void precio_patatas_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cuenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_total_Click(object sender, EventArgs e)
        {

        }

        private void carta_comidas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.cerrar();
        }
    }
}
