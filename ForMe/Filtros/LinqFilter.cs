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
        var todosGeneros = musics. Select(generos => generos.Genero).Distinct().ToList();
        foreach (var linhaGenero in todosGeneros)
        {
            strTmp +=  linhaGenero + "\n";

        }
        return strTmp;
    }
    public static string FiltroJson(List<Music> musics)
    {
        string strTmp = string.Empty;
        var todosGeneros = musics;//. Select( generos => generos.Genero).Distinct().ToList();

        for (int i = 0; i < todosGeneros.Count; i++)
        {
            strTmp += musics[i] + "\n";
        }
        
        return strTmp;
    }

}
