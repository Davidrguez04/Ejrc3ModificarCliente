using Ejrc3ModificarCliente.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejrc3ModificarCliente.Servicios
{
    internal class ClienteNuevoImpl:ClienteNuevoInterfaz
    {
        public void darAltaClienteNuevo(List<ClienteDto2> listaAntigua)
        {
            ClienteDto2 cliente2 = crearNuevoCliente();
            listaAntigua.Add(cliente2);
        }

        private ClienteDto2 crearNuevoCliente()
        {
            ClienteDto2 nuevoCliente = new ClienteDto2();

            Console.WriteLine("Intoduzca el id: ");
            nuevoCliente.Id = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Introduzca el dni:");
            nuevoCliente.Dni = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Introduzca IBAN:");
            nuevoCliente.Iban = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Introduzca la fecha alta:");
            nuevoCliente.FchAlta = Convert.ToString(Console.ReadLine());

            nuevoCliente.CodigoS = "CSI1SSXX";
            return nuevoCliente;
        }

        public void borrarCliente(List<ClienteDto2> listaAntigua)
        {
            InterfazMenu mi = new ImplMenu();
            string dnibuscar=mi.pedirDni();

            //Posición
            int i;
            bool aBorrar = false;

            for ( i = 0;i<listaAntigua.Count();i++)
            {
                if (listaAntigua[i].Dni.Equals(dnibuscar))
                {
                    aBorrar = true;
                    break;
                }
            }
            if(aBorrar)
            {
                listaAntigua.RemoveAt(i);
            }
            else
            {
                Console.WriteLine("[INFO]--El cliente no existe");
            }
            

        }

        
    }
}
