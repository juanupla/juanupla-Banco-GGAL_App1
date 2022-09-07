using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_GGAL_App1
{
    internal class TipoCuenta
    {

        private int Id;
        private string Nombre;

        public TipoCuenta()
        {

            id = 0;
            Nombre = "";

        }

        public TipoCuenta(int id, string nombre)
        {
            this.Id = id;
            this.Nombre = nombre;
        }

        public int id
        {
            get { return Id; }
            set { Id = value; }
        }

        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }


        public override string ToString()
        {
            return nombre;
        }
    }
}
