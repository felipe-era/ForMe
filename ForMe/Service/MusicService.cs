using ForMe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForMe.Service;

internal class MusicService
{
    public static void FiltrarGeneros(List<Music> lstMusicas)
    {
        var varTodosGeneros = lstMusicas.Select(generos => generos.Genero).Distinct().ToList();

        MessageBox.Show(varTodosGeneros.ToString());


        //foreach (var linhaGenero in varTodosGeneros)
        //{
        //}

    }
}
