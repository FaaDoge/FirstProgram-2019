namespace PROYECTO_FINAL
{
    partial class REGISTRO
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.texfecha = new System.Windows.Forms.DateTimePicker();
            this.texnombre = new System.Windows.Forms.TextBox();
            this.texapellido = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.texusuario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.texcontra = new System.Windows.Forms.TextBox();
            this.texcontraC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.texcorreo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.texpais = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label11 = new System.Windows.Forms.Label();
            this.texci = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(249, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(462, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(249, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha Nac.";
            // 
            // texfecha
            // 
            this.texfecha.Location = new System.Drawing.Point(318, 142);
            this.texfecha.Name = "texfecha";
            this.texfecha.Size = new System.Drawing.Size(100, 20);
            this.texfecha.TabIndex = 7;
            this.texfecha.Value = new System.DateTime(1999, 1, 13, 0, 0, 0, 0);
            // 
            // texnombre
            // 
            this.texnombre.Location = new System.Drawing.Point(318, 70);
            this.texnombre.Name = "texnombre";
            this.texnombre.Size = new System.Drawing.Size(100, 20);
            this.texnombre.TabIndex = 9;
            // 
            // texapellido
            // 
            this.texapellido.Location = new System.Drawing.Point(530, 70);
            this.texapellido.Name = "texapellido";
            this.texapellido.Size = new System.Drawing.Size(100, 20);
            this.texapellido.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Registrarse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(56, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Usuario:";
            // 
            // texusuario
            // 
            this.texusuario.Location = new System.Drawing.Point(108, 216);
            this.texusuario.Name = "texusuario";
            this.texusuario.Size = new System.Drawing.Size(100, 20);
            this.texusuario.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(249, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Contraseña:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(462, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Confirmar C:";
            // 
            // texcontra
            // 
            this.texcontra.Location = new System.Drawing.Point(319, 216);
            this.texcontra.Name = "texcontra";
            this.texcontra.PasswordChar = '*';
            this.texcontra.Size = new System.Drawing.Size(100, 20);
            this.texcontra.TabIndex = 17;
            // 
            // texcontraC
            // 
            this.texcontraC.Location = new System.Drawing.Point(530, 216);
            this.texcontraC.Name = "texcontraC";
            this.texcontraC.PasswordChar = '*';
            this.texcontraC.Size = new System.Drawing.Size(100, 20);
            this.texcontraC.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(462, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Correo:";
            // 
            // texcorreo
            // 
            this.texcorreo.Location = new System.Drawing.Point(531, 142);
            this.texcorreo.Name = "texcorreo";
            this.texcorreo.Size = new System.Drawing.Size(100, 20);
            this.texcorreo.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(56, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Pais:";
            // 
            // texpais
            // 
            this.texpais.Location = new System.Drawing.Point(108, 142);
            this.texpais.Name = "texpais";
            this.texpais.Size = new System.Drawing.Size(100, 20);
            this.texpais.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(303, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "REGISTRO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(261, 319);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Foto:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(318, 278);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(56, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "CI:";
            // 
            // texci
            // 
            this.texci.Location = new System.Drawing.Point(107, 70);
            this.texci.Name = "texci";
            this.texci.Size = new System.Drawing.Size(100, 20);
            this.texci.TabIndex = 27;
            // 
            // REGISTRO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROYECTO_FINAL.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(684, 432);
            this.Controls.Add(this.texci);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.texpais);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.texcorreo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.texcontraC);
            this.Controls.Add(this.texcontra);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.texusuario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.texapellido);
            this.Controls.Add(this.texnombre);
            this.Controls.Add(this.texfecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "REGISTRO";
            this.Text = "REGISTRO";
            this.Load += new System.EventHandler(this.REGISTRO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker texfecha;
        private System.Windows.Forms.TextBox texnombre;
        private System.Windows.Forms.TextBox texapellido;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox texusuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox texcontra;
        private System.Windows.Forms.TextBox texcontraC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox texcorreo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox texpais;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox texci;
    }
}