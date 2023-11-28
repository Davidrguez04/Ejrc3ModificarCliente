using Ejrc3ModificarCliente.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejrc3ModificarCliente.Servicios
{
    internal class ClienteImpl:ClienteInterfaz
    {
        public void darAltaCliente(List<ClienteDto> listaAntigua)
        {
            ClienteDto cliente = crearNuevoCliente();
            listaAntigua.Add(cliente);
        }

        private ClienteDto crearNuevoCliente()
        {
            ClienteDto nuevoCliente = new ClienteDto();

            Console.WriteLine("Intoduzca el id: ");
            nuevoCliente.IdCLiente = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Introduzca el nombre:");
            nuevoCliente.NombreCliente = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Introduzca el dni:");
            nuevoCliente.DniCliente = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Introduzca los apellidos:");
            nuevoCliente.ApellidosCliente = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Introduzca el cumpleaños:");
            nuevoCliente.FchNacimientoCliente = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Introduzca el email:");
            nuevoCliente.EmailCliente = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Introduzca el teléfono:");
            nuevoCliente.TlfCliente = Convert.ToInt32(Console.ReadLine());




            return nuevoCliente;
        }
    }
}
