using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Csharp_Hotel_System
{
    class RESERVATION
    {
        Connect conn = new Connect();
        // get all reservations
        public DataTable getAllReserv()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `reservations`", conn.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        // create a function to add a new reservation
        public bool addReservation(int number, int client, DateTime dateIn, DateTime dateOut)
        {
            MySqlCommand command = new MySqlCommand();
            String insertQuery = "INSERT INTO `reservations`(`roomNumber`, `clientId`, `dateIn`, `dateOut`) VALUES (@rnm, @cid, @din, @dout)";
            command.CommandText = insertQuery;
            command.Connection = conn.GetConnection();

            // @rnm, @cid, @din, @dout
            command.Parameters.Add("@rnm", MySqlDbType.Int32).Value = number;
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = client;
            command.Parameters.Add("@din", MySqlDbType.Datetime).Value = dateIn;
            command.Parameters.Add("@dout", MySqlDbType.Datetime).Value = dateOut;

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

        // Create a function to edit the selected reservation
        public bool editReservation(int reservId, int number, int client, DateTime dateIn, DateTime dateOut)
        {
            MySqlCommand command = new MySqlCommand();
            String editQuery = "UPDATE `reservations` SET `roomNumber`=@,`clientId`=@cid,`dateIn`=@din,`dateOut`=@dout WHERE `reservId`=@rvid";
            command.CommandText = editQuery;
            command.Connection = conn.GetConnection();

            // @rnm, @cid, @din, @dout, @rvid
            command.Parameters.Add("@rvid", MySqlDbType.Int32).Value = reservId;
            command.Parameters.Add("@rnm", MySqlDbType.Int32).Value = number;
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = client;
            command.Parameters.Add("@din", MySqlDbType.VarChar).Value = dateIn;
            command.Parameters.Add("@dout", MySqlDbType.VarChar).Value = dateOut;

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

        // Create a function to delete the selected reservation
        // We only need the reservation id
        public bool removeReserv(int rsv_id)
        {
            MySqlCommand command = new MySqlCommand();
            String removeQuery = "DELETE FROM `reservations` WHERE `reservId`=@rvid";
            command.CommandText = removeQuery;
            command.Connection = conn.GetConnection();

            // @num
            command.Parameters.Add("@rvid", MySqlDbType.Int32).Value = rsv_id;

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
