using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_KABH
{
    public class Conexion
    {
        private MySqlConnection con = new MySqlConnection();
        private string server = "localhost";
        private string database = "hotel_kabh";
        private string username = "root";
        private string password = "";
        private string cadenaConexion;

        public Conexion()
        {
            cadenaConexion = "Database=" + database +
            "; DataSource=" + server +
            "; User Id=" + username +
            "; Password=" + password;
        }

        public MySqlConnection ConectarDB()
        {
            try
            {
                con.ConnectionString = cadenaConexion;
                con.Open();
            }
            catch (MySqlException e)
            {

            }
            return con;
        }

        public MySqlConnection DesconectarDB()
        {
            try
            {
                con.Close();
            }
            catch (MySqlException e)
            {

            }
            return con;

        }

    }
}