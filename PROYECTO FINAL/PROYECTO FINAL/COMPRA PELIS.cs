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
    public partial class COMPRA_PELIS : Form
    {
        List<DATOS_COMPRAS> peli = DATOS.pelis;
        List<DATOS_COMPRAS> musica = DATOS.music;
        List<DATOS_COMPRAS> carro = DATOS.Carrito;
        List<DATOS_COMPRAS> deseo = DATOS.deseos;
        DATOS_COMPRAS caracteristicas;
        DATOS_COMPRAS com = DATOS.compra;
        public COMPRA_PELIS()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            caracteristicas = (DATOS_COMPRAS)dataGridView1.CurrentRow.Tag;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mostrar();
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

        private void button2_Click(object sender, EventArgs e)
        {
            carro.Add(caracteristicas);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            deseo.Add(caracteristicas);
        }
        private void mostrar()
        {
            switch (comboBox1.Text)
            {

                case "Peliculas":
                    dataGridView1.Rows.Clear();
                    for (int i = 0; i < peli.Count; i++)
                    {
                        caracteristicas = peli[i];
                        dataGridView1.Rows.Add(caracteristicas.id, caracteristicas.producto, caracteristicas.precio, caracteristicas.marca, caracteristicas.año, caracteristicas.estado, caracteristicas.critica);
                        dataGridView1.Rows[i].Tag = caracteristicas;
                    }
                    break;
                case "Musica":
                    dataGridView1.Rows.Clear();
                    for (int i = 0; i < musica.Count; i++)
                    {
                        caracteristicas = musica[i];
                        dataGridView1.Rows.Add(caracteristicas.id, caracteristicas.producto, caracteristicas.precio, caracteristicas.marca, caracteristicas.año, caracteristicas.estado, caracteristicas.critica);
                        dataGridView1.Rows[i].Tag = caracteristicas;
                    }
                    break;
            }
        }
    }
}
