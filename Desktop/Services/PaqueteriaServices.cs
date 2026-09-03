using Desktop.Models;
using DotNetEnv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Desktop.Services
{
    public class PaqueteriaService
    {
        HttpClient httpClient;
        const string urlApi = "https://juwgqwemmsyexiyoldjm.supabase.co/rest/v1/PAQUETERIA"; // Endpoint

        public PaqueteriaService()
        {
            Env.Load("../../../");
            var apikey = Environment.GetEnvironmentVariable("apikey_supabase");

            // Inicializar el HttpClient y configurar la base address y los headers necesarios
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(urlApi);
            // agregar la apikey y el header de aceptacion de json
            httpClient.DefaultRequestHeaders.Add("apikey", "sb_publishable_nbYHDfGANmzDBagxB1qSBg_aBn0Zhxt");
            httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
        }

        public async Task<List<Paqueteria>?> GetAllAsync()
        {
            try
            {
                var response = await httpClient.GetAsync(urlApi);
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var paqueteria = System.Text.Json.JsonSerializer.Deserialize<List<Models.Paqueteria>>(json);
                    return paqueteria;
                }
                else
                {
                    throw new Exception("Error al obtener los paqueteria" + response.ReasonPhrase);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener paqueteria desde la Api: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public async Task<List<Paqueteria>?> GetAllWithFilterAsync(string filter)
        {
            try
            {
                string filtrosupabase = $"?or=(Emisor_Nombre_y_Apellido.ilike.*{filter}*,Emisor_Direccion.ilike.*{filter}*, Emisor_Fecha_y_Hora_Despacho.ilike.*{filter}*, Emisor_Codigo.ilike.*{filter}*, Destinatario_Nombre_y_Apellido.ilike.*{filter}*,Destinatario_Direccion.ilike.*{filter}*, Destinatario_Fecha_y_Hora_Entrega.ilike.*{filter}*)";
                var response = await httpClient.GetAsync(filtrosupabase);
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var paqueteria = System.Text.Json.JsonSerializer.Deserialize<List<Models.Paqueteria>>(json);
                    return paqueteria;
                }
                else
                {
                    throw new Exception("Error al obtener la paqueteria" + response.ReasonPhrase);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener paqueteria desde la Api: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public async Task<bool> AddPaqueteriaAsync(Paqueteria paqueteria)
        {
            try
            {
                // Configuramos las opciones de serialización para ignorar propiedades nulas y hacer que la búsqueda de propiedades sea insensible a mayúsculas
                var options = new JsonSerializerOptions
                {
                    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                    PropertyNameCaseInsensitive = true,
                };

                var json = JsonSerializer.Serialize(paqueteria, options);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync("", content);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Error al crear el paqueteria: " + response.ReasonPhrase);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el paqueteria desde la Api: " + ex.Message);
                return false;
            }

        }

        public async Task<bool> UpdatePaqueteriaAsync(Paqueteria paqueteria)
        {
            try
            {
                // Configuramos las opciones de serialización para ignorar propiedades nulas y hacer que la búsqueda de propiedades sea insensible a mayúsculas
                var options = new JsonSerializerOptions
                {
                    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                    PropertyNameCaseInsensitive = true,
                };

                var json = JsonSerializer.Serialize(paqueteria, options);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                string urlUpdate = $"?id=eq.{paqueteria.id}";
                var response = await httpClient.PutAsync(urlUpdate, content);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Error al actualizar el paqueteria: " + response.ReasonPhrase);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el paqueteria desde la Api: " + ex.Message);
                return false;
            }
        }

        public async Task<bool> DeletePaqueteriaAsync(int? id)
        {
            try
            {
                string urlDelete = $"?id=eq.{id}";
                var response = httpClient.DeleteAsync(urlDelete).Result;
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Error al eliminar el paquete: " + response.ReasonPhrase);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el paquete desde la Api: " + ex.Message);
                return false;
            }
        }
    }
}
