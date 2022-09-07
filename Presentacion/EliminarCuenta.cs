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
    public partial class FrmEliminarCuenta : Form
    {
        accesoDatos oBD;
        Cliente cliente;

        public FrmEliminarCuenta()
        {
            cliente = new Cliente();
            oBD = new accesoDatos();
            InitializeComponent();
        }

        private void EliminarCuenta_Load(object sender, EventArgs e)
        {
            Cliente client = new Cliente();
            btnAtras.Enabled = false;
            cargarCombo();
            txtDNI.Enabled = false;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
        }

        private void cargarCombo()
        {
            DataTable tabla = new DataTable();
            string query = "cargar_combo";
            tabla = oBD.ConsultarBD(query);
            CboTipoCuenta.DataSource = tabla;
            CboTipoCuenta.DisplayMember = "nombre";
            CboTipoCuenta.ValueMember = "id_tc";

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (validarNroDNI())
            {
                string sql = "buscar_cliente";
                int i = Convert.ToInt32(txtDNINro.Text);
                Cliente c = new Cliente(i);
                Cliente cRetorno = oBD.DbBuscarCliente(sql, c);


                if (cRetorno.Nro_cliente > -1)
                {
                    txtApellido.Text = cRetorno.Apellido;
                    txtNombre.Text = cRetorno.Nombre;
                    txtDNI.Text = txtDNINro.Text;

                    int nro_Cliente_Actual = cRetorno.Nro_cliente;
                    txtDNI.Enabled = false;
                    txtNombre.Enabled = false;
                    txtApellido.Enabled = false;
                    btnAtras.Enabled = true;
                    cliente.Cuentas.Clear();
                    dgvDetalles.Rows.Clear();
                    string sql1 = "buscarCuentas";
                    DataTable tabla = oBD.ConsultarCuentas(sql1, nro_Cliente_Actual);
                    foreach (DataRow fila in tabla.Rows)
                    {

                        TipoCuenta tp = new TipoCuenta();
                        tp.id = Convert.ToInt32(fila["id_tc"].ToString());
                        Cuenta cuenta = new Cuenta(tp);
                        cuenta.Cbu = Convert.ToInt32(fila["cbu"].ToString());
                        cuenta.Saldo = Convert.ToDecimal(fila["saldo"].ToString());
                        cuenta.UltimoMov = Convert.ToDateTime(fila["ultimoMovimiento"].ToString());
                        cliente.AgregarCuentas(cuenta);  /*Cuentas.Add(cuenta);*/
                        dgvDetalles.Rows.Add(new object[] { cuenta.Cbu, cuenta.Saldo, cuenta.tipoCuenta.id, cuenta.UltimoMov });

                    }

                }
                else
                {
                    MessageBox.Show("No existe ningún cliente registrado con el nro " + Convert.ToInt32(txtDNINro.Text) + ". Verifique el mismo", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    limpiarDNINro();
                    txtDNINro.Focus();
                }
            }
        }

        private bool validarNroDNI()
        {
            if (txtDNINro.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar un D.N.I válido", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDNINro.Focus();
                return false;
            }
            else
            {
                try
                {
                    Convert.ToInt32(txtDNINro.Text);
                }
                catch
                {
                    MessageBox.Show("Debe ingresar un D.N.I válido", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDNINro.Focus();
                    return false;
                }
            }

            return true;
        }
        private void limpiarDNINro()
        {
            txtDNINro.Text = String.Empty;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = dgvDetalles.CurrentRow;

            if (fila.Index >= 0)
            {
                string sql = "eliminarCuenta";
                
                int posicion = fila.Index;  //dgvDetalles.SelectedRows.Count; /*fila.Index;*/
                int cbueliminar = cliente.Cuentas[posicion].Cbu;
                if (oBD.EliminarCuenta(sql, cbueliminar) > 0)
                {
                    cliente.EliminarCuentas(posicion);
                    dgvDetalles.Rows.Remove(dgvDetalles.CurrentRow);
                    MessageBox.Show("Se ha eliminado una cuenta correctamente", "Sistema", MessageBoxButtons.OK);
                }
            }

        }
    }
}
