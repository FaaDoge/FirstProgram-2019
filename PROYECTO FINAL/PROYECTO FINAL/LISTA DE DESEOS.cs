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
    public partial class LISTA_DE_DESEOS : Form
    {
        public LISTA_DE_DESEOS()
        {
            InitializeComponent();
        }
        List<DATOS_COMPRAS> des = DATOS.deseos;
        List<DATOS_COMPRAS> carr = DATOS.Carrito;
        DATOS_COMPRAS agregado;
        private void LISTA_DE_DESEOS_Load(object sender, EventArgs e)
        {
            mostrar();
        }
        private void mostrar()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < des.Count; i++)
            {
                agregado = des[i];
                if (agregado != null)
                {
                    dataGridView1.Rows.Add(agregado.id, agregado.producto, agregado.precio, agregado.marca, agregado.año, agregado.estado, agregado.critica);
                    dataGridView1.Rows[i].Tag = agregado;
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            agregado = (DATOS_COMPRAS)dataGridView1.CurrentRow.Tag;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            carr.Add(agregado);
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (agregado != null)
            {
                des.Remove(agregado);
                mostrar();
            }
        }
    }
}