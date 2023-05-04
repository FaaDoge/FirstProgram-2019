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
    
    public partial class MENU_PRINCIPAL : Form
    {
        USUARIOS uel = DATOS.datus;
        Administrador per = DATOS.permisos;
        public MENU_PRINCIPAL()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           VENTAS vender = new VENTAS();
           vender.ShowDialog(); 
        }

        private void buELE_Click(object sender, EventArgs e)
        {
            COMPRA_LIBROS libros = new COMPRA_LIBROS();
            libros.ShowDialog();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CONTROL_USUARIOS us = new CONTROL_USUARIOS();
            us.ShowDialog();

        }

        private void MENU_PRINCIPAL_Load(object sender, EventArgs e)
        {
            if (per.f == true)
            {
                cerrarSesionToolStripMenuItem.Visible = true;
            }
            label1.Text = uel.usuario;
            pictureBox3.ImageLocation = uel.foto;
        }

        private void venderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CARRITO car = new CARRITO();
            car.ShowDialog();
        }

        private void cerrarSesionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void controlDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LISTA_DE_DESEOS lisd = new LISTA_DE_DESEOS();
            lisd.ShowDialog();
        }

        private void buCA_Click(object sender, EventArgs e)
        {
            COMPRA_ELECTRONICOS ce = new COMPRA_ELECTRONICOS();
            ce.ShowDialog();
        }

        private void buDO_Click(object sender, EventArgs e)
        {
            COMPRA_DOMESTICOS cd = new COMPRA_DOMESTICOS();
            cd.ShowDialog();
        }

        private void buTRA_Click(object sender, EventArgs e)
        {
            COMPRA_AUTOS ca = new COMPRA_AUTOS();
            ca.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void buEN_Click(object sender, EventArgs e)
        {
            COMPRA_PELIS p = new COMPRA_PELIS();
         p.ShowDialog();
        }
    }
}
