namespace Csharp_Hotel_System
{
    partial class ManageReservationForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePickerOut = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerIn = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxRoomNumber = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxRoomType = new System.Windows.Forms.ComboBox();
            this.LabelRoomType = new System.Windows.Forms.Label();
            this.textBoxClientID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClearFields = new System.Windows.Forms.Button();
            this.buttonRemoveReservation = new System.Windows.Forms.Button();
            this.buttonEditReservation = new System.Windows.Forms.Button();
            this.buttonAddReservation = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LabelManageRooms = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dateTimePickerOut);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dateTimePickerIn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBoxRoomNumber);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBoxRoomType);
            this.panel1.Controls.Add(this.LabelRoomType);
            this.panel1.Controls.Add(this.textBoxClientID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonClearFields);
            this.panel1.Controls.Add(this.buttonRemoveReservation);
            this.panel1.Controls.Add(this.buttonEditReservation);
            this.panel1.Controls.Add(this.buttonAddReservation);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 541);
            this.panel1.TabIndex = 2;
            // 
            // dateTimePickerOut
            // 
            this.dateTimePickerOut.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.dateTimePickerOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerOut.Location = new System.Drawing.Point(212, 292);
            this.dateTimePickerOut.Name = "dateTimePickerOut";
            this.dateTimePickerOut.Size = new System.Drawing.Size(128, 29);
            this.dateTimePickerOut.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 23);
            this.label4.TabIndex = 26;
            this.label4.Text = "Date Out:";
            // 
            // dateTimePickerIn
            // 
            this.dateTimePickerIn.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.dateTimePickerIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerIn.Location = new System.Drawing.Point(212, 257);
            this.dateTimePickerIn.Name = "dateTimePickerIn";
            this.dateTimePickerIn.Size = new System.Drawing.Size(128, 29);
            this.dateTimePickerIn.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "Date In:";
            // 
            // comboBoxRoomNumber
            // 
            this.comboBoxRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.comboBoxRoomNumber.FormattingEnabled = true;
            this.comboBoxRoomNumber.Location = new System.Drawing.Point(212, 219);
            this.comboBoxRoomNumber.Name = "comboBoxRoomNumber";
            this.comboBoxRoomNumber.Size = new System.Drawing.Size(220, 32);
            this.comboBoxRoomNumber.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Room Number:";
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.Location = new System.Drawing.Point(212, 181);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(220, 32);
            this.comboBoxRoomType.TabIndex = 20;
            this.comboBoxRoomType.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoomType_SelectedIndexChanged);
            // 
            // LabelRoomType
            // 
            this.LabelRoomType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelRoomType.AutoSize = true;
            this.LabelRoomType.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRoomType.Location = new System.Drawing.Point(81, 184);
            this.LabelRoomType.Name = "LabelRoomType";
            this.LabelRoomType.Size = new System.Drawing.Size(125, 23);
            this.LabelRoomType.TabIndex = 19;
            this.LabelRoomType.Text = "Room Type:";
            // 
            // textBoxClientID
            // 
            this.textBoxClientID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClientID.Location = new System.Drawing.Point(212, 146);
            this.textBoxClientID.Name = "textBoxClientID";
            this.textBoxClientID.Size = new System.Drawing.Size(144, 29);
            this.textBoxClientID.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Client ID:";
            // 
            // buttonClearFields
            // 
            this.buttonClearFields.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonClearFields.BackColor = System.Drawing.Color.Black;
            this.buttonClearFields.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearFields.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClearFields.Location = new System.Drawing.Point(307, 460);
            this.buttonClearFields.Name = "buttonClearFields";
            this.buttonClearFields.Size = new System.Drawing.Size(94, 39);
            this.buttonClearFields.TabIndex = 15;
            this.buttonClearFields.Text = "Clear Fields";
            this.buttonClearFields.UseVisualStyleBackColor = false;
            this.buttonClearFields.Click += new System.EventHandler(this.buttonClearFields_Click);
            // 
            // buttonRemoveReservation
            // 
            this.buttonRemoveReservation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRemoveReservation.BackColor = System.Drawing.Color.Black;
            this.buttonRemoveReservation.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveReservation.ForeColor = System.Drawing.Color.White;
            this.buttonRemoveReservation.Location = new System.Drawing.Point(222, 460);
            this.buttonRemoveReservation.Name = "buttonRemoveReservation";
            this.buttonRemoveReservation.Size = new System.Drawing.Size(79, 39);
            this.buttonRemoveReservation.TabIndex = 14;
            this.buttonRemoveReservation.Text = "Remove";
            this.buttonRemoveReservation.UseVisualStyleBackColor = false;
            // 
            // buttonEditReservation
            // 
            this.buttonEditReservation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEditReservation.BackColor = System.Drawing.Color.Black;
            this.buttonEditReservation.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditReservation.ForeColor = System.Drawing.Color.White;
            this.buttonEditReservation.Location = new System.Drawing.Point(150, 460);
            this.buttonEditReservation.Name = "buttonEditReservation";
            this.buttonEditReservation.Size = new System.Drawing.Size(66, 39);
            this.buttonEditReservation.TabIndex = 13;
            this.buttonEditReservation.Text = "Edit";
            this.buttonEditReservation.UseVisualStyleBackColor = false;
            // 
            // buttonAddReservation
            // 
            this.buttonAddReservation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddReservation.BackColor = System.Drawing.Color.Black;
            this.buttonAddReservation.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddReservation.ForeColor = System.Drawing.Color.White;
            this.buttonAddReservation.Location = new System.Drawing.Point(52, 460);
            this.buttonAddReservation.Name = "buttonAddReservation";
            this.buttonAddReservation.Size = new System.Drawing.Size(92, 39);
            this.buttonAddReservation.TabIndex = 12;
            this.buttonAddReservation.Text = "Add New Reservation";
            this.buttonAddReservation.UseVisualStyleBackColor = false;
            this.buttonAddReservation.Click += new System.EventHandler(this.buttonAddReservation_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(465, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(459, 395);
            this.dataGridView1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Controls.Add(this.LabelManageRooms);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(924, 100);
            this.panel2.TabIndex = 0;
            // 
            // LabelManageRooms
            // 
            this.LabelManageRooms.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelManageRooms.AutoSize = true;
            this.LabelManageRooms.BackColor = System.Drawing.SystemColors.Desktop;
            this.LabelManageRooms.Font = new System.Drawing.Font("Verdana", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelManageRooms.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelManageRooms.Location = new System.Drawing.Point(203, 23);
            this.LabelManageRooms.Name = "LabelManageRooms";
            this.LabelManageRooms.Size = new System.Drawing.Size(481, 52);
            this.LabelManageRooms.TabIndex = 0;
            this.LabelManageRooms.Text = "Manage Reservations";
            this.LabelManageRooms.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ManageReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 541);
            this.Controls.Add(this.panel1);
            this.Name = "ManageReservationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageReservationForm";
            this.Load += new System.EventHandler(this.ManageReservationForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonClearFields;
        private System.Windows.Forms.Button buttonRemoveReservation;
        private System.Windows.Forms.Button buttonEditReservation;
        private System.Windows.Forms.Button buttonAddReservation;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LabelManageRooms;
        private System.Windows.Forms.TextBox textBoxClientID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerOut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxRoomNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxRoomType;
        private System.Windows.Forms.Label LabelRoomType;
    }
}