﻿namespace Csharp_Hotel_System
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRoomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageClientsToolStripMenuItem,
            this.manageRoomsToolStripMenuItem,
            this.manageReservationToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageClientsToolStripMenuItem
            // 
            this.manageClientsToolStripMenuItem.Name = "manageClientsToolStripMenuItem";
            this.manageClientsToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.manageClientsToolStripMenuItem.Text = "Manage Clients";
            this.manageClientsToolStripMenuItem.Click += new System.EventHandler(this.ManageClientsToolStripMenuItem_Click);
            // 
            // manageReservationToolStripMenuItem
            // 
            this.manageReservationToolStripMenuItem.Name = "manageReservationToolStripMenuItem";
            this.manageReservationToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.manageReservationToolStripMenuItem.Text = "Manage Reservation";
            this.manageReservationToolStripMenuItem.Click += new System.EventHandler(this.ManageReservationToolStripMenuItem_Click);
            // 
            // manageRoomsToolStripMenuItem
            // 
            this.manageRoomsToolStripMenuItem.Name = "manageRoomsToolStripMenuItem";
            this.manageRoomsToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.manageRoomsToolStripMenuItem.Text = "Manage Rooms";
            this.manageRoomsToolStripMenuItem.Click += new System.EventHandler(this.ManageRoomsToolStripMenuItem_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Form";
            this.Text = "Main_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageReservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageRoomsToolStripMenuItem;
    }
}