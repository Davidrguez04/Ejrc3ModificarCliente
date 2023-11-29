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
            ClienteDto2 clienteNuevo = crearNuevoCliente();
            InterfazMenu mi = new ImplMenu();
            clienteNuevo.Id = mi.pedirId();
            
            
            //long IdBuscar = mi.pedirId();
            
            //Esto es para controlar si el Id que introduce el cliente ya esta en uso
            foreach (ClienteDto2 cliente2 in listaAntigua)
            {
                if (cliente2.Id.Equals(clienteNuevo.Id))
                {
                    
                    Console.WriteLine("Introduzca otro id ya que este ya esta en uso: ");
                    clienteNuevo.Id = Convert.ToInt64(Console.ReadLine());


                    break;
                }
                else
                {
                    break;
                }
            }

            listaAntigua.Add(clienteNuevo);
        }

        private ClienteDto2 crearNuevoCliente()
        {
            ClienteDto2 nuevoCliente = new ClienteDto2();

            /*Console.WriteLine("Intoduzca el id: ");
            nuevoCliente.Id = Convert.ToInt64(Console.ReadLine());
            */
            

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
            string dniBuscar=mi.pedirDni();

            //Objeto específico
            ClienteDto2 clienteABorrar = new ClienteDto2();
            foreach(ClienteDto2 cliente2 in listaAntigua)
            {
                if (cliente2.Dni.Equals(dniBuscar))
                {
                    clienteABorrar = cliente2;

                    /* Se elimina por referencia de memoria no por valores de los campos
                     * clienteABorrar.FchBaja = cliente2.FchBaja;
                    clienteABorrar.FchAlta = cliente2.FchAlta;
                    clienteABorrar.Iban = cliente2.Iban;
                    clienteABorrar.CodigoS = cliente2.CodigoS;
                    clienteABorrar.Dni = cliente2.Dni;
                    clienteABorrar.Id = cliente2.Id;
                    */

                    break;
                }
            }
            listaAntigua.Remove(clienteABorrar);

            //Posición
            /*
            int i;
            bool aBorrar = false;

            for ( i = 0;i<listaAntigua.Count();i++)
            {
                if (listaAntigua[i].Dni.Equals(dniBuscar))
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
            */

        }
        public void modificarCliente(List<ClienteDto2> listaAntigua)
        {
            InterfazMenu mi = new ImplMenu();
            InterfazMenu me=new ImplMenu();

            string dniBuscar = mi.pedirDni();

            string campo;
            string nuevo;
            bool salir = false;

            ClienteDto2 campoCambio = new ClienteDto2();

            foreach (ClienteDto2 cliente2 in listaAntigua)
            {
                if (cliente2.Dni.Equals(dniBuscar))
                {
                    Console.WriteLine("\n"+cliente2.ToString());

                    
                    campoCambio= cliente2;
                    while(!salir)
                    {
                        int opcion = me.mostrarMenuCampos();

                        switch (opcion)
                        {
                            case 0:
                                salir = true;
                                break;
                            case 1:
                                
                                Console.WriteLine("Seleccionaste el campo IBAN");
                                Console.WriteLine("Introduzca el valor nuevo: ");
                                cliente2.Iban = Console.ReadLine();
                                break;
                            /*case 2:
                                Console.WriteLine("Seleccionaste el campo ID");
                                Console.WriteLine("Introduzca el valor nuevo: ");
                                cliente2.Id = Console.ReadLine();
                                break;*/
                            case 3:
                               
                                Console.WriteLine("Seleccionaste el campo Fecha Baja");
                                Console.WriteLine("Introduzca el valor nuevo: ");
                                cliente2.FchBaja = Console.ReadLine();
                                break;
                            case 4:
                                
                                Console.WriteLine("Seleccionaste el campo Fecha Alta");
                                Console.WriteLine("Introduzca el valor nuevo: ");
                                cliente2.FchAlta = Console.ReadLine();
                                break;

                            default:

                                Console.WriteLine("[ERROR]--EL valor introducido no es correcto!!!");
                                break;


                        }
                    } 

                }
            }
            
            //listaAntigua.Add(campoCambio);
            

            

            Console.WriteLine("");
        }

        
    }
}
