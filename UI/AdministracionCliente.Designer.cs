namespace UI
{
    partial class AdministracionCliente
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
            lblNombre = new Label();
            txtNombreCliente = new TextBox();
            txtTelefono = new TextBox();
            lblNumero = new Label();
            txtCorreo = new TextBox();
            lblCorreo = new Label();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnAnular = new Button();
            gridClientes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridClientes).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(28, 15);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(110, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre del Cliente";
            lblNombre.Click += label1_Click;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(33, 47);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(100, 23);
            txtNombreCliente.TabIndex = 1;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(33, 122);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 3;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(28, 88);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(52, 15);
            lblNumero.TabIndex = 2;
            lblNumero.Text = "Telefono";
            lblNumero.Click += label2_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(38, 198);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(100, 23);
            txtCorreo.TabIndex = 5;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(33, 166);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(47, 15);
            lblCorreo.TabIndex = 4;
            lblCorreo.Text = "Correro";
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(248, 53);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 6;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(248, 108);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnAnular
            // 
            btnAnular.Location = new Point(248, 166);
            btnAnular.Name = "btnAnular";
            btnAnular.Size = new Size(75, 23);
            btnAnular.TabIndex = 8;
            btnAnular.Text = "Anular";
            btnAnular.UseVisualStyleBackColor = true;
            // 
            // gridClientes
            // 
            gridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridClientes.Location = new Point(373, 44);
            gridClientes.Name = "gridClientes";
            gridClientes.RowTemplate.Height = 25;
            gridClientes.Size = new Size(399, 329);
            gridClientes.TabIndex = 9;
            // 
            // AdministracionCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gridClientes);
            Controls.Add(btnAnular);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(txtCorreo);
            Controls.Add(lblCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(lblNumero);
            Controls.Add(txtNombreCliente);
            Controls.Add(lblNombre);
            Name = "AdministracionCliente";
            Text = "AdministracionCliente";
            ((System.ComponentModel.ISupportInitialize)gridClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombreCliente;
        private TextBox txtTelefono;
        private Label lblNumero;
        private TextBox txtCorreo;
        private Label lblCorreo;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnAnular;
        private DataGridView gridClientes;
    }
}