namespace Desktop.Views
{
    partial class IniciarSesionView
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
            pictureBoxLogo = new PictureBox();
            Label1 = new Label();
            label2 = new Label();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            bntIniciarSesion = new Button();
            btnCanselar = new Button();
            checkVerPassword = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources._457253329_8568748999811128_8558321184153530508_n;
            pictureBoxLogo.Location = new Point(12, 12);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(443, 451);
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(476, 87);
            Label1.Name = "Label1";
            Label1.Size = new Size(59, 20);
            Label1.TabIndex = 1;
            Label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(476, 168);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(571, 88);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(310, 27);
            txtUsuario.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(571, 165);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '!';
            txtPassword.Size = new Size(310, 27);
            txtPassword.TabIndex = 4;
            // 
            // bntIniciarSesion
            // 
            bntIniciarSesion.Location = new Point(521, 389);
            bntIniciarSesion.Name = "bntIniciarSesion";
            bntIniciarSesion.Size = new Size(94, 29);
            bntIniciarSesion.TabIndex = 5;
            bntIniciarSesion.Text = "Iniciar Sesion";
            bntIniciarSesion.UseVisualStyleBackColor = true;
            bntIniciarSesion.Click += bntIniciarSesion_Click;
            // 
            // btnCanselar
            // 
            btnCanselar.Location = new Point(727, 389);
            btnCanselar.Name = "btnCanselar";
            btnCanselar.Size = new Size(94, 29);
            btnCanselar.TabIndex = 6;
            btnCanselar.Text = "Cancelar";
            btnCanselar.UseVisualStyleBackColor = true;
            btnCanselar.Click += btnCanselar_Click;
            // 
            // checkVerPassword
            // 
            checkVerPassword.AutoSize = true;
            checkVerPassword.Location = new Point(476, 265);
            checkVerPassword.Name = "checkVerPassword";
            checkVerPassword.Size = new Size(117, 24);
            checkVerPassword.TabIndex = 7;
            checkVerPassword.Text = "Ver Password";
            checkVerPassword.UseVisualStyleBackColor = true;
            checkVerPassword.CheckedChanged += checkVerPassword_CheckedChanged;
            // 
            // IniciarSesionView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(946, 513);
            Controls.Add(checkVerPassword);
            Controls.Add(btnCanselar);
            Controls.Add(bntIniciarSesion);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(Label1);
            Controls.Add(pictureBoxLogo);
            Name = "IniciarSesionView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar Sesion";
            Load += IniciarSesionView_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxLogo;
        private Label Label1;
        private Label label2;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private Button bntIniciarSesion;
        private Button btnCanselar;
        private CheckBox checkVerPassword;
    }
}