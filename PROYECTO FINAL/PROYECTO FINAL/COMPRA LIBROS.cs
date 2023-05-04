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

    public partial class COMPRA_LIBROS : Form
    {
        //libros
        List<DATOS_COMPRAS> libC = DATOS.librosC;
        List<DATOS_COMPRAS> libL = DATOS.librosL;
        List<DATOS_COMPRAS> libD = DATOS.librosD;
        List<DATOS_COMPRAS> libN = DATOS.librosN;

        List<DATOS_COMPRAS> carro = DATOS.Carrito;
        List<DATOS_COMPRAS> deseo = DATOS.deseos;
        DATOS_COMPRAS caracteristicas;
        DATOS_COMPRAS com = DATOS.compra;
        public COMPRA_LIBROS()
        {
            InitializeComponent();
        }

        private void COMPRA_LIBROS_Load(object sender, EventArgs e)
        {
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            caracteristicas = (DATOS_COMPRAS)dataGridView1.CurrentRow.Tag;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {

                case "Científicos":
                    dataGridView1.Rows.Clear();
                    for (int i = 0; i < libC.Count; i++)
                    {
                        caracteristicas = libC[i];
                        dataGridView1.Rows.Add(caracteristicas.id, caracteristicas.producto, caracteristicas.precio, caracteristicas.marca, caracteristicas.año, caracteristicas.estado, caracteristicas.critica);
                        dataGridView1.Rows[i].Tag = caracteristicas;
                    } 
                    break;
                case "Literatura y lingüísticos":
                    dataGridView1.Rows.Clear();
                    for (int i = 0; i < libL.Count; i++)
                    {   
                        caracteristicas = libL[i];
                        dataGridView1.Rows.Add(caracteristicas.id, caracteristicas.producto, caracteristicas.precio, caracteristicas.marca, caracteristicas.año, caracteristicas.estado, caracteristicas.critica);
                        dataGridView1.Rows[i].Tag = caracteristicas;
                    }
                    break;
                case "Dramas":
                    dataGridView1.Rows.Clear();
                    for (int i = 0; i < libD.Count; i++)
                    {
                        caracteristicas = libD[i];
                        dataGridView1.Rows.Add(caracteristicas.id, caracteristicas.producto, caracteristicas.precio, caracteristicas.marca, caracteristicas.año, caracteristicas.estado, caracteristicas.critica);
                        dataGridView1.Rows[i].Tag = caracteristicas;
                    }
                    break;
                case "Niños":
                    dataGridView1.Rows.Clear();
                    for (int i = 0; i < libN.Count; i++)
                    {
                        caracteristicas = libN[i];
                        dataGridView1.Rows.Add(caracteristicas.id, caracteristicas.producto, caracteristicas.precio, caracteristicas.marca, caracteristicas.año, caracteristicas.estado, caracteristicas.critica);
                        dataGridView1.Rows[i].Tag = caracteristicas;
                    }
                    break;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            carro.Add(caracteristicas);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            deseo.Add(caracteristicas);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            com.precio = caracteristicas.precio;
            if (com.precio != 0)
            {
                PAYPAL p = new PAYPAL();
                p.ShowDialog();
            }
        }
    }
}
