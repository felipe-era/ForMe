using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ForMe.Models;

internal class Music
{
    [JsonPropertyName("song")]
    public string? Nome { get; set; }

    [JsonPropertyName("artist")]
    public string? Artista{ get; set; }

    [JsonPropertyName("duration_ms")]
    public int? Duracao { get; set; }

    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    public void ExibirDetalhesMusica()
    {
        MessageBox.Show($" {Nome}-{Artista}-{Duracao}-{Genero} ");
    }

    public List<string?> GetDetalhesMusicas()
    {
        List<string?> detalhes = new List<string?>
        {
            Nome,
            Artista,
            Duracao?.ToString(),
            Genero
        };

        return detalhes;
    }
}
