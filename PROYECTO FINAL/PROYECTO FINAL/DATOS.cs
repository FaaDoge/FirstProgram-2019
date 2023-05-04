using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL
{
    class DATOS
    {
        public static List<USUARIOS> usuarios = new List<USUARIOS>();
        public static List<DATOS_COMPRAS> Carrito = new List<DATOS_COMPRAS>();
        public static List<DATOS_COMPRAS> deseos = new List<DATOS_COMPRAS>();
        public static List<DATOS_COMPRAS> ventas = new List<DATOS_COMPRAS>();
        //libros
        public static List<DATOS_COMPRAS> librosC = new List<DATOS_COMPRAS>();
        public static List<DATOS_COMPRAS> librosL = new List<DATOS_COMPRAS>();
        public static List<DATOS_COMPRAS> librosD = new List<DATOS_COMPRAS>();
        public static List<DATOS_COMPRAS> librosN = new List<DATOS_COMPRAS>();
        //Electronicos
        public static List<DATOS_COMPRAS> electronicosE = new List<DATOS_COMPRAS>();
        public static List<DATOS_COMPRAS> electronicosC = new List<DATOS_COMPRAS>();
        public static List<DATOS_COMPRAS> electronicosCE = new List<DATOS_COMPRAS>();
        public static List<DATOS_COMPRAS> electronicosCO = new List<DATOS_COMPRAS>();
        //DOmesticos
        public static List<DATOS_COMPRAS> domesticosC = new List<DATOS_COMPRAS>();
        public static List<DATOS_COMPRAS> domesticosM = new List<DATOS_COMPRAS>();
        //Autos
        public static List<DATOS_COMPRAS> AUT = new List<DATOS_COMPRAS>();
        public static List<DATOS_COMPRAS> AUP = new List<DATOS_COMPRAS>();
        //ENtre
        public static List<DATOS_COMPRAS> music = new List<DATOS_COMPRAS>();
        public static List<DATOS_COMPRAS> pelis = new List<DATOS_COMPRAS>();
        //Usuarios
        public static USUARIOS datus = new USUARIOS();
        public static Administrador permisos = new Administrador();
        //paypal
        public static DATOS_COMPRAS compra = new DATOS_COMPRAS();
    }
}
