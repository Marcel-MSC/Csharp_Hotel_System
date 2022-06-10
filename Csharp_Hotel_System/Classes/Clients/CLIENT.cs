using System;
using MySql.Data.MySqlClient;
using System.Data;

namespace Csharp_Hotel_System
{
    //Create a class client to add a new client, edit client, remove client and get all clients

    class Client
    {
        readonly Connect conn = new Connect();

        // Create a new function to insert a new client
        public bool insertClient(String fname, String lname, String phone, String country)
        {
            try
            {
                MySqlCommand command = new MySqlCommand();
                String insertQuery = "INSERT INTO `clients`(`first_name`, `last_name`, `phone`, `country`) VALUES (@fnm,@lnm,@phn,@cnt)";
                command.CommandText = insertQuery;
                command.Connection = conn.GetConnection();

                //@fnm,@lnm,@phn,@cnt
                command.Parameters.Add("@fnm", MySqlDbType.VarChar).Value = fname;
                command.Parameters.Add("@lnm", MySqlDbType.VarChar).Value = lname;
                command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
                command.Parameters.Add("@cnt", MySqlDbType.VarChar).Value = country;

                conn.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    return true;
                }
                else
                {
                    conn.closeConnection();
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
        // Create a function to get the clients list
        public DataTable getClients()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `clients`", conn.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        // Create a function to edit the clients data

        public bool editClients(int id, String fname, String lname, String phone, String country)
        {
            MySqlCommand command = new MySqlCommand();
            String editQuery = "UPDATE `clients` SET `first_name`=@fnm,`last_name`=@lnm,`phone`=@phn,`country`=@cnt where `id`=@cid";
            command.CommandText = editQuery;
            command.Connection = conn.GetConnection();

            // @cid,@fnm,@lnm,@phn,@cnt
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@fnm", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lnm", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@cnt", MySqlDbType.VarChar).Value = country;

            conn.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
        }

        // Create a function to delete the selected client
        // We only need the client id
        public bool RemoveClient(int id)
        {
            MySqlCommand command = new MySqlCommand();
            String removeQuery = "DELETE FROM `clients` WHERE `id`=@cid";
            command.CommandText = removeQuery;
            command.Connection = conn.GetConnection();

            // @cid
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = id;

            conn.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
        }
    }
}