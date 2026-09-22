using Desktop.Services;
using Services.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Views
{
    public partial class LocalidadesApiView : Form
    {
        LocalidadesApiService localidadesService = new LocalidadesApiService();
        ProvinciasApiService provinciasService = new ProvinciasApiService();
        PaisesApiService paisesService = new PaisesApiService();
        Localidad? localidadModificada;
        public LocalidadesApiView()
        {
            InitializeComponent();
            _ = LoadLocalidades();
            _ = LoadComboProvincias();
        }

        private async Task LoadComboProvincias()
        {
            var provincias = await provinciasService.GetAllAsync();
            if (provincias != null)
            {
                comboProvincias.DataSource = provincias;
                comboProvincias.DisplayMember = "Name";
                comboProvincias.ValueMember = "Id";
                comboProvincias.SelectedValue = -1;
            }
        }

        private async Task LoadLocalidades()
        {
            var localidades = await localidadesService.GetAllAsync();
            if (localidades != null)
            {
                dataGridLocalidades.DataSource = localidades;
                //ocultamos las columnas que no queremos mostrar
                //dataGridClientes.Columns["Id"].Visible = false;
                //dataGridClientes.Columns["Created_at"].Visible = false;
                //dataGridClientes.Columns["LocalidadId"].Visible = false;
                //dataGridClientes.Columns["IsDeleted"].Visible = false;
            }
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            var localidades = await localidadesService.GetAllWithFilterAsync(txtBusqueda.Text);
            if (localidades != null)
            {
                dataGridLocalidades.DataSource = localidades;
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            Localidad localidad = new Localidad
            {
                Name = txtNombre.Text,
                ProvinciaId = comboProvincias.SelectedValue != null ? (int)comboProvincias.SelectedValue : 0
            };
            bool localidadGuardado;
            if (localidadModificada == null)
            {
                localidadGuardado = await localidadesService.AddLocalidadAsync(localidad);
            }
            else
            {
                localidad.Id = localidadModificada.Id;
                localidadGuardado = await localidadesService.UpdateLocalidadAsync(localidad);
            }
            if (!localidadGuardado)
            {
                MessageBox.Show("Error al guardar el localidad");
                return;
            }
            MessageBox.Show("Cliente guardado correctamente");
            await LoadLocalidades();
            ClearTextBox();
            tabControl1.SelectedTab = tabPageLista;
            localidadModificada = null;
        }

        private void ClearTextBox()
        {
            txtNombre.Clear();
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPageAgregarEditar;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPageLista;
            ClearTextBox();
            localidadModificada = null;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //capturamos el cliente seleccionado en la grilla
            if (dataGridLocalidades.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un cliente para modificar");
                return;
            }
            localidadModificada = (Localidad)dataGridLocalidades.CurrentRow.DataBoundItem;
            //llenamos los campos del formulario con los datos del cliente seleccionado
            txtNombre.Text = localidadModificada.Name;
            
            if (localidadModificada.ProvinciaId != 0)
                comboProvincias.SelectedValue = localidadModificada.ProvinciaId;
            //cambiamos a la pestaña de agregar/editar
            tabControl1.SelectedTab = tabPageAgregarEditar;

        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            //chequeamos si la tecla presionada es Enter y pulsamos el botón de buscar
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnBuscar.PerformClick();
                e.Handled = true; // Evita que el sonido de "ding" se reproduzca
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            //capturamos el localidad seleccionado en la grilla
            if (dataGridLocalidades.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un localidad para eliminar");
                return;
            }
            var localidadAEliminar = (Localidad)dataGridLocalidades.CurrentRow.DataBoundItem;
            //preguntamos si está seguro de eliminar el localida
            var result = MessageBox.Show($"¿Está seguro de eliminar al localidad {localidadAEliminar.Name}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                //eliminamos el localidad
                var localidadEliminado = await localidadesService.DeleteLocalidadAsync((int)localidadAEliminar.Id!);
                if (!localidadEliminado)
                {
                    MessageBox.Show("Error al eliminar el localidad");
                    return;
                }
                MessageBox.Show($"Localidad {localidadAEliminar.Name} eliminado correctamente");
                await LoadLocalidades();
            }
        }

        private async void checkVerEliminados_CheckedChanged(object sender, EventArgs e)
        {
            txtBusqueda.Enabled = !checkVerEliminados.Checked;
            btnBuscar.Enabled = !checkVerEliminados.Checked;
            btnNuevo.Enabled = !checkVerEliminados.Checked;
            btnModificar.Enabled = !checkVerEliminados.Checked;
            btnEliminar.Enabled = !checkVerEliminados.Checked;
            btnRestaurar.Enabled = checkVerEliminados.Checked;
            if (checkVerEliminados.Checked)
            {
                await LoadDeleteds();
            }
            else
            {
                await LoadLocalidades();
            }
        }

        private async Task LoadDeleteds()
        {
            var localidades = await localidadesService.GetDeletedsAsync();
            if (localidades != null)
            {
                dataGridLocalidades.DataSource = localidades;
            }
        }

        private async void btnRestaurar_Click(object sender, EventArgs e)
        {
            //capturamos el cliente seleccionado en la grilla
            if (dataGridLocalidades.CurrentRow != null)
            {
                var localidadARestaurar = (Localidad)dataGridLocalidades.CurrentRow.DataBoundItem;
                //preguntamos si está seguro de eliminar el cliente
                var result = MessageBox.Show($"¿Está seguro de restaurar al localidad {localidadARestaurar.Name}?", "Confirmar restauración", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    //eliminamos el cliente
                    var localidadRestaurado = await localidadesService.RestoreLocalidadAsync((int)localidadARestaurar.Id!);
                    if (localidadRestaurado)
                    {
                        MessageBox.Show($"Cliente {localidadARestaurar.Name} restaurado correctamente");
                        await LoadDeleteds();
                    }
                    else
                    {
                        MessageBox.Show("Error al restaurar el localidad");
                    }
                }
            }

            else
            {
                MessageBox.Show("Seleccione un localidad para restaurar");
            }
        }
    }
}
