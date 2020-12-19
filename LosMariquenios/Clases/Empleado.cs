using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using LosMariquenios.Clases.Clases_Internas;

namespace LosMariquenios.Clases
{
    class Empleado: ConexionBaseDeDatos
    {
        private string rfc;
        private string nombre;
        private string correo;
        private string telefono;
        private string tipo_de_usuario;
        private string contrasena;
        private char estado;

        public Empleado()
        {
        }
        //Constructor parametrizado
        public Empleado(string rfc, string nombre, string correo, string telefono, string tipo_de_usuario, string contrasena, bool estado)
        {
            this.rfc = rfc;
            this.nombre = nombre;
            this.correo = correo;
            this.telefono = telefono;
            this.tipo_de_usuario = tipo_de_usuario;
            this.contrasena = contrasena;
            this.estado = estado ? 'A' : 'I';

        }
        public Empleado(string rfc)
        {
            getEmployeeData(rfc);
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string TipoDeUsuario
        {
            get { return tipo_de_usuario; }
            set { tipo_de_usuario = value; }
        }
        public string Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }
        public char Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public void InsertEmployee()
        {
            //==================================================================//==================================================================
            //usuario.PassUser = PasswordHash.HashPassword(usuario.PassUser);
            string query = $@"INSERT INTO empleados (rfc, nombre, correo, telefono, tipo_de_usuario, contrasena, estado) 
                            VALUES('{ this.rfc }','{ this.nombre }','{ this.correo }','{ this.telefono }', '{this.tipo_de_usuario}','{this.contrasena}', '{this.estado}');";
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
        public void getEmployeeData(string rfc)
        {
            //==================================================================//==================================================================
            string query = $@"SELECT * FROM empleados WHERE rfc = '{rfc}';";

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
                    this.correo = $"{dataReader.GetString("correo")}"; 
                    this.telefono = $"{dataReader.GetString("telefono")}"; 
                    this.tipo_de_usuario = $"{dataReader.GetString("tipo_de_usuario")}";
                    this.contrasena = $"{dataReader.GetString("contrasena")}";
                    this.estado = Convert.ToChar($"{dataReader.GetString("estado")}");
                }
                else
                {
                    dataReader.Close();
                    CloseConnection();
                    throw new ArgumentException("No se encontro a ningun empleado con el RFC ingresado");
                }
                //close Data Reader
                dataReader.Close();

                //close Connection
                CloseConnection();
            }
            else
            {
                CloseConnection();
                throw new ArgumentException("No se pudo conectar a la base de datos");
            }
        }
        public void UpdateEmployeeData(string rfc)
        {
            string query = $@"UPDATE empleados SET nombre ='{this.nombre}', correo='{this.correo}', telefono='{this.telefono}', tipo_de_usuario='{this.tipo_de_usuario}', contrasena='{this.contrasena}',
                                                  estado='{this.estado}' WHERE rfc='{rfc}';";

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
        public static List<string>[] getAllEmployees(string rfc = "")
        {
            string query = $@"SELECT * FROM empleados WHERE rfc  LIKE '{rfc}%';";

            //Create a list to store the result
            List<string>[] list = new List<string>[7];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();
            list[6] = new List<string>();

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
                    list[3].Add(dataReader["correo"] + "");
                    list[4].Add(dataReader["telefono"] + "");
                    list[5].Add(dataReader["tipo_de_usuario"] + "");
                    string s = $"{dataReader.GetString("estado")}";
                    list[6].Add(s == "A" ? "Activo" : "Inactivo");

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
        public static string getPassOfUser(string rfc, out string nombre)
        {
            string query = $@"SELECT nombre, contrasena FROM empleados WHERE rfc = '{rfc}' AND estado = 'A';";
            string nombre_empleado = "";
            string contrasena = "";

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
                    nombre_empleado = (dataReader["nombre"] + "");
                    contrasena = (dataReader["contrasena"] + "");

                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                CloseConnection();
                nombre = nombre_empleado;
                //return list to be displayed
                return contrasena;
            }
            else
            {
                throw new ArgumentException("Conexion con la base de datos fallo");
            }
        }
        }
    }
