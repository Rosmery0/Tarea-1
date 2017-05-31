namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtpmes = new System.Windows.Forms.TextBox();
            this.txtpaño = new System.Windows.Forms.TextBox();
            this.txtaños = new System.Windows.Forms.TextBox();
            this.txtmeses = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblcuotas = new System.Windows.Forms.Label();
            this.lblganancia = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblmensual = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Footlight MT Light", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(169, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prestamos Rosario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Calculadora.Properties.Resources.dollar501;
            this.pictureBox1.Location = new System.Drawing.Point(439, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Footlight MT Light", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad prestada:";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(236, 135);
            this.txtcantidad.Multiline = true;
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(165, 24);
            this.txtcantidad.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Meses";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(365, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Porcentaje por año";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Años";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(365, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Porcentaje por mes";
            // 
            // txtpmes
            // 
            this.txtpmes.Location = new System.Drawing.Point(369, 202);
            this.txtpmes.Multiline = true;
            this.txtpmes.Name = "txtpmes";
            this.txtpmes.Size = new System.Drawing.Size(165, 24);
            this.txtpmes.TabIndex = 8;
            // 
            // txtpaño
            // 
            this.txtpaño.Location = new System.Drawing.Point(369, 271);
            this.txtpaño.Multiline = true;
            this.txtpaño.Name = "txtpaño";
            this.txtpaño.Size = new System.Drawing.Size(165, 24);
            this.txtpaño.TabIndex = 9;
            // 
            // txtaños
            // 
            this.txtaños.Location = new System.Drawing.Point(36, 271);
            this.txtaños.Multiline = true;
            this.txtaños.Name = "txtaños";
            this.txtaños.Size = new System.Drawing.Size(165, 24);
            this.txtaños.TabIndex = 10;
            // 
            // txtmeses
            // 
            this.txtmeses.Location = new System.Drawing.Point(36, 202);
            this.txtmeses.Multiline = true;
            this.txtmeses.Name = "txtmeses";
            this.txtmeses.Size = new System.Drawing.Size(165, 24);
            this.txtmeses.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(-3, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(661, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "_________________________________________________________________________________" +
    "____________________________";
            // 
            // lblcuotas
            // 
            this.lblcuotas.AutoSize = true;
            this.lblcuotas.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcuotas.Location = new System.Drawing.Point(328, 401);
            this.lblcuotas.Name = "lblcuotas";
            this.lblcuotas.Size = new System.Drawing.Size(0, 20);
            this.lblcuotas.TabIndex = 13;
            // 
            // lblganancia
            // 
            this.lblganancia.AutoSize = true;
            this.lblganancia.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblganancia.Location = new System.Drawing.Point(328, 369);
            this.lblganancia.Name = "lblganancia";
            this.lblganancia.Size = new System.Drawing.Size(0, 20);
            this.lblganancia.TabIndex = 14;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(328, 338);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(0, 20);
            this.lbltotal.TabIndex = 15;
            // 
            // lblmensual
            // 
            this.lblmensual.AutoSize = true;
            this.lblmensual.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensual.Location = new System.Drawing.Point(66, 401);
            this.lblmensual.Name = "lblmensual";
            this.lblmensual.Size = new System.Drawing.Size(0, 20);
            this.lblmensual.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(66, 369);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 20);
            this.label12.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(66, 338);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 20);
            this.label13.TabIndex = 18;
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(236, 202);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(101, 34);
            this.btncalcular.TabIndex = 19;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.Location = new System.Drawing.Point(236, 262);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(101, 34);
            this.btnlimpiar.TabIndex = 20;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 509);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblmensual);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lblganancia);
            this.Controls.Add(this.lblcuotas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtmeses);
            this.Controls.Add(this.txtaños);
            this.Controls.Add(this.txtpaño);
            this.Controls.Add(this.txtpmes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtpmes;
        private System.Windows.Forms.TextBox txtpaño;
        private System.Windows.Forms.TextBox txtaños;
        private System.Windows.Forms.TextBox txtmeses;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblcuotas;
        private System.Windows.Forms.Label lblganancia;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblmensual;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpiar;

    }
}

