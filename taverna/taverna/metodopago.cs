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
    public partial class metodoPago : Form
    {
        public metodoPago()
        {
            InitializeComponent();
        }

        private void label_pago_Click(object sender, EventArgs e)
        {

        }

        private void pergamino_metpago_Click(object sender, EventArgs e)
        {

        }

        private void metodoPago_Load(object sender, EventArgs e)
        {

        }

        private void cartel_volver_Click(object sender, EventArgs e)
        {

        }

        private void boton_volver_Click(object sender, EventArgs e)
        {
            new salonTaberna().Show();
            this.Close();
        }

        private void boton_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gold_knight_Click(object sender, EventArgs e)
        {

        }

        private void picture_coin_Click(object sender, EventArgs e)
        {

        }

        private void buton_trans_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buton_cred_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void buton_payp_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void foto_banco_Click(object sender, EventArgs e)
        {

        }

        private void foto_tarjetas_Click(object sender, EventArgs e)
        {

        }

        private void foto_payp_Click(object sender, EventArgs e)
        {

        }
        private void boton_aceptar_Click(object sender, EventArgs e)
        {
            //Si ningún radioButtons se ha seleccionado, mostramos un mensaje de error
            if (buton_trans.Checked == false && buton_cred.Checked == false && buton_payp.Checked == false)
            {
                label_error.Visible = true;
            }
            else
            {
                //Si alguno ha sido seleccionado, mostramos el mensaje correspondiente 
                label_aceptado.Visible = true;
                label_error.Visible = false;
            }
        }

        private void label_aceptado_Click(object sender, EventArgs e)
        {

        }

        private void boton_borrar_Click_1(object sender, EventArgs e)
        {
            //Borramos todos los radioButtons seleccionados
            buton_cred.Checked = false;
            buton_trans.Checked = false;
            buton_payp.Checked = false;
            label_aceptado.Visible = false;
            label_error.Visible = false;
        }

        private void link_web_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Si pulsamos en el linkLabel, nos redirigiremos al web oficial de PayPal
            System.Diagnostics.Process.Start("https://www.paypal.com/es/webapps/mpp/account-selection");  
        }

        private void label_error_Click(object sender, EventArgs e)
        {

        }

        private void metodoPago_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.cerrar();
        }
    }
}