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
    public partial class registro : Form
    {
        //Cremos un String con la dirección del fichero
        string file = ("bbdd.txt");
        public registro()
        {
            InitializeComponent();
        }

        private void registro_Load(object sender, EventArgs e)
        {

        }

        private void cartelregistro_Click(object sender, EventArgs e)
        {

        }

        private void label_user_Click(object sender, EventArgs e)
        {

        }

        private void label_pass_Click(object sender, EventArgs e)
        {

        }

        private void meter_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void boton_registro_Click(object sender, EventArgs e)
        {
            //Método que crea el fichero si no existe
            if (!File.Exists(file))
            {
                File.Create(file);
            }

            if (meter_usuario.Text != "" || meter_pass.Text != "")
            {
                //Si el método comprobarUser nos devuelve un false, significa que le nombre que queremos introducir
                //no coincide con ninguno registrado
                if (!comprobarUser(file))
                {
                    //Escribimos en el fichero el nombre y la contraseña
                    StreamWriter sw = new StreamWriter(file, true);
                    sw.WriteLine(meter_usuario.Text + ';' + meter_pass.Text);
                    //Ocultamos mensaje de error y mostramos el mensaje de usuario creado
                    label_error.Visible = false;
                    label_creado.Visible = true;
                    fallo_vacio.Visible = false;
                    sw.Close();
                    //Reiniciamos el valor de nombre y usuario por si el usuario quiere registrar a más usuarios
                    meter_usuario.Text = "";
                    meter_pass.Text = "";

                }
            }
            else
            {
                fallo_vacio.Visible = true;
                label_error.Visible = false;
                label_creado.Visible = false;
            }
        }

        private void boton_borrar_Click(object sender, EventArgs e)
        {
            //Reiniciamos el valor de los registros y escondemos los mensajes de error
            label_creado.Visible = false;
            label_error.Visible = false;
            fallo_vacio.Visible = false;
            meter_usuario.Text = "";
            meter_pass.Text = "";
        }

        private void antorchaI_Click(object sender, EventArgs e)
        {

        }

        private void boton_salir_Click(object sender, EventArgs e)
        {
            //Salimos del programa
            this.Close();
        }

        private void boton_volver_Click(object sender, EventArgs e)
        {
            //Volvemos a la pantalla principal y escondemos la actual
            new ventana().Show();
            this.Close();
        }

        private void meter_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_error_Click(object sender, EventArgs e)
        {

        }

        private bool comprobarUser(String file)
        {
            //Este método que devuelve un boolean nos va a permitir comprobar si ya existe un
            //usuario con el nombre que queremos ponerle a un nuevo registro (él nombre del usuario
            //funcionaría como la PK)
            //Inicializamos el bollean repetido a false
            bool repetido = false;
            String line;
            //Leemos el fichero
            StreamReader sr = new StreamReader(file);
            ArrayList lista = new ArrayList();
            line = sr.ReadLine();
            lista.Add(lista);

            while (line != null)
            {
                string[] array = line.Split(';');
                if (meter_usuario.Text.Equals(array[0]))
                {
                    //Si existe un usuario con ese nombre, ponemos el boolean repetido a true
                    repetido = true;
                    label_error.Visible = true;
                }
                line = sr.ReadLine();
            }
            //Devolvemos el boolean
            sr.Close();
            return repetido;
        }

        private void label_creado_Click(object sender, EventArgs e)
        {

        }

        private void dark_souls2_Click_1(object sender, EventArgs e)
        {

        }

        private void label_crearUser_Click(object sender, EventArgs e)
        {

        }

        private void fallo_vacio_Click(object sender, EventArgs e)
        {

        }

        private void registro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.cerrar();
        }
    }
}
