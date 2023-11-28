using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejrc3ModificarCliente.Servicios
{
    internal class ImplMenu:InterfazMenu
    {
        public void mensajeBienvenida()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            string mensaje = "Bienvenido a cajero de CSI1";
            Console.WriteLine("\n\n\t\t\t\t" + mensaje);
        }
        public int mostrarMenu()
        {
            int opcion;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t\t\t--------------------------------");
            Console.WriteLine("\t\t\t\t|\tMenú:            ");
            Console.WriteLine("\t\t\t\t|0.-Salir                     ");
            Console.WriteLine("\t\t\t\t|1.-Dar de alta Cliente                     ");
            Console.WriteLine("\t\t\t\t|2.- Dar Alta Nuevo Cliente                     ");
            Console.WriteLine("\t\t\t\t|3.-Modificar datos Registro            ");
            Console.WriteLine("\t\t\t\t|4.-Eliminar un cliente            ");
            Console.WriteLine("\t\t\t\t|5.-Historial de operaciones            ");
            Console.WriteLine("\t\t\t\t|6.-Ingresar dinero                     ");
            Console.Write("\n\tSeleccione una opción: ");

            opcion = Console.ReadKey(true).KeyChar - ('0');

            return opcion;

        }
        public string pedirDni()
        {
            Console.WriteLine("Indica el dni del cliente: ");
            string dniCliente = Console.ReadLine();

            return dniCliente;
        }
    }
}
