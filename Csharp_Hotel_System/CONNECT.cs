using MySql.Data.MySqlClient;
using System.Data;

namespace Csharp_Hotel_System
{
    /* This class will make the connection between our app and mysql database
     * first you need to download and install mysql connector and add it to your project
     * download link - https://dev.mysql.com/downloads/connector/net/
     */
    class Connect
    {
        private readonly MySqlConnection Connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=Csharp_Hotel_DB");

        // Create a function to return our connection
        public MySqlConnection GetConnection()
        {
            return Connection;
        }

        // Create a function to open the connection
        public void openConnection()
        {
            if(Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }
        }

        // Create a function to close the connection
        public void closeConnection()
        {
            if (Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }
        }

    }
}
