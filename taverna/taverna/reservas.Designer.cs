namespace taverna
{
    partial class reservas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reservas));
            this.boton_salir = new System.Windows.Forms.Button();
            this.cartel_volver = new System.Windows.Forms.PictureBox();
            this.boton_volver = new System.Windows.Forms.Button();
            this.pergamino = new System.Windows.Forms.PictureBox();
            this.label_reservas = new System.Windows.Forms.Label();
            this.meter_usuario = new System.Windows.Forms.TextBox();
            this.num_comensales = new System.Windows.Forms.NumericUpDown();
            this.meter_hora = new System.Windows.Forms.TextBox();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.label_creado = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.personas = new System.Windows.Forms.Label();
            this.fechasR = new System.Windows.Forms.Label();
            this.horaR = new System.Windows.Forms.Label();
            this.boton_reservar = new System.Windows.Forms.Button();
            this.boton_borrar = new System.Windows.Forms.Button();
            this.label_error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cartel_volver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pergamino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_comensales)).BeginInit();
            this.SuspendLayout();
            // 
            // boton_salir
            // 
            this.boton_salir.BackColor = System.Drawing.Color.IndianRed;
            this.boton_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.boton_salir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.boton_salir.Location = new System.Drawing.Point(735, 423);
            this.boton_salir.Name = "boton_salir";
            this.boton_salir.Size = new System.Drawing.Size(65, 28);
            this.boton_salir.TabIndex = 16;
            this.boton_salir.Text = "Salir";
            this.boton_salir.UseVisualStyleBackColor = false;
            this.boton_salir.Click += new System.EventHandler(this.boton_salir_Click);
            // 
            // cartel_volver
            // 
            this.cartel_volver.BackColor = System.Drawing.Color.Transparent;
            this.cartel_volver.Image = ((System.Drawing.Image)(resources.GetObject("cartel_volver.Image")));
            this.cartel_volver.Location = new System.Drawing.Point(1, 0);
            this.cartel_volver.Name = "cartel_volver";
            this.cartel_volver.Size = new System.Drawing.Size(143, 127);
            this.cartel_volver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cartel_volver.TabIndex = 17;
            this.cartel_volver.TabStop = false;
            this.cartel_volver.Click += new System.EventHandler(this.cartel_volver_Click);
            // 
            // boton_volver
            // 
            this.boton_volver.BackColor = System.Drawing.Color.Peru;
            this.boton_volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_volver.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.boton_volver.Location = new System.Drawing.Point(29, 72);
            this.boton_volver.Name = "boton_volver";
            this.boton_volver.Size = new System.Drawing.Size(84, 35);
            this.boton_volver.TabIndex = 18;
            this.boton_volver.Text = "Volver";
            this.boton_volver.UseVisualStyleBackColor = false;
            this.boton_volver.Click += new System.EventHandler(this.boton_volver_Click);
            // 
            // pergamino
            // 
            this.pergamino.BackColor = System.Drawing.Color.Transparent;
            this.pergamino.Image = ((System.Drawing.Image)(resources.GetObject("pergamino.Image")));
            this.pergamino.Location = new System.Drawing.Point(159, 0);
            this.pergamino.Name = "pergamino";
            this.pergamino.Size = new System.Drawing.Size(584, 456);
            this.pergamino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pergamino.TabIndex = 19;
            this.pergamino.TabStop = false;
            this.pergamino.Click += new System.EventHandler(this.pergamino_Click);
            // 
            // label_reservas
            // 
            this.label_reservas.AutoSize = true;
            this.label_reservas.BackColor = System.Drawing.Color.DarkOrange;
            this.label_reservas.Font = new System.Drawing.Font("Gadugi", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_reservas.Image = ((System.Drawing.Image)(resources.GetObject("label_reservas.Image")));
            this.label_reservas.Location = new System.Drawing.Point(353, 9);
            this.label_reservas.Name = "label_reservas";
            this.label_reservas.Size = new System.Drawing.Size(170, 44);
            this.label_reservas.TabIndex = 20;
            this.label_reservas.Text = "Reservas";
            this.label_reservas.Click += new System.EventHandler(this.label_reservas_Click_1);
            // 
            // meter_usuario
            // 
            this.meter_usuario.BackColor = System.Drawing.Color.NavajoWhite;
            this.meter_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meter_usuario.Location = new System.Drawing.Point(472, 66);
            this.meter_usuario.Name = "meter_usuario";
            this.meter_usuario.Size = new System.Drawing.Size(192, 31);
            this.meter_usuario.TabIndex = 21;
            this.meter_usuario.TextChanged += new System.EventHandler(this.meter_usuario_TextChanged);
            // 
            // num_comensales
            // 
            this.num_comensales.BackColor = System.Drawing.Color.NavajoWhite;
            this.num_comensales.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_comensales.Location = new System.Drawing.Point(472, 105);
            this.num_comensales.Name = "num_comensales";
            this.num_comensales.Size = new System.Drawing.Size(192, 31);
            this.num_comensales.TabIndex = 22;
            this.num_comensales.ValueChanged += new System.EventHandler(this.num_comensales_ValueChanged);
            // 
            // meter_hora
            // 
            this.meter_hora.BackColor = System.Drawing.Color.NavajoWhite;
            this.meter_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meter_hora.Location = new System.Drawing.Point(472, 340);
            this.meter_hora.Name = "meter_hora";
            this.meter_hora.Size = new System.Drawing.Size(192, 31);
            this.meter_hora.TabIndex = 23;
            this.meter_hora.TextChanged += new System.EventHandler(this.meter_hora_TextChanged);
            // 
            // calendario
            // 
            this.calendario.BackColor = System.Drawing.Color.NavajoWhite;
            this.calendario.Location = new System.Drawing.Point(472, 166);
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 24;
            this.calendario.TitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendario_DateChanged);
            // 
            // label_creado
            // 
            this.label_creado.AutoSize = true;
            this.label_creado.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_creado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_creado.ForeColor = System.Drawing.Color.Red;
            this.label_creado.Location = new System.Drawing.Point(293, 376);
            this.label_creado.Name = "label_creado";
            this.label_creado.Size = new System.Drawing.Size(268, 24);
            this.label_creado.TabIndex = 43;
            this.label_creado.Text = "Reserva realizada con éxito";
            this.label_creado.Visible = false;
            this.label_creado.Click += new System.EventHandler(this.label_creado_Click);
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.BackColor = System.Drawing.Color.NavajoWhite;
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Image = ((System.Drawing.Image)(resources.GetObject("nombre.Image")));
            this.nombre.Location = new System.Drawing.Point(292, 72);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(93, 25);
            this.nombre.TabIndex = 44;
            this.nombre.Text = "Nombre";
            this.nombre.Click += new System.EventHandler(this.nombre_Click);
            // 
            // personas
            // 
            this.personas.AutoSize = true;
            this.personas.BackColor = System.Drawing.Color.NavajoWhite;
            this.personas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personas.Image = ((System.Drawing.Image)(resources.GetObject("personas.Image")));
            this.personas.Location = new System.Drawing.Point(292, 111);
            this.personas.Name = "personas";
            this.personas.Size = new System.Drawing.Size(143, 25);
            this.personas.TabIndex = 45;
            this.personas.Text = "Nº Personas";
            this.personas.Click += new System.EventHandler(this.personas_Click);
            // 
            // fechasR
            // 
            this.fechasR.AutoSize = true;
            this.fechasR.BackColor = System.Drawing.Color.NavajoWhite;
            this.fechasR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechasR.Image = ((System.Drawing.Image)(resources.GetObject("fechasR.Image")));
            this.fechasR.Location = new System.Drawing.Point(292, 166);
            this.fechasR.Name = "fechasR";
            this.fechasR.Size = new System.Drawing.Size(163, 25);
            this.fechasR.TabIndex = 46;
            this.fechasR.Text = "Fecha reserva";
            this.fechasR.Click += new System.EventHandler(this.fechasR_Click);
            // 
            // horaR
            // 
            this.horaR.AutoSize = true;
            this.horaR.BackColor = System.Drawing.Color.NavajoWhite;
            this.horaR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horaR.Image = ((System.Drawing.Image)(resources.GetObject("horaR.Image")));
            this.horaR.Location = new System.Drawing.Point(292, 343);
            this.horaR.Name = "horaR";
            this.horaR.Size = new System.Drawing.Size(148, 25);
            this.horaR.TabIndex = 47;
            this.horaR.Text = "Hora reserva";
            this.horaR.Click += new System.EventHandler(this.horaR_Click);
            // 
            // boton_reservar
            // 
            this.boton_reservar.BackColor = System.Drawing.Color.Peru;
            this.boton_reservar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_reservar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.boton_reservar.Location = new System.Drawing.Point(619, 403);
            this.boton_reservar.Name = "boton_reservar";
            this.boton_reservar.Size = new System.Drawing.Size(91, 35);
            this.boton_reservar.TabIndex = 48;
            this.boton_reservar.Text = "Reservar";
            this.boton_reservar.UseVisualStyleBackColor = false;
            this.boton_reservar.Click += new System.EventHandler(this.boton_reservar_Click);
            // 
            // boton_borrar
            // 
            this.boton_borrar.BackColor = System.Drawing.Color.Peru;
            this.boton_borrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_borrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.boton_borrar.Location = new System.Drawing.Point(521, 403);
            this.boton_borrar.Name = "boton_borrar";
            this.boton_borrar.Size = new System.Drawing.Size(84, 35);
            this.boton_borrar.TabIndex = 49;
            this.boton_borrar.Text = "Borrar";
            this.boton_borrar.UseVisualStyleBackColor = false;
            this.boton_borrar.Click += new System.EventHandler(this.boton_borrar_Click);
            // 
            // label_error
            // 
            this.label_error.AutoSize = true;
            this.label_error.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_error.ForeColor = System.Drawing.Color.Red;
            this.label_error.Location = new System.Drawing.Point(203, 407);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(307, 24);
            this.label_error.TabIndex = 50;
            this.label_error.Text = "No puede haber campos vacíos";
            this.label_error.Visible = false;
            this.label_error.Click += new System.EventHandler(this.label_error_Click);
            // 
            // reservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.boton_borrar);
            this.Controls.Add(this.boton_reservar);
            this.Controls.Add(this.horaR);
            this.Controls.Add(this.fechasR);
            this.Controls.Add(this.personas);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label_creado);
            this.Controls.Add(this.calendario);
            this.Controls.Add(this.meter_hora);
            this.Controls.Add(this.num_comensales);
            this.Controls.Add(this.meter_usuario);
            this.Controls.Add(this.label_reservas);
            this.Controls.Add(this.boton_volver);
            this.Controls.Add(this.cartel_volver);
            this.Controls.Add(this.boton_salir);
            this.Controls.Add(this.pergamino);
            this.Name = "reservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.reservas_FormClosed);
            this.Load += new System.EventHandler(this.reservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cartel_volver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pergamino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_comensales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button boton_salir;
        private System.Windows.Forms.PictureBox cartel_volver;
        private System.Windows.Forms.Button boton_volver;
        private System.Windows.Forms.PictureBox pergamino;
        private System.Windows.Forms.Label label_reservas;
        private System.Windows.Forms.TextBox meter_usuario;
        private System.Windows.Forms.NumericUpDown num_comensales;
        private System.Windows.Forms.TextBox meter_hora;
        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.Label label_creado;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label personas;
        private System.Windows.Forms.Label fechasR;
        private System.Windows.Forms.Label horaR;
        private System.Windows.Forms.Button boton_reservar;
        private System.Windows.Forms.Button boton_borrar;
        private System.Windows.Forms.Label label_error;
    }
}