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
    public partial class VENTAS : Form
    {
        public VENTAS()
        {
            InitializeComponent();
        }
        List<DATOS_COMPRAS> pro = DATOS.ventas;
        //libros
        List<DATOS_COMPRAS> dat = DATOS.librosC;
        List<DATOS_COMPRAS> datD = DATOS.librosD;
        List<DATOS_COMPRAS> datL = DATOS.librosL;
        List<DATOS_COMPRAS> datN = DATOS.librosN;
        //domesticos
        List<DATOS_COMPRAS> domM = DATOS.domesticosM;
        List<DATOS_COMPRAS> domC = DATOS.domesticosC;
        //electronicos
        List<DATOS_COMPRAS> elec = DATOS.electronicosE;
        List<DATOS_COMPRAS> elecC = DATOS.electronicosC;
        List<DATOS_COMPRAS> elecCE = DATOS.electronicosCE;
        List<DATOS_COMPRAS> elecCO = DATOS.electronicosCO;
        //Transporte
        List<DATOS_COMPRAS> autp = DATOS.AUP;
        List<DATOS_COMPRAS> autt = DATOS.AUT;
        //pelis
        List<DATOS_COMPRAS> peli = DATOS.pelis;
        List<DATOS_COMPRAS> musica = DATOS.music;
        DATOS_COMPRAS objeto;
        private void VENTAS_Load(object sender, EventArgs e)
        {
            mostrar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            agregar();
            mostrar();
            
        }
        private void agregar()
        {
            objeto = new DATOS_COMPRAS();
            objeto.id = int.Parse(textID.Text);
            objeto.producto = textPro.Text;
            objeto.precio = int.Parse(textPrecio.Text);
            objeto.marca = textmarca.Text;
            objeto.año = textBox1.Text;
            objeto.tipo = listtipo.Text;
            objeto.categoria = comboCategoria.Text;
            objeto.critica = "Sin criticas";
            if (radioButton1.Checked == true)
            {
                objeto.estado = "Nuevo";
            }
            if (radioButton2.Checked == true)
            {
                objeto.estado = "Usado";
            }
            if (radioButton3.Checked == true)
            {
                objeto.estado = "Dañado";
            }
            pro.Add(objeto);
            verificar();
        }
        private void verificar()
        {
            switch (listtipo.Text.ToLower())
            {
                case "cientificos":
                    dat.Add(objeto);
                    StreamWriter sper = new StreamWriter(@"C:\Users\fabry\Downloads\librosCientificos.txt");
                    foreach (DATOS_COMPRAS objeto in dat)
                    {
                        sper.WriteLine(objeto.id + "|" + objeto.producto + "|" + objeto.precio + "|" + objeto.marca + "|" + objeto.año + "|" + objeto.estado + "|" + objeto.critica);
                    }
                    sper.Close();
                    break;
                case "literatura y lingüísticos":
                    datL.Add(objeto);
                    sper = new StreamWriter(@"C:\Users\fabry\Downloads\librosLiteratura.txt");
                    foreach (DATOS_COMPRAS objeto in datL)
                    {
                        sper.WriteLine(objeto.id + "|" + objeto.producto + "|" + objeto.precio + "|" + objeto.marca + "|" + objeto.año + "|" + objeto.estado + "|" + objeto.critica);
                    }
                    sper.Close();
                    break;
                case "dramas":
                    datD.Add(objeto);
                    sper = new StreamWriter(@"C:\Users\fabry\Downloads\librosDramas.txt");
                    foreach (DATOS_COMPRAS objeto in datD)
                    {
                        sper.WriteLine(objeto.id + "|" + objeto.producto + "|" + objeto.precio + "|" + objeto.marca + "|" + objeto.año + "|" + objeto.estado + "|" + objeto.critica);
                    }
                    sper.Close();
                    break;
                case "niños":
                    datN.Add(objeto);
                    sper = new StreamWriter(@"C:\Users\fabry\Downloads\librosniños.txt");
                    foreach (DATOS_COMPRAS objeto in datN)
                    {
                        sper.WriteLine(objeto.id + "|" + objeto.producto + "|" + objeto.precio + "|" + objeto.marca + "|" + objeto.año + "|" + objeto.estado + "|" + objeto.critica);
                    }
                    sper.Close();
                    break;
                case "muebles":
                    domM.Add(objeto);
                    sper = new StreamWriter(@"C:\Users\fabry\Downloads\domesticosM.txt");
                    foreach (DATOS_COMPRAS objeto in domM)
                    {
                        sper.WriteLine(objeto.id + "|" + objeto.producto + "|" + objeto.precio + "|" + objeto.marca + "|" + objeto.año + "|" + objeto.estado + "|" + objeto.critica);
                    }
                    sper.Close();
                    break;
                case "comodidad":
                    domC.Add(objeto);
                    sper = new StreamWriter(@"C:\Users\fabry\Downloads\domesticosC.txt");
                    foreach (DATOS_COMPRAS objeto in domC)
                    {
                        sper.WriteLine(objeto.id + "|" + objeto.producto + "|" + objeto.precio + "|" + objeto.marca + "|" + objeto.año + "|" + objeto.estado + "|" + objeto.critica);
                    }
                    sper.Close();
                    break;
                case "electrodomesticos":
                    elec.Add(objeto);
                    sper = new StreamWriter(@"C:\Users\fabry\Downloads\Edomesticos.txt");
                    foreach (DATOS_COMPRAS objeto in elec)
                    {
                        sper.WriteLine(objeto.id + "|" + objeto.producto + "|" + objeto.precio + "|" + objeto.marca + "|" + objeto.año + "|" + objeto.estado + "|" + objeto.critica);
                    }
                    sper.Close();
                    break;
                case "computadoras":
                    elecC.Add(objeto);
                    sper = new StreamWriter(@"C:\Users\fabry\Downloads\Ecomputadoras.txt");
                    foreach (DATOS_COMPRAS objeto in elecC)
                    {
                        sper.WriteLine(objeto.id + "|" + objeto.producto + "|" + objeto.precio + "|" + objeto.marca + "|" + objeto.año + "|" + objeto.estado + "|" + objeto.critica);
                    }
                    sper.Close();
                    break;
                case "celulares":
                    elecCE.Add(objeto);
                    sper = new StreamWriter(@"C:\Users\fabry\Downloads\Ecelulares.txt");
                    foreach (DATOS_COMPRAS objeto in elecCE)
                    {
                        sper.WriteLine(objeto.id + "|" + objeto.producto + "|" + objeto.precio + "|" + objeto.marca + "|" + objeto.año + "|" + objeto.estado + "|" + objeto.critica);
                    }
                    sper.Close();
                    break;
                case "consolas":
                    elecCO.Add(objeto);
                    sper = new StreamWriter(@"C:\Users\fabry\Downloads\Econsolas.txt");
                    foreach (DATOS_COMPRAS objeto in elecCO)
                    {
                        sper.WriteLine(objeto.id + "|" + objeto.producto + "|" + objeto.precio + "|" + objeto.marca + "|" + objeto.año + "|" + objeto.estado + "|" + objeto.critica);
                    }
                    sper.Close();
                    break;
                case "pequeños":
                    autp.Add(objeto);
                    sper = new StreamWriter(@"C:\Users\fabry\Downloads\AUP.txt");
                    foreach (DATOS_COMPRAS objeto in autp)
                    {
                        sper.WriteLine(objeto.id + "|" + objeto.producto + "|" + objeto.precio + "|" + objeto.marca + "|" + objeto.año + "|" + objeto.estado + "|" + objeto.critica);
                    }
                    sper.Close();
                    break;
                case "todo terrenos":
                    autt.Add(objeto);
                    sper = new StreamWriter(@"C:\Users\fabry\Downloads\AUT.txt");
                    foreach (DATOS_COMPRAS objeto in autt)
                    {
                        sper.WriteLine(objeto.id + "|" + objeto.producto + "|" + objeto.precio + "|" + objeto.marca + "|" + objeto.año + "|" + objeto.estado + "|" + objeto.critica);
                    }
                    sper.Close();
                    break;
                case "peliculas":
                    peli.Add(objeto);
                    sper = new StreamWriter(@"C:\Users\fabry\Downloads\pelis.txt");
                    foreach (DATOS_COMPRAS objeto in peli)
                    {
                        sper.WriteLine(objeto.id + "|" + objeto.producto + "|" + objeto.precio + "|" + objeto.marca + "|" + objeto.año + "|" + objeto.estado + "|" + objeto.critica);
                    }
                    sper.Close();
                    break;
                case "muscia":
                    musica.Add(objeto);
                    sper = new StreamWriter(@"C:\Users\fabry\Downloads\musica.txt");
                    foreach (DATOS_COMPRAS objeto in musica)
                    {
                        sper.WriteLine(objeto.id + "|" + objeto.producto + "|" + objeto.precio + "|" + objeto.marca + "|" + objeto.año + "|" + objeto.estado + "|" + objeto.critica);
                    }
                    sper.Close();
                    break;

            }
        }
        private void mostrar()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < pro.Count; i++)
            {
                objeto = pro[i];
                if (objeto != null)
                {
                    dataGridView1.Rows.Add(objeto.id, objeto.producto, objeto.precio, objeto.marca,objeto.año,objeto.categoria, objeto.tipo, objeto.estado);
                    dataGridView1.Rows[i].Tag = objeto;
                }
            }

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionar();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }

        private void comboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboCategoria.Text.ToLower())
            {
                case "libros":
                    listtipo.Items.Clear();
                    listtipo.Items.Add("Cientificos");
                    listtipo.Items.Add("Literatura y lingüísticos");
                    listtipo.Items.Add("Dramas");
                    listtipo.Items.Add("Niños");
                    break;
                case "domesticos":
                    listtipo.Items.Clear();
                    listtipo.Items.Add("Comodidad");
                    listtipo.Items.Add("Muebles");
                    break;
                case "electronicos":
                    listtipo.Items.Clear();
                    listtipo.Items.Add("Electrodomesticos");
                    listtipo.Items.Add("Computadoras");
                    listtipo.Items.Add("Celulares");
                    listtipo.Items.Add("Consolas");
                    break;
                case "transporte":
                    listtipo.Items.Clear();
                    listtipo.Items.Add("Pequeños");
                    listtipo.Items.Add("Todo terrenos");
                    break;
                case "entretenimiento":
                    listtipo.Items.Clear();
                    listtipo.Items.Add("Peliculas");
                    listtipo.Items.Add("Musica");
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            editar();
        }
        
        private void seleccionar()
        {
            objeto = (DATOS_COMPRAS)dataGridView1.CurrentRow.Tag;
            textID.Text = objeto.id.ToString();
            textPro.Text = objeto.producto;
            textPrecio.Text = objeto.precio.ToString();
            textmarca.Text = objeto.marca;
            textBox1.Text = objeto.año;
            comboCategoria.Text = objeto.categoria;
            listtipo.Text = objeto.tipo;

            if (objeto.estado == "Nuevo")
            {
                radioButton1.Checked = true;
            }
            if (objeto.estado == "Usado")
            {
                radioButton2.Checked = true;
            }
            if (objeto.estado == "Dañado")
            {
                radioButton3.Checked = true;
            }
        }
        private void editar()
        {
            if (objeto != null)
            {
                objeto.id = int.Parse(textID.Text);
                objeto.producto = textPro.Text;
                objeto.precio = int.Parse(textPrecio.Text);
                objeto.marca = textmarca.Text;
                objeto.año = textBox1.Text;
                objeto.categoria = comboCategoria.Text;
                objeto.tipo = listtipo.Text;
                if (radioButton1.Checked == true)
                {
                    objeto.estado = "Nuevo";
                }
                if (radioButton2.Checked == true)
                {
                    objeto.estado = "Usado";
                }
                if (radioButton3.Checked == true)
                {
                    objeto.estado = "Dañado";
                }
                mostrar();
                switch (listtipo.Text.ToLower())
                {
                    case "cientificos":
                        
                        StreamWriter sper = new StreamWriter(@"C:\Users\fabry\Downloads\librosCientificos.txt");
                        foreach (DATOS_COMPRAS objeto in dat)
                        {
                            sper.WriteLine(objeto.id + "|" + objeto.producto + "|" + objeto.precio + "|" + objeto.marca + "|" + objeto.año + "|" + objeto.estado + "|" + objeto.critica);
                        }
                        sper.Close();
                        break;
                    case "literatura y lingüísticos":
                        
                        sper = new StreamWriter(@"C:\Users\fabry\Downloads\librosLiteratura.txt");
                        foreach (DATOS_COMPRAS objeto in datL)
                        {
                            sper.WriteLine(objeto.id + "|" + objeto.producto + "|" + objeto.precio + "|" + objeto.marca + "|" + objeto.año + "|" + objeto.estado + "|" + objeto.critica);
                        }
                        sper.Close();
                        break;
                    case "dramas":
                        
                        sper = new StreamWriter(@"C:\Users\fabry\Downloads\librosDramas.txt");
                        foreach (DATOS_COMPRAS objeto in datD)
                        {
                            sper.WriteLine(objeto.id + "|" + objeto.producto + "|" + objeto.precio + "|" + objeto.marca + "|" + objeto.año + "|" + objeto.estado + "|" + objeto.critica);
                        }
                        sper.Close();
                        break;
                    case "niños":
                        
                        sper = new StreamWriter(@"C:\Users\fabry\Downloads\librosniños.txt");
                        foreach (DATOS_COMPRAS objeto in datN)
                        {
                            sper.WriteLine(objeto.id + "|" + objeto.producto + "|" + objeto.precio + "|" + objeto.marca + "|" + objeto.año + "|" + objeto.estado + "|" + objeto.critica);
                        }
                        sper.Close();
                        break;
                    case "muebles":
                        
                        sper = new StreamWriter(@"C:\Users\fabry\Downloads\domesticosM.txt");
                        foreach (DATOS_COMPRAS objeto in domM)
                        {
                            sper.WriteLine(objeto.id + "|" + objeto.producto + "|" + objeto.precio + "|" + objeto.marca + "|" + objeto.año + "|" + objeto.estado + "|" + objeto.critica);
                        }
                        sper.Close();
                        break;
                    case "comodidad":
                        
                        sper = new StreamWriter(@"C:\Users\fabry\Downloads\domesticosC.txt");
                        foreach (DATOS_COMPRAS objeto in domC)
                        {
                            sper.WriteLine(objeto.id + "|" + objeto.producto + "|" + objeto.precio + "|" + objeto.marca + "|" + objeto.año + "|" + objeto.estado + "|" + objeto.critica);
                        }
                        sper.Close();
                        break;
                    case "electrodomesticos":
                        
                        sper = new StreamWriter(@"C:\Users\fabry\Downloads\Edomesticos.txt");
                        foreach (DATOS_COMPRAS objeto in elec)
                        {
                            sper.WriteLine(objeto.id + "|" + objeto.producto + "|" + objeto.precio + "|" + objeto.marca + "|" + objeto.año + "|" + objeto.estado + "|" + objeto.critica);
                        }
                        sper.Close();
                        break;
                    case "computadoras":
                        
                        sper = new StreamWriter(@"C:\Users\fabry\Downloads\Ecomputadoras.txt");
                        foreach (DATOS_COMPRAS objeto in elecC)
                        {
                            sper.WriteLine(objeto.id + "|" + objeto.producto + "|" + objeto.precio + "|" + objeto.marca + "|" + objeto.año + "|" + objeto.estado + "|" + objeto.critica);
                        }
                        sper.Close();
                        break;
                    case "celulares":
                        
                        sper = new StreamWriter(@"C:\Users\fabry\Downloads\Ecelulares.txt");
                        foreach (DATOS_COMPRAS objeto in elecCE)
                        {
                            sper.WriteLine(objeto.id + "|" + objeto.producto + "|" + objeto.precio + "|" + objeto.marca + "|" + objeto.año + "|" + objeto.estado + "|" + objeto.critica);
                        }
                        sper.Close();
                        break;
                    case "consolas":
                        
                        sper = new StreamWriter(@"C:\Users\fabry\Downloads\Econsolas.txt");
                        foreach (DATOS_COMPRAS objeto in elecCO)
                        {
                            sper.WriteLine(objeto.id + "|" + objeto.producto + "|" + objeto.precio + "|" + objeto.marca + "|" + objeto.año + "|" + objeto.estado + "|" + objeto.critica);
                        }
                        sper.Close();
                        break;
                    case "pequeños":
                        
                        sper = new StreamWriter(@"C:\Users\fabry\Downloads\AUP.txt");
                        foreach (DATOS_COMPRAS objeto in autp)
                        {
                            sper.WriteLine(objeto.id + "|" + objeto.producto + "|" + objeto.precio + "|" + objeto.marca + "|" + objeto.año + "|" + objeto.estado + "|" + objeto.critica);
                        }
                        sper.Close();
                        break;
                    case "todo terrenos":
                        
                        sper = new StreamWriter(@"C:\Users\fabry\Downloads\AUT.txt");
                        foreach (DATOS_COMPRAS objeto in autt)
                        {
                            sper.WriteLine(objeto.id + "|" + objeto.producto + "|" + objeto.precio + "|" + objeto.marca + "|" + objeto.año + "|" + objeto.estado + "|" + objeto.critica);
                        }
                        sper.Close();
                        break;
                    case "peliculas":
                       
                        sper = new StreamWriter(@"C:\Users\fabry\Downloads\pelis.txt");
                        foreach (DATOS_COMPRAS objeto in peli)
                        {
                            sper.WriteLine(objeto.id + "|" + objeto.producto + "|" + objeto.precio + "|" + objeto.marca + "|" + objeto.año + "|" + objeto.estado + "|" + objeto.critica);
                        }
                        sper.Close();
                        break;
                    case "muscia":
                        
                        sper = new StreamWriter(@"C:\Users\fabry\Downloads\musica.txt");
                        foreach (DATOS_COMPRAS objeto in musica)
                        {
                            sper.WriteLine(objeto.id + "|" + objeto.producto + "|" + objeto.precio + "|" + objeto.marca + "|" + objeto.año + "|" + objeto.estado + "|" + objeto.critica);
                        }
                        sper.Close();
                        break;

                }
            }
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (objeto != null)
            {
                pro.Remove(objeto);
                mostrar();
                switch (listtipo.Text.ToLower())
                {
                    case "cientificos":
                        dat.Remove(objeto);
                        StreamWriter sper = new StreamWriter(@"C:\Users\fabry\Downloads\librosCientificos.txt");
                        foreach (DATOS_COMPRAS objeto in dat)
                        {
                            sper.WriteLine(objeto.id + "|" + objeto.producto + "|" + objeto.precio + "|" + objeto.marca + "|" + objeto.año + "|" + objeto.estado + "|" + objeto.critica);
                        }
                        sper.Close();
                        break;
                    case "literatura y lingüísticos":
                        datL.Remove(objeto);
                        sper = new StreamWriter(@"C:\Users\fabry\Downloads\librosLiteratura.txt");
                        foreach (DATOS_COMPRAS objeto in datL)
                        {
                            sper.WriteLine(objeto.id + "|" + objeto.producto + "|" + objeto.precio + "|" + objeto.marca + "|" + objeto.año + "|" + objeto.estado + "|" + objeto.critica);
                        }
                        sper.Close();
                        break;
                    case "dramas":
                        datD.Remove(objeto);
                        sper = new StreamWriter(@"C:\Users\fabry\Downloads\librosDramas.txt");
                        foreach (DATOS_COMPRAS objeto in datD)
                        {
                            sper.WriteLine(objeto.id + "|" + objeto.producto + "|" + objeto.precio + "|" + objeto.marca + "|" + objeto.año + "|" + objeto.estado + "|" + objeto.critica);
                        }
                        sper.Close();
                        break;
                    case "niños":
                        datN.Remove(objeto);
                        sper = new StreamWriter(@"C:\Users\fabry\Downloads\librosniños.txt");
                        foreach (DATOS_COMPRAS objeto in datN)
                        {
                            sper.WriteLine(objeto.id + "|" + objeto.producto + "|" + objeto.precio + "|" + objeto.marca + "|" + objeto.año + "|" + objeto.estado + "|" + objeto.critica);
                        }
                        sper.Close();
                        break;
                    case "muebles":
                        domM.Remove(objeto);
                        sper = new StreamWriter(@"C:\Users\fabry\Downloads\domesticosM.txt");
                        foreach (DATOS_COMPRAS objeto in domM)
                        {
                            sper.WriteLine(objeto.id + "|" + objeto.producto + "|" + objeto.precio + "|" + objeto.marca + "|" + objeto.año + "|" + objeto.estado + "|" + objeto.critica);
                        }
                        sper.Close();
                        break;
                    case "comodidad":
                        domC.Remove(objeto);
                        sper = new StreamWriter(@"C:\Users\fabry\Downloads\domesticosC.txt");
                        foreach (DATOS_COMPRAS objeto in domC)
                        {
                            sper.WriteLine(objeto.id + "|" + objeto.producto + "|" + objeto.precio + "|" + objeto.marca + "|" + objeto.año + "|" + objeto.estado + "|" + objeto.critica);
                        }
                        sper.Close();
                        break;
                    case "electrodomesticos":
                        elec.Remove(objeto);
                        sper = new StreamWriter(@"C:\Users\fabry\Downloads\Edomesticos.txt");
                        foreach (DATOS_COMPRAS objeto in elec)
                        {
                            sper.WriteLine(objeto.id + "|" + objeto.producto + "|" + objeto.precio + "|" + objeto.marca + "|" + objeto.año + "|" + objeto.estado + "|" + objeto.critica);
                        }
                        sper.Close();
                        break;
                    case "computadoras":
                        elecC.Remove(objeto);
                        sper = new StreamWriter(@"C:\Users\fabry\Downloads\Ecomputadoras.txt");
                        foreach (DATOS_COMPRAS objeto in elecC)
                        {
                            sper.WriteLine(objeto.id + "|" + objeto.producto + "|" + objeto.precio + "|" + objeto.marca + "|" + objeto.año + "|" + objeto.estado + "|" + objeto.critica);
                        }
                        sper.Close();
                        break;
                    case "celulares":
                        elecCE.Remove(objeto);
                        sper = new StreamWriter(@"C:\Users\fabry\Downloads\Ecelulares.txt");
                        foreach (DATOS_COMPRAS objeto in elecCE)
                        {
                            sper.WriteLine(objeto.id + "|" + objeto.producto + "|" + objeto.precio + "|" + objeto.marca + "|" + objeto.año + "|" + objeto.estado + "|" + objeto.critica);
                        }
                        sper.Close();
                        break;
                    case "consolas":
                        elecCO.Remove(objeto);
                        sper = new StreamWriter(@"C:\Users\fabry\Downloads\Econsolas.txt");
                        foreach (DATOS_COMPRAS objeto in elecCO)
                        {
                            sper.WriteLine(objeto.id + "|" + objeto.producto + "|" + objeto.precio + "|" + objeto.marca + "|" + objeto.año + "|" + objeto.estado + "|" + objeto.critica);
                        }
                        sper.Close();
                        break;
                    case "pequeños":
                        autp.Remove(objeto);
                        sper = new StreamWriter(@"C:\Users\fabry\Downloads\AUP.txt");
                        foreach (DATOS_COMPRAS objeto in autp)
                        {
                            sper.WriteLine(objeto.id + "|" + objeto.producto + "|" + objeto.precio + "|" + objeto.marca + "|" + objeto.año + "|" + objeto.estado + "|" + objeto.critica);
                        }
                        sper.Close();
                        break;
                    case "todo terrenos":
                        autt.Remove(objeto);
                        sper = new StreamWriter(@"C:\Users\fabry\Downloads\AUT.txt");
                        foreach (DATOS_COMPRAS objeto in autt)
                        {
                            sper.WriteLine(objeto.id + "|" + objeto.producto + "|" + objeto.precio + "|" + objeto.marca + "|" + objeto.año + "|" + objeto.estado + "|" + objeto.critica);
                        }
                        sper.Close();
                        break;
                    case "peliculas":
                        peli.Remove(objeto);
                        sper = new StreamWriter(@"C:\Users\fabry\Downloads\pelis.txt");
                        foreach (DATOS_COMPRAS objeto in peli)
                        {
                            sper.WriteLine(objeto.id + "|" + objeto.producto + "|" + objeto.precio + "|" + objeto.marca + "|" + objeto.año + "|" + objeto.estado + "|" + objeto.critica);
                        }
                        sper.Close();
                        break;
                    case "muscia":
                        musica.Remove(objeto);
                        sper = new StreamWriter(@"C:\Users\fabry\Downloads\musica.txt");
                        foreach (DATOS_COMPRAS objeto in musica)
                        {
                            sper.WriteLine(objeto.id + "|" + objeto.producto + "|" + objeto.precio + "|" + objeto.marca + "|" + objeto.año + "|" + objeto.estado + "|" + objeto.critica);
                        }
                        sper.Close();
                        break;
                }
            }
        }
    }
}
