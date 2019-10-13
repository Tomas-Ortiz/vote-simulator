namespace Simulador_voto_electrónico
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Titulo = new System.Windows.Forms.Label();
            this.Texto1 = new System.Windows.Forms.TextBox();
            this.BotGenerar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Texto2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Texto3 = new System.Windows.Forms.TextBox();
            this.Cand3 = new System.Windows.Forms.TextBox();
            this.ListaResultados = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sexo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Edad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Provincia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BotBorrar = new System.Windows.Forms.Button();
            this.BotSalir = new System.Windows.Forms.Button();
            this.Cand2 = new System.Windows.Forms.TextBox();
            this.Cand1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CandidatoGanador = new System.Windows.Forms.Button();
            this.VotosTotales = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BotPrioridad = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Barra_progreso = new System.Windows.Forms.ProgressBar();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.VotosCandidato = new System.Windows.Forms.Button();
            this.BotCandidatoxProvincia = new System.Windows.Forms.Button();
            this.BotOrdenar_candidato = new System.Windows.Forms.Button();
            this.verGrafico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Titulo.Location = new System.Drawing.Point(198, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(0, 13);
            this.Titulo.TabIndex = 0;
            // 
            // Texto1
            // 
            this.Texto1.Location = new System.Drawing.Point(82, 115);
            this.Texto1.Name = "Texto1";
            this.Texto1.Size = new System.Drawing.Size(70, 20);
            this.Texto1.TabIndex = 1;
            // 
            // BotGenerar
            // 
            this.BotGenerar.Location = new System.Drawing.Point(225, 295);
            this.BotGenerar.Name = "BotGenerar";
            this.BotGenerar.Size = new System.Drawing.Size(116, 42);
            this.BotGenerar.TabIndex = 3;
            this.BotGenerar.Text = "Generar resultados";
            this.BotGenerar.UseVisualStyleBackColor = true;
            this.BotGenerar.Click += new System.EventHandler(this.BotGenerar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "CANDIDATOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seleccione la cantidad de votantes en cada provincia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mendoza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(153, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Buenos Aires";
            // 
            // Texto2
            // 
            this.Texto2.Location = new System.Drawing.Point(257, 115);
            this.Texto2.Name = "Texto2";
            this.Texto2.Size = new System.Drawing.Size(70, 20);
            this.Texto2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.Location = new System.Drawing.Point(340, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Córdoba";
            // 
            // Texto3
            // 
            this.Texto3.Location = new System.Drawing.Point(406, 115);
            this.Texto3.Name = "Texto3";
            this.Texto3.Size = new System.Drawing.Size(70, 20);
            this.Texto3.TabIndex = 10;
            // 
            // Cand3
            // 
            this.Cand3.Location = new System.Drawing.Point(367, 226);
            this.Cand3.Name = "Cand3";
            this.Cand3.Size = new System.Drawing.Size(137, 20);
            this.Cand3.TabIndex = 13;
            // 
            // ListaResultados
            // 
            this.ListaResultados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Cand,
            this.Sexo,
            this.Edad,
            this.Provincia,
            this.columnHeader1});
            this.ListaResultados.Location = new System.Drawing.Point(130, 373);
            this.ListaResultados.Name = "ListaResultados";
            this.ListaResultados.Size = new System.Drawing.Size(311, 140);
            this.ListaResultados.TabIndex = 14;
            this.ListaResultados.UseCompatibleStateImageBehavior = false;
            this.ListaResultados.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Id.Width = 35;
            // 
            // Cand
            // 
            this.Cand.Text = "Candidato";
            this.Cand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cand.Width = 90;
            // 
            // Sexo
            // 
            this.Sexo.Text = "Sexo";
            this.Sexo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Edad
            // 
            this.Edad.Text = "Edad";
            this.Edad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Edad.Width = 40;
            // 
            // Provincia
            // 
            this.Provincia.Text = "Provincia";
            this.Provincia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Provincia.Width = 75;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 1;
            // 
            // BotBorrar
            // 
            this.BotBorrar.Location = new System.Drawing.Point(10, 525);
            this.BotBorrar.Name = "BotBorrar";
            this.BotBorrar.Size = new System.Drawing.Size(86, 21);
            this.BotBorrar.TabIndex = 16;
            this.BotBorrar.Text = "Borrar todo";
            this.BotBorrar.UseVisualStyleBackColor = true;
            this.BotBorrar.Click += new System.EventHandler(this.BotBorrar_Click);
            // 
            // BotSalir
            // 
            this.BotSalir.Location = new System.Drawing.Point(470, 525);
            this.BotSalir.Name = "BotSalir";
            this.BotSalir.Size = new System.Drawing.Size(86, 21);
            this.BotSalir.TabIndex = 17;
            this.BotSalir.Text = "Salir";
            this.BotSalir.UseVisualStyleBackColor = true;
            this.BotSalir.Click += new System.EventHandler(this.BotSalir_Click);
            // 
            // Cand2
            // 
            this.Cand2.Location = new System.Drawing.Point(191, 226);
            this.Cand2.Name = "Cand2";
            this.Cand2.Size = new System.Drawing.Size(137, 20);
            this.Cand2.TabIndex = 23;
            // 
            // Cand1
            // 
            this.Cand1.Location = new System.Drawing.Point(26, 226);
            this.Cand1.Name = "Cand1";
            this.Cand1.Size = new System.Drawing.Size(137, 20);
            this.Cand1.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(170, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 18);
            this.label7.TabIndex = 25;
            this.label7.Text = "PROVINCIAS Y VOTANTES";
            // 
            // CandidatoGanador
            // 
            this.CandidatoGanador.Location = new System.Drawing.Point(446, 400);
            this.CandidatoGanador.Name = "CandidatoGanador";
            this.CandidatoGanador.Size = new System.Drawing.Size(116, 21);
            this.CandidatoGanador.TabIndex = 27;
            this.CandidatoGanador.Text = "Candidato ganador";
            this.CandidatoGanador.UseVisualStyleBackColor = true;
            this.CandidatoGanador.Click += new System.EventHandler(this.CandidatoGanador_Click);
            // 
            // VotosTotales
            // 
            this.VotosTotales.Location = new System.Drawing.Point(446, 470);
            this.VotosTotales.Name = "VotosTotales";
            this.VotosTotales.Size = new System.Drawing.Size(116, 21);
            this.VotosTotales.TabIndex = 28;
            this.VotosTotales.Text = "Votos totales";
            this.VotosTotales.UseVisualStyleBackColor = true;
            this.VotosTotales.Click += new System.EventHandler(this.VotosTotales_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Image = global::Simulador_voto_electrónico.Properties.Resources.Alien_Ink_2560X1600_Abstract_Background_1;
            this.label8.Location = new System.Drawing.Point(6, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 29;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::Simulador_voto_electrónico.Properties.Resources.Linea_horizontal;
            this.pictureBox3.Image = global::Simulador_voto_electrónico.Properties.Resources.Linea_horizontal;
            this.pictureBox3.Location = new System.Drawing.Point(-4, 264);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(570, 17);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Simulador_voto_electrónico.Properties.Resources.Linea_horizontal;
            this.pictureBox2.Image = global::Simulador_voto_electrónico.Properties.Resources.Linea_horizontal;
            this.pictureBox2.Location = new System.Drawing.Point(-4, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(570, 12);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Simulador_voto_electrónico.Properties.Resources.Linea_horizontal;
            this.pictureBox1.Image = global::Simulador_voto_electrónico.Properties.Resources.Linea_horizontal;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(570, 17);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(165, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 22);
            this.label9.TabIndex = 30;
            this.label9.Text = "VOTO ELECTRÓNICO";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Poor Richard", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(283, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Ingrese nombre y apellido de tres candidatos";
            // 
            // BotPrioridad
            // 
            this.BotPrioridad.Location = new System.Drawing.Point(5, 373);
            this.BotPrioridad.Name = "BotPrioridad";
            this.BotPrioridad.Size = new System.Drawing.Size(115, 25);
            this.BotPrioridad.TabIndex = 31;
            this.BotPrioridad.Text = "Ordenar por edad";
            this.BotPrioridad.UseVisualStyleBackColor = true;
            this.BotPrioridad.Click += new System.EventHandler(this.BotOrdenar_edad);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Simulador_voto_electrónico.Properties.Resources.voto;
            this.pictureBox4.Location = new System.Drawing.Point(358, 9);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(71, 28);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 32;
            this.pictureBox4.TabStop = false;
            // 
            // Barra_progreso
            // 
            this.Barra_progreso.Location = new System.Drawing.Point(130, 345);
            this.Barra_progreso.Name = "Barra_progreso";
            this.Barra_progreso.Size = new System.Drawing.Size(311, 23);
            this.Barra_progreso.TabIndex = 33;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(5, 438);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(115, 34);
            this.button5.TabIndex = 35;
            this.button5.Text = "Ordenar por provincia";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.BotOrdenar_provincia);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(5, 405);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 25);
            this.button4.TabIndex = 35;
            this.button4.Text = "Ordenar por sexo";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.BotOrdenar_sexo);
            // 
            // VotosCandidato
            // 
            this.VotosCandidato.Location = new System.Drawing.Point(446, 373);
            this.VotosCandidato.Name = "VotosCandidato";
            this.VotosCandidato.Size = new System.Drawing.Size(116, 21);
            this.VotosCandidato.TabIndex = 36;
            this.VotosCandidato.Text = "Votos por candidato";
            this.VotosCandidato.UseVisualStyleBackColor = true;
            this.VotosCandidato.Click += new System.EventHandler(this.VotosCandidato_Click);
            // 
            // BotCandidatoxProvincia
            // 
            this.BotCandidatoxProvincia.Location = new System.Drawing.Point(446, 428);
            this.BotCandidatoxProvincia.Name = "BotCandidatoxProvincia";
            this.BotCandidatoxProvincia.Size = new System.Drawing.Size(116, 36);
            this.BotCandidatoxProvincia.TabIndex = 37;
            this.BotCandidatoxProvincia.Text = "Candidato por provincia";
            this.BotCandidatoxProvincia.UseVisualStyleBackColor = true;
            this.BotCandidatoxProvincia.Click += new System.EventHandler(this.BotCandidatoxProvincia_Click);
            // 
            // BotOrdenar_candidato
            // 
            this.BotOrdenar_candidato.Location = new System.Drawing.Point(5, 480);
            this.BotOrdenar_candidato.Name = "BotOrdenar_candidato";
            this.BotOrdenar_candidato.Size = new System.Drawing.Size(115, 35);
            this.BotOrdenar_candidato.TabIndex = 38;
            this.BotOrdenar_candidato.Text = "Ordenar por candiddato";
            this.BotOrdenar_candidato.UseVisualStyleBackColor = true;
            this.BotOrdenar_candidato.Click += new System.EventHandler(this.BotOrdenar_candidato_Click);
            // 
            // verGrafico
            // 
            this.verGrafico.Location = new System.Drawing.Point(446, 493);
            this.verGrafico.Name = "verGrafico";
            this.verGrafico.Size = new System.Drawing.Size(116, 21);
            this.verGrafico.TabIndex = 39;
            this.verGrafico.Text = "Ver gráfico";
            this.verGrafico.UseVisualStyleBackColor = true;
            this.verGrafico.Click += new System.EventHandler(this.verGrafico_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Simulador_voto_electrónico.Properties.Resources.Alien_Ink_2560X1600_Abstract_Background_1;
            this.ClientSize = new System.Drawing.Size(568, 551);
            this.Controls.Add(this.verGrafico);
            this.Controls.Add(this.BotOrdenar_candidato);
            this.Controls.Add(this.BotCandidatoxProvincia);
            this.Controls.Add(this.VotosCandidato);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Barra_progreso);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.BotPrioridad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.VotosTotales);
            this.Controls.Add(this.CandidatoGanador);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Cand1);
            this.Controls.Add(this.Cand2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BotSalir);
            this.Controls.Add(this.BotBorrar);
            this.Controls.Add(this.ListaResultados);
            this.Controls.Add(this.Cand3);
            this.Controls.Add(this.Texto3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Texto2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BotGenerar);
            this.Controls.Add(this.Texto1);
            this.Controls.Add(this.Titulo);
            this.Name = "Principal";
            this.Text = "Voto electrónico";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.TextBox Texto1;
        private System.Windows.Forms.Button BotGenerar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Texto2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Texto3;
        private System.Windows.Forms.TextBox Cand3;
        private System.Windows.Forms.ListView ListaResultados;
        private System.Windows.Forms.Button BotBorrar;
        private System.Windows.Forms.Button BotSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox Cand2;
        private System.Windows.Forms.TextBox Cand1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button CandidatoGanador;
        private System.Windows.Forms.Button VotosTotales;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Cand;
        private System.Windows.Forms.ColumnHeader Sexo;
        private System.Windows.Forms.ColumnHeader Edad;
        private System.Windows.Forms.ColumnHeader Provincia;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button BotPrioridad;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ProgressBar Barra_progreso;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button VotosCandidato;
        private System.Windows.Forms.Button BotCandidatoxProvincia;
        private System.Windows.Forms.Button BotOrdenar_candidato;
        private System.Windows.Forms.Button verGrafico;
    }
}

