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
    public partial class FrmCrearCuentas : Form
    {
        accesoDatos oBD;
        Cliente cliente;
        public FrmCrearCuentas()
        {
            InitializeComponent();
            oBD = new accesoDatos();
            cliente = new Cliente();
            //DataRowView item = (DataRowView)cboTipoCuenta.SelectedItem;

        }

        private void FrmCrearCuentas_Load(object sender, EventArgs e)
        {
            Habilitar(true);
            cargarCombo();
            txtUltMovimiento.Enabled = false;
            txtUltMovimiento.Text = DateTime.Now.ToString("dd/MM/yyyy");

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (validarCuentas())
            {


                DataRowView item = (DataRowView)cboTipoCuenta.SelectedItem;
                int idTipoCuenta = Convert.ToInt32(item.Row.ItemArray[0]);
                string nombreTipoCuenta = Convert.ToString(item.Row.ItemArray[1]);
                int CBU = Convert.ToInt32(txtCBU.Text);
                decimal Saldo = Convert.ToDecimal(txtSaldo.Text);
                DateTime ultimoMov = Convert.ToDateTime(txtUltMovimiento.Text);

                TipoCuenta tipoCuenta = new TipoCuenta(idTipoCuenta, nombreTipoCuenta);
                Cuenta cuenta = new Cuenta(CBU, Saldo, tipoCuenta, ultimoMov);
                cliente.AgregarCuentas(cuenta);
                dgvDetalles.Rows.Add(new object[] { CBU, Saldo, tipoCuenta, ultimoMov }); //new object [] es un vector de objetos
                //DataGridViewRow fila = dgvDetalles.CurrentRow; // Perimte acceder a la fila del dgv seleccionado
                //foreach(DatagridViewRows filas in dgv.Rows)  // Permite recorrer filas, como un DataRow por ej.
                //dgv.Rows.Remuve(dgv.CurrentRow)  // Permite elminiar la fila que este seleccionada

            }
        }

        private void Habilitar(bool x)
        {
            txtDNINro.Enabled = !x;
            gbCliente.Enabled = !x;
            gbCuentas.Enabled = !x;
            btnAceptar.Enabled = !x;
            btnBuscar.Enabled = !x;



        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbtNuevo_CheckedChanged(object sender, EventArgs e)
        {
            Habilitar(false);
            txtDNINro.Enabled = false;
            btnBuscar.Enabled = false;
            gbCuentas.Enabled = false;
            btnAceptar.Enabled = false;
            btnAtras.Enabled = false;
            limpiarCliente();
            limpiarDNINro();
        }

        private void rbtExistente_CheckedChanged(object sender, EventArgs e)
        {
            Habilitar(true);
            txtDNINro.Enabled = true;
            btnBuscar.Enabled = true;
        }

        private void limpiarCliente()
        {
            txtDNI.Text = String.Empty;
            txtNombre.Text = String.Empty;
            txtApellido.Text = String.Empty;
        }

        private void limpiarCuenta()
        {
            txtCBU.Text = String.Empty;
            txtSaldo.Text = String.Empty;
            txtUltMovimiento.Text = String.Empty;
            cboTipoCuenta.SelectedIndex = -1;
        }

        private void limpiarDNINro()
        {
            txtDNINro.Text = String.Empty;
        }

        private void cargarCombo()
        {
            DataTable tabla = new DataTable();
            string query = "cargar_combo";
            tabla = oBD.ConsultarBD(query);
            cboTipoCuenta.DataSource = tabla;
            cboTipoCuenta.DisplayMember = "nombre";
            cboTipoCuenta.ValueMember = "id_tc";

        }

        private bool validarSiguiente()
        {
            if (txtApellido.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar un Apellido válido", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellido.Focus();
                return false;
            }
            if (txtNombre.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar un Nombre válido", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return false;
            }
            if (txtDNI.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar un D.N.I válido", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDNI.Focus();
                return false;
            }
            else
            {
                try
                {
                    Convert.ToInt32(txtDNI.Text);
                }
                catch
                {
                    MessageBox.Show("Debe ingresar un D.N.I válido", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDNI.Focus();
                    return false;
                }
            }


            return true;
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

        private bool validarCuentas()
        {
            if (txtCBU.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar un CBU válido", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCBU.Focus();
                return false;
            }
            else
            {
                try
                {
                    Convert.ToInt32(txtCBU.Text);
                }
                catch
                {
                    MessageBox.Show("Debe ingresar un CBU válido", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCBU.Focus();
                    return false;
                }
            }
            if (txtSaldo.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar un Saldo válido", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSaldo.Focus();
                return false;
            }
            else
            {
                try
                {
                    Convert.ToDecimal(txtSaldo.Text);
                }
                catch
                {
                    MessageBox.Show("Debe ingresar un Saldo válido", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSaldo.Focus();
                    return false;
                }
            }
            if (cboTipoCuenta.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de cuenta", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboTipoCuenta.Focus();
                return false;
            }




            return true;


        }

        private void btnSiguente_Click(object sender, EventArgs e)
        {
            if (validarSiguiente())
            {
                Habilitar(false);
                txtDNI.Enabled = false;
                txtNombre.Enabled = false;
                txtApellido.Enabled = false;
                txtDNINro.Enabled = false;
                btnBuscar.Enabled = false;
                btnAtras.Enabled = true;
                btnSiguente.Enabled = false;
                rbtExistente.Enabled = false;
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            rbtExistente.Enabled = true;
            txtDNI.Enabled = true;
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            btnAtras.Enabled = false;
            btnSiguente.Enabled = true;
            gbCuentas.Enabled = false;
            btnAceptar.Enabled = false;
            limpiarCuenta();
            dgvDetalles.Rows.Clear();
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
                    gbCuentas.Enabled = true;
                    btnAceptar.Enabled = true;
                    int nro_Cliente_Actual = cRetorno.Nro_cliente;
                }
                else
                {
                    MessageBox.Show("No existe ningún cliente registrado con el nro " + Convert.ToInt32(txtDNINro.Text) + ". Verifique el mismo o cree un nuevo cliente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    limpiarDNINro();
                    txtDNINro.Focus();
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (rbtNuevo.Checked)
            {
                cliente.Dni = Convert.ToInt32(txtDNI.Text);
                cliente.Nombre = txtNombre.Text;
                cliente.Apellido = txtApellido.Text;
                string sql = "cuentas_cliente_nuevo";
                int posicion = oBD.DbInsertarCliente(sql, cliente);
                int contador = 0;
                for (int i = 0; i < cliente.Cuentas.Count; i++)
                {
                    TipoCuenta t = cliente.Cuentas[i].tipoCuenta;

                    int cbu = Convert.ToInt32(cliente.Cuentas[i].Cbu);
                    decimal saldo = Convert.ToDecimal(cliente.Cuentas[i].Saldo);
                    DateTime UltimoMov = Convert.ToDateTime(cliente.Cuentas[i].UltimoMov);

                    Cuenta c = new Cuenta(cbu, saldo, t, UltimoMov);
                    string sql2 = "cliente_nuevo_suscuentas";
                    int r = oBD.DbInsertarCuentasCNuevo(sql2, c, posicion);

                    if (r > 0)
                    {
                        contador++;
                    }
                }
                MessageBox.Show("Se han insertado correctamente " + contador + " cuentas para el nuevo cliente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                int dni = Convert.ToInt32(txtDNI.Text);
                string sql3 = "buscar_nrocliente_existente";
                int posicion = Convert.ToInt32(oBD.DBBuscarExistente(sql3, dni));
                int contador = 0;
                for (int i = 0; i < cliente.Cuentas.Count; i++)
                {
                    TipoCuenta t = cliente.Cuentas[i].tipoCuenta;

                    int cbu = Convert.ToInt32(cliente.Cuentas[i].Cbu);
                    decimal saldo = Convert.ToDecimal(cliente.Cuentas[i].Saldo);
                    DateTime UltimoMov = Convert.ToDateTime(cliente.Cuentas[i].UltimoMov);

                    Cuenta c = new Cuenta(cbu, saldo, t, UltimoMov);
                    string sql4 = "cliente_nuevo_suscuentas";
                    int r = oBD.DbInsertarCuentasCNuevo(sql4, c, posicion);

                    if (r > 0)
                    {
                        contador++;
                    }
                }
                MessageBox.Show("Se han insertado correctamente " + contador + " cuentas para el cliente pre-existente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
