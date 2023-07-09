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
    public const string APIHTTP = "https://guilhermeonrails.github.io/api-csharp-songs/songs.json";

    /// <summary>
    /// Conexão com API teste1
    /// </summary>
    /// <param name="strRetorno">Utilizada para o retorno</param>
    /// <returns>Task vazia caso não encontre</returns>
    public async Task<bool> ConectaApiAsync()
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                HttpResponseMessage httpResponse = await client.GetAsync(APIHTTP);
                httpResponse.EnsureSuccessStatusCode(); // Lança uma exceção se a requisição não for bem-sucedida (código de status 2xx)

                if (httpResponse.IsSuccessStatusCode)
                {
                    string responseBody = await httpResponse.Content.ReadAsStringAsync();
                    var musicas = JsonSerializer.Deserialize<List<Music>>(responseBody);
                    //strRetorno = musicas[1].ToString();'
                    return true;
                }
                else
                {
                    MessageBox.Show($"Falha na requisição. Código de status: {httpResponse.StatusCode}");
                    return false;
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Ocorreu um erro na requisição: {ex.Message}");
            }
        }
        return false;
    }

    /// <summary>
    /// Conexão com API teste2- NW?
    /// </summary>
    /// <param name="strRetorno"></param>
    /// <returns></returns>
    public async Task<bool> ConectaApi2Async()
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                var strResponse = await client.GetStringAsync(APIHTTP);
                //caso estiver off não cai como httpexception
                return true;
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Falha na requisição. Código de status: {ex.Message}");
                return false;
            }

        }
    }

    public async Task<string> ConectaApiAsyncString()
    {

        string strRetorno = string.Empty;
        using (HttpClient client = new HttpClient())
        {
            try
            {
                HttpResponseMessage httpResponse = await client.GetAsync(APIHTTP);
                httpResponse.EnsureSuccessStatusCode(); // Lança uma exceção se a requisição não for bem-sucedida (código de status 2xx)

                if (httpResponse.IsSuccessStatusCode)
                {
                    string responseBody = await httpResponse.Content.ReadAsStringAsync();
                    var musics = JsonSerializer.Deserialize<List<Music>>(responseBody);
                    return responseBody;
                }
                else
                {
                    MessageBox.Show($"Falha na requisição. Código de status: {httpResponse.StatusCode}");
                    return strRetorno;
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Ocorreu um erro na requisição: {ex.Message}");
            }
        }
        return strRetorno;
    }

    public static async Task<List<Music>> JsonMusicas()
    {
        List<Music> lstMusic = new List<Music>();
        string strRetorno = string.Empty;

        using (HttpClient client = new HttpClient())
        {
            try
            {
                HttpResponseMessage httpResponse = await client.GetAsync(APIHTTP);
                httpResponse.EnsureSuccessStatusCode(); // Lança uma exceção se a requisição não for bem-sucedida (código de status 2xx)

                if (httpResponse.IsSuccessStatusCode)
                {
                    string responseBody = await httpResponse.Content.ReadAsStringAsync();
                    lstMusic = JsonSerializer.Deserialize<List<Music>>(responseBody);
                    return lstMusic;
                }
                else
                {
                    MessageBox.Show($"Falha na requisição. Código de status: {httpResponse.StatusCode}");
                    return lstMusic;
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Ocorreu um erro na requisição: {ex.Message}");
            }
        }

        return lstMusic;
    }








}
