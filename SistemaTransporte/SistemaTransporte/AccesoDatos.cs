using System;
using System.Diagnostics;
using System.Data;
using MySql.Data.MySqlClient;


namespace SistemaTransporte
{
    class AccesoDatos
    {
        private string cadenaConexion = "Server=127.0.0.1;Database=Transportes;Uid=root;Pwd=;";
        private MySqlConnection conexion = new MySqlConnection();

        public void Conectar()
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();

            }
            catch (MySqlException ex)
            {

                Trace.WriteLine(ex.Message);
            }

        }

        public void Desconectar()
        {
            try
            {
                conexion.Close();
            }
            catch (MySqlException ex)
            {

                Trace.WriteLine(ex.Message);
            }

        }
        public int Ejecutar(string cadenaSql)
        {

            int resultado = 0;
            try
            {
                Conectar();
                MySqlCommand comando = new MySqlCommand(cadenaSql, conexion);
                resultado = comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {

                Trace.WriteLine(ex.Message);
            }
            finally
            {
                Desconectar();
            }
            return resultado;
        }
        public DataSet consultarDatos(string cadenasSql)

        {
            DataSet resultado = new DataSet();

            try
            {
                Conectar();

                MySqlDataAdapter adaptador = new MySqlDataAdapter(cadenasSql, conexion);
                adaptador.Fill(resultado);
            }
            catch (MySqlException Ex)
            {

                Trace.WriteLine(Ex.Message);
            }

            finally
            {
                Desconectar();
            }

            return resultado;
        }
    }
}
