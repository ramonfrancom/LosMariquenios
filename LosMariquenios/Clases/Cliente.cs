using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using LosMariquenios.Clases.Clases_Internas;

namespace LosMariquenios.Clases
{
    class Cliente : ConexionBaseDeDatos
    {
        private string rfc;
        private string nombre;
        private string domicilio;
        private string correo;

        public Cliente()
        {

        }

        //Constructor parametrizado
        public Cliente(string rfc, string nombre, string domicilio, string correo)
        {
            this.rfc = rfc;
            this.nombre = nombre;
            this.domicilio = domicilio;
            this.correo = correo;
        }

        //Constructor base de datos
        public Cliente(string codigo_barras)
        {
            getClientData(codigo_barras);
        }

        public string RFC
        {
            get { return rfc; }
            set { rfc = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Domicilio
        {
            get { return domicilio; }
            set { domicilio = value; }
        }

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public void InsertClient()
        {
            //==================================================================//==================================================================
            //usuario.PassUser = PasswordHash.HashPassword(usuario.PassUser);
            string query = $@"INSERT INTO clientes (rfc, nombre, domicilio, correo) 
                            VALUES('{ this.rfc }','{ this.nombre }','{ this.domicilio }','{ this.correo }');";
            try
            {
                //open connection
                if (OpenConnection() == true)
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, dataBaseConnection);

                    //Execute command
                    cmd.ExecuteNonQuery();

                    //close connection
                    CloseConnection();
                }
            }
            catch (MySqlException ex)
            {
                CloseConnection();
                throw new ArgumentException(ex.Message);
            }
        }

        public void UpdateClientData(string rfc)
        {
            string query = $@"UPDATE clientes SET nombre ='{ this.nombre }', 
                                                  domicilio ='{ this.domicilio }',  
                                                  correo = '{ this.correo }'
                                                  WHERE rfc='{ rfc }';";

            //Open connection
            if (OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = dataBaseConnection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                CloseConnection();
            }
        }

        public void getClientData(string rfc)
        {
            //==================================================================//==================================================================
            string query = $@"SELECT * FROM clientes WHERE rfc = '{rfc}';";

            //Open connection
            if (OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, dataBaseConnection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.Read())
                {
                    //Read the data and store them in the list
                    this.nombre = $"{dataReader.GetString("nombre")}";
                    this.domicilio = $"{dataReader.GetString("domicilio")}";
                    this.correo = $"{dataReader.GetString("correo")}";
                }
                //close Data Reader
                dataReader.Close();

                //close Connection
                CloseConnection();
            }
            else
            {
                throw new ArgumentException("No se pudo conectar a la base de datos");
            }
        }

        public static List<string>[] getAllClients(string rfc_cliente = "")
        {
            string query = $@"SELECT * FROM clientes WHERE rfc LIKE '{rfc_cliente}%';";

            //Create a list to store the result
            List<string>[] list = new List<string>[7];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();

            //Open connection
            if (OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, dataBaseConnection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add((list[0].Count + 1).ToString());
                    list[1].Add(dataReader["rfc"] + "");
                    list[2].Add(dataReader["nombre"] + "");
                    list[3].Add(dataReader["domicilio"] + "");
                    list[4].Add(dataReader["correo"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }
    }
}
