﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Csharp_Hotel_System
{
    /* This class will make the connection between our app and mysql database
     * first you need to download and install mysql connector and add it to your project
     * download link - https://dev.mysql.com/downloads/connector/net/
     */
    class CONNECT
    {
        private MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=Csharp_Hotel_DB");

        // Create a function to return our connection
        public MySqlConnection GetConnection()
        {
            return connection;
        }

        // Create a function to open the connection
        public void openConnection()
        {
            if(connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        // Create a function to close the connection
        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

    }
}
