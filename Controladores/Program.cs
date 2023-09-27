using eduproyectocasa1.Servicios;
using eduproyectocasa1.Servidores;

namespace eduproyectocasa1.Controladores
{/// <summary>
/// Clase principal de la aplicacion
/// 260923-jpr
/// </summary>

    class program
    {

        /// <summary>
        /// Metodo inicial de nuestra aplicacion
        /// 260923-jpr
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            MenuInterfaz menuInterfaz = new MenuImplementacion();
            menuInterfaz.mensajeBienvenida();
        
        // Variable para poder entrar o cerrar el bucle.(como una llave)
        bool cerrarBucle = false;

        //Se trata de la opcion que se selecciona.
        int opcionSeleccionar;

        //condicion para entrar en el while/bucle y se debe cumplir la condicion 
       
            while (!cerrarBucle)
       
            {
            opcionSeleccionar = menuInterfaz.mostrarBucle();
                Console.WriteLine(opcionSeleccionar);

                switch (opcionSeleccionar) {
                    case 0:
                        Console.WriteLine("[INFOS] - La aplicacion se cerrara.");
                        cerrarBucle = true;
                        break;
                    case 1:
                        Console.WriteLine("[INFOS] - Estas buscando partida, acepta cuando quieras empezarla.");
                        break;
                    case 2:
                        Console.WriteLine("[INFOS] - Elige el personaje que quieras comprar");
                        break;
                    default:
                        Console.WriteLine("[INFOS] - La opcion seleccionada no existe");
                        break;
                }

            }

        }
       
           

    }
}