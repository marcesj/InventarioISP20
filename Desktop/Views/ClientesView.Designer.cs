namespace Desktop.Views
{
    partial class ClientesView
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
            label1 = new Label();
            tabControl = new TabControl();
            tabPageLista = new TabPage();
            label7 = new Label();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnNuevo = new Button();
            txtBusqueda = new TextBox();
            label2 = new Label();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            dataGridClientes = new DataGridView();
            tabPageAgregarEditar = new TabPage();
            txtDni = new TextBox();
            txtDireccion = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            tabControl.SuspendLayout();
            tabPageLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridClientes).BeginInit();
            tabPageAgregarEditar.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Harlow Solid Italic", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(142, 46);
            label1.TabIndex = 0;
            label1.Text = "Clientes";
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPageLista);
            tabControl.Controls.Add(tabPageAgregarEditar);
            tabControl.Location = new Point(21, 47);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(815, 411);
            tabControl.TabIndex = 1;
            // 
            // tabPageLista
            // 
            tabPageLista.Controls.Add(label7);
            tabPageLista.Controls.Add(btnEliminar);
            tabPageLista.Controls.Add(btnModificar);
            tabPageLista.Controls.Add(btnNuevo);
            tabPageLista.Controls.Add(txtBusqueda);
            tabPageLista.Controls.Add(label2);
            tabPageLista.Controls.Add(btnBuscar);
            tabPageLista.Controls.Add(dataGridClientes);
            tabPageLista.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPageLista.Location = new Point(4, 29);
            tabPageLista.Name = "tabPageLista";
            tabPageLista.Padding = new Padding(3);
            tabPageLista.Size = new Size(807, 378);
            tabPageLista.TabIndex = 0;
            tabPageLista.Text = "Lista";
            tabPageLista.UseVisualStyleBackColor = true;
            tabPageLista.Click += tabPageLista_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 32);
            label7.Name = "label7";
            label7.Size = new Size(0, 25);
            label7.TabIndex = 7;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(128, 255, 255);
            btnEliminar.Location = new Point(670, 305);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 48);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(128, 255, 255);
            btnModificar.Location = new Point(657, 203);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(107, 29);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(128, 255, 255);
            btnNuevo.Location = new Point(670, 102);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(94, 33);
            btnNuevo.TabIndex = 4;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(141, 72);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(469, 31);
            txtBusqueda.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(128, 255, 255);
            label2.Location = new Point(42, 72);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 2;
            label2.Text = "Buscar";
            label2.Click += label2_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(128, 255, 255);
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassPlus;
            btnBuscar.IconColor = Color.DimGray;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 30;
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(636, 19);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(114, 51);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dataGridClientes
            // 
            dataGridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridClientes.Location = new Point(16, 102);
            dataGridClientes.Name = "dataGridClientes";
            dataGridClientes.RowHeadersWidth = 51;
            dataGridClientes.Size = new Size(594, 251);
            dataGridClientes.TabIndex = 0;
            // 
            // tabPageAgregarEditar
            // 
            tabPageAgregarEditar.Controls.Add(txtDni);
            tabPageAgregarEditar.Controls.Add(txtDireccion);
            tabPageAgregarEditar.Controls.Add(txtApellido);
            tabPageAgregarEditar.Controls.Add(txtNombre);
            tabPageAgregarEditar.Controls.Add(btnCancelar);
            tabPageAgregarEditar.Controls.Add(btnGuardar);
            tabPageAgregarEditar.Controls.Add(label6);
            tabPageAgregarEditar.Controls.Add(label5);
            tabPageAgregarEditar.Controls.Add(label4);
            tabPageAgregarEditar.Controls.Add(label3);
            tabPageAgregarEditar.Location = new Point(4, 29);
            tabPageAgregarEditar.Name = "tabPageAgregarEditar";
            tabPageAgregarEditar.Padding = new Padding(3);
            tabPageAgregarEditar.Size = new Size(807, 378);
            tabPageAgregarEditar.TabIndex = 1;
            tabPageAgregarEditar.Text = "Agregar/Editar";
            tabPageAgregarEditar.UseVisualStyleBackColor = true;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(182, 177);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(472, 27);
            txtDni.TabIndex = 9;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(182, 262);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(472, 27);
            txtDireccion.TabIndex = 8;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(182, 99);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(472, 27);
            txtApellido.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(182, 30);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(472, 27);
            txtNombre.TabIndex = 6;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Silver;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.Location = new Point(694, 154);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Silver;
            btnGuardar.BackgroundImageLayout = ImageLayout.Center;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.Location = new Point(694, 64);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 249);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 3;
            label6.Text = "Direccion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 177);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 2;
            label5.Text = "DNI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 106);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 1;
            label4.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 30);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 0;
            label3.Text = "Nombre";
            // 
            // ClientesView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(963, 519);
            Controls.Add(tabControl);
            Controls.Add(label1);
            Name = "ClientesView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            tabControl.ResumeLayout(false);
            tabPageLista.ResumeLayout(false);
            tabPageLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridClientes).EndInit();
            tabPageAgregarEditar.ResumeLayout(false);
            tabPageAgregarEditar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tabControl;
        private TabPage tabPageLista;
        private TabPage tabPageAgregarEditar;
        private DataGridView dataGridClientes;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnNuevo;
        private TextBox txtBusqueda;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtDni;
        private TextBox txtDireccion;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label7;
    }
}