using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using LosMariquenios.Clases.Clases_Internas;

namespace LosMariquenios.Clases
{
    class Venta : ConexionBaseDeDatos
    {
        private string fecha;
        private string rfc_empleado;
        private string rfc_cliente;
        private char estado;
        private List<DetalleVenta> detalles_venta;

        public Venta()
        {

        }

        //Constructor parametrizado
        public Venta(string rfc_empleado, string rfc_cliente, char estado, List<DetalleVenta> detalles_venta)
        {
            this.rfc_empleado = rfc_empleado;
            this.rfc_cliente = rfc_cliente;
            this.estado = estado;
            this.detalles_venta = detalles_venta;
        }


        public void InsertSell()
        {
            //==================================================================//==================================================================
            //usuario.PassUser = PasswordHash.HashPassword(usuario.PassUser);
            string querySell = $@"INSERT INTO ventas (fecha, rfc_empleado, rfc_cliente, estado) 
                            VALUES(NOW(),'{ this.rfc_empleado }','{ this.rfc_cliente }','{ this.estado }');";
            string queryFolio = $@"SELECT LAST_INSERT_ID() AS folio;";
            string folio ="";
            try
            {
                //open connection
                if (OpenConnection() == true)
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(querySell, dataBaseConnection);
                    MySqlCommand cmdFolio = new MySqlCommand(queryFolio, dataBaseConnection);

                    //Execute command
                    cmd.ExecuteNonQuery();
                    cmdFolio.ExecuteNonQuery();
                    MySqlDataReader dataReader = cmdFolio.ExecuteReader();
                    if (dataReader.Read())
                    {
                        folio = (dataReader["folio"] + "");
                    }

                    //close connection
                    CloseConnection();
                }

                foreach (DetalleVenta detalle_venta in this.detalles_venta)
                {
                    detalle_venta.InsertSellDetail(folio);
                }

            }
            catch (MySqlException ex)
            {
                CloseConnection();
                throw new ArgumentException(ex.Message);
            }
        }
        public static int getSellsFolio()
        {
            string query = $@"SELECT Table_schema, Table_Name, Auto_increment FROM information_schema.TABLES WHERE TABLE_SCHEMA = 'los_marisquenios' AND TABLE_NAME = 'ventas';";
            int i = -1;
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
                    i = Convert.ToInt32($"{dataReader.GetString("Auto_increment")}");
                }
                //close Data Reader
                dataReader.Close();

                //close Connection
                CloseConnection();
                return i;
            }
            else
            {
                throw new ArgumentException("No se pudo conectar a la base de datos");
            }
        }
        public static List<string>[] getAllSells(string folio = "")
        {
            string query = $@"SELECT * FROM venta_cliente_empleado_total;";

            //Create a list to store the result
            List<string>[] list = new List<string>[10];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();
            list[6] = new List<string>();
            list[7] = new List<string>();
            list[8] = new List<string>();
            list[9] = new List<string>();

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
                    list[1].Add(dataReader["folio"] + "");
                    list[2].Add(dataReader["fecha"] + "");
                    list[3].Add(dataReader["rfc_cliente"] + "");
                    list[4].Add(dataReader["nombre_cliente"] + "");
                    list[5].Add(dataReader["rfc_empleado"] + "");
                    list[6].Add(dataReader["nombre_empleado"] + "");
                    list[7].Add(dataReader["cantidad_productos"] + "");
                    string s = $"{dataReader.GetString("estado")}";
                    list[8].Add(s == "N" ? "No Solicito" : "Facturado");
                    double subtotal= (float)Convert.ToDecimal(dataReader["total"] + "");
                    double iva = subtotal * .16;
                    double total = subtotal + iva;
                    list[9].Add(Convert.ToString(total));

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
