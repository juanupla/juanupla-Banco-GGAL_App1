using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_GGAL_App1
{
    internal class Cuenta
    {
        private int cbu;
        private decimal saldo;
        private TipoCuenta TipoCuenta;
        private DateTime ultimoMov;



        public Cuenta(TipoCuenta tipoCuenta)
        {
            cbu = 0;
            saldo = 0;
            this.TipoCuenta = tipoCuenta;
            ultimoMov = DateTime.Now;



        }
        public Cuenta(int cbu, decimal saldo, TipoCuenta tipoCuenta, DateTime utimoMov)
        {
            this.cbu = cbu;
            this.saldo = saldo;
            this.TipoCuenta = tipoCuenta;
            this.ultimoMov = utimoMov;

        }

        public int Cbu
        {
            get { return cbu; }
            set { cbu = value; }
        }

        public decimal Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public TipoCuenta tipoCuenta
        {
            get { return TipoCuenta; }
            set { TipoCuenta = value; }
        }

        public DateTime UltimoMov
        {
            get { return ultimoMov; }
            set { ultimoMov = value; }

        }




        public override string ToString()
        {
            return "CBU: " + Cbu + " Tipo de Cuenta: " + TipoCuenta + " |Saldo:  " + Saldo + "  Ultimo Movimiento: " + UltimoMov;
        }

    }
}
