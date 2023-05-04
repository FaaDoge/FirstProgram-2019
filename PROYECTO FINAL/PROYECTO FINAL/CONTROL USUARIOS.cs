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
    public partial class CONTROL_USUARIOS : Form
    {
        public CONTROL_USUARIOS()
        {
            InitializeComponent();
        }
        List<USUARIOS> dat = DATOS.usuarios;
        USUARIOS lista;
        USUARIOS edi = new USUARIOS();
        private void CONTROL_USUARIOS_Load(object sender, EventArgs e)
        {

            mostrar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int com = 0;
            com = user(texuser.Text);
            if (com == 1)
            {
                if (texcontra.Text == textCcontra.Text)
                {
                    lista = new USUARIOS();
                    lista.ci = int.Parse(textCI.Text);
                    lista.nombres = textNOM.Text;
                    lista.apellidos = textAPE.Text;
                    lista.usuario = texuser.Text;
                    lista.correo = texcorreo.Text;
                    lista.contra = texcontra.Text;
                    lista.pais = texPAIS.Text;
                    lista.fecha = dateTimePicker1.Text;
                    lista.foto = pictureBox1.ImageLocation;
                    dat.Add(lista);
                    escribir();
                    mostrar();
                }
                else
                {
                    texcontra.Clear();
                    textCcontra.Clear();
                    MessageBox.Show("Contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                texuser.Clear();
                MessageBox.Show("Este nombre de usuario ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public int user(string u)
        {
            int r = 1;
            for (int i = 0; i < dat.Count; i++)
            {
                ;lista = dat[i];
                if (lista.usuario == u)
                {
                    r = 0;
                }
            }
            return r;
        }
        private void escribir()
        {
            StreamWriter sper = new StreamWriter(@"C:\Users\fabry\Downloads\uu.txt");
            foreach (USUARIOS lista in dat)
            {
                sper.WriteLine(lista.usuario + "|" + lista.ci + "|" + lista.nombres + "|" + lista.apellidos + "|" + lista.correo + "|" + lista.fecha + "|" + lista.pais + "|" + lista.contra + "|" + lista.foto);
            }
            sper.Close();
        }
        private void mostrar()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < dat.Count; i++)
            {
                lista = dat[i];
                if (lista != null)
                {
                    dataGridView1.Rows.Add(lista.usuario, lista.ci, lista.nombres, lista.apellidos, lista.fecha, lista.pais, lista.correo);
                    dataGridView1.Rows[i].Tag = lista;
                }

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (edi != null)
            {
                edi.usuario = texuser.Text;
                edi.ci = int.Parse(textCI.Text);
                edi.nombres = textNOM.Text;
                edi.apellidos = textAPE.Text;
                edi.fecha = dateTimePicker1.Text;
                edi.pais = texPAIS.Text;
                edi.correo = texcorreo.Text;
                escribir();
                mostrar();
            }
            

        }
        private void seleccionar()
        {
            edi = (USUARIOS)dataGridView1.CurrentRow.Tag;
            textNOM.Text = edi.nombres;
            textAPE.Text = edi.apellidos;
            texcontra.Text = edi.contra;
            texcorreo.Text = edi.correo;
            texPAIS.Text = edi.pais;
            textCcontra.Text = edi.contra;
            textCI.Text = edi.ci.ToString();
            texuser.Text = edi.usuario;
            dateTimePicker1.Text = edi.fecha;
            pictureBox1.ImageLocation = edi.foto;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lista != null)
            {
                dat.Remove(lista);
                mostrar();
            }
            escribir();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionar();
        }
    }
}
