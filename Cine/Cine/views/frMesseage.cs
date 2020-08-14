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
    public partial class frMesseage : Form
    {
        public frMesseage(String encabezado, String texto)
        {
            InitializeComponent();
            this.CenterToScreen();
            lbEncabezado.Text = encabezado;
            lbTexto.Text = texto;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
