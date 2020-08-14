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
    public partial class frDelete : Form
    {
        peliculas_controller controlador = new peliculas_controller();
        String id;
        public frDelete(object id)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.id = Convert.ToString(id);
            if (this.id != "") {
                controlador.readDelete(this.id, lbTexto);
            }
        }

        private void FrDelete_Load(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            controlador.delete(this.id);
            new frMesseage("Success", "Pelicula eliminada correctamente").Show();
            this.Hide();
        }
    }
}
