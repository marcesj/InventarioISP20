using Desktop.Services;
using DotNetEnv;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Views
{
    public partial class ProbandoAI_Gemini : Form
    {
        public ProbandoAI_Gemini()
        {
            InitializeComponent();
        }

        private void ProbandoAI_Gemini_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1Send_Click(object sender, EventArgs e)
        {
            Env.Load("../../../");
            var apikey = Environment.GetEnvironmentVariable("APIKEY_GEMINI");
            if (apikey == null)
            {
                textBox2RESPONSE.Text = "No se encontro la APIKEY en las variables del entorno.";
                return;
            }
            //textBox2RESPONSE.Text = $"La APIKEY ES: {apikey}";

            //creamos un hhtpclient para hacer la peticion a la api de gemini con using
            using (var client = new HttpClient())
            {
                textBox2RESPONSE.Text = "Procesando su Consulta";
                var url = "https://generativelanguage.googleapis.com/v1beta/interactions";
                var requestBody = new
                {
                    model = "gemini-3.5-flash",
                    input = textBox1Prompt.Text
                };
                client.DefaultRequestHeaders.Add("x-goog-api-key", $"{apikey}");

                var response = await client.PostAsJsonAsync(url, requestBody);
                if (response == null)
                {
                    textBox2RESPONSE.Text = "No se recibió respuesta de la API.";
                    return;
                }

                GeminiService? responseGemini = await response.Content.ReadFromJsonAsync<GeminiService>();
                if (responseGemini == null)
                {
                    textBox2RESPONSE.Text = "No se pudo deserializar la respuesta de la API.";
                    return;
                }
                textBox2RESPONSE.Text = responseGemini.steps[1].content[0].text;
            }
        }
    }
}
