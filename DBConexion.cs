using BaseDeDatos_SQLLite.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BaseDeDatos_SQLLite
{
    public class DBConexion
    {
        public static SQLiteConnection conn = new SQLiteConnection("Data Source=InventarioBD3.db;");

        public static DataTable obtenerTabla(string consultaTabla)
        {
            // Creamos la tabla que va a retornar
            DataTable dt = new DataTable();

            try
            {
                // Abrimos la conexion
                conn.Open();

                // Mediante la conexion utilizamos la consulta que regresa la tabla deseada
                SQLiteCommand comando = new SQLiteCommand(consultaTabla, conn);

                // Establecemos que el comando a texto
                comando.CommandType = CommandType.Text;

                // Adaptamos el tipo de dato a DataTable para los DataGridView
                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(comando);

                // Ejecutamos y adaptamos al tipo de dato
                adaptador.Fill(dt);

            } catch (SQLiteException e)
            {
                // Error a mostrar en caso de fallar
                MessageBox.Show("Error " + e.Message);
            }
            finally
            {
                // En caso de que la conexion no este vacia, finalizamos y cerramos la conexion
                if (conn != null)
                {
                    conn.Close();
                }

            }
            return dt;

        }

        public static int ejecutarConsulta(string consulta)
        {
            // Inicializamos la conexion
            SQLiteConnection conn = new SQLiteConnection("Data Source=InventarioBD3.db;");
            int filasAfectadas = 0;

            try
            {
                // Abrimos la conexion
                conn.Open();

                // Inicializamos la conexion con la consulta en un comando
                SQLiteCommand comando = new SQLiteCommand(consulta, conn);

                // Definimos el comando como texto
                comando.CommandType = CommandType.Text;

                // Ejecutamos el comando y obtenemos el numero de filas afectadas
                filasAfectadas = comando.ExecuteNonQuery();

            }
            catch (SQLiteException e)
            {
                // Error a mostrar en caso de fallar
                MessageBox.Show("Error: " + e.Message);
            }
            finally
            {
                // En caso de que la conexion no este vacia, finalizamos y cerramos la conexion
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return filasAfectadas;
        }

        public static bool iniciarSesion(string consulta, string usuario, string password)
        {
            // inicializamos la variable que almacenara los datos consultados
            SQLiteDataReader data;
            // Esta variable devolvera si el usuario es valido o no
            bool valueReturn = false;
            string db_password, db_usuario;
            try
            {
                // Abrimos la conexion
                conn.Open();

                // Preparamos el comando y lo ejecutamos
                SQLiteCommand comando = new SQLiteCommand(consulta, conn);
                data = comando.ExecuteReader();

                // leemos los primeros datos devueltos
                data.Read();

                // Almacenamos los datos que requerimos en variables locales
                db_password = data["password"].ToString();
                db_usuario = data["nombre"].ToString();
                

                // Evaluamos si es usuario es valido y si lo es devolveremos true
                if (db_usuario == usuario && db_password == password) {
                    valueReturn = true;
                }

                // Cerramos el enlace de lectura de la base de datos
                data.Close();

            }
            catch (SQLiteException e)
            {
                MessageBox.Show("Error " + e.Message);
            }
            catch (InvalidOperationException e)
            {
                db_usuario = "isNull";
                db_password = "isNull";
            }
            finally
            {
                // Despues de todo, si existe la conexion a la base de datos, cerramos conexion
                if (conn != null)
                {
                    conn.Close();
                }
            }

            // Devolvemos verdadero en caso de que las credenciales sean correctas
            return valueReturn;
        }

        public static string[] obtenerUsuario(string usuario)
        {
            // inicializamos la variable que almacenara los datos consultados
            string consulta = $"SELECT nombre, rol FROM usuarios WHERE nombre = '{usuario}'";
            string[] strReturn = new string[2];
            SQLiteDataReader data;
            try
            {
                // Abrimos la conexion
                conn.Open();

                // Preparamos el comando y lo ejecutamos
                SQLiteCommand comando = new SQLiteCommand(consulta, conn);
                data = comando.ExecuteReader();

                // leemos los primeros datos devueltos
                data.Read();

                // Almacenamos los datos que requerimos en variables locales
                strReturn[0] = data["nombre"].ToString();
                strReturn[1] = data["rol"].ToString();

                // Cerramos el enlace de lectura de la base de datos
                data.Close();

            }
            catch (SQLiteException e)
            {
                MessageBox.Show("Error " + e.Message);
            }
            finally
            {
                // Despues de todo, si existe la conexion a la base de datos, cerramos conexion
                if (conn != null)
                {
                    conn.Close();
                }
            }

            // Devolvemos verdadero en caso de que las credenciales sean correctas
            return strReturn;
        }

    }
}
