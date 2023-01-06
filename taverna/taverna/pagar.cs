using System;
using System.Collections;
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
    public partial class foto_shield : Form
    {
        //Cremos 2 String en los que vamos a guardar la dirección de los ficheros con
        //el precio gastado de las bebidas y las comidas
        //Para mostrar en esta pantalla el precio total de las bebidas y la comida compradas
        //guardamos esa información un su fichero correspondiente y ahora lo leemos
        string file = ("bebidas.txt");
        string file2 = ("comidas.txt");
        public foto_shield()
        {
            InitializeComponent();
        }

        private void cesta_Load(object sender, EventArgs e)
        {

        }

        private void libro_carta_Click(object sender, EventArgs e)
        {

        }

        private void pergamino_carta_Click(object sender, EventArgs e)
        {

        }

        private void label_cesta_Click(object sender, EventArgs e)
        {

        }

        private void label_bebidas_Click(object sender, EventArgs e)
        {

        }

        private void label_comidas_Click(object sender, EventArgs e)
        {

        }

        private void tb_pbebidas_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_pcomida_TextChanged(object sender, EventArgs e)
        {

        }

        private void boton_mostrar_Click(object sender, EventArgs e)
        {
            //Comprobamos que el primer fichero1(bebidas) existe
            if (!File.Exists(file))
            {
                File.Create(file);
            }
            //Leemos la información del fichero
            String line;
            StreamReader sr = new StreamReader(file);
            line = sr.ReadLine();
            //Si el fichero no tiene información, le damos el valor 0
            if (line == null)
            {
                line = "0";
            }
            //Parseamos a int y mostramos el precio total
            int a = Int32.Parse(line);
            tb_pbebidas.Text = a + "€";

            sr.Close();
            //Hacemos exactamente lo mismo pero para el fichero2(comidas)
            if (!File.Exists(file2))
            {
                File.Create(file2);
            }

            String line2;
            StreamReader sr2 = new StreamReader(file2);
            line2 = sr2.ReadLine();

            if (line2 == null)
            {
                line2 = "0";
            }

            int b = Int32.Parse(line2);
            tb_pcomida.Text = b + "€";

            sr2.Close();

            mostrar_total.Text = (a + b) +"€";
        }

        private void cartel_volver_Click(object sender, EventArgs e)
        {

        }

        private void boton_volver_Click(object sender, EventArgs e)
        {
            //Volvemos a la pantalla del salón y escondemos la actual
            new salonTaberna().Show();
            this.Close();
        }

        private void boton_salir_Click(object sender, EventArgs e)
        {
            //Salimos del programa
            this.Close();
        }

        private void label_total_Click(object sender, EventArgs e)
        {

        }

        private void mostrar_total_TextChanged(object sender, EventArgs e)
        {

        }

        private void boton_pagar_Click(object sender, EventArgs e)
        {
            //Nos movemos a la pantalla metodoPago y ocultamos la actual
            new metodoPago().Show();
            this.Hide();
        }

        private void foto_escudo_Click(object sender, EventArgs e)
        {

        }

        private void pergamino_pago_Click(object sender, EventArgs e)
        {

        }

        private void label_pago_Click(object sender, EventArgs e)
        {

        }

        private void boton_pago_Click(object sender, EventArgs e)
        {
            //Mostramos un label que indica que se ha pagado
            label_pagado.Visible = true;
        }

        private void label_pagado_Click(object sender, EventArgs e)
        {

        }

        private void foto_shield_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.cerrar();
        }
    }
}
