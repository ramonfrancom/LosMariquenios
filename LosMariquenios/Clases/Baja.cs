using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using LosMariquenios.Clases.Clases_Internas;

namespace LosMariquenios.Clases
{
    class Baja : ConexionBaseDeDatos
    {
        private int folio;
        private string fecha;
        private string rfc_empleado;
        private List<DetalleBaja> detalles_baja;

        public Baja()
        {

        }

        //Constructor parametrizado
        public Baja(string rfc_empleado, List<DetalleBaja> detalles_baja) 
        {
            this.rfc_empleado = rfc_empleado;
            this.detalles_baja = detalles_baja;
        }


        public void InsertExit()
        {
            //==================================================================//==================================================================
            //usuario.PassUser = PasswordHash.HashPassword(usuario.PassUser);
            string querySell = $@"INSERT INTO bajas (fecha, rfc_empleado) 
                            VALUES(NOW(),'{ this.rfc_empleado }');";
            string queryFolio = $@"SELECT LAST_INSERT_ID() AS folio;";
            string folio = "";
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
                    MySqlDataReader dataReader = cmdFolio.ExecuteReader();
                    if (dataReader.Read())
                    {
                        folio = (dataReader["folio"] + "");
                    }

                    dataReader.Close();

                    //close connection
                    CloseConnection();
                }

                foreach (DetalleBaja detalle_baja in this.detalles_baja)
                {
                    detalle_baja.InsertExitDetail(folio);
                }

            }
            catch (MySqlException ex)
            {
                CloseConnection();
                throw new ArgumentException(ex.Message);
            }
        }

        public static int getExitsFolio()
        {
            string query = $@"SELECT Table_schema, Table_Name, Auto_increment FROM information_schema.TABLES WHERE TABLE_SCHEMA = 'los_marisquenios' AND TABLE_NAME = 'bajas';";
            int i=-1;
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
                CloseConnection();
                throw new ArgumentException("No se pudo conectar a la base de datos");
            }
        }
        public static List<string>[] getAllExits(string folio)
        {
            string query = $@"SELECT * FROM baja_empleado_detalle;";

            //Create a list to store the result
            List<string>[] list = new List<string>[9];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();
            list[6] = new List<string>();
            list[7] = new List<string>();
            list[8] = new List<string>();

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
                    list[3].Add(dataReader["rfc_empleado"] + "");
                    list[4].Add(dataReader["nombre_empleado"] + "");
                    list[5].Add(dataReader["codigo_barras_producto"] + "");
                    list[6].Add(dataReader["nombre_producto"] + "");
                    list[7].Add(dataReader["motivo"] + "");
                    list[8].Add(dataReader["cantidad_salientes"] + "");

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
                CloseConnection();
                return list;
            }
        }
    }
}
