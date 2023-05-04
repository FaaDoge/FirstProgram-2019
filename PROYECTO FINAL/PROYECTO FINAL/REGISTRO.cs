using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PROYECTO_FINAL
{
    public partial class REGISTRO : Form
    {
      
        public REGISTRO()
        {
            InitializeComponent();
        }
        List<USUARIOS> us = DATOS.usuarios;
        
        USUARIOS reg;
        USUARIOS udat = DATOS.datus;
        private void button1_Click(object sender, EventArgs e)
        {
            registrar();
        }
        public void registrar()
        {
            int com=0;
            com = user(texusuario.Text);
            if (com == 1){ 
                if (texcontra.Text == texcontraC.Text) {
                    reg = new USUARIOS();
                    reg.ci = int.Parse(texci.Text);
                    reg.correo = texcorreo.Text;
                    reg.nombres = texnombre.Text;
                    reg.apellidos = texapellido.Text;
                    reg.usuario = texusuario.Text;
                    reg.contra = texcontra.Text;
                    reg.pais = texpais.Text;
                    reg.fecha = texfecha.Text;
                    reg.foto = pictureBox1.ImageLocation;
                    us.Add(reg);
                    escribir();
                    Close();
                }
                else { 
                    texcontra.Clear();
                    texcontraC.Clear();
                    MessageBox.Show("Contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else { 
                texusuario.Clear();
                MessageBox.Show("Este nombre de usuario ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        public int user(string u)
        {
            int r = 1;
                for (int i = 0; i < us.Count; i++)
                {
                    reg = us[i];
                    if (reg.usuario == u)
                    {
                        r = 0;
                    }
                }
            return r;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void REGISTRO_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation=openFileDialog1.FileName;
        }
        private void escribir()
        {
            StreamWriter sper = new StreamWriter(@"C:\Users\fabry\Downloads\uu.txt");
            foreach (USUARIOS re in us)
            {
                sper.WriteLine(re.usuario + "|" + re.ci + "|" + re.nombres + "|" + re.apellidos+"|"+re.correo+"|"+re.fecha+"|"+ re.pais+ "|" + re.contra+"|" + re.foto);
            }
            sper.Close();
        }

    }
}
