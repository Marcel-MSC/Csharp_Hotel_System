namespace Csharp_Hotel_System
{
    partial class ManageClientsForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.LabelFirstName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.labelCountry = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.textBoxCountry);
            this.panel1.Controls.Add(this.labelCountry);
            this.panel1.Controls.Add(this.textBoxPhone);
            this.panel1.Controls.Add(this.labelPhone);
            this.panel1.Controls.Add(this.textBoxLastName);
            this.panel1.Controls.Add(this.labelLastName);
            this.panel1.Controls.Add(this.textBoxFirstName);
            this.panel1.Controls.Add(this.LabelFirstName);
            this.panel1.Controls.Add(this.textBoxID);
            this.panel1.Controls.Add(this.labelID);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 541);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(924, 100);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Font = new System.Drawing.Font("Verdana", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(284, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Clients";
            // 
            // labelID
            // 
            this.labelID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(104, 181);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(42, 23);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "ID:";
            // 
            // textBoxID
            // 
            this.textBoxID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(152, 178);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(144, 29);
            this.textBoxID.TabIndex = 2;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstName.Location = new System.Drawing.Point(152, 213);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(220, 29);
            this.textBoxFirstName.TabIndex = 4;
            // 
            // LabelFirstName
            // 
            this.LabelFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelFirstName.AutoSize = true;
            this.LabelFirstName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFirstName.Location = new System.Drawing.Point(24, 216);
            this.LabelFirstName.Name = "LabelFirstName";
            this.LabelFirstName.Size = new System.Drawing.Size(122, 23);
            this.LabelFirstName.TabIndex = 3;
            this.LabelFirstName.Text = "First Name:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastName.Location = new System.Drawing.Point(152, 248);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(220, 29);
            this.textBoxLastName.TabIndex = 6;
            // 
            // labelLastName
            // 
            this.labelLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(27, 251);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(119, 23);
            this.labelLastName.TabIndex = 5;
            this.labelLastName.Text = "Last Name:";
            this.labelLastName.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhone.Location = new System.Drawing.Point(152, 283);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(220, 29);
            this.textBoxPhone.TabIndex = 8;
            // 
            // labelPhone
            // 
            this.labelPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(69, 286);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(77, 23);
            this.labelPhone.TabIndex = 7;
            this.labelPhone.Text = "Phone:";
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCountry.Location = new System.Drawing.Point(152, 318);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(220, 29);
            this.textBoxCountry.TabIndex = 10;
            // 
            // labelCountry
            // 
            this.labelCountry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCountry.AutoSize = true;
            this.labelCountry.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountry.Location = new System.Drawing.Point(52, 321);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(94, 23);
            this.labelCountry.TabIndex = 9;
            this.labelCountry.Text = "Country:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(420, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(492, 341);
            this.dataGridView1.TabIndex = 11;
            // 
            // ManageClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(924, 541);
            this.Controls.Add(this.panel1);
            this.Name = "ManageClientsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageClientsForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label LabelFirstName;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}