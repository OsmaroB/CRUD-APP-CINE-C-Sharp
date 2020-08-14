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
    public partial class frMantenimiento : Form
    {
        peliculas_controller controlador = new peliculas_controller();
        String id;
        public frMantenimiento(object id)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.id = Convert.ToString(id);
            controlador.cmbGenero(cmbGenero);
            if (this.id != "")
            {
                controlador.read(this.id, txtNombre, txtDirector, txtAnio, cmbGenero, txtId);
            }
            
                
            
            
        }

        private void FrMantenimiento_Load(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (this.id != "")
            {
                controlador.update(txtId,txtNombre,txtDirector,Convert.ToInt32(txtAnio.Text),cmbGenero);
                new frMesseage("Success", "Pelicula modificada correctamente").Show();
                this.Hide();
            }
            else {
                controlador.create(txtId, txtNombre, txtDirector, Convert.ToInt32(txtAnio.Text), cmbGenero);
                new frMesseage("Success", "Pelicula agregado correctamente").Show();
                this.Hide();
            }
        }
    }
}
