using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_FINAL
{
    public partial class GG : Form
    {
        List<USUARIOS> uss = DATOS.usuarios;
        USUARIOS reg = new USUARIOS();
        USUARIOS us = DATOS.datus;
        Administrador per = DATOS.permisos;
        public GG()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            REGISTRO registrar = new REGISTRO();
            registrar.ShowDialog();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            switch (textBox3.Text)
            {
                case "":
                    inicio();
                    break;
                case "2121":
                    per.f = true;
                    inicio();
                    break;
                default:
                    MessageBox.Show("Permisos Denegados");
                    break;
            }
            
        }
        public void inicio()
        {
            bool rev = false;
            for (int i = 0; i < uss.Count; i++) { 
                reg = uss[i];
                if (textBox2.Text == reg.contra && textBox1.Text == reg.usuario) { 
                    rev = true;
                    break;
                }
            }
            if (rev == true) { 
                this.DialogResult = DialogResult.OK;
                us.usuario = reg.usuario;
                us.foto = reg.foto;
                us.nombres = reg.nombres;
                us.apellidos = reg.apellidos;
                us.ci = reg.ci;
            }
            else {
                textBox1.Clear();
                textBox2.Clear();
                MessageBox.Show("Contraseña o usuario incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
