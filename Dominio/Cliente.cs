using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_GGAL_App1
{
    internal class Cliente
    {
        private int nro_cliente;
        private int dni;
        private string nombre;
        private string apellido;
        private List<Cuenta> cuentas;



        public Cliente(int Dni)
        {
            dni = Dni;
            nro_cliente = 0;
            nombre = "";
            apellido = "";

        }

        public Cliente(int dni, string nombre, string apellido, int nroCliente)
        {

            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.nro_cliente = nroCliente;



        }

        public Cliente(string nombre, string apellido, int nroCliente)
        {


            this.nombre = nombre;
            this.apellido = apellido;
            this.nro_cliente = nroCliente;
            this.dni = 0;
        }

        public Cliente()
        {

            nro_cliente = 0;
            dni = 0;
            nombre = "";
            apellido = "";
            cuentas = new List<Cuenta>();
        }

        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public List<Cuenta> Cuentas
        {
            get { return cuentas; }
            set { cuentas = value; }
        }

        public int Nro_cliente
        {
            get { return nro_cliente; }
            set { nro_cliente = value; }
        }

        public void AgregarCuentas(Cuenta cuenta)
        {
            Cuentas.Add(cuenta);
        }
        public void EliminarCuentas(int posicion)
        {
            Cuentas.RemoveAt(posicion);
        }
        public override string ToString()
        {
            return "Apellido y Nombre: " + Apellido + ", " + Nombre + " | DNi Nro: " + Dni;
        }
    }
}
