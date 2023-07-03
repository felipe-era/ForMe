using ForMe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ForMe.Controllers;

internal class SongController
{
    public async Task<string> ConectaApiAsync(string strRetorno)
    {
        strRetorno = string.Empty;
        using (HttpClient client = new HttpClient())
        {
            try
            {
                HttpResponseMessage httpResponse = await client.GetAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
                httpResponse.EnsureSuccessStatusCode(); // Lança uma exceção se a requisição não for bem-sucedida (código de status 2xx)

                if (httpResponse.IsSuccessStatusCode)
                {
                    // Lê o conteúdo da resposta como uma string
                    string responseBody = await httpResponse.Content.ReadAsStringAsync();
                    // Processa os dados recebidos
                    var musicas = JsonSerializer.Deserialize<List<Music>>(responseBody);
                    //rtbResponse.Text = musicas.Count.ToString();
                    //musicas[0].ExibirDetalhesMusica();
                    strRetorno = musicas[0].ToString();
                }
                else
                {
                    // A requisição não foi bem-sucedida, exibe o código de status
                    MessageBox.Show($"Falha na requisição. Código de status: {httpResponse.StatusCode}");
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Ocorreu um erro na requisição: {ex.Message}");
            }
        }
        return strRetorno;

    }

    public async Task<string> ConectaApi2Async(string strRetorno)
    {
        strRetorno = string.Empty;

        using (HttpClient client = new HttpClient())
        {
            try
            {
                string strResponse = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
                strRetorno = strResponse;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Ocorreu um erro na requisição: {ex.Message}");
            }

        }
        return strRetorno;
    }





}
