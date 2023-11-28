using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejrc3ModificarCliente.Servicios
{
    internal interface InterfazMenu
    {
        /// <summary>
        /// Método que muestra el mensaje de bienvenida
        /// 151123 -David RA
        /// </summary>
        public void mensajeBienvenida();

        /// <summary>
        /// Método que muestra el menú y recoge la opción del usuarios
        /// 151123- David RA
        /// </summary>
        /// <returns>un entero con la opción seleccionada</returns>
        public int mostrarMenu();

        public string pedirDni();
    }
}
