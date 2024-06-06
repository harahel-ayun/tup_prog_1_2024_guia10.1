namespace ejercicio1_guia10._1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.btnresultados = new System.Windows.Forms.Button();
            this.listBoxresultado = new System.Windows.Forms.ListBox();
            this.textdistancia = new System.Windows.Forms.TextBox();
            this.btnradiobici = new System.Windows.Forms.RadioButton();
            this.btnradiomoto = new System.Windows.Forms.RadioButton();
            this.btnradioauto = new System.Windows.Forms.RadioButton();
            this.btnradiotp = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 2;
            // 
            // btnregistrar
            // 
            this.btnregistrar.Location = new System.Drawing.Point(423, 80);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(96, 52);
            this.btnregistrar.TabIndex = 4;
            this.btnregistrar.Text = "Registrar Encuesta";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // btnresultados
            // 
            this.btnresultados.Location = new System.Drawing.Point(219, 137);
            this.btnresultados.Name = "btnresultados";
            this.btnresultados.Size = new System.Drawing.Size(93, 50);
            this.btnresultados.TabIndex = 5;
            this.btnresultados.Text = "Ver resultados";
            this.btnresultados.UseVisualStyleBackColor = true;
            this.btnresultados.Click += new System.EventHandler(this.btnresultados_Click);
            // 
            // listBoxresultado
            // 
            this.listBoxresultado.FormattingEnabled = true;
            this.listBoxresultado.ItemHeight = 16;
            this.listBoxresultado.Location = new System.Drawing.Point(22, 19);
            this.listBoxresultado.Name = "listBoxresultado";
            this.listBoxresultado.Size = new System.Drawing.Size(517, 116);
            this.listBoxresultado.TabIndex = 10;
            // 
            // textdistancia
            // 
            this.textdistancia.Location = new System.Drawing.Point(92, 36);
            this.textdistancia.Name = "textdistancia";
            this.textdistancia.Size = new System.Drawing.Size(119, 22);
            this.textdistancia.TabIndex = 11;
            // 
            // btnradiobici
            // 
            this.btnradiobici.AutoSize = true;
            this.btnradiobici.Location = new System.Drawing.Point(39, 18);
            this.btnradiobici.Name = "btnradiobici";
            this.btnradiobici.Size = new System.Drawing.Size(79, 20);
            this.btnradiobici.TabIndex = 6;
            this.btnradiobici.TabStop = true;
            this.btnradiobici.Text = "Bicicleta";
            this.btnradiobici.UseVisualStyleBackColor = true;
            this.btnradiobici.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnradiomoto
            // 
            this.btnradiomoto.AutoSize = true;
            this.btnradiomoto.Location = new System.Drawing.Point(39, 44);
            this.btnradiomoto.Name = "btnradiomoto";
            this.btnradiomoto.Size = new System.Drawing.Size(97, 20);
            this.btnradiomoto.TabIndex = 7;
            this.btnradiomoto.TabStop = true;
            this.btnradiomoto.Text = "Motocicleta";
            this.btnradiomoto.UseVisualStyleBackColor = true;
            // 
            // btnradioauto
            // 
            this.btnradioauto.AutoSize = true;
            this.btnradioauto.Location = new System.Drawing.Point(39, 70);
            this.btnradioauto.Name = "btnradioauto";
            this.btnradioauto.Size = new System.Drawing.Size(87, 20);
            this.btnradioauto.TabIndex = 8;
            this.btnradioauto.TabStop = true;
            this.btnradioauto.Text = "Automovil";
            this.btnradioauto.UseVisualStyleBackColor = true;
            // 
            // btnradiotp
            // 
            this.btnradiotp.AutoSize = true;
            this.btnradiotp.Location = new System.Drawing.Point(39, 96);
            this.btnradiotp.Name = "btnradiotp";
            this.btnradiotp.Size = new System.Drawing.Size(270, 20);
            this.btnradiotp.TabIndex = 9;
            this.btnradiotp.TabStop = true;
            this.btnradiotp.Text = "Transporte publico (colectivos,remis,etc)";
            this.btnradiotp.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnradiotp);
            this.groupBox1.Controls.Add(this.btnradioauto);
            this.groupBox1.Controls.Add(this.btnradiomoto);
            this.groupBox1.Controls.Add(this.btnradiobici);
            this.groupBox1.Location = new System.Drawing.Point(30, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 140);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de transporte de uso mas frecuente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.btnregistrar);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(45, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(553, 271);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingresar numero";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textdistancia);
            this.groupBox3.Location = new System.Drawing.Point(31, 182);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(374, 79);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Distancia aproximada segun el vehiculo seleccionado";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBoxresultado);
            this.groupBox4.Controls.Add(this.btnresultados);
            this.groupBox4.Location = new System.Drawing.Point(47, 325);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(550, 197);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resultados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 524);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Button btnresultados;
        private System.Windows.Forms.ListBox listBoxresultado;
        private System.Windows.Forms.TextBox textdistancia;
        private System.Windows.Forms.RadioButton btnradiobici;
        private System.Windows.Forms.RadioButton btnradiomoto;
        private System.Windows.Forms.RadioButton btnradioauto;
        private System.Windows.Forms.RadioButton btnradiotp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

