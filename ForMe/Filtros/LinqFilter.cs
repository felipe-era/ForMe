using ForMe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForMe.Filtros;


internal class LinqFilter
{
    public static string FiltraTodosGeneros(List<Music> musics)
    {
        string strTmp = string.Empty;
        var todosGeneros = musics.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var linhaGenero in todosGeneros)
        {
            strTmp += linhaGenero + "\n";

        }
        return strTmp;
    }
    public static string FiltroOrdemNome(List<Music> musics)
    {
        string strTmp = string.Empty;
        var todosGeneros = musics.OrderBy(musics => musics.Artista)
                                 .Select(musics => musics.Artista)
                                 .Distinct().ToList();
        foreach (var linhaOrdenada in todosGeneros)
        {
            strTmp += linhaOrdenada + "\n";

        }
        return strTmp;
    }
    public static string FiltrarMusicasArtista(List<Music> musics, string pMusicaPesquisa)
    {
        string strTmp = string.Empty;
        var todosGeneros = musics.Where(musics => musics.Artista!.Equals(pMusicaPesquisa)).ToList();
        
        for (int i = 0; i < todosGeneros.Count; i++)
        {
            strTmp += todosGeneros[i].Artista + " -" + todosGeneros[i].Nome + " - " + todosGeneros[i].Duracao + "\n"; 
        }
       
        return strTmp;
    }

}
