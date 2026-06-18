namespace Desktop.Views
{
    partial class MenuPrincipalView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnSaludo = new FontAwesome.Sharp.IconButton();
            menuStrip1 = new MenuStrip();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            SubMenuArticulos = new FontAwesome.Sharp.IconMenuItem();
            categoriasToolStripMenuItem = new ToolStripMenuItem();
            SubMenuSalir = new FontAwesome.Sharp.IconMenuItem();
            SubMenuSalirDelSistema = new FontAwesome.Sharp.IconMenuItem();
            SubMenuClientes = new FontAwesome.Sharp.IconMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnSaludo
            // 
            BtnSaludo.BackColor = Color.LawnGreen;
            BtnSaludo.IconChar = FontAwesome.Sharp.IconChar.ThinkPeaks;
            BtnSaludo.IconColor = Color.Black;
            BtnSaludo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnSaludo.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSaludo.Location = new Point(12, 381);
            BtnSaludo.Name = "BtnSaludo";
            BtnSaludo.Size = new Size(176, 57);
            BtnSaludo.TabIndex = 0;
            BtnSaludo.Text = "Saludo";
            BtnSaludo.UseVisualStyleBackColor = false;
            BtnSaludo.Click += BtnSaludo_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconMenuItem1, SubMenuSalir });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { SubMenuArticulos, categoriasToolStripMenuItem, SubMenuClientes });
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.House;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(100, 24);
            iconMenuItem1.Text = "Principal";
            // 
            // SubMenuArticulos
            // 
            SubMenuArticulos.IconChar = FontAwesome.Sharp.IconChar.TableList;
            SubMenuArticulos.IconColor = Color.Black;
            SubMenuArticulos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SubMenuArticulos.Name = "SubMenuArticulos";
            SubMenuArticulos.Size = new Size(224, 26);
            SubMenuArticulos.Text = "Artículos";
            SubMenuArticulos.Click += SubMenuArticulos_Click;
            // 
            // categoriasToolStripMenuItem
            // 
            categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            categoriasToolStripMenuItem.Size = new Size(224, 26);
            categoriasToolStripMenuItem.Text = "Categorias";
            categoriasToolStripMenuItem.Click += categoriasToolStripMenuItem_Click;
            // 
            // SubMenuSalir
            // 
            SubMenuSalir.DropDownItems.AddRange(new ToolStripItem[] { SubMenuSalirDelSistema });
            SubMenuSalir.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            SubMenuSalir.IconColor = Color.Black;
            SubMenuSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SubMenuSalir.Name = "SubMenuSalir";
            SubMenuSalir.Size = new Size(72, 24);
            SubMenuSalir.Text = "Salir";
            // 
            // SubMenuSalirDelSistema
            // 
            SubMenuSalirDelSistema.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            SubMenuSalirDelSistema.IconColor = Color.Black;
            SubMenuSalirDelSistema.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SubMenuSalirDelSistema.Name = "SubMenuSalirDelSistema";
            SubMenuSalirDelSistema.Size = new Size(202, 26);
            SubMenuSalirDelSistema.Text = "Salir del Sistema";
            SubMenuSalirDelSistema.Click += SubMenuSalirDelSistema_Click;
            // 
            // SubMenuClientes
            // 
            SubMenuClientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            SubMenuClientes.IconColor = Color.Black;
            SubMenuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SubMenuClientes.Name = "SubMenuClientes";
            SubMenuClientes.Size = new Size(224, 26);
            SubMenuClientes.Text = "Clientes";
            SubMenuClientes.Click += SubMenuClientes_Click;
            // 
            // MenuPrincipalView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(BtnSaludo);
            Controls.Add(menuStrip1);
            ForeColor = Color.Blue;
            MainMenuStrip = menuStrip1;
            Name = "MenuPrincipalView";
            Text = "Sistema de Inventario ISP 20-2do año TSDS";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnSaludo;
        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem SubMenuArticulos;
        private FontAwesome.Sharp.IconMenuItem SubMenuSalir;
        private FontAwesome.Sharp.IconMenuItem SubMenuSalirDelSistema;
        private ToolStripMenuItem categoriasToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem SubMenuClientes;
    }
}
