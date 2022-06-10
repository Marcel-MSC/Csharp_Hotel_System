using MySql.Data.MySqlClient;
using System.Data;
using System.IO;

namespace Csharp_Hotel_System
{
    internal class Connect
    {
        private readonly MySqlConnection Connection = new MySqlConnection("server=localhost;port=3306;userid=root;password=admin22332;database=hotel");
        public MySqlConnection GetConnection()
        {
            try
            {
                return Connection;
            } catch (IOException e)
            {
                throw e;
            }
        }
        public void openConnection()
        {
            try
            {
                if (Connection.State == ConnectionState.Closed)
                {
                    Connection.Open();
                }
            }
            catch (IOException e)
            {
                throw e;
            }
        }
        public void closeConnection()
        {
            try
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            } catch (IOException e)
            {
                throw e;
            }
        }
    }
}
