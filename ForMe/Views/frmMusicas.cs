using ForMe.Controllers;
using ForMe.Filtros;
using ForMe.Models;
using ForMe.Service;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using ForMe.Filtros;

namespace ForMe.Views;

public partial class frmMusicas : Form
{

    SongController songController = new SongController();
    //private List<Music> lstMusic;

    public frmMusicas()
    {
        InitializeComponent();
    }







    private async void btnTryHttp_Click(object sender, EventArgs e)
    {
        bool blnTmp = await songController.ConectaApiAsync();
        rtbResponse.Text = blnTmp.ToString();
    }

    private async void btnTryHttp2_Click(object sender, EventArgs e)
    {
        var strJson = await songController.ConectaApi2Async();
        int i = 0;
        rtbResponse.Text = strJson.ToString();
    }

    private async void btnMusicGeneros_ClickAsync(object sender, EventArgs e)
    {
        var strJson = await songController.ConectaApiAsyncString();
        int i = 0;
        rtbResponse.Text = strJson.ToString();

    }

    private async void btnMusicaGeneros_ClickAsync(object sender, EventArgs e)
    {
        List<Music> lstMusic = JsonSerializer.Deserialize<List<Music>>(await songController.ConectaApiAsyncString());
        rtbResponse.Text = LinqFilter.FiltraTodosGeneros(lstMusic);
        rtbResponse.Text = LinqFilter.FiltroJson(lstMusic);

    }

    private void frmMusicas_Load(object sender, EventArgs e)
    {
        //frmMusicas_LoadAsync(sender, e);
    }

  


}
