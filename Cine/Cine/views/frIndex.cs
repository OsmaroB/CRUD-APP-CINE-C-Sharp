using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cine.controllers;

namespace Cine.views
{
    public partial class frIndex : Form
    {
        peliculas_controller controlador = new peliculas_controller();
        public frIndex()
        {
            InitializeComponent();
            this.CenterToScreen();
            controlador.tabla(1, 1, PanelGrid);
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            new frMantenimiento("").Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            new frMantenimiento("").Show();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            PanelGrid.Controls.Clear();
            controlador.tabla(1, 1, PanelGrid);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            PanelGrid.Controls.Clear();
            controlador.tablaBusqueda(1,1,PanelGrid,txtSearch);
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            new frCreditos().ShowDialog();
        }
    }
}
