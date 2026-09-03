using Desktop.Models;
using Desktop.Services;

namespace Desktop.Views
{
    public partial class PaqueteriaView : Form
    {
        PaqueteriaService paqueteriaService = new PaqueteriaService();
        Paqueteria paqueteriaModificado;
        public PaqueteriaView()
        {
            InitializeComponent();
            LoadPaqueteria();
        }

        private async void LoadPaqueteria()
        {
            var paqueteria = await paqueteriaService.GetAllAsync();
            if (paqueteria != null)
            {
                dataGridPaqueteria.DataSource = paqueteria;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPageAgregarEditar_Click(object sender, EventArgs e)
        {

        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            var paqueteria = await paqueteriaService.GetAllWithFilterAsync(txtBusqueda.Text);
            if (paqueteria != null)
            {
                dataGridPaqueteria.DataSource = paqueteria;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.tabControl.SelectedTab = tabPageAgregarEditar;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //capturamos el cliente seleccionado en el DataGridView
            if (dataGridPaqueteria.CurrentRow != null)
            {
                paqueteriaModificado = (Paqueteria)dataGridPaqueteria.CurrentRow.DataBoundItem;
                //llenamos los campos del formulario con los datos del cliente seleccionado
                txtEmisorNombreApellido.Text = paqueteriaModificado.Emisor_Nombre_y_Apellido;
                txtEmisorTelefono.Text = paqueteriaModificado.Emisor_Telefono.ToString();
                txtEmisorDireccion.Text = paqueteriaModificado.Emisor_Direccion;
                datetimeEmisorFechaHoraDespacho.Value = paqueteriaModificado.Emisor_Fecha_y_Hora_Despacho;
                txtCodigo.Text = paqueteriaModificado.Emisor_Codigo;
                txtDestinatarioNombreApellido.Text = paqueteriaModificado.Destinatario_Nombre_y_Apellido;
                txtDestintarioTelefono.Text = paqueteriaModificado.Destinatario_Telefono.ToString();
                txtDestinatarioDireccion.Text = paqueteriaModificado.Destinatario_Direccion;
                datetimeDestinatarioFechaHoraEntrega.Value = paqueteriaModificado.Destinatario_Fecha_y_Hora_Entrega;

                //cambiamos a la pestaña de agregar/editar
                tabControl.SelectedTab = tabPageAgregarEditar;
            }
        }

        private void textDestinatarioFechaHoraEntrega_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            bool paqueteriaGuardado;

            Paqueteria paqueteria = new Paqueteria()
            {
                Emisor_Nombre_y_Apellido = txtEmisorNombreApellido.Text,
                Emisor_Telefono = Convert.ToUInt32(txtEmisorTelefono.Text),
                Emisor_Direccion = txtEmisorDireccion.Text,
                Emisor_Fecha_y_Hora_Despacho = datetimeEmisorFechaHoraDespacho.Value,
                Emisor_Codigo = txtCodigo.Text,
                Destinatario_Nombre_y_Apellido = txtDestinatarioNombreApellido.Text,
                Destinatario_Telefono = Convert.ToUInt32(txtDestintarioTelefono.Text),
                Destinatario_Direccion = txtDestinatarioDireccion.Text,
                Destinatario_Fecha_y_Hora_Entrega = datetimeDestinatarioFechaHoraEntrega.Value,
            };
            if (paqueteriaModificado == null)
            {
                paqueteriaGuardado = await paqueteriaService.AddPaqueteriaAsync(paqueteria);
            }
            else
            {
                paqueteria.id = paqueteriaModificado.id;
                paqueteria.created_at = paqueteriaModificado.created_at;
                paqueteriaGuardado = await paqueteriaService.UpdatePaqueteriaAsync(paqueteria);
            }

            if (paqueteriaGuardado)
            {
                MessageBox.Show("Paquetería guardada correctamente");
                LoadPaqueteria();
                ClearTextBox();
                tabControl.SelectedTab = tabPageLista;
            }
            else
            {
                MessageBox.Show("Error al guardar el cliente");
            }
        }

        private void ClearTextBox()
        {
            txtEmisorNombreApellido.Clear();
            txtEmisorTelefono.Clear();
            txtEmisorDireccion.Clear();
            datetimeEmisorFechaHoraDespacho.Value = DateTime.Now;
            txtCodigo.Clear();
            txtDestinatarioNombreApellido.Clear();
            txtDestintarioTelefono.Clear();
            txtDestinatarioDireccion.Clear();
            datetimeDestinatarioFechaHoraEntrega.Value = DateTime.Now;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.tabControl.SelectedTab = tabPageLista;
            ClearTextBox();
            paqueteriaModificado = null;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //ahora vamos a eliminar el cliente seleccionado en el DataGridView
            if (dataGridPaqueteria.CurrentRow != null)
            {
                paqueteriaModificado = (Paqueteria)dataGridPaqueteria.CurrentRow.DataBoundItem;
                //preguntamos si esta seguro de eliminar el cliente
                DialogResult result = MessageBox.Show("¿Está seguro de eliminar el paquete seleccionado?", "Eliminar Paquete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    //eliminamos el cliente
                    bool paqueteriaEliminado = paqueteriaService.DeletePaqueteriaAsync(paqueteriaModificado.id).Result;
                    if (paqueteriaEliminado)
                    {
                        MessageBox.Show("Paquete eliminado correctamente");
                        LoadPaqueteria();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el paquete");
                    }
                }
            }
        }

        private void PaqueteriaView_Load(object sender, EventArgs e)
        {

        }
    }
}
