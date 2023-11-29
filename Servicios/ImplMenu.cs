using Ejrc3ModificarCliente.Entidades;
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
        public long pedirId()
        {
            ClienteDto2 nuevoCliente= new ClienteDto2();    
            Console.WriteLine("Indica el Id del cliente: ");
            nuevoCliente.Id = Convert.ToInt64(Console.ReadLine());

            return nuevoCliente.Id;
        }

        public int mostrarMenuCampos()
        {

            int opcion;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t\t\t--------------------------------");
            Console.WriteLine("\t\t\t\t|\tCampos:            ");
            Console.WriteLine("\t\t\t\t|0.-Salir                     ");
            Console.WriteLine("\t\t\t\t|1.-IBAN                     ");
            Console.WriteLine("\t\t\t\t|2.- ID                    ");
            Console.WriteLine("\t\t\t\t|3.-Fecha Baja            ");
            Console.WriteLine("\t\t\t\t|4.-FechaAlta            ");
            Console.Write("\n\tSeleccione un campo: ");

            opcion = Console.ReadKey(true).KeyChar - ('0');

            return opcion;
        }
    }
}
