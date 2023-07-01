using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SQLite;

namespace DesarrolloLAP_SYSTEMS
{
    class comandosBD
    {
        static string strConexion = "Data Source = BDLAP.db";

        static private SQLiteConnection conexion;
        static private SQLiteCommand comando;

        //Metodo para crear la cadena de conexion
        private void conectar(string consulta)
        {
            //Instancio una nueva conexion
            conexion = new SQLiteConnection(strConexion);


            //Instancio un nuevo comando usando la conexion y la consulta ingresada al metodo
            comando = new SQLiteCommand(consulta, conexion);
        }


        //Este es el metodo para recuperar datos mediante una consulta
        public SQLiteDataReader consulta(string codigoConsulta)
        {
            conectar(codigoConsulta);

            try
            {
                conexion.Open();

                return comando.ExecuteReader();
            }
            catch
            {
                SQLiteDataReader error = null;
                return error;
                //En caso de tener algun problema en la conexion, se devuelve un valor nulo
            }
        }

        //Este es el metodo para cerrar la conexion
        public void desconectar()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }

        //Metodo para ejecutar comandos en la base de datos
        public bool ABM(string consulta)
        {
            bool Resultado = false;

            conectar(consulta);

            try
            {
                conexion.Open();

                comando.ExecuteNonQuery();

                Resultado = true;
            }
            catch
            {
                Resultado = false;
            }

            desconectar();

            return Resultado;
        }
    }
}
