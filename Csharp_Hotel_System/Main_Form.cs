using System;
using System.Windows.Forms;

namespace Csharp_Hotel_System
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainFormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ManageClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageClientsForm manageCF = new ManageClientsForm();
            manageCF.ShowDialog();
        }

        private void ManageRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageRoomsForm manageRF = new ManageRoomsForm();
            manageRF.ShowDialog();
        }

        private void ManageReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageReservationForm manageRSVF = new ManageReservationForm();
            manageRSVF.ShowDialog();
        }
    }
}
