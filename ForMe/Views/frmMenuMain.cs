using ForMe.Controllers;
using ForMe.Models;
using ForMe.Views;
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

namespace ForMe;

public partial class frmMenuMain : Form
{
    public frmMenuMain()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {

        frmMusicas frmMusicas = new frmMusicas();
        frmMusicas.ShowDialog();
    }

    private void toolStripMenuItem3_Click(object sender, EventArgs e)
    {
        frmMusicas frmMsc = new frmMusicas();
        frmMsc.TopLevel = false;
        frmMsc.Dock = DockStyle.Fill;
        panel1.Controls.Clear();

        panel1.Controls.Add(frmMsc);
        frmMsc.Show();
    }

    private void xToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Environment.Exit(0);
    }
}
