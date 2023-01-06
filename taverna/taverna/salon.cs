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
    public partial class salonTaberna : Form
    {
        //Variable estática en la que vamos a guardar el nombre del usuario
        public static String nombreUser;

        public salonTaberna()
        {
            InitializeComponent();
            //Para mostrar el nombre del usuario nada más entrar en la pantalla
            label_bienvenido.Text += nombreUser;
        }

        private void label_bienvenidoD_Click(object sender, EventArgs e)
        {

        }

        private void lista_senales_Click(object sender, EventArgs e)
        {

        }

        private void boton_comida_Click(object sender, EventArgs e)
        {
            //Nos movemos a la pantalla de carta de comida y escondemos la actual
            new carta_comidas().Show();
            this.Close();
        }

        private void boton_bebida_Click(object sender, EventArgs e)
        {
            //Nos movemos a la pantalla de carta de comidas y escondemos la actual
            new carta_bebidas().Show();
            this.Close();
        }

        private void boton_reservar_Click(object sender, EventArgs e)
        {
            //Nos movemos a la pantalla de reservas y escondemos la actual
            new reservas().Show();
            this.Close();
        }

        private void boton_cesta_Click(object sender, EventArgs e)
        {
            //Nos movemos a la pantalla de pago y escondemos la actual
            new foto_shield().Show();
            this.Close();
        }

        private void dark_souls_Click(object sender, EventArgs e)
        {

        }

        private void salonTaberna_Load(object sender, EventArgs e)
        {

        }

        private void boton_salir_Click(object sender, EventArgs e)
        {
            //Salimos del programa
            this.Close();
        }

        private void boton_volver_Click(object sender, EventArgs e)
        {
            //Regresamos a la página principal
            new ventana().Show();
            this.Close();
        }

        private void pergamino_nombre_Click(object sender, EventArgs e)
        {

        }

        private void label_bienvenido_Click(object sender, EventArgs e)
        {

        }

        private void salonTaberna_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.cerrar();
        }
    }
}
