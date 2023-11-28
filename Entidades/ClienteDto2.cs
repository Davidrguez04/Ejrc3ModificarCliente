using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejrc3ModificarCliente.Entidades
{
    internal class ClienteDto2
    {
        long id;
        string iban = "aaaaa";
        string codigoS = "CSI1SSXX";
        string fchAlta = "9999/12/31";
        string fchBaja = "9999/12/31";
        string dni = "aaaaa";

        //getters y setters
        public long Id { get => id; set => id = value; }
        public string Iban { get => iban; set => iban = value; }
        public string CodigoS { get => codigoS; set => codigoS = value; }
        public string FchAlta { get => fchAlta; set => fchAlta = value; }
        public string FchBaja { get => fchBaja; set => fchBaja = value; }
        public string Dni { get => dni; set => dni = value; }

        //Constructores
        public ClienteDto2()
        {
        }

        public ClienteDto2(long id, string iban, string codigoS, string fchAlta, string fchBaja, string dni)
        {
            this.id = id;
            this.iban = iban;
            this.codigoS = codigoS;
            this.fchAlta = fchAlta;
            this.fchBaja = fchBaja;
            this.dni = dni;
        }

        //Método ToString
        override
            public string ToString()
        {
            string clienteString = "ID: " + this.id + " \nIBAN: ES14 " + this.iban +
                " \nDNI: " + this.dni +
                " \nCodigo switch: " + this.codigoS +
                " \nFecha Alta: " + this.fchAlta +
                " \nFecha Baja: " + this.fchBaja;

            return clienteString;
        }
    }
}
