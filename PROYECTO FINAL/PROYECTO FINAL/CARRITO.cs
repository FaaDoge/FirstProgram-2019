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
    public partial class CARRITO : Form
    {
        List<DATOS_COMPRAS> car = DATOS.Carrito;
        List<DATOS_COMPRAS> dese = DATOS.deseos;
        DATOS_COMPRAS agregados;
        DATOS_COMPRAS com = DATOS.compra;
        public CARRITO()
        {
            InitializeComponent();
        }
        private void mostrar()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < car.Count; i++)
            {
                agregados = car[i];
                if (agregados != null)
                {
                    dataGridView1.Rows.Add(agregados.id, agregados.producto,agregados.precio,agregados.marca, agregados.año,agregados.estado, agregados.critica);
                    dataGridView1.Rows[i].Tag = agregados;
                }

            }

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            agregados = (DATOS_COMPRAS)dataGridView1.CurrentRow.Tag;
        }
        private void CARRITO_Load(object sender, EventArgs e)
        {
            mostrar();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dese.Add(agregados);
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            int su = 0;
            com.precio = agregados.precio;
            for (int i = 0; i < car.Count; i++)
            {
                agregados = car[i];
                su = su + agregados.precio;
                
            }
            com.precio = su;
            if (com.precio != 0)
            {
                PAYPAL p = new PAYPAL();
                p.ShowDialog();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (agregados != null)
            {
                car.Remove(agregados);
                mostrar();
            }
        }
    }
}
