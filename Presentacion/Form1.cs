using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco_GGAL_App1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCrearCuentas frmCrearCuentas = new FrmCrearCuentas();
            frmCrearCuentas.Show();
        }

        private void eliminarCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEliminarCuenta frmEliminarCuenta = new FrmEliminarCuenta();
            frmEliminarCuenta.Show();
        }

        private void reportListadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListadoClientes frmListadoClientes = new FrmListadoClientes();
            frmListadoClientes.Show();
        }
    }
}
