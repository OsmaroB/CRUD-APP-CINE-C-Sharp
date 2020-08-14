using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine.models
{
    class database_class
    {
        Object[] datos;
        //CREAMOS LA INSTANCIA AL CODIGO PARA CREAR LA TABLA PERSONALIZADA
        DataGridPersonal dataGrid = new DataGridPersonal();
        //Creamos el string con la conexion a la base
        private static string conexionString = "server=DESKTOP-4OKMQRM\\SQLEXPRESS ; database=Blockbuster ; integrated security = true";
        //creamos la variable de conexion
        SqlConnection conex;

        //creamos un arreglo de objetos para porder traer los datos
        public object[] Datos { get => datos; set => datos = value; }

        //creamos una conexion publica 
        public SqlConnection conexion()
        {
            conex = new SqlConnection(conexionString);
            return conex;
        }
        //abrimos la conexion de la instancia
        protected void AbrirConexion()
        {
            conex.Open();
        }
        //cerramos la conexion de la instancia
        protected void CerrarConexion()
        {
            conex.Close();
        }

        //=============================================================================================
        //          TABLA FOCALIZADA
        // parametros 
        // Query: Recive el parametro con query 
        //=============================================================================================
        //creamos la tabla por medio de la query con las columnas
        public DataTable tabla(String query, int numeroColumnas, int frMantenimiendo, int frDelete, Panel panel, String[] encabezado)
        {
            SqlDataAdapter adp = new SqlDataAdapter(query, conexion());
            DataTable consulta = new DataTable();
            adp.Fill(consulta);
            dataGrid.setNumeroColumnas(numeroColumnas);
            dataGrid.setNumeroFilas(consulta.Rows.Count);

            String[,] datos = new String[consulta.Rows.Count, numeroColumnas];
            for (int i = 0; i < consulta.Rows.Count; i++)
            {

                for (int h = 0; h < numeroColumnas; h++)
                {
                    datos[i, h] = consulta.Rows[i][h].ToString();
                }
            }
            dataGrid.CreacionDataGrid(panel, encabezado, datos, frMantenimiendo, frDelete);
            return consulta;
        }



        public void executeRow(String query, Object[,] arregloTotal)
        {

            SqlCommand comando = new SqlCommand(query, conexion());
            for (int i = 0; i < (arregloTotal.Length / 2); i++)
            {
                comando.Parameters.AddWithValue(arregloTotal[i, 0].ToString(), arregloTotal[i, 1]);
            }
            try
            {
                AbrirConexion();
                SqlDataReader myReader = comando.ExecuteReader();
                CerrarConexion();
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
        }

        public void getRows(String query, Object[,] arregloTotal)
        {

            SqlCommand commandDatabase = new SqlCommand(query, conexion());
            for (int i = 0; i < (arregloTotal.Length / 2); i++)
            {
                commandDatabase.Parameters.AddWithValue(arregloTotal[i, 0].ToString(), arregloTotal[i, 1]);
            }
            try
            {
                AbrirConexion();
                SqlDataReader myReader = commandDatabase.ExecuteReader();
                while (myReader.Read())
                {
                    ReadSingleRow((IDataRecord)myReader);
                }

                CerrarConexion();
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
        }

        public void ReadSingleRow(IDataRecord record)
        {
            datos = new Object[record.FieldCount];
            for (int i = 0; i < record.FieldCount; i++)
            {
                datos[i] = record[i];
            }

        }

        public void cmb(ComboBox cmb, String query, String nombre, String id)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(conexionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            cmb.DisplayMember = nombre;
            cmb.ValueMember = id;
            cmb.DataSource = dt;
        }
    }
}
