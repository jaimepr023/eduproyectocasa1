using eduproyectocasa1.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eduproyectocasa1.Servidores
{

    internal class MenuImplementacion : MenuInterfaz
    {
        /// <summary>
        /// Clase que implementa la interfaz del menu
        /// </summary>
        public void mensajeBienvenida()
        {
            string mensaje = "Bienvenido a la Grieta del Invocador.";
            Console.WriteLine(mensaje);
        }
        public int mostrarBucle()
        {
            int opcionIntroducida;
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Opcion 0. Salir");
            Console.WriteLine("Opcion 1. Buscar partida");
            Console.WriteLine("Opcion 2. Comprar un personaje");
            Console.WriteLine("------------------------------------");

            opcionIntroducida = Console.ReadKey(true).KeyChar-('0');

            return opcionIntroducida;

        }


    }


}