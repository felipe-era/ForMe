using ForMe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForMe.Filtros;

internal class LinqFilter
{
    public static void FiltraTodosGeneros(List<Music> musics)
    {
        var todosGeneros = musics.Select(generos => generos.Genero).Distinct().ToList();

        MessageBox.Show($"{todosGeneros}");


    }
}
