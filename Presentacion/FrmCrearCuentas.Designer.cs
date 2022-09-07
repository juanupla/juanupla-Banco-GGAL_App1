namespace Banco_GGAL_App1
{
    partial class FrmCrearCuentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gbCuentas = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtCBU = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtUltMovimiento = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.cboTipoCuenta = new System.Windows.Forms.ComboBox();
            this.rbtNuevo = new System.Windows.Forms.RadioButton();
            this.rbtExistente = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnSiguente = new System.Windows.Forms.Button();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtDNINro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ColCBU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTipoCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUltimoMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbCuentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.gbCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(887, 477);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 34);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(685, 477);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(140, 34);
            this.btnAceptar.TabIndex = 18;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // gbCuentas
            // 
            this.gbCuentas.Controls.Add(this.btnAgregar);
            this.gbCuentas.Controls.Add(this.txtCBU);
            this.gbCuentas.Controls.Add(this.txtSaldo);
            this.gbCuentas.Controls.Add(this.txtUltMovimiento);
            this.gbCuentas.Controls.Add(this.label9);
            this.gbCuentas.Controls.Add(this.label8);
            this.gbCuentas.Controls.Add(this.label7);
            this.gbCuentas.Controls.Add(this.label6);
            this.gbCuentas.Controls.Add(this.dgvDetalles);
            this.gbCuentas.Controls.Add(this.cboTipoCuenta);
            this.gbCuentas.Location = new System.Drawing.Point(483, 39);
            this.gbCuentas.Name = "gbCuentas";
            this.gbCuentas.Size = new System.Drawing.Size(706, 407);
            this.gbCuentas.TabIndex = 17;
            this.gbCuentas.TabStop = false;
            this.gbCuentas.Text = "Cuentas";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(544, 183);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(108, 33);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtCBU
            // 
            this.txtCBU.Location = new System.Drawing.Point(230, 63);
            this.txtCBU.Name = "txtCBU";
            this.txtCBU.Size = new System.Drawing.Size(251, 22);
            this.txtCBU.TabIndex = 1;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(230, 105);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(251, 22);
            this.txtSaldo.TabIndex = 3;
            // 
            // txtUltMovimiento
            // 
            this.txtUltMovimiento.Location = new System.Drawing.Point(230, 188);
            this.txtUltMovimiento.Name = "txtUltMovimiento";
            this.txtUltMovimiento.Size = new System.Drawing.Size(251, 22);
            this.txtUltMovimiento.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(89, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "CBU";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(89, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Saldo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Tipo de Cuenta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ult. Movimiento";
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCBU,
            this.ColSaldo,
            this.ColTipoCuenta,
            this.ColUltimoMovimiento});
            this.dgvDetalles.Location = new System.Drawing.Point(30, 238);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.RowHeadersWidth = 51;
            this.dgvDetalles.RowTemplate.Height = 24;
            this.dgvDetalles.Size = new System.Drawing.Size(674, 161);
            this.dgvDetalles.TabIndex = 9;
            // 
            // cboTipoCuenta
            // 
            this.cboTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoCuenta.FormattingEnabled = true;
            this.cboTipoCuenta.Location = new System.Drawing.Point(230, 142);
            this.cboTipoCuenta.Name = "cboTipoCuenta";
            this.cboTipoCuenta.Size = new System.Drawing.Size(249, 24);
            this.cboTipoCuenta.TabIndex = 5;
            // 
            // rbtNuevo
            // 
            this.rbtNuevo.AutoSize = true;
            this.rbtNuevo.Location = new System.Drawing.Point(158, 61);
            this.rbtNuevo.Name = "rbtNuevo";
            this.rbtNuevo.Size = new System.Drawing.Size(68, 20);
            this.rbtNuevo.TabIndex = 11;
            this.rbtNuevo.TabStop = true;
            this.rbtNuevo.Text = "Nuevo";
            this.rbtNuevo.UseVisualStyleBackColor = true;
            this.rbtNuevo.CheckedChanged += new System.EventHandler(this.rbtNuevo_CheckedChanged);
            // 
            // rbtExistente
            // 
            this.rbtExistente.AutoSize = true;
            this.rbtExistente.Location = new System.Drawing.Point(289, 61);
            this.rbtExistente.Name = "rbtExistente";
            this.rbtExistente.Size = new System.Drawing.Size(82, 20);
            this.rbtExistente.TabIndex = 12;
            this.rbtExistente.TabStop = true;
            this.rbtExistente.Text = "Existente";
            this.rbtExistente.UseVisualStyleBackColor = true;
            this.rbtExistente.CheckedChanged += new System.EventHandler(this.rbtExistente_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Es un cliente";
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.btnAtras);
            this.gbCliente.Controls.Add(this.btnSiguente);
            this.gbCliente.Controls.Add(this.txtDNI);
            this.gbCliente.Controls.Add(this.txtNombre);
            this.gbCliente.Controls.Add(this.txtApellido);
            this.gbCliente.Controls.Add(this.label4);
            this.gbCliente.Controls.Add(this.label3);
            this.gbCliente.Controls.Add(this.label2);
            this.gbCliente.Location = new System.Drawing.Point(35, 156);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(442, 290);
            this.gbCliente.TabIndex = 16;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(198, 217);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(84, 37);
            this.btnAtras.TabIndex = 7;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnSiguente
            // 
            this.btnSiguente.Location = new System.Drawing.Point(301, 217);
            this.btnSiguente.Name = "btnSiguente";
            this.btnSiguente.Size = new System.Drawing.Size(86, 37);
            this.btnSiguente.TabIndex = 6;
            this.btnSiguente.Text = "Siguente";
            this.btnSiguente.UseVisualStyleBackColor = true;
            this.btnSiguente.Click += new System.EventHandler(this.btnSiguente_Click);
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(106, 48);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(251, 22);
            this.txtDNI.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(106, 104);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(251, 22);
            this.txtNombre.TabIndex = 3;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(106, 158);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(251, 22);
            this.txtApellido.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "D.N.I ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apellido";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(356, 105);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(66, 29);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtDNINro
            // 
            this.txtDNINro.Location = new System.Drawing.Point(99, 108);
            this.txtDNINro.Name = "txtDNINro";
            this.txtDNINro.Size = new System.Drawing.Size(251, 22);
            this.txtDNINro.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "D.N.I Nro";
            // 
            // ColCBU
            // 
            this.ColCBU.HeaderText = "CBU";
            this.ColCBU.MinimumWidth = 6;
            this.ColCBU.Name = "ColCBU";
            this.ColCBU.ReadOnly = true;
            this.ColCBU.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColCBU.Width = 125;
            // 
            // ColSaldo
            // 
            this.ColSaldo.HeaderText = "Saldo";
            this.ColSaldo.MinimumWidth = 6;
            this.ColSaldo.Name = "ColSaldo";
            this.ColSaldo.Width = 125;
            // 
            // ColTipoCuenta
            // 
            this.ColTipoCuenta.HeaderText = "Tipo de cuenta";
            this.ColTipoCuenta.MinimumWidth = 6;
            this.ColTipoCuenta.Name = "ColTipoCuenta";
            this.ColTipoCuenta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColTipoCuenta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColTipoCuenta.Width = 125;
            // 
            // ColUltimoMovimiento
            // 
            this.ColUltimoMovimiento.HeaderText = "Ultimo Movimiento";
            this.ColUltimoMovimiento.MinimumWidth = 6;
            this.ColUltimoMovimiento.Name = "ColUltimoMovimiento";
            this.ColUltimoMovimiento.Width = 125;
            // 
            // FrmCrearCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 548);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gbCuentas);
            this.Controls.Add(this.rbtNuevo);
            this.Controls.Add(this.rbtExistente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtDNINro);
            this.Controls.Add(this.label1);
            this.Name = "FrmCrearCuentas";
            this.Text = "FrmCrearCuentas";
            this.Load += new System.EventHandler(this.FrmCrearCuentas_Load);
            this.gbCuentas.ResumeLayout(false);
            this.gbCuentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox gbCuentas;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtCBU;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtUltMovimiento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCBU;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSaldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTipoCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUltimoMovimiento;
        private System.Windows.Forms.ComboBox cboTipoCuenta;
        private System.Windows.Forms.RadioButton rbtNuevo;
        private System.Windows.Forms.RadioButton rbtExistente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnSiguente;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtDNINro;
        private System.Windows.Forms.Label label1;
    }
}