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
    public partial class COMPRA_ELECTRONICOS : Form
    {
        List<DATOS_COMPRAS> elec = DATOS.electronicosE;
        List<DATOS_COMPRAS> elecC = DATOS.electronicosC;
        List<DATOS_COMPRAS> elecCE = DATOS.electronicosCE;
        List<DATOS_COMPRAS> elecCO = DATOS.electronicosCO;
        List<DATOS_COMPRAS> carro = DATOS.Carrito;
        List<DATOS_COMPRAS> deseo = DATOS.deseos;
        DATOS_COMPRAS com = DATOS.compra;
        DATOS_COMPRAS caracteristicas;
        public COMPRA_ELECTRONICOS()
        {
            InitializeComponent();
        }

        private void COMPRA_ELECTRONICOS_Load(object sender, EventArgs e)
        {
            
        }
        

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            caracteristicas = (DATOS_COMPRAS)dataGridView1.CurrentRow.Tag;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {

                case "Electrodomesticos":
                    dataGridView1.Rows.Clear();
                    for (int i = 0; i < elec.Count; i++)
                    {
                        caracteristicas = elec[i];
                        dataGridView1.Rows.Add(caracteristicas.id, caracteristicas.producto, caracteristicas.precio, caracteristicas.marca, caracteristicas.año, caracteristicas.estado, caracteristicas.critica);
                        dataGridView1.Rows[i].Tag = caracteristicas;
                    }
                    break;
                case "Computadoras":
                    dataGridView1.Rows.Clear();
                    for (int i = 0; i < elecC.Count; i++)
                    {
                        caracteristicas = elecC[i];
                        dataGridView1.Rows.Add(caracteristicas.id, caracteristicas.producto, caracteristicas.precio, caracteristicas.marca, caracteristicas.año, caracteristicas.estado, caracteristicas.critica);
                        dataGridView1.Rows[i].Tag = caracteristicas;
                    }
                    break;
                case "Celulares":
                    dataGridView1.Rows.Clear();
                    for (int i = 0; i < elecCE.Count; i++)
                    {
                        caracteristicas = elecCE[i];
                        dataGridView1.Rows.Add(caracteristicas.id, caracteristicas.producto, caracteristicas.precio, caracteristicas.marca, caracteristicas.año, caracteristicas.estado, caracteristicas.critica);
                        dataGridView1.Rows[i].Tag = caracteristicas;
                    }
                    break;
                case "Consolas":
                    dataGridView1.Rows.Clear();
                    for (int i = 0; i < elecCO.Count; i++)
                    {
                        caracteristicas = elecCO[i];
                        dataGridView1.Rows.Add(caracteristicas.id, caracteristicas.producto, caracteristicas.precio, caracteristicas.marca, caracteristicas.año, caracteristicas.estado, caracteristicas.critica);
                        dataGridView1.Rows[i].Tag = caracteristicas;
                    }
                    break;
            }
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            carro.Add(caracteristicas);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            deseo.Add(caracteristicas);
        }
    }
}
