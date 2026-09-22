
using DotNetEnv;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;


namespace Desktop.Services
{
    public class PaisesApiService
    {
        HttpClient httpClient;
        JsonSerializerOptions options;
        public PaisesApiService()
        {
            httpClient = SettingHttpClient();
            options = SettingJsonSerializer();
        }
        public async Task<List<Pais>?> GetAllAsync()
        {
            try
            {
                var response = await httpClient.GetAsync("");
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Error al obtener las paises: " + response.ReasonPhrase);
                    return null;
                }
                var json = await response.Content.ReadAsStringAsync();
                var paises = JsonSerializer.Deserialize<List<Pais>>(json, options);
                return paises;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error obtener las paises desde la Api: " + ex.Message);
                return null;

            }
        }

        public async Task<List<Pais>?> GetDeletedsAsync()
        {
            try
            {
                var response = await httpClient.GetAsync("deleteds");
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Error al obtener las Paises: " + response.ReasonPhrase);
                    return null;
                }
                var json = await response.Content.ReadAsStringAsync();
                var paises = JsonSerializer.Deserialize<List<Pais>>(json, options);
                return paises;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error obtener las paises desde la Api: " + ex.Message);
                return null;

            }
        }

        public async Task<List<Pais>?> GetAllWithFilterAsync(string filter)
        {
            try
            {
                var response = await httpClient.GetAsync($"?filtro={filter}");
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Error al obtener las paises: " + response.ReasonPhrase);
                    return null;

                }
                var json = await response.Content.ReadAsStringAsync();
                var paises = JsonSerializer.Deserialize<List<Pais>>(json, options);
                return paises;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error obtener las paises desde la Api: " + ex.Message);
                return null;

            }
        }

        public async Task<bool> AddLocalidadAsync(Pais pais)
        {
            try
            {
                var json = JsonSerializer.Serialize(pais, options);
                var paisJson = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync("", paisJson);
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Error al crear la pais: " + response.ReasonPhrase);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear la pais desde la Api: " + ex.Message);
                return false;
            }

        }

        public async Task<bool> DeletePaisAsync(int id)
        {
            try
            {
                var response = await httpClient.DeleteAsync(id.ToString());
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Error al eliminar la pais: " + response.ReasonPhrase);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la pais desde la Api: " + ex.Message);
                return false;
            }
        }

        public async Task<bool> RestorePaisAsync(int id)
        {
            try
            {
                var response = await httpClient.PutAsync($"restore/{id}", null);
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Error al eliminar la pais: " + response.ReasonPhrase);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la pais desde la Api: " + ex.Message);
                return false;
            }

        }

        public async Task<bool> UpdatePaisAsync(Pais pais)
        {
            try
            {
                // Configuramos las opciones de serialización para ignorar propiedades nulas y hacer que la búsqueda de propiedades sea insensible a mayúsculas
                var options = new JsonSerializerOptions
                {
                    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                    PropertyNameCaseInsensitive = true,
                };

                var json = JsonSerializer.Serialize(pais, options);
                var paisJson = new StringContent(json, Encoding.UTF8, "application/json");
                string idcliente = pais.Id.ToString();
                var response = await httpClient.PutAsync(idcliente, paisJson);
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Error al actualizar la pais: " + response.ReasonPhrase);
                    return false;
                }
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la pais desde la Api: " + ex.Message);
                return false;
            }

        }

        private HttpClient SettingHttpClient()
        {
            Env.Load("../../../");
            //var urlApi = Environment.GetEnvironmentVariable("URLAPI");
            var urlApi = Environment.GetEnvironmentVariable("URLAPILOCAL");

            //instanciamos el httpClient y lo configuramos para poder utilizarlo en cada uno de los métodos
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(urlApi + "Paises/");
            //agregamos apikey de la url
            httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            return httpClient;
        }

        private JsonSerializerOptions SettingJsonSerializer()
        {
            return new JsonSerializerOptions
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                PropertyNameCaseInsensitive = true,
            };
        }

    }
}

