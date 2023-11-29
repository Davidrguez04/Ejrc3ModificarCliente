/*Continuando con el proyecto del ejercicio 2, amplíalo con una funcionalidad más. 
El usuario, al seleccionar la opción 3, deberá poder modificar cualquiera de los campos (salvo el id) de un 
cliente; el cual especificará mediante el DNI.
Una vez indicado qué cliente se quiere modificar mediante el DNI, se preguntará qué campo específico se quiere 
modificar (queda a criterio del alumnado cómo hacerlo). Una vez indicado el campo, se solicitará el nuevo valor
y se llevará a cabo la modificación. El usuario tendrá la opción de seguir modificando campos antes de volver al 
menú principal.
 */

using Ejrc3ModificarCliente.Entidades;
using Ejrc3ModificarCliente.Servicios;

namespace Ejrc3ModificarCliente.Controladores
{
    class Program
    {
        static void Main(string[] args)
        {
            //lista para base de datos
            List<ClienteDto> listaCliente = new List<ClienteDto>();
            List<ClienteDto2> listaCliente2 = new List<ClienteDto2>();


            InterfazMenu menuInterfaz = new ImplMenu();
            ClienteInterfaz ci = new ClienteImpl();
            ClienteNuevoInterfaz mi = new ClienteNuevoImpl();


            //Control de repetición menú
            bool cerrarMenu = false;

            //Opción sellecionada por usuario
            int opcionSeleccionada;

            menuInterfaz.mensajeBienvenida();



            /*El menú se mostrará tras cada selección y ejecución de esta mientras no se coja la opción 0 que es la que controla
             * el valor el boolean cerrarMenu
             */
            while (!cerrarMenu)
            {
                opcionSeleccionada = menuInterfaz.mostrarMenu();
                Console.Clear();
                Console.WriteLine("\n\t[INFO] - Has seleccionado la opción: " + opcionSeleccionada);

                switch (opcionSeleccionada)
                {
                    case 0:
                        cerrarMenu = true;
                        Console.WriteLine("\n\tLa sesión se cerrará");
                        break;

                    case 1:
                        Console.WriteLine("\n\tSe ejecuta el alta");
                        ci.darAltaCliente(listaCliente);
                        Console.Clear();

                        foreach (ClienteDto cliente in listaCliente)
                        {
                            Console.WriteLine(cliente.ToString());
                            Console.WriteLine("\n");
                        }
                        break;

                    case 2:
                        Console.WriteLine("\n\tNuevo Cliente:");
                        mi.darAltaClienteNuevo(listaCliente2);
                        Console.Clear();

                        foreach (ClienteDto2 cliente2 in listaCliente2)
                        {
                            Console.WriteLine(cliente2.ToString());
                            Console.WriteLine("\n");
                        }

                        break;

                    case 3:
                        Console.WriteLine("\n\t");
                        mi.modificarCliente(listaCliente2);
                        break;

                    case 4:
                        Console.WriteLine("\n\tEliminar un cliente");
                        mi.borrarCliente(listaCliente2);
                        break;

                    case 5:
                        Console.WriteLine("\n\tMostar clientes registrados en banco");
                        Console.Clear();
                        foreach (ClienteDto2 cliente2 in listaCliente2)
                        {
                            Console.WriteLine(cliente2.ToString());
                            Console.WriteLine("\n");
                        }

                        break;

                    case 6:
                        
                        break;



                    default:
                        Console.WriteLine("\n\t[INFO]- La opción que has seleccionado no se encuentra dentro de los casos");
                        break;
                }
            }
            }
    }
}
