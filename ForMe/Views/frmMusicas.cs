using ForMe.Controllers;
using ForMe.Models;
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
        string strTmp = songController.ConectaApiAsync("").ToString();
        rtbResponse.Text = strTmp;
    }

    private void btnTryHttp2_Click(object sender, EventArgs e)
    {
        string strTmp = songController.ConectaApi2Async("").ToString();
        rtbResponse.Text = strTmp;

    }
}
