using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Csharp_Hotel_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Connect conn = new Connect();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            String query = "SELECT * FROM `users` WHERE `user`=@user AND `password`=@password";

            command.CommandText = query;
            command.Connection = conn.GetConnection();
            command.Parameters.Add("@user", MySqlDbType.VarChar).Value = textBoxUserName.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = textBoxPassword.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            // if the username and the password exists
            if (table.Rows.Count > 0)
            {
                // Show the Main Form
                this.Hide();
                MainForm mform = new MainForm();
                mform.Show();
            }
            else{
                if (textBoxUserName.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter your Username to Login", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(textBoxPassword.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter your Password to Login", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("This Username or Password doesn't exists.", "Wrong data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
