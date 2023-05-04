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
    public partial class PAYPAL : Form
    {
        USUARIOS us = DATOS.datus;
        DATOS_COMPRAS dc = DATOS.compra;
        public PAYPAL()
        {
            InitializeComponent();
        }

        private void PAYPAL_Load(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = us.foto;
            textBox1.Text = us.ci.ToString();
            textBox2.Text = us.nombres;
            textBox3.Text = us.apellidos;
            textBox6.Text = dc.precio.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != "" && textBox4.Text != "")
            {
                textBox6.Text = "0";
            }
            else
            {
                MessageBox.Show("Por favor agregue todos los datos");
            }
            
        }
    }
}
