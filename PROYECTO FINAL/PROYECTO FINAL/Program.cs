using System;
using System.Windows.Forms;
using System.IO;

namespace PROYECTO_FINAL
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            Leer();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GG ingreso = new GG();
            if (ingreso.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MENU_PRINCIPAL());
            }
        }
        static void Leer()
        {
            
            StreamReader sr = new StreamReader(@"C:\Users\fabry\Downloads\uu.txt");
            string l = sr.ReadLine();
                while (l != null)
                {
                    string[] datosus = l.Split('|');
                    USUARIOS obusu = new USUARIOS();
                    obusu.usuario = datosus[0].ToString();
                    obusu.ci = int.Parse(datosus[1].ToString());
                    obusu.nombres = datosus[2].ToString();
                    obusu.apellidos = datosus[3].ToString();
                    obusu.correo = datosus[4].ToString();
                    obusu.fecha= datosus[5].ToString();
                    obusu.pais = datosus[6].ToString();
                    obusu.contra = datosus[7].ToString();
                    obusu.foto = datosus[8].ToString();
                    DATOS.usuarios.Add(obusu);
                    l = sr.ReadLine();
                }
                sr.Close();
            //Domesticos
            StreamReader srdomesticos = new StreamReader(@"C:\Users\fabry\Downloads\domesticosC.txt");
            l = srdomesticos.ReadLine();
            while (l != null)
            {
                string[] datosdom = l.Split('|');
                DATOS_COMPRAS domes = new DATOS_COMPRAS();
                domes.id = int.Parse(datosdom[0].ToString());
                domes.producto = datosdom[1].ToString();
                domes.precio = int.Parse(datosdom[2].ToString());
                domes.marca = datosdom[3].ToString();
                domes.año = datosdom[4].ToString();
                domes.estado = datosdom[5].ToString();
                domes.critica = datosdom[6].ToString();
                DATOS.domesticosC.Add(domes);
                l = srdomesticos.ReadLine();
            }
            srdomesticos.Close();
            //Domesticos
            srdomesticos = new StreamReader(@"C:\Users\fabry\Downloads\domesticosM.txt");
            l = srdomesticos.ReadLine();
            while (l != null)
            {
                string[] datosdom = l.Split('|');
                DATOS_COMPRAS domes = new DATOS_COMPRAS();
                domes.id = int.Parse(datosdom[0].ToString());
                domes.producto = datosdom[1].ToString();
                domes.precio = int.Parse(datosdom[2].ToString());
                domes.marca = datosdom[3].ToString();
                domes.año = datosdom[4].ToString();
                domes.estado = datosdom[5].ToString();
                domes.critica = datosdom[6].ToString();
                DATOS.domesticosM.Add(domes);
                l = srdomesticos.ReadLine();
            }
            srdomesticos.Close();


            //libros
            //Cientificos
            StreamReader srlibros = new StreamReader(@"C:\Users\fabry\Downloads\librosCientificos.txt");
            l = srlibros.ReadLine();
            while (l != null)
            {
                string[] datosli = l.Split('|');
                DATOS_COMPRAS lib = new DATOS_COMPRAS();
                lib.id = int.Parse(datosli[0].ToString());
                lib.producto = datosli[1].ToString();
                lib.precio = int.Parse(datosli[2].ToString());
                lib.marca = datosli[3].ToString();
                lib.año = datosli[4].ToString();
                lib.estado = datosli[5].ToString();
                lib.critica = datosli[6].ToString();
                DATOS.librosC.Add(lib);
                l = srlibros.ReadLine();
            }
            srlibros.Close();

            //Literatura
            srlibros = new StreamReader(@"C:\Users\fabry\Downloads\librosLiteratura.txt");
            l = srlibros.ReadLine();
            while (l != null)
            {
                string[] datosli = l.Split('|');
                DATOS_COMPRAS lib = new DATOS_COMPRAS();
                lib.id = int.Parse(datosli[0].ToString());
                lib.producto = datosli[1].ToString();
                lib.precio = int.Parse(datosli[2].ToString());
                lib.marca = datosli[3].ToString();
                lib.año = datosli[4].ToString();
                lib.estado = datosli[5].ToString();
                lib.critica = datosli[6].ToString();
                DATOS.librosL.Add(lib);
                l = srlibros.ReadLine();
            }
            srlibros.Close();

            //Dramas
            srlibros = new StreamReader(@"C:\Users\fabry\Downloads\librosDramas.txt");
            l = srlibros.ReadLine();
            while (l != null)
            {
                string[] datosli = l.Split('|');
                DATOS_COMPRAS lib = new DATOS_COMPRAS();
                lib.id = int.Parse(datosli[0].ToString());
                lib.producto = datosli[1].ToString();
                lib.precio = int.Parse(datosli[2].ToString());
                lib.marca = datosli[3].ToString();
                lib.año = datosli[4].ToString();
                lib.estado = datosli[5].ToString();
                lib.critica = datosli[6].ToString();
                DATOS.librosD.Add(lib);
                l = srlibros.ReadLine();
            }
            srlibros.Close();
            //niños
            srlibros = new StreamReader(@"C:\Users\fabry\Downloads\librosniños.txt");
            l = srlibros.ReadLine();
            while (l != null)
            {
                string[] datosli = l.Split('|');
                DATOS_COMPRAS lib = new DATOS_COMPRAS();
                lib.id = int.Parse(datosli[0].ToString());
                lib.producto = datosli[1].ToString();
                lib.precio = int.Parse(datosli[2].ToString());
                lib.marca = datosli[3].ToString();
                lib.año = datosli[4].ToString();
                lib.estado = datosli[5].ToString();
                lib.critica = datosli[6].ToString();
                DATOS.librosN.Add(lib);
                l = srlibros.ReadLine();
            }
            srlibros.Close();


            //Electronicos
            //Electrodomesticos
            StreamReader srE = new StreamReader(@"C:\Users\fabry\Downloads\Edomesticos.txt");
            l = srE.ReadLine();
            while (l != null)
            {
                string[] datosE = l.Split('|');
                DATOS_COMPRAS E = new DATOS_COMPRAS();
                E.id = int.Parse(datosE[0].ToString());
                E.producto = datosE[1].ToString();
                E.precio = int.Parse(datosE[2].ToString());
                E.marca = datosE[3].ToString();
                E.año = datosE[4].ToString();
                E.estado = datosE[5].ToString();
                E.critica = datosE[6].ToString();
                DATOS.electronicosE.Add(E);
                l = srE.ReadLine();
            }
            srE.Close();
            //Computadoras
            srE = new StreamReader(@"C:\Users\fabry\Downloads\Ecomputadoras.txt");
            l = srE.ReadLine();
            while (l != null)
            {
                string[] datosE = l.Split('|');
                DATOS_COMPRAS E = new DATOS_COMPRAS();
                E.id = int.Parse(datosE[0].ToString());
                E.producto = datosE[1].ToString();
                E.precio = int.Parse(datosE[2].ToString());
                E.marca = datosE[3].ToString();
                E.año = datosE[4].ToString();
                E.estado = datosE[5].ToString();
                E.critica = datosE[6].ToString();
                DATOS.electronicosC.Add(E);
                l = srE.ReadLine();
            }
            srE.Close();
            //Celulares
            srE = new StreamReader(@"C:\Users\fabry\Downloads\Ecelulares.txt");
            l = srE.ReadLine();
            while (l != null)
            {
                string[] datosE = l.Split('|');
                DATOS_COMPRAS E = new DATOS_COMPRAS();
                E.id = int.Parse(datosE[0].ToString());
                E.producto = datosE[1].ToString();
                E.precio = int.Parse(datosE[2].ToString());
                E.marca = datosE[3].ToString();
                E.año = datosE[4].ToString();
                E.estado = datosE[5].ToString();
                E.critica = datosE[6].ToString();
                DATOS.electronicosCE.Add(E);
                l = srE.ReadLine();
            }
            srE.Close();
            //Consolas
            srE = new StreamReader(@"C:\Users\fabry\Downloads\Econsolas.txt");
            l = srE.ReadLine();
            while (l != null)
            {
                string[] datosE = l.Split('|');
                DATOS_COMPRAS E = new DATOS_COMPRAS();
                E.id = int.Parse(datosE[0].ToString());
                E.producto = datosE[1].ToString();
                E.precio = int.Parse(datosE[2].ToString());
                E.marca = datosE[3].ToString();
                E.año = datosE[4].ToString();
                E.estado = datosE[5].ToString();
                E.critica = datosE[6].ToString();
                DATOS.electronicosCO.Add(E);
                l = srE.ReadLine();
            }
            srE.Close();

            //autps
            StreamReader autos = new StreamReader(@"C:\Users\fabry\Downloads\AUP.txt");
            l = autos.ReadLine();
            while (l != null)
            {
                string[] datosdom = l.Split('|');
                DATOS_COMPRAS domes = new DATOS_COMPRAS();
                domes.id = int.Parse(datosdom[0].ToString());
                domes.producto = datosdom[1].ToString();
                domes.precio = int.Parse(datosdom[2].ToString());
                domes.marca = datosdom[3].ToString();
                domes.año = datosdom[4].ToString();
                domes.estado = datosdom[5].ToString();
                domes.critica = datosdom[6].ToString();
                DATOS.AUP.Add(domes);
                l = autos.ReadLine();
            }
            autos.Close();
            //autos
            autos = new StreamReader(@"C:\Users\fabry\Downloads\AUT.txt");
            l = autos.ReadLine();
            while (l != null)
            {
                string[] datosdom = l.Split('|');
                DATOS_COMPRAS domes = new DATOS_COMPRAS();
                domes.id = int.Parse(datosdom[0].ToString());
                domes.producto = datosdom[1].ToString();
                domes.precio = int.Parse(datosdom[2].ToString());
                domes.marca = datosdom[3].ToString();
                domes.año = datosdom[4].ToString();
                domes.estado = datosdom[5].ToString();
                domes.critica = datosdom[6].ToString();
                DATOS.AUT.Add(domes);
                l = autos.ReadLine();
            }
            autos.Close();
            //pelis
            StreamReader pelis = new StreamReader(@"C:\Users\fabry\Downloads\pelis.txt");
            l = pelis.ReadLine();
            while (l != null)
            {
                string[] datosdom = l.Split('|');
                DATOS_COMPRAS domes = new DATOS_COMPRAS();
                domes.id = int.Parse(datosdom[0].ToString());
                domes.producto = datosdom[1].ToString();
                domes.precio = int.Parse(datosdom[2].ToString());
                domes.marca = datosdom[3].ToString();
                domes.año = datosdom[4].ToString();
                domes.estado = datosdom[5].ToString();
                domes.critica = datosdom[6].ToString();
                DATOS.pelis.Add(domes);
                l = pelis.ReadLine();
            }
            pelis.Close();
            //autos
            pelis = new StreamReader(@"C:\Users\fabry\Downloads\musica.txt");
            l = pelis.ReadLine();
            while (l != null)
            {
                string[] datosdom = l.Split('|');
                DATOS_COMPRAS domes = new DATOS_COMPRAS();
                domes.id = int.Parse(datosdom[0].ToString());
                domes.producto = datosdom[1].ToString();
                domes.precio = int.Parse(datosdom[2].ToString());
                domes.marca = datosdom[3].ToString();
                domes.año = datosdom[4].ToString();
                domes.estado = datosdom[5].ToString();
                domes.critica = datosdom[6].ToString();
                DATOS.music.Add(domes);
                l = pelis.ReadLine();
            }
            pelis.Close();
        }
    }
}
