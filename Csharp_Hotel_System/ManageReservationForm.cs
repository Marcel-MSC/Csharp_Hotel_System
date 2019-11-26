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
    public partial class ManageReservationForm : Form
    {
        public ManageReservationForm()
        {
            InitializeComponent();
        }

        ROOM room = new ROOM();
        RESERVATION reservation = new RESERVATION();

        private void ManageReservationForm_Load(object sender, EventArgs e)
        {
            // display room's type
            comboBoxRoomType.DataSource = room.roomTypeList();
            comboBoxRoomType.DisplayMember = "label";
            comboBoxRoomType.ValueMember = "category_id";
        }

        private void buttonClearFields_Click(object sender, EventArgs e)
        {
            textBoxClientID.Text = "";
            comboBoxRoomType.SelectedIndex = 0;
            dateTimePickerIn.Value = DateTime.Now;
            dateTimePickerOut.Value = DateTime.Now;

        }

        private void comboBoxRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // display room's number depending on the selected type
                int type = Convert.ToInt32(comboBoxRoomType.SelectedValue.ToString());
                comboBoxRoomNumber.DataSource = room.roomByType(type);
                comboBoxRoomNumber.DisplayMember = "number";
                comboBoxRoomNumber.ValueMember = "number";
            }
            catch (Exception ex)
            {
                // do nothing 
            }
            
        }

        private void buttonAddReservation_Click(object sender, EventArgs e)
        {
            int clientID = Convert.ToInt32(textBoxClientID.Text);
            int roomNumber = Convert.ToInt32(comboBoxRoomNumber.SelectedValue);
            DateTime dateIn = dateTimePickerIn.Value;
            DateTime dateOut = dateTimePickerOut.Value;

            if (reservation.addReservation(roomNumber, clientID, dateIn, dateOut))
            {
                MessageBox.Show("New reservation added", "Add reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                MessageBox.Show("reservation NOT added", "Add reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
