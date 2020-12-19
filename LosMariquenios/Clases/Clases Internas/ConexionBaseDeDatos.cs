using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LosMariquenios.Clases.Clases_Internas
{
    public class ConexionBaseDeDatos
    {
        //==================================================================//==================================================================
        public const int IterationCount = 65536;

        //==================================================================//==================================================================
        private static string server = "localhost";
        private static string database = "los_marisquenios";
        private static string uid = "los_marisquenios_dbadmin";
        private static string password = "7eV42u";
        private static string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
        protected static MySqlConnection dataBaseConnection = new MySqlConnection(connectionString);

        //open connection to database
        protected static bool OpenConnection()
        {
            try
            {
                dataBaseConnection.Open();
                return true;
            }
            catch (MySqlException ex)
            {

                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        throw new ArgumentException("Fallo en conexion con la base de datos.  Contacte al administrador");

                    case 1045:
                        throw new ArgumentException("Usuario y contraseña no validos favor de verificarlos");
                }
                return false;
            }
        }

        //Close connection
        protected static bool CloseConnection()
        {
            try
            {
                dataBaseConnection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
    }
}
