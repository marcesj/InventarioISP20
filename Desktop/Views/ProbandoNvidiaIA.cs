using Desktop.Models;
using Desktop.Services;
using DotNetEnv;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Views
{
    public partial class ProbandoNvidiaIA : Form
    {
        public ProbandoNvidiaIA()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private async void BotonENVIAR_Click(object sender, EventArgs e)
        {
            Env.Load("../../../");
            var apikey = Environment.GetEnvironmentVariable("APIKEY_NVIDIA");
            if (apikey == null)
            {
                txtRtaIa.Text = "No se encontro la APIKEY en las variables del entorno.";
                return;
            }
            //txtRtaIa.Text = $"La APIKEY ES: {apikey}";

            //creamos un hhtpclient para hacer la peticion a la api de gemini con using
            using (var client = new HttpClient())
            {
                txtRtaIa.Text = "Procesando su Consulta";
                var url = "https://integrate.api.nvidia.com/v1/chat/completions";
                //Creamos un requestBody para armar consulta con Nvidia IA
                var requestBody = new
                {
                    messages = new[]
                    {
                        new { role = "user", content =  txtPrompt.Text}
                    },
                    model = "nvidia/ising-calibration-1.5-31b"
                };

                string jsonPayload = JsonSerializer.Serialize(requestBody);

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", $"{apikey}");

                var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

                var response = await client.PostAsJsonAsync(url, requestBody);
                if (response == null)
                {
                    txtRtaIa.Text = "No se recibió respuesta de la API.";
                    return;
                }

                ResponseNvidia? responseNvidia = await response.Content.ReadFromJsonAsync<ResponseNvidia>();
                if (responseNvidia == null)
                {
                    txtRtaIa.Text = "No se pudo deserializar la respuesta de la API.";
                    return;
                }
                txtRtaIa.Text = responseNvidia.choices[0].message.content;
            }
        }

        private void ProbandoNvidiaIA_Load(object sender, EventArgs e)
        {

        }
    }
}
