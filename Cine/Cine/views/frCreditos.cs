using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine.views
{
    public partial class frCreditos : Form
    {
        public frCreditos()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore.exe", "www.google.com");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
