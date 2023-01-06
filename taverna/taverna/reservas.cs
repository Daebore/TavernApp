using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taverna
{
    public partial class reservas : Form
    {
        public reservas()
        {
            InitializeComponent();
        }

        private void reservas_Load(object sender, EventArgs e)
        {

        }

        private void label_reservas_Click(object sender, EventArgs e)
        {

        }

        private void boton_salir_Click(object sender, EventArgs e)
        {
            //Cerramos el programa
            this.Close();
        }

        private void cartel_volver_Click(object sender, EventArgs e)
        {

        }

        private void boton_volver_Click(object sender, EventArgs e)
        {
            //Volvemos a la pantalla del salón y ocultamos la actual
            new salonTaberna().Show();
            this.Close();
        }

        private void label_reservas_Click_1(object sender, EventArgs e)
        {

        }

        private void num_comensales_ValueChanged(object sender, EventArgs e)
        {

        }

        private void calendario_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void meter_hora_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_creado_Click(object sender, EventArgs e)
        {

        }


        private void nombre_Click(object sender, EventArgs e)
        {

        }

        private void personas_Click(object sender, EventArgs e)
        {

        }

        private void fechasR_Click(object sender, EventArgs e)
        {

        }

        private void horaR_Click(object sender, EventArgs e)
        {

        }

        private void boton_reservar_Click(object sender, EventArgs e)
        {
            //Si los textBox de usuario o la hora están vacíos o el valor del numericUpDown de comensales está vacío,
            //saltamos los mensajes de error correspondientes
            if (meter_usuario.Text == " " || num_comensales.Value == 0 || meter_hora.Text == " ")
            {
                label_error.Visible = true;
                label_creado.Visible = false;
            }
            else
            {
                //Reiniciamos el valor de los registros
                meter_usuario.Text = " ";
                meter_hora.Text = " ";
                num_comensales.Value = 0;
                label_creado.Visible = true;
                label_error.Visible = false;
            }
        }

        private void meter_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void boton_borrar_Click(object sender, EventArgs e)
        {
            //Reiniciamos el valor de lso registros
            meter_usuario.Text = "";
            meter_hora.Text = " ";
            num_comensales.Value = 0;
            label_creado.Visible = false;
            label_error.Visible = false;
        }

        private void pergamino_Click(object sender, EventArgs e)
        {

        }

        private void label_error_Click(object sender, EventArgs e)
        {

        }

        private void reservas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.cerrar();
        }
    }
}

