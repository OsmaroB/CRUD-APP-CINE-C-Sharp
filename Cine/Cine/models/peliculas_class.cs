using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine.models
{
    class peliculas_class
    {
        private String id;
        private String nombre;
        private String Director;
        private int anio;
        private object igGenero;
        Object[,] arregloTotal;
        //ANIDAMOS LA CLASE DE DATABASE
        database_class db = new database_class();

        public string Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Director1 { get => Director; set => Director = value; }
        public int Anio { get => anio; set => anio = value; }
        public object IgGenero { get => igGenero; set => igGenero = value; }


        public bool create()
        {

            try
            {
                //Asignamos al arreglo de la siguiente forma arregloTotal[cantidad_de_campos,2]
                arregloTotal = new Object[5, 2];
                arregloTotal[0, 0] = "@id";
                arregloTotal[1, 0] = "@nombre";
                arregloTotal[2, 0] = "@director";
                arregloTotal[3, 0] = "@anio";
                arregloTotal[4, 0] = "@idGenero";
                arregloTotal[0, 1] = this.id;
                arregloTotal[1, 1] = this.nombre;
                arregloTotal[2, 1] = this.Director;
                arregloTotal[3, 1] = this.anio;
                arregloTotal[4, 1] = this.igGenero;
                string query = "INSERT INTO Peliculas VALUES(@id,@nombre,@director,@anio,@idGenero)";
                db.executeRow(query, arregloTotal);
                return true;

            }
            catch (Exception ex)
            {

                return false;
                throw;
            }
        }

        public bool update()
        {

            try
            {
                //Asignamos al arreglo de la siguiente forma arregloTotal[cantidad_de_campos,2]
                arregloTotal = new Object[5, 2];
                arregloTotal[0, 0] = "@id";
                arregloTotal[1, 0] = "@nombre";
                arregloTotal[2, 0] = "@director";
                arregloTotal[3, 0] = "@anio";
                arregloTotal[4, 0] = "@idGenero";
                arregloTotal[0, 1] = this.id;
                arregloTotal[1, 1] = this.nombre;
                arregloTotal[2, 1] = this.Director;
                arregloTotal[3, 1] = this.anio;
                arregloTotal[4, 1] = this.igGenero;
                string query = "UPDATE Peliculas set nombrePelicula = @nombre , director = @director, anio = @anio, idGenero = @idGenero WHERE idPelicula = @id";
                db.executeRow(query, arregloTotal);
                return true;

            }
            catch (Exception ex)
            {

                return false;
                throw;
            }
        }


        public Object[] ReadDelete()
        {
            //SE inicializara el arreglo del objeto pot medio del numero de columnas
            Object[] datos = new Object[2];
            try
            {
                //Asignamos al arreglo de la siguiente forma arregloTotal[cantidad_de_campos,2]
                arregloTotal = new Object[1, 2];
                arregloTotal[0, 0] = "@id";
                arregloTotal[0, 1] = this.id;
                string query = "SELECT nombrePelicula FROM Peliculas WHERE idPelicula = @id" +
                    "" +
                    "";
                db.getRows(query, arregloTotal);
                datos = db.Datos;
                return datos;
            }
            catch (Exception)
            {
                return datos;
                throw;
            }
        }

        public bool delete()
        {

            try
            {
                //Asignamos al arreglo de la siguiente forma arregloTotal[cantidad_de_campos,2]
                arregloTotal = new Object[1, 2];
                arregloTotal[0, 0] = "@id";
                arregloTotal[0, 1] = this.id;
                string query = "DELETE Peliculas WHERE idPelicula = @id";
                db.executeRow(query, arregloTotal);
                return true;

            }
            catch (Exception ex)
            {

                return false;
                throw;
            }
        }


        public Object[] Read()
        {
            //SE inicializara el arreglo del objeto pot medio del numero de columnas
            Object[] datos = new Object[2];
            try
            {
                //Asignamos al arreglo de la siguiente forma arregloTotal[cantidad_de_campos,2]
                arregloTotal = new Object[1, 2];
                arregloTotal[0, 0] = "@id";
                arregloTotal[0, 1] = this.id;
                string query = "SELECT idPelicula, nombrePelicula, director,anio,idGenero FROM Peliculas WHERE idPelicula = @id";
                db.getRows(query, arregloTotal);
                datos = db.Datos;
                return datos;
            }
            catch (Exception)
            {
                return datos;
                throw;
            }
        }


        public void tabla(int frMantenimiento, int frDelete, Panel panel)
        {
            try
            {
                int numeroColumnas = 5;
                String[] encabezado = { "id", "Nombre", "Director","Año","Genero" };
                db.tabla("SELECT idPelicula, nombrePelicula, director,anio,G.nombreGenero FROM Peliculas P INNER JOIN Generos G ON G.idGenero = P.idGenero", numeroColumnas, frMantenimiento, frDelete, panel, encabezado);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        public void tablaBusqueda(int frMantenimiento, int frDelete, Panel panel)
        {
            try
            {
                int numeroColumnas = 5;
                String[] encabezado = { "id", "Nombre", "Director", "Año", "Genero" };
                String nombre = "'%" + this.nombre + "%'";
                String query = "SELECT idPelicula, nombrePelicula, director,anio,G.nombreGenero FROM Peliculas P INNER JOIN Generos G ON G.idGenero = P.idGenero WHERE nombrePelicula LIKE " + nombre;
                db.tabla(query, numeroColumnas, frMantenimiento, frDelete, panel, encabezado);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        public void cmbGenero(ComboBox cmb)
        {

            db.cmb(cmb, "SELECT idGenero,nombreGenero FROM Generos", "nombreGenero", "idGenero");
        }
    }
}
