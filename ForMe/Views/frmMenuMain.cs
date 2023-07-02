using ForMe.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
}
