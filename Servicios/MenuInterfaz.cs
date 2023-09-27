using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eduproyectocasa1.Servicios
{
    /// <summary>
    /// interfaz principal que va en relacion a nuestro metodo
    /// 260923-jpr
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que muestra nuestro mensaje
        /// 260923-jpr
        /// </summary>
        public void mensajeBienvenida();

        /// <summary>
        /// Metodo que muestra el bucle por pantalla
        /// 270923-jpr
        /// </summary>
        /// <return>Devuelve un entero en la posicion seleccionada</return>
        public int mostrarBucle();
    }
}