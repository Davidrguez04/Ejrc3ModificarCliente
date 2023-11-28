using Ejrc3ModificarCliente.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejrc3ModificarCliente.Servicios
{
    internal interface ClienteNuevoInterfaz
    {
        public void darAltaClienteNuevo(List<ClienteDto2> listaAntigua);
        public void borrarCliente(List<ClienteDto2> listaAntigua);
       
    }
}
