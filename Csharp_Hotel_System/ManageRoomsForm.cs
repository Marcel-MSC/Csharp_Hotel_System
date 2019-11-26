using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_Hotel_System
{
    public partial class ManageRoomsForm : Form
    {
        public ManageRoomsForm()
        {
            InitializeComponent();
        }

        ROOM room = new ROOM();

        private void ManageRoomsForm_Load(object sender, EventArgs e)
        {
            ComboBoxRoomType.DataSource = room.roomTypeList();
            ComboBoxRoomType.DisplayMember = "label";
            ComboBoxRoomType.ValueMember = "category_id";

            dataGridView1.DataSource = room.getRooms();
        }

        private void buttonAddRoom_Click(object sender, EventArgs e)
        {
            
            int type = Convert.ToInt32(ComboBoxRoomType.SelectedValue.ToString());
            string phone = TextBoxPhone.Text;
            string free = "";

            try
            {
                int number = Convert.ToInt32(TextBoxNumber.Text);

                if (radioButtonYES.Checked)
                {
                    free = "YES";
                }
                else if (radioButtonNO.Checked)
                {
                    free = "NO";
                }

                if (room.addRoom(number, type, phone, free))
                {
                    MessageBox.Show("Room added succesfuly", "Add room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = room.getRooms();
                }
                else
                {
                    MessageBox.Show("Room not added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Room Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEditRoom_Click(object sender, EventArgs e)
        {
            
            int type = Convert.ToInt32(ComboBoxRoomType.SelectedValue.ToString());
            String phone = TextBoxPhone.Text;
            String free = "";

            try
            {
                int number = Convert.ToInt32(TextBoxNumber.Text);
                if (radioButtonYES.Checked)
                {
                    free = "YES";
                }
                else if (radioButtonNO.Checked)
                {
                    free = "NO";
                }

                if (room.editRooms(number, type, phone, free))
                {
                    MessageBox.Show("Room edited succesfuly", "Edit room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = room.getRooms();
                }
                else
                {
                    MessageBox.Show("Room not edited", "Edit room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Room Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRemoveRoom_Click(object sender, EventArgs e)
        {
            try
            {
                int number = Convert.ToInt32(TextBoxNumber.Text);

                if (room.removeRoom(number))
                {
                    MessageBox.Show("Room remove succesfuly", "Edit room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = room.getRooms();
                }
                else
                {
                    MessageBox.Show("Room not remove", "Edit room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Room Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClearFields_Click(object sender, EventArgs e)
        {
            TextBoxNumber.Text = "";
            ComboBoxRoomType.SelectedIndex = 0;
            TextBoxPhone.Text = "";
        }

        // display selected row data from datagridview to textboxes
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBoxNumber.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ComboBoxRoomType.SelectedValue = dataGridView1.CurrentRow.Cells[1].Value;
            TextBoxPhone.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            string free = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            
            if (free.Equals("YES"))
            {
                radioButtonYES.Checked = true;
            }else if (free.Equals("NO"))
            {
                radioButtonNO.Checked = true;
            }
        }
    }
}
