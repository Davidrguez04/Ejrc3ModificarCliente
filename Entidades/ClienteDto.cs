using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejrc3ModificarCliente.Entidades
{
    internal class ClienteDto
    {
        long idCliente;
        string nombreCliente = "aaaaa";
        string dniCliente = "aaaaa";
        string apellidosCliente = "aaaaa";
        string fchNacimientoCliente = "9999/12/31";
        string emailCliente = "aaaaa";
        int tlfCliente = 1111111;
        string fchAltaCliente = "9999/12/31";
        string fchBajaCliente = "9999/12/31";


        //getters y setters

        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string DniCliente { get => dniCliente; set => dniCliente = value; }
        public string ApellidosCliente { get => apellidosCliente; set => apellidosCliente = value; }
        public string FchNacimientoCliente { get => fchNacimientoCliente; set => fchNacimientoCliente = value; }
        public string EmailCliente { get => emailCliente; set => emailCliente = value; }
        public int TlfCliente { get => tlfCliente; set => tlfCliente = value; }
        public string FchAltaCliente { get => fchAltaCliente; set => fchAltaCliente = value; }
        public string FchBajaCliente { get => fchBajaCliente; set => fchBajaCliente = value; }
        public long IdCLiente { get => idCliente; set => idCliente = value; }

        //Constructores(Métodos que crean objetos)

        //Constructor vacio
        public ClienteDto()
        {
        }


        public ClienteDto(long idCliente, string nombreCliente, string dniCliente, string apellidosCliente, string fchNacimientoCliente, string emailCliente, int tlfCliente, string fchAltaCliente)
        {
            this.apellidosCliente = apellidosCliente;
            this.fchNacimientoCliente = fchNacimientoCliente;
            this.emailCliente = emailCliente;
            this.tlfCliente = tlfCliente;
            this.fchAltaCliente = fchAltaCliente;
            this.idCliente = idCliente;
        }

        //Método ToString
        override
            public string ToString()
        {
            string clienteString = "Nombre: " + this.nombreCliente + " \nApellidos: " + this.apellidosCliente +
                " \nDNI: " + this.dniCliente +
                " \nFecha Nacimiento: " + this.fchNacimientoCliente +
                " \nEmail: " + this.emailCliente +
                " \nTelefono: " + this.tlfCliente +
                " \nFecha Hoy: " + this.fchAltaCliente +
                " \nFecha Baja: " + this.fchBajaCliente;

            return clienteString;
        }

        /*
        public string ToString()
        {
            
            return $"Cliente: {nombreCliente} {dniCliente}";
            
        }
        */
    }
}
