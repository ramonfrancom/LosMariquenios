using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using LosMariquenios.Clases.Clases_Internas;

namespace LosMariquenios.Clases
{
    class Producto : ConexionBaseDeDatos
    {
        private string codigo_barras;//numero
        private string nombre;
        private string descripcion;
        private int existencia;
        private float precio;
        private char estado;

        public Producto()
        {

        }

        //Constructor parametrizado
        public Producto(string codigo_barras, string nombre, string descripcion, int existencia, float precio, bool estado)
        {
            this.codigo_barras = codigo_barras;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.existencia = existencia;
            this.precio = precio;
            this.estado = estado ? 'V' : 'D';
        }

        //Constructor base de datos
        public Producto(string codigo_barras)
        {
            getProductData(codigo_barras);
        }

        public string CodigoBarras
        {
            get { return codigo_barras; }
            set { codigo_barras = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public int Existencia
        {
            get { return existencia; }
            set { existencia = value; }
        }
        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public char Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public void InsertProduct()
        {
            //==================================================================//==================================================================
            //usuario.PassUser = PasswordHash.HashPassword(usuario.PassUser);
            string query = $@"INSERT INTO productos (codigo_barras, nombre, descripcion, existencia, precio, estado) 
                            VALUES('{this.codigo_barras}','{ this.nombre }','{ this.descripcion }',{ this.existencia },{ this.precio },'{ this.estado }');";
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
                throw new ArgumentException(ex.Message);
            }
        }

        public void UpdateProductData(string codigo_barras)
        {
            string query = $@"UPDATE productos SET nombre ='{this.nombre}', 
                                                  descripcion='{this.descripcion}',  
                                                  existencia= {this.existencia},
                                                  precio= {this.precio},  
                                                  estado='{this.estado}'
                                                  WHERE codigo_barras='{codigo_barras}';";

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

        public void getProductData(string codigo_barras)
        {
            //==================================================================//==================================================================
            string query = $@"SELECT * FROM productos WHERE codigo_barras = '{codigo_barras}';";

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
                    this.descripcion = $"{dataReader.GetString("descripcion")}";
                    this.estado = Convert.ToChar($"{dataReader.GetString("estado")}");
                    this.existencia = Convert.ToInt32($"{dataReader.GetString("existencia")}");
                    this.precio = (float) Convert.ToDouble($"{dataReader.GetString("precio")}");
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

        public static List<string>[] getAllProducts(string codigo_barras = "")
        {
            string query = $@"SELECT * FROM productos WHERE codigo_barras  LIKE '{codigo_barras}%';";

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
                    list[1].Add(dataReader["codigo_barras"] + "");
                    list[2].Add(dataReader["nombre"] + "");
                    list[3].Add(dataReader["descripcion"] + "");
                    list[4].Add(dataReader["precio"] + "");
                    list[5].Add(dataReader["existencia"] + "");
                    string s = $"{dataReader.GetString("estado")}";
                    list[6].Add( s == "V" ? "En Venta": "Descontinuado"); 

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
