namespace taverna
{
    partial class foto_shield
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(foto_shield));
            this.libro_carta = new System.Windows.Forms.PictureBox();
            this.pergamino_carta = new System.Windows.Forms.PictureBox();
            this.label_cesta = new System.Windows.Forms.Label();
            this.label_bebidas = new System.Windows.Forms.Label();
            this.label_comidas = new System.Windows.Forms.Label();
            this.tb_pbebidas = new System.Windows.Forms.TextBox();
            this.tb_pcomida = new System.Windows.Forms.TextBox();
            this.boton_mostrar = new System.Windows.Forms.Button();
            this.cartel_volver = new System.Windows.Forms.PictureBox();
            this.boton_volver = new System.Windows.Forms.Button();
            this.boton_salir = new System.Windows.Forms.Button();
            this.label_total = new System.Windows.Forms.Label();
            this.mostrar_total = new System.Windows.Forms.TextBox();
            this.foto_escudo = new System.Windows.Forms.PictureBox();
            this.boton_pagar = new System.Windows.Forms.Button();
            this.pergamino_pago = new System.Windows.Forms.PictureBox();
            this.label_pago = new System.Windows.Forms.Label();
            this.boton_pago = new System.Windows.Forms.Button();
            this.label_pagado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.libro_carta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pergamino_carta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartel_volver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto_escudo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pergamino_pago)).BeginInit();
            this.SuspendLayout();
            // 
            // libro_carta
            // 
            this.libro_carta.BackColor = System.Drawing.Color.Transparent;
            this.libro_carta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("libro_carta.BackgroundImage")));
            this.libro_carta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.libro_carta.Location = new System.Drawing.Point(175, 39);
            this.libro_carta.Name = "libro_carta";
            this.libro_carta.Size = new System.Drawing.Size(661, 412);
            this.libro_carta.TabIndex = 0;
            this.libro_carta.TabStop = false;
            this.libro_carta.Click += new System.EventHandler(this.libro_carta_Click);
            // 
            // pergamino_carta
            // 
            this.pergamino_carta.BackColor = System.Drawing.Color.Transparent;
            this.pergamino_carta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pergamino_carta.Image = ((System.Drawing.Image)(resources.GetObject("pergamino_carta.Image")));
            this.pergamino_carta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pergamino_carta.Location = new System.Drawing.Point(219, 9);
            this.pergamino_carta.Name = "pergamino_carta";
            this.pergamino_carta.Size = new System.Drawing.Size(394, 64);
            this.pergamino_carta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pergamino_carta.TabIndex = 3;
            this.pergamino_carta.TabStop = false;
            this.pergamino_carta.Click += new System.EventHandler(this.pergamino_carta_Click);
            // 
            // label_cesta
            // 
            this.label_cesta.AutoSize = true;
            this.label_cesta.BackColor = System.Drawing.Color.NavajoWhite;
            this.label_cesta.Font = new System.Drawing.Font("MS Gothic", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label_cesta.ForeColor = System.Drawing.Color.Black;
            this.label_cesta.Image = ((System.Drawing.Image)(resources.GetObject("label_cesta.Image")));
            this.label_cesta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_cesta.Location = new System.Drawing.Point(255, 24);
            this.label_cesta.Name = "label_cesta";
            this.label_cesta.Size = new System.Drawing.Size(319, 35);
            this.label_cesta.TabIndex = 4;
            this.label_cesta.Text = "Registro compras";
            this.label_cesta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_cesta.Click += new System.EventHandler(this.label_cesta_Click);
            // 
            // label_bebidas
            // 
            this.label_bebidas.AutoSize = true;
            this.label_bebidas.BackColor = System.Drawing.Color.NavajoWhite;
            this.label_bebidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bebidas.Image = ((System.Drawing.Image)(resources.GetObject("label_bebidas.Image")));
            this.label_bebidas.Location = new System.Drawing.Point(295, 171);
            this.label_bebidas.Name = "label_bebidas";
            this.label_bebidas.Size = new System.Drawing.Size(181, 29);
            this.label_bebidas.TabIndex = 25;
            this.label_bebidas.Text = "Total bebidas:";
            this.label_bebidas.Click += new System.EventHandler(this.label_bebidas_Click);
            // 
            // label_comidas
            // 
            this.label_comidas.AutoSize = true;
            this.label_comidas.BackColor = System.Drawing.Color.NavajoWhite;
            this.label_comidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_comidas.Image = ((System.Drawing.Image)(resources.GetObject("label_comidas.Image")));
            this.label_comidas.Location = new System.Drawing.Point(304, 232);
            this.label_comidas.Name = "label_comidas";
            this.label_comidas.Size = new System.Drawing.Size(172, 29);
            this.label_comidas.TabIndex = 26;
            this.label_comidas.Text = "Total comida:";
            this.label_comidas.Click += new System.EventHandler(this.label_comidas_Click);
            // 
            // tb_pbebidas
            // 
            this.tb_pbebidas.BackColor = System.Drawing.Color.NavajoWhite;
            this.tb_pbebidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pbebidas.Location = new System.Drawing.Point(548, 165);
            this.tb_pbebidas.Name = "tb_pbebidas";
            this.tb_pbebidas.Size = new System.Drawing.Size(162, 35);
            this.tb_pbebidas.TabIndex = 27;
            this.tb_pbebidas.TextChanged += new System.EventHandler(this.tb_pbebidas_TextChanged);
            // 
            // tb_pcomida
            // 
            this.tb_pcomida.BackColor = System.Drawing.Color.NavajoWhite;
            this.tb_pcomida.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pcomida.Location = new System.Drawing.Point(548, 229);
            this.tb_pcomida.Name = "tb_pcomida";
            this.tb_pcomida.Size = new System.Drawing.Size(162, 35);
            this.tb_pcomida.TabIndex = 28;
            this.tb_pcomida.TextChanged += new System.EventHandler(this.tb_pcomida_TextChanged);
            // 
            // boton_mostrar
            // 
            this.boton_mostrar.BackColor = System.Drawing.Color.Peru;
            this.boton_mostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_mostrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.boton_mostrar.Location = new System.Drawing.Point(548, 352);
            this.boton_mostrar.Name = "boton_mostrar";
            this.boton_mostrar.Size = new System.Drawing.Size(84, 35);
            this.boton_mostrar.TabIndex = 29;
            this.boton_mostrar.Text = "Mostrar";
            this.boton_mostrar.UseVisualStyleBackColor = false;
            this.boton_mostrar.Click += new System.EventHandler(this.boton_mostrar_Click);
            // 
            // cartel_volver
            // 
            this.cartel_volver.BackColor = System.Drawing.Color.Transparent;
            this.cartel_volver.Image = ((System.Drawing.Image)(resources.GetObject("cartel_volver.Image")));
            this.cartel_volver.Location = new System.Drawing.Point(1, 0);
            this.cartel_volver.Name = "cartel_volver";
            this.cartel_volver.Size = new System.Drawing.Size(143, 127);
            this.cartel_volver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cartel_volver.TabIndex = 30;
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
            this.boton_volver.TabIndex = 31;
            this.boton_volver.Text = "Volver";
            this.boton_volver.UseVisualStyleBackColor = false;
            this.boton_volver.Click += new System.EventHandler(this.boton_volver_Click);
            // 
            // boton_salir
            // 
            this.boton_salir.BackColor = System.Drawing.Color.IndianRed;
            this.boton_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.boton_salir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.boton_salir.Location = new System.Drawing.Point(735, 423);
            this.boton_salir.Name = "boton_salir";
            this.boton_salir.Size = new System.Drawing.Size(65, 28);
            this.boton_salir.TabIndex = 32;
            this.boton_salir.Text = "Salir";
            this.boton_salir.UseVisualStyleBackColor = false;
            this.boton_salir.Click += new System.EventHandler(this.boton_salir_Click);
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.BackColor = System.Drawing.Color.NavajoWhite;
            this.label_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total.Image = ((System.Drawing.Image)(resources.GetObject("label_total.Image")));
            this.label_total.Location = new System.Drawing.Point(304, 302);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(80, 29);
            this.label_total.TabIndex = 33;
            this.label_total.Text = "Total:";
            this.label_total.Click += new System.EventHandler(this.label_total_Click);
            // 
            // mostrar_total
            // 
            this.mostrar_total.BackColor = System.Drawing.Color.NavajoWhite;
            this.mostrar_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrar_total.Location = new System.Drawing.Point(548, 296);
            this.mostrar_total.Name = "mostrar_total";
            this.mostrar_total.Size = new System.Drawing.Size(162, 35);
            this.mostrar_total.TabIndex = 34;
            this.mostrar_total.TextChanged += new System.EventHandler(this.mostrar_total_TextChanged);
            // 
            // foto_escudo
            // 
            this.foto_escudo.BackColor = System.Drawing.Color.Transparent;
            this.foto_escudo.Image = ((System.Drawing.Image)(resources.GetObject("foto_escudo.Image")));
            this.foto_escudo.Location = new System.Drawing.Point(-31, 229);
            this.foto_escudo.Name = "foto_escudo";
            this.foto_escudo.Size = new System.Drawing.Size(253, 222);
            this.foto_escudo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.foto_escudo.TabIndex = 35;
            this.foto_escudo.TabStop = false;
            this.foto_escudo.Click += new System.EventHandler(this.foto_escudo_Click);
            // 
            // boton_pagar
            // 
            this.boton_pagar.BackColor = System.Drawing.Color.Silver;
            this.boton_pagar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("boton_pagar.BackgroundImage")));
            this.boton_pagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.boton_pagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.boton_pagar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.boton_pagar.Location = new System.Drawing.Point(69, 311);
            this.boton_pagar.Name = "boton_pagar";
            this.boton_pagar.Size = new System.Drawing.Size(57, 53);
            this.boton_pagar.TabIndex = 36;
            this.boton_pagar.UseVisualStyleBackColor = false;
            this.boton_pagar.Click += new System.EventHandler(this.boton_pagar_Click);
            // 
            // pergamino_pago
            // 
            this.pergamino_pago.BackColor = System.Drawing.Color.Transparent;
            this.pergamino_pago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pergamino_pago.Image = ((System.Drawing.Image)(resources.GetObject("pergamino_pago.Image")));
            this.pergamino_pago.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pergamino_pago.Location = new System.Drawing.Point(15, 191);
            this.pergamino_pago.Name = "pergamino_pago";
            this.pergamino_pago.Size = new System.Drawing.Size(170, 67);
            this.pergamino_pago.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pergamino_pago.TabIndex = 37;
            this.pergamino_pago.TabStop = false;
            this.pergamino_pago.Click += new System.EventHandler(this.pergamino_pago_Click);
            // 
            // label_pago
            // 
            this.label_pago.AutoSize = true;
            this.label_pago.BackColor = System.Drawing.Color.NavajoWhite;
            this.label_pago.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pago.Image = ((System.Drawing.Image)(resources.GetObject("label_pago.Image")));
            this.label_pago.Location = new System.Drawing.Point(25, 200);
            this.label_pago.Name = "label_pago";
            this.label_pago.Size = new System.Drawing.Size(147, 48);
            this.label_pago.TabIndex = 45;
            this.label_pago.Text = "Elegir método \r\nde pago";
            this.label_pago.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_pago.Click += new System.EventHandler(this.label_pago_Click);
            // 
            // boton_pago
            // 
            this.boton_pago.BackColor = System.Drawing.Color.Peru;
            this.boton_pago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_pago.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.boton_pago.Location = new System.Drawing.Point(638, 352);
            this.boton_pago.Name = "boton_pago";
            this.boton_pago.Size = new System.Drawing.Size(84, 35);
            this.boton_pago.TabIndex = 46;
            this.boton_pago.Text = "Pagar";
            this.boton_pago.UseVisualStyleBackColor = false;
            this.boton_pago.Click += new System.EventHandler(this.boton_pago_Click);
            // 
            // label_pagado
            // 
            this.label_pagado.AutoSize = true;
            this.label_pagado.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_pagado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pagado.ForeColor = System.Drawing.Color.Red;
            this.label_pagado.Location = new System.Drawing.Point(372, 408);
            this.label_pagado.Name = "label_pagado";
            this.label_pagado.Size = new System.Drawing.Size(241, 24);
            this.label_pagado.TabIndex = 47;
            this.label_pagado.Text = "Pago realizado con éxito";
            this.label_pagado.Visible = false;
            this.label_pagado.Click += new System.EventHandler(this.label_pagado_Click);
            // 
            // foto_shield
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_pago);
            this.Controls.Add(this.pergamino_pago);
            this.Controls.Add(this.label_pagado);
            this.Controls.Add(this.boton_pago);
            this.Controls.Add(this.boton_pagar);
            this.Controls.Add(this.mostrar_total);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.boton_salir);
            this.Controls.Add(this.boton_volver);
            this.Controls.Add(this.cartel_volver);
            this.Controls.Add(this.boton_mostrar);
            this.Controls.Add(this.tb_pcomida);
            this.Controls.Add(this.tb_pbebidas);
            this.Controls.Add(this.label_comidas);
            this.Controls.Add(this.label_bebidas);
            this.Controls.Add(this.label_cesta);
            this.Controls.Add(this.pergamino_carta);
            this.Controls.Add(this.libro_carta);
            this.Controls.Add(this.foto_escudo);
            this.Name = "foto_shield";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form7";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.foto_shield_FormClosed);
            this.Load += new System.EventHandler(this.cesta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libro_carta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pergamino_carta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartel_volver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto_escudo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pergamino_pago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox libro_carta;
        private System.Windows.Forms.PictureBox pergamino_carta;
        private System.Windows.Forms.Label label_cesta;
        private System.Windows.Forms.Label label_bebidas;
        private System.Windows.Forms.Label label_comidas;
        private System.Windows.Forms.TextBox tb_pbebidas;
        private System.Windows.Forms.TextBox tb_pcomida;
        private System.Windows.Forms.Button boton_mostrar;
        private System.Windows.Forms.PictureBox cartel_volver;
        private System.Windows.Forms.Button boton_volver;
        private System.Windows.Forms.Button boton_salir;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.TextBox mostrar_total;
        private System.Windows.Forms.PictureBox foto_escudo;
        private System.Windows.Forms.Button boton_pagar;
        private System.Windows.Forms.PictureBox pergamino_pago;
        private System.Windows.Forms.Label label_pago;
        private System.Windows.Forms.Button boton_pago;
        private System.Windows.Forms.Label label_pagado;
    }
}