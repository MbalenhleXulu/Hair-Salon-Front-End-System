
namespace DaZieRange_Appointment_System
{
    partial class RegisterStaff
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
            this.components = new System.ComponentModel.Container();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookAnAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.dsSalon = new DaZieRange_Appointment_System.SalonDataSet();
            this.taStaff = new DaZieRange_Appointment_System.SalonDataSetTableAdapters.StaffTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffPhoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mtxtNumber = new System.Windows.Forms.MaskedTextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSalon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("SimSun", 36F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label8.Location = new System.Drawing.Point(17, 70);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(570, 48);
            this.label8.TabIndex = 50;
            this.label8.Text = "REGISTER STAFF MEMEBER";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Monotype Corsiva", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 16);
            this.label9.TabIndex = 48;
            this.label9.Text = "Home address*";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(130, 316);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 47;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(130, 147);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 45;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(130, 189);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "Password*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "Phone number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "First Name";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Thistle;
            this.button2.Font = new System.Drawing.Font("Monotype Corsiva", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(24, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 23);
            this.button2.TabIndex = 39;
            this.button2.Text = "REGISTER";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(388, 40);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "__________________________________________";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "_______________________________________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(253, 40);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "YOUR HOME OF GLAM";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Thistle;
            this.menuStrip1.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.staffLoginToolStripMenuItem,
            this.bookAnAppointmentToolStripMenuItem,
            this.orderProductToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.aboutUsToolStripMenuItem,
            this.closeToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(796, 28);
            this.menuStrip1.TabIndex = 35;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(62, 26);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // staffLoginToolStripMenuItem
            // 
            this.staffLoginToolStripMenuItem.Name = "staffLoginToolStripMenuItem";
            this.staffLoginToolStripMenuItem.Size = new System.Drawing.Size(63, 26);
            this.staffLoginToolStripMenuItem.Text = "Login";
            // 
            // bookAnAppointmentToolStripMenuItem
            // 
            this.bookAnAppointmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookAppointmentToolStripMenuItem,
            this.orderProductsToolStripMenuItem});
            this.bookAnAppointmentToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bookAnAppointmentToolStripMenuItem.Name = "bookAnAppointmentToolStripMenuItem";
            this.bookAnAppointmentToolStripMenuItem.Size = new System.Drawing.Size(77, 26);
            this.bookAnAppointmentToolStripMenuItem.Text = "Services";
            // 
            // bookAppointmentToolStripMenuItem
            // 
            this.bookAppointmentToolStripMenuItem.Name = "bookAppointmentToolStripMenuItem";
            this.bookAppointmentToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.bookAppointmentToolStripMenuItem.Text = "Book Appointment";
            // 
            // orderProductsToolStripMenuItem
            // 
            this.orderProductsToolStripMenuItem.Name = "orderProductsToolStripMenuItem";
            this.orderProductsToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.orderProductsToolStripMenuItem.Text = "Order Products";
            // 
            // orderProductToolStripMenuItem
            // 
            this.orderProductToolStripMenuItem.Name = "orderProductToolStripMenuItem";
            this.orderProductToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.orderProductToolStripMenuItem.Text = "Order Product";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(104, 26);
            this.closeToolStripMenuItem.Text = "Transaction";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(111, 26);
            this.aboutUsToolStripMenuItem.Text = "Get in Touch";
            // 
            // closeToolStripMenuItem1
            // 
            this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            this.closeToolStripMenuItem1.Size = new System.Drawing.Size(58, 26);
            this.closeToolStripMenuItem1.Text = "Close";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DaZieRange_Appointment_System.Properties.Resources.Icon;
            this.pictureBox1.Location = new System.Drawing.Point(650, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 52;
            this.label3.Text = "Type";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Administrator",
            "Manager",
            "Receptionist",
            "Nail technician",
            "Hair Stylist",
            "Makeup Artist"});
            this.cmbType.Location = new System.Drawing.Point(130, 231);
            this.cmbType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(100, 21);
            this.cmbType.TabIndex = 53;
            // 
            // dsSalon
            // 
            this.dsSalon.DataSetName = "SalonDataSet";
            this.dsSalon.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taStaff
            // 
            this.taStaff.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffIDDataGridViewTextBoxColumn,
            this.staffNameDataGridViewTextBoxColumn,
            this.staffAddressDataGridViewTextBoxColumn,
            this.staffTypeDataGridViewTextBoxColumn,
            this.staffPhoneNumberDataGridViewTextBoxColumn,
            this.staffPasswordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.staffBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(279, 147);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(501, 212);
            this.dataGridView1.TabIndex = 54;
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "staff_ID";
            this.staffIDDataGridViewTextBoxColumn.HeaderText = "staff_ID";
            this.staffIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            this.staffIDDataGridViewTextBoxColumn.Width = 115;
            // 
            // staffNameDataGridViewTextBoxColumn
            // 
            this.staffNameDataGridViewTextBoxColumn.DataPropertyName = "staff_Name";
            this.staffNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.staffNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.staffNameDataGridViewTextBoxColumn.Name = "staffNameDataGridViewTextBoxColumn";
            this.staffNameDataGridViewTextBoxColumn.Width = 110;
            // 
            // staffAddressDataGridViewTextBoxColumn
            // 
            this.staffAddressDataGridViewTextBoxColumn.DataPropertyName = "staff_Address";
            this.staffAddressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.staffAddressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.staffAddressDataGridViewTextBoxColumn.Name = "staffAddressDataGridViewTextBoxColumn";
            this.staffAddressDataGridViewTextBoxColumn.Width = 115;
            // 
            // staffTypeDataGridViewTextBoxColumn
            // 
            this.staffTypeDataGridViewTextBoxColumn.DataPropertyName = "staff_Type";
            this.staffTypeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.staffTypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.staffTypeDataGridViewTextBoxColumn.Name = "staffTypeDataGridViewTextBoxColumn";
            this.staffTypeDataGridViewTextBoxColumn.Width = 115;
            // 
            // staffPhoneNumberDataGridViewTextBoxColumn
            // 
            this.staffPhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "staff_PhoneNumber";
            this.staffPhoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            this.staffPhoneNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.staffPhoneNumberDataGridViewTextBoxColumn.Name = "staffPhoneNumberDataGridViewTextBoxColumn";
            this.staffPhoneNumberDataGridViewTextBoxColumn.Width = 115;
            // 
            // staffPasswordDataGridViewTextBoxColumn
            // 
            this.staffPasswordDataGridViewTextBoxColumn.DataPropertyName = "staff_Password";
            this.staffPasswordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.staffPasswordDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.staffPasswordDataGridViewTextBoxColumn.Name = "staffPasswordDataGridViewTextBoxColumn";
            this.staffPasswordDataGridViewTextBoxColumn.Width = 115;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.dsSalon;
            // 
            // mtxtNumber
            // 
            this.mtxtNumber.Location = new System.Drawing.Point(130, 276);
            this.mtxtNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtxtNumber.Mask = "(999) 000-0000";
            this.mtxtNumber.Name = "mtxtNumber";
            this.mtxtNumber.Size = new System.Drawing.Size(100, 20);
            this.mtxtNumber.TabIndex = 55;
            // 
            // RegisterStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(796, 428);
            this.Controls.Add(this.mtxtNumber);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RegisterStaff";
            this.Text = "V";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSalon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookAnAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbType;
        private SalonDataSet dsSalon;
        private SalonDataSetTableAdapters.StaffTableAdapter taStaff;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffPhoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private System.Windows.Forms.MaskedTextBox mtxtNumber;
    }
}