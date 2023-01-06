using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taverna
{
    public partial class ventana : Form
    {
        //Declaramos un String y guardamos en él el fichero de texto
        string file = ("bbdd.txt");
        public ventana()
        {
            InitializeComponent();
            contarUsers();

        }

        private void ventana_Load(object sender, EventArgs e)
        {

        }

        private void antorchaD_Click(object sender, EventArgs e)
        {

        }

        private void boton_entrar_Click(object sender, EventArgs e)
        {
            //Este método creará el fichero si no existe
            if (!File.Exists(file))
            {
                File.Create(file);
            }

            String line;
            //Creamos un objeto que nos permita leer
            StreamReader sr = new StreamReader(file);
            //Decalramos una lista
            ArrayList lista = new ArrayList();
            //Leemos la primera línea y guardamos el resultado en el String line
            line = sr.ReadLine();
            //Metemos el String en la lista
            lista.Add(lista);

            //Mientras el fichero tenga información, se seguirá leyendo
            while (line != null)
            {
                //Cada registro va a tener el nombre del usuario y la edad, separados por un ;
                //Con split separamos cada registro y lo guardamos en un array auxiliar
                string[] array = line.Split(';');
                if (meter_usuario.Text.Equals(array[0]))
                {
                    //Esto nos va a permitir mostrar el nombre del usuario en la siguiente página
                    salonTaberna.nombreUser = meter_usuario.Text;
                    if (meter_pass.Text.Equals(array[1]))
                    {
                        //Si el usuario y la contraseña introducidos por el usuario, cambiamos de pantalla y escondemos la actual
                        new salonTaberna().Show();
                        this.Close();
                    }
                }
                //Si el usuario y/o contraseña no coinciden con las registradas, mostramos un label indicando un error
                label_error.Visible = true;
                //Seguimos leyendo
                line = sr.ReadLine();
            }
            //Cerramos el fichero
            sr.Close();
        }

        private void boton_salir_Click(object sender, EventArgs e)
        {
            //Salimos del programa
            this.Close();
        }

        private void meter_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_usuario_Click(object sender, EventArgs e)
        {

        }

        private void boton_borrar_Click(object sender, EventArgs e)
        {
            //Si pulsamos en el botón borrar, escondemos el mensaje de error y reiniciamos los 
            //registros de los textBox de nombre y contraseña
            label_error.Visible = false;
            meter_usuario.Text = "";
            meter_pass.Text = "";
        }

        private void meter_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_pass_Click(object sender, EventArgs e)
        {

        }

        private void cartelgrande_Click(object sender, EventArgs e)
        {

        }

        private void boton_registro_Click(object sender, EventArgs e)
        {
            //Nos movemos a la pantalla de registro y escondemos la actual
            new registro().Show();
            this.Close();
        }

        private void label_error_Click(object sender, EventArgs e)
        {

        }
        
        private void contarUsers()
        {
            //Este método nos permitírá mostrar por pantalla el número de usuarios que hay registrados
            //Funciona de forma similar al anterior que nos permitía leer, sin embargo, en este caso es 
            //más sencillo: por cada línea que leamos en el fichero, sumamos 1 a la variable contador
            //y mostramos el resultado en la pantalla inicial
            int contador = 0;
            String line;
            StreamReader sr = new StreamReader(file);
            ArrayList lista = new ArrayList();
            line = sr.ReadLine();
            lista.Add(lista);

            while (line != null)
            {
                line = sr.ReadLine();
                contador++;

            }
            sr.Close();
            //Mostramos el resultado por pantalla (requiere casteo al ser un .Text)
            label_registados.Text += contador.ToString();
        }

        private void label_registados_Click(object sender, EventArgs e)
        {

        }

        private void pergamino_numUser_Click(object sender, EventArgs e)
        {

        }

        private void welcome_Click(object sender, EventArgs e)
        {

        }

        private void ventana_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.cerrar();
        }
    }
}
