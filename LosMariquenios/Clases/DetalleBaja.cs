using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using LosMariquenios.Clases.Clases_Internas;

namespace LosMariquenios.Clases
{
    class DetalleBaja : Detalle
    {
        
        private string motivo;
        public DetalleBaja()
        {

        }

        //Constructor parametrizado
        public DetalleBaja(string codigo_barras, int cantidad, string motivo)
        {
            this.codigo_barras_producto = codigo_barras;
            this.cantidad = cantidad;
            this.motivo = motivo;
            getProductDetailData(codigo_barras);
        }
        
        public string Codigo_Barras_Producto
        {
            get { return codigo_barras_producto; }
            set { codigo_barras_producto = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public string Motivo
        {
            get { return motivo; }
            set { motivo = value; }
        }
        public int Cantidad_Maxima
        {
            get { return cantidad_maxima; }
            set { cantidad_maxima = value; }
        }
        public void InsertExitDetail(string folio_baja)
        {
            //==================================================================//==================================================================
            //usuario.PassUser = PasswordHash.HashPassword(usuario.PassUser);
            string query = $@"INSERT INTO detalles_baja (folio_baja, codigo_barras_producto, cantidad_salientes, motivo) 
                            VALUES({ Convert.ToInt32(folio_baja) },'{codigo_barras_producto }',{ this.cantidad },'{ this.motivo }');";

            string queryProductos = $@"UPDATE productos SET existencia = existencia - {cantidad} WHERE codigo_barras = '{codigo_barras_producto}';";

            try
            {
                //open connection
                if (OpenConnection() == true)
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, dataBaseConnection);
                    MySqlCommand cmdProduct = new MySqlCommand(queryProductos, dataBaseConnection);

                    //Execute command
                    cmd.ExecuteNonQuery();
                    cmdProduct.ExecuteNonQuery();

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
        public void getProductDetailData(string codigo_barras)
        {
            //==================================================================//==================================================================
            string query = $@"SELECT nombre, existencia FROM productos WHERE codigo_barras = '{codigo_barras}';";

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
                    this.cantidad_maxima = Convert.ToInt32($"{dataReader.GetString("existencia")}");
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
        public static List<string>[] getAllSellDetails(string folio = "")
        {
            //string query = $@"SELECT * FROM venta_cliente_empleado_total WHERE folio LIKE {Convert.ToInt32(folio)}%;";

            ////Create a list to store the result
            //List<string>[] list = new List<string>[7];
            //list[0] = new List<string>();
            //list[1] = new List<string>();
            //list[2] = new List<string>();
            //list[3] = new List<string>();
            //list[4] = new List<string>();
            //list[5] = new List<string>();
            //list[6] = new List<string>();
            //list[7] = new List<string>();
            //list[8] = new List<string>();
            //list[9] = new List<string>();

            ////Open connection
            //if (OpenConnection() == true)
            //{
            //    //Create Command
            //    MySqlCommand cmd = new MySqlCommand(query, dataBaseConnection);
            //    //Create a data reader and Execute the command
            //    MySqlDataReader dataReader = cmd.ExecuteReader();

            //    //Read the data and store them in the list
            //    while (dataReader.Read())
            //    {
            //        list[0].Add((list[0].Count + 1).ToString());
            //        list[1].Add(dataReader["folio"] + "");
            //        list[2].Add(dataReader["fecha"] + "");
            //        list[3].Add(dataReader["rfc_cliente"] + "");
            //        list[4].Add(dataReader["nombre_cliente"] + "");
            //        list[5].Add(dataReader["rfc_empleado"] + "");
            //        list[6].Add(dataReader["nombre_empleado"] + "");
            //        list[7].Add(dataReader["cantidad_productos"] + "");
            //        list[8].Add(dataReader["estado"] + "");
            //        list[9].Add(dataReader["total"] + "");

            //    }

            //    //close Data Reader
            //    dataReader.Close();

            //    //close Connection
            //    CloseConnection();

            //    //return list to be displayed
            //    return list;
            //}
            //else
            //{
            //    return list;
            //}
            return null;
        }
    }
}
