using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine.models
{
    class DataGridPersonal
    {
        static int numero_columnas;
        static int numero_filas;
        private String[] encabezado;
        public static String[] Ids;

        public void setNumeroFilas(int values)
        {
            numero_filas = values;
            Ids = new String[values];
        }
        public void setEncabezado(String[] values)
        {
            encabezado = values;
            MessageBox.Show(encabezado[1]);
        }
        public void setNumeroColumnas(int value)
        {
            numero_columnas = value;
        }



        private int evaluamosFilas()
        {
            return (34 * (numero_filas + 1));

        }

        public void CreacionDataGrid(Panel panelExterno, String[] encabezado1, String[,] datos, int formulario, int formularioDelete)
        {
            try
            {
                object[] id = new object[numero_filas];
                int total = numero_columnas + 2;
                //Creamos el panel que usara de top adonde se alinearan todas las columnas
                Panel panelTop = new Panel();
                panelTop.Dock = System.Windows.Forms.DockStyle.Top;
                //Evaluamos la altura correspondiente a la cantidad de datos que tendria
                panelTop.Size = new System.Drawing.Size(1058, evaluamosFilas());
                panelExterno.AutoScroll = true;
                panelExterno.Controls.Add(panelTop);
                panelExterno.Tag = panelTop;
                panelTop.Show();




                for (int i = 0; i < total; i++)
                {
                    Panel panelNuevo = new Panel();
                    int ancho_columnas = 904 / numero_columnas;
                    panelNuevo.Name = "PanelColumn" + i;
                    panelNuevo.Dock = System.Windows.Forms.DockStyle.Right;
                    panelNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));

                    for (int h = 0; h < numero_filas; h++)
                    {

                        if (i > (numero_columnas - 1))
                        {
                            panelNuevo.Size = new System.Drawing.Size(62, 373);
                        }
                        else
                        {
                            panelNuevo.Size = new System.Drawing.Size(ancho_columnas, 373);
                        }
                        panelTop.Controls.Add(panelNuevo);
                        panelTop.Tag = panelNuevo;
                        panelNuevo.Show();
                        Button btn = new Button();
                        btn.Dock = System.Windows.Forms.DockStyle.Top;
                        btn.FlatAppearance.BorderSize = 0;
                        btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        btn.ForeColor = System.Drawing.Color.White;
                        btn.Location = new System.Drawing.Point(0, 306);
                        btn.Size = new System.Drawing.Size(312, 34);

                        if (i == (numero_columnas))
                        {
                            btn.Text = "Editar";
                            String jo = Ids[h];
                            btn.UseVisualStyleBackColor = false;
                            //Creamos el evento del boton
                            btn.Click += new EventHandler(boton_click);
                            //Creamos el evento boton_click
                            void boton_click(object sender, EventArgs e)
                            {
                                //Mandamos a traer el formulario que se necesite
                                Formularios abrir = new Formularios();
                                abrir.SeleccionarFormulario(formulario, jo);
                            }
                            if (h % 2 == 0)
                            {
                                //194; 156; 56
                                btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(156)))), ((int)(((byte)(56)))));
                            }
                            else
                            {
                                //187; 163; 66
                                btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(163)))), ((int)(((byte)(66)))));
                            }
                        }
                        else if (i == (numero_columnas + 1))
                        {
                            btn.Text = "Eliminar";
                            String jo = Ids[h];
                            btn.UseVisualStyleBackColor = false;
                            //Creamos el evento del boton
                            btn.Click += new EventHandler(boton_click);
                            //Creamos el evento boton_click
                            void boton_click(object sender, EventArgs e)
                            {
                                //Mandamos a traer el formulario que se necesite
                                Formularios abrir = new Formularios();
                                abrir.SeleccionarFormularioDelete(formularioDelete, jo);
                            }
                            if (h % 2 == 0)
                            {
                                //208; 79; 60
                                btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(79)))), ((int)(((byte)(60)))));
                            }
                            else
                            {
                                //203; 100; 78
                                btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(100)))), ((int)(((byte)(78)))));
                            }
                        }
                        else if (i == 0)
                        {
                            Ids[h] = datos[h, 0].ToString();
                            //MessageBox.Show("Mostrar datos "+datos[i,h]);
                            btn.Text = datos[h, 0].ToString();
                            btn.UseVisualStyleBackColor = false;
                            if (i % 2 == 0)
                            {
                                btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
                            }
                            else
                            {
                                btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
                            }
                        }
                        else if (i <= numero_columnas)
                        {
                            btn.Text = datos[h, i];
                            if (i == 0)
                            {
                                id[h] = datos[h, i].ToString();
                            }
                            btn.UseVisualStyleBackColor = false;
                            if (h % 2 == 0)
                            {
                                btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
                            }
                            else
                            {
                                btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
                            }
                        }

                        panelNuevo.Controls.Add(btn);
                        panelNuevo.Tag = btn;

                        btn.Show();
                    }
                    Button btnEncabezado = new Button();
                    btnEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
                    btnEncabezado.FlatAppearance.BorderSize = 0;
                    btnEncabezado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btnEncabezado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btnEncabezado.ForeColor = System.Drawing.Color.White;
                    btnEncabezado.Location = new System.Drawing.Point(0, 306);
                    btnEncabezado.Size = new System.Drawing.Size(312, 34);

                    if (i == (numero_columnas))
                    {
                        btnEncabezado.Text = "Editar";

                    }
                    else if (i == (numero_columnas + 1))
                    {
                        btnEncabezado.Text = "Eliminar";
                    }
                    else if (i < numero_columnas)
                    {
                        //Encajamos los valores internos del encabezado
                        btnEncabezado.Text = encabezado1[i];
                    }
                    btnEncabezado.UseVisualStyleBackColor = false;
                    btnEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
                    panelNuevo.Controls.Add(btnEncabezado);
                    panelNuevo.Tag = btnEncabezado;
                    btnEncabezado.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }










    }
}
