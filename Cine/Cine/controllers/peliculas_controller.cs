using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cine.models;

namespace Cine.controllers
{
    class peliculas_controller
    {
        peliculas_class clase = new peliculas_class();
        public void create(Control idPelicula, Control nombre, Control director, int anio, ComboBox nombreGenero)
        {
            if (!string.IsNullOrEmpty(nombre.Text))
            {
                if (!string.IsNullOrEmpty(director.Text))
                {
                    if (anio > 1850 )
                    {
                        if (!string.IsNullOrEmpty(idPelicula.Text))
                        {
                            if (Convert.ToInt32(nombreGenero.SelectedValue) != 0)
                            {
                                //Ejecutamos los set
                                clase.Id = idPelicula.Text;
                                clase.Nombre = nombre.Text;
                                clase.Director1 = director.Text;
                                clase.Anio = anio;
                                clase.IgGenero = nombreGenero.SelectedValue;
                                clase.create();
                            }
                            else
                            {
                                MessageBox.Show("Error campo tipo usuario vacio");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error campo celular vacio");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error campo correo vacio");
                    }
                }
                else
                {
                    MessageBox.Show("Error campo apellido vacio");
                }

            }
            else
            {
                MessageBox.Show("Error");
            }
        }



        public void update(Control idPelicula, Control nombre, Control director, int anio, ComboBox nombreGenero)
        {
            if (!string.IsNullOrEmpty(nombre.Text))
            {
                if (!string.IsNullOrEmpty(director.Text))
                {
                    if (anio > 1850)
                    {
                        if (!string.IsNullOrEmpty(idPelicula.Text))
                        {
                            if (Convert.ToInt32(nombreGenero.SelectedValue) != 0)
                            {
                                //Ejecutamos los set
                                clase.Id = idPelicula.Text;
                                clase.Nombre = nombre.Text;
                                clase.Director1 = director.Text;
                                clase.Anio = anio;
                                clase.IgGenero = nombreGenero.SelectedValue;
                                clase.update();
                            }
                            else
                            {
                                MessageBox.Show("Error campo tipo usuario vacio");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error campo celular vacio");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error campo correo vacio");
                    }
                }
                else
                {
                    MessageBox.Show("Error campo apellido vacio");
                }

            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        public void readDelete(String id, Control lb)
        {
            if (id != "")
            {
                clase.Id = id;
                Object[] datos = new Object[2];
                datos = clase.ReadDelete();
                lb.Text = Convert.ToString(datos[0]);
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        public void read(String id, Control nombre, Control director, Control anio, ComboBox Genero,Control idPel)
        {
            if (id != "")
            {
                clase.Id = id;
                Object[] datos = new Object[2];
                datos = clase.Read();
                nombre.Text = Convert.ToString(datos[1]);
                director.Text = Convert.ToString(datos[2]);
                anio.Text = Convert.ToString(datos[3]);
                idPel.Text = Convert.ToString(datos[0]);
                Genero.SelectedValue = Convert.ToString(datos[4]);
                Genero.SelectedText = Convert.ToString(datos[4]);
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        public void tabla(int frMantenimiento, int frDelete, Panel panel)
        {
            clase.tabla(frMantenimiento, frDelete, panel);
        }

        public void tablaBusqueda(int frMantenimiento, int frDelete, Panel panel, TextBox txtSearch)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                clase.Nombre = txtSearch.Text;
                clase.tablaBusqueda(frMantenimiento, frDelete, panel);
            }
            else
            {
                clase.tabla(frMantenimiento, frDelete, panel);
            }
        }

        public void delete(String id)
        {
            if (id != "")
            {
                clase.Id = id;
                clase.delete();
            }
            else
            {
            }
        }
        public void cmbGenero(ComboBox cmb)
        {
            clase.cmbGenero(cmb);
        }
    }
}
