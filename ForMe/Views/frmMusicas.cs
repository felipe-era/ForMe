using ForMe.Controllers;
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
}
