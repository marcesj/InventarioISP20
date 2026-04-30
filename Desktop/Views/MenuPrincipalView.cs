namespace Desktop.Views
{
    public partial class MenuPrincipalView : Form
    {
        public MenuPrincipalView()
        {
            InitializeComponent();
        }

        #region codigo del boton saludo
        private void BtnSaludo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Hola, bienvenido a mi aplicacion de escritorio!");
        }
        #endregion


        private void SubMenuArticulos_Click(object sender, EventArgs e)
        {
            ArticulosView articulosView = new ArticulosView();
            articulosView.Show();
        }


        private void SubMenuSalirDelSistema_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoriasView categoriasView = new CategoriasView();
            categoriasView.MdiParent = this; 
            categoriasView.ShowDialog();
        }
    }
}