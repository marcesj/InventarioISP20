namespace Desktop.Views
{
    partial class PaqueteriaView
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
            dataGridPaqueteria = new DataGridView();
            tabPageAgregarEditar = new TabPage();
            pictureBox1 = new PictureBox();
            datetimeDestinatarioFechaHoraEntrega = new DateTimePicker();
            datetimeEmisorFechaHoraDespacho = new DateTimePicker();
            txtDestinatarioDireccion = new TextBox();
            label14 = new Label();
            txtCodigo = new TextBox();
            txtDestintarioTelefono = new TextBox();
            label13 = new Label();
            label11 = new Label();
            label10 = new Label();
            txtDestinatarioNombreApellido = new TextBox();
            label9 = new Label();
            label8 = new Label();
            txtEmisorTelefono = new TextBox();
            txtEmisorDireccion = new TextBox();
            txtEmisorNombreApellido = new TextBox();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            tabControl.SuspendLayout();
            tabPageLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPaqueteria).BeginInit();
            tabPageAgregarEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.InactiveBorder;
            label1.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(5, 5);
            label1.Name = "label1";
            label1.Size = new Size(162, 31);
            label1.TabIndex = 0;
            label1.Text = "PAQUETERIA";
            label1.Click += label1_Click;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPageLista);
            tabControl.Controls.Add(tabPageAgregarEditar);
            tabControl.Location = new Point(5, 55);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1702, 780);
            tabControl.TabIndex = 2;
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
            tabPageLista.Controls.Add(dataGridPaqueteria);
            tabPageLista.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPageLista.Location = new Point(4, 29);
            tabPageLista.Name = "tabPageLista";
            tabPageLista.Padding = new Padding(3);
            tabPageLista.Size = new Size(1694, 747);
            tabPageLista.TabIndex = 0;
            tabPageLista.Text = "Lista";
            tabPageLista.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 35);
            label7.Name = "label7";
            label7.Size = new Size(0, 25);
            label7.TabIndex = 7;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(128, 255, 255);
            btnEliminar.Location = new Point(1528, 246);
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
            btnModificar.Location = new Point(1528, 333);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(107, 35);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(128, 255, 255);
            btnNuevo.Location = new Point(1527, 167);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(94, 33);
            btnNuevo.TabIndex = 4;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(125, 65);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(759, 31);
            txtBusqueda.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(128, 255, 255);
            label2.Location = new Point(29, 68);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 2;
            label2.Text = "Buscar";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(128, 255, 255);
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassPlus;
            btnBuscar.IconColor = Color.DimGray;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 30;
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(1528, 68);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(114, 51);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dataGridPaqueteria
            // 
            dataGridPaqueteria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPaqueteria.Location = new Point(29, 102);
            dataGridPaqueteria.Name = "dataGridPaqueteria";
            dataGridPaqueteria.RowHeadersWidth = 51;
            dataGridPaqueteria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridPaqueteria.Size = new Size(1462, 649);
            dataGridPaqueteria.TabIndex = 0;
            // 
            // tabPageAgregarEditar
            // 
            tabPageAgregarEditar.Controls.Add(pictureBox1);
            tabPageAgregarEditar.Controls.Add(datetimeDestinatarioFechaHoraEntrega);
            tabPageAgregarEditar.Controls.Add(datetimeEmisorFechaHoraDespacho);
            tabPageAgregarEditar.Controls.Add(txtDestinatarioDireccion);
            tabPageAgregarEditar.Controls.Add(label14);
            tabPageAgregarEditar.Controls.Add(txtCodigo);
            tabPageAgregarEditar.Controls.Add(txtDestintarioTelefono);
            tabPageAgregarEditar.Controls.Add(label13);
            tabPageAgregarEditar.Controls.Add(label11);
            tabPageAgregarEditar.Controls.Add(label10);
            tabPageAgregarEditar.Controls.Add(txtDestinatarioNombreApellido);
            tabPageAgregarEditar.Controls.Add(label9);
            tabPageAgregarEditar.Controls.Add(label8);
            tabPageAgregarEditar.Controls.Add(txtEmisorTelefono);
            tabPageAgregarEditar.Controls.Add(txtEmisorDireccion);
            tabPageAgregarEditar.Controls.Add(txtEmisorNombreApellido);
            tabPageAgregarEditar.Controls.Add(btnCancelar);
            tabPageAgregarEditar.Controls.Add(btnGuardar);
            tabPageAgregarEditar.Controls.Add(label6);
            tabPageAgregarEditar.Controls.Add(label5);
            tabPageAgregarEditar.Controls.Add(label3);
            tabPageAgregarEditar.Location = new Point(4, 29);
            tabPageAgregarEditar.Name = "tabPageAgregarEditar";
            tabPageAgregarEditar.Padding = new Padding(3);
            tabPageAgregarEditar.Size = new Size(1694, 747);
            tabPageAgregarEditar.TabIndex = 1;
            tabPageAgregarEditar.Text = "Agregar/Editar";
            tabPageAgregarEditar.UseVisualStyleBackColor = true;
            tabPageAgregarEditar.Click += tabPageAgregarEditar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Imagen_de_paqueteria;
            pictureBox1.Location = new Point(1063, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(538, 439);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // datetimeDestinatarioFechaHoraEntrega
            // 
            datetimeDestinatarioFechaHoraEntrega.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            datetimeDestinatarioFechaHoraEntrega.Format = DateTimePickerFormat.Custom;
            datetimeDestinatarioFechaHoraEntrega.Location = new Point(260, 386);
            datetimeDestinatarioFechaHoraEntrega.Name = "datetimeDestinatarioFechaHoraEntrega";
            datetimeDestinatarioFechaHoraEntrega.Size = new Size(412, 27);
            datetimeDestinatarioFechaHoraEntrega.TabIndex = 7;
            // 
            // datetimeEmisorFechaHoraDespacho
            // 
            datetimeEmisorFechaHoraDespacho.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            datetimeEmisorFechaHoraDespacho.Format = DateTimePickerFormat.Custom;
            datetimeEmisorFechaHoraDespacho.Location = new Point(249, 176);
            datetimeEmisorFechaHoraDespacho.Name = "datetimeEmisorFechaHoraDespacho";
            datetimeEmisorFechaHoraDespacho.Size = new Size(423, 27);
            datetimeEmisorFechaHoraDespacho.TabIndex = 3;
            // 
            // txtDestinatarioDireccion
            // 
            txtDestinatarioDireccion.Location = new Point(200, 341);
            txtDestinatarioDireccion.Name = "txtDestinatarioDireccion";
            txtDestinatarioDireccion.Size = new Size(472, 27);
            txtDestinatarioDireccion.TabIndex = 6;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(20, 344);
            label14.Name = "label14";
            label14.Size = new Size(157, 20);
            label14.TabIndex = 22;
            label14.Text = "Destinatario Direccion";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(271, 436);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(401, 27);
            txtCodigo.TabIndex = 8;
            txtCodigo.TextChanged += txtCodigo_TextChanged;
            // 
            // txtDestintarioTelefono
            // 
            txtDestintarioTelefono.Location = new Point(200, 298);
            txtDestintarioTelefono.Name = "txtDestintarioTelefono";
            txtDestintarioTelefono.Size = new Size(472, 27);
            txtDestintarioTelefono.TabIndex = 5;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(31, 443);
            label13.Name = "label13";
            label13.Size = new Size(58, 20);
            label13.TabIndex = 17;
            label13.Text = "Código";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(19, 391);
            label11.Name = "label11";
            label11.Size = new Size(235, 20);
            label11.TabIndex = 15;
            label11.Text = "Destinatario Fecha y Hora Entrega";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(20, 301);
            label10.Name = "label10";
            label10.Size = new Size(152, 20);
            label10.TabIndex = 14;
            label10.Text = "Destinatario Teléfono";
            // 
            // txtDestinatarioNombreApellido
            // 
            txtDestinatarioNombreApellido.Location = new Point(240, 229);
            txtDestinatarioNombreApellido.Name = "txtDestinatarioNombreApellido";
            txtDestinatarioNombreApellido.Size = new Size(432, 27);
            txtDestinatarioNombreApellido.TabIndex = 4;
            txtDestinatarioNombreApellido.TextChanged += textBox2_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(20, 236);
            label9.Name = "label9";
            label9.Size = new Size(221, 20);
            label9.TabIndex = 12;
            label9.Text = "Destinatario Nombre y Apellido";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 176);
            label8.Name = "label8";
            label8.Size = new Size(214, 20);
            label8.TabIndex = 10;
            label8.Text = "Emisor Fecha y Hora Despacho";
            // 
            // txtEmisorTelefono
            // 
            txtEmisorTelefono.Location = new Point(200, 78);
            txtEmisorTelefono.Name = "txtEmisorTelefono";
            txtEmisorTelefono.Size = new Size(472, 27);
            txtEmisorTelefono.TabIndex = 1;
            // 
            // txtEmisorDireccion
            // 
            txtEmisorDireccion.Location = new Point(200, 122);
            txtEmisorDireccion.Name = "txtEmisorDireccion";
            txtEmisorDireccion.Size = new Size(472, 27);
            txtEmisorDireccion.TabIndex = 2;
            // 
            // txtEmisorNombreApellido
            // 
            txtEmisorNombreApellido.Location = new Point(211, 26);
            txtEmisorNombreApellido.Name = "txtEmisorNombreApellido";
            txtEmisorNombreApellido.Size = new Size(461, 27);
            txtEmisorNombreApellido.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Silver;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.Cyan;
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.Location = new Point(837, 257);
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
            btnGuardar.ForeColor = Color.Cyan;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.Location = new Point(837, 167);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 125);
            label6.Name = "label6";
            label6.Size = new Size(121, 20);
            label6.TabIndex = 3;
            label6.Text = "Emisor Direccion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 81);
            label5.Name = "label5";
            label5.Size = new Size(116, 20);
            label5.TabIndex = 2;
            label5.Text = "Emisor Telefono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 33);
            label3.Name = "label3";
            label3.Size = new Size(185, 20);
            label3.TabIndex = 0;
            label3.Text = "Emisor Nombre y Apellido";
            // 
            // PaqueteriaView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1662, 866);
            Controls.Add(tabControl);
            Controls.Add(label1);
            Name = "PaqueteriaView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "PaqueteriaView";
            Load += PaqueteriaView_Load;
            tabControl.ResumeLayout(false);
            tabPageLista.ResumeLayout(false);
            tabPageLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPaqueteria).EndInit();
            tabPageAgregarEditar.ResumeLayout(false);
            tabPageAgregarEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tabControl;
        private TabPage tabPageLista;
        private Label label7;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnNuevo;
        private TextBox txtBusqueda;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private DataGridView dataGridPaqueteria;
        private TabPage tabPageAgregarEditar;
        private TextBox txtEmisorTelefono;
        private TextBox txtEmisorDireccion;
        private TextBox txtEmisorNombreApellido;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label8;
        private TextBox txtDestinatarioNombreApellido;
        private Label label9;
        private Label label13;
        private Label label11;
        private Label label10;
        private TextBox txtDestintarioTelefono;
        private TextBox txtCodigo;
        private TextBox txtDestinatarioDireccion;
        private Label label14;
        private DateTimePicker datetimeEmisorFechaHoraDespacho;
        private DateTimePicker datetimeDestinatarioFechaHoraEntrega;
        private PictureBox pictureBox1;
    }
}