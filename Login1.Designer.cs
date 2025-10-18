
namespace DaZieRange_Appointment_System
{
    partial class Login1
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookAnAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.salonDataSet = new DaZieRange_Appointment_System.SalonDataSet();
            this.lblCust_ID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffPhoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentScheduleDataSet = new DaZieRange_Appointment_System.AppointmentScheduleDataSet();
            this.customerTableAdapter = new DaZieRange_Appointment_System.AppointmentScheduleDataSetTableAdapters.CustomerTableAdapter();
            this.taStaff = new DaZieRange_Appointment_System.SalonDataSetTableAdapters.StaffTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentScheduleDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username*";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Thistle;
            this.button1.Location = new System.Drawing.Point(90, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(186, 124);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(251, 20);
            this.txtUserName.TabIndex = 3;
            this.txtUserName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password*";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(186, 193);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(251, 20);
            this.txtPassWord.TabIndex = 5;
            this.txtPassWord.UseSystemPasswordChar = true;
            this.txtPassWord.TextChanged += new System.EventHandler(this.txtPassWord_TextChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.DimGray;
            this.linkLabel1.Location = new System.Drawing.Point(183, 243);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(104, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Lost your password?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.Gray;
            this.linkLabel2.Location = new System.Drawing.Point(360, 243);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(77, 13);
            this.linkLabel2.TabIndex = 7;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Return to store";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Thistle;
            this.button2.Location = new System.Drawing.Point(199, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Register";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(62, 26);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click_1);
            // 
            // staffLoginToolStripMenuItem
            // 
            this.staffLoginToolStripMenuItem.Name = "staffLoginToolStripMenuItem";
            this.staffLoginToolStripMenuItem.Size = new System.Drawing.Size(63, 26);
            this.staffLoginToolStripMenuItem.Text = "Login";
            this.staffLoginToolStripMenuItem.Click += new System.EventHandler(this.staffLoginToolStripMenuItem_Click_1);
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
            this.bookAppointmentToolStripMenuItem.Enabled = false;
            this.bookAppointmentToolStripMenuItem.Name = "bookAppointmentToolStripMenuItem";
            this.bookAppointmentToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.bookAppointmentToolStripMenuItem.Text = "Book Appointment";
            this.bookAppointmentToolStripMenuItem.Click += new System.EventHandler(this.bookAppointmentToolStripMenuItem_Click_1);
            // 
            // orderProductsToolStripMenuItem
            // 
            this.orderProductsToolStripMenuItem.Enabled = false;
            this.orderProductsToolStripMenuItem.Name = "orderProductsToolStripMenuItem";
            this.orderProductsToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.orderProductsToolStripMenuItem.Text = "Order Products";
            this.orderProductsToolStripMenuItem.Click += new System.EventHandler(this.orderProductsToolStripMenuItem_Click_1);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Enabled = false;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(104, 26);
            this.closeToolStripMenuItem.Text = "Transaction";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(111, 26);
            this.aboutUsToolStripMenuItem.Text = "Get in Touch";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem1
            // 
            this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            this.closeToolStripMenuItem1.Size = new System.Drawing.Size(58, 26);
            this.closeToolStripMenuItem1.Text = "Close";
            this.closeToolStripMenuItem1.Click += new System.EventHandler(this.closeToolStripMenuItem1_Click);
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
            this.closeToolStripMenuItem,
            this.aboutUsToolStripMenuItem,
            this.closeToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(790, 28);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "YOUR HOME OF GLAM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-76, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "_______________________________________";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(247, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "________________________________________";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(-65, 31);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 27;
            this.lblDate.Text = "Date";
            // 
            // salonDataSet
            // 
            this.salonDataSet.DataSetName = "SalonDataSet";
            this.salonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblCust_ID
            // 
            this.lblCust_ID.AutoSize = true;
            this.lblCust_ID.Location = new System.Drawing.Point(12, 63);
            this.lblCust_ID.Name = "lblCust_ID";
            this.lblCust_ID.Size = new System.Drawing.Size(65, 13);
            this.lblCust_ID.TabIndex = 30;
            this.lblCust_ID.Text = "Customer ID";
            this.lblCust_ID.Click += new System.EventHandler(this.lblCust_ID_Click);
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
            this.staffPasswordDataGridViewTextBoxColumn,
            this.staffEmailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.staffBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(494, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "staff_ID";
            this.staffIDDataGridViewTextBoxColumn.HeaderText = "staff_ID";
            this.staffIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            this.staffIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // staffNameDataGridViewTextBoxColumn
            // 
            this.staffNameDataGridViewTextBoxColumn.DataPropertyName = "staff_Name";
            this.staffNameDataGridViewTextBoxColumn.HeaderText = "staff_Name";
            this.staffNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.staffNameDataGridViewTextBoxColumn.Name = "staffNameDataGridViewTextBoxColumn";
            this.staffNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // staffAddressDataGridViewTextBoxColumn
            // 
            this.staffAddressDataGridViewTextBoxColumn.DataPropertyName = "staff_Address";
            this.staffAddressDataGridViewTextBoxColumn.HeaderText = "staff_Address";
            this.staffAddressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.staffAddressDataGridViewTextBoxColumn.Name = "staffAddressDataGridViewTextBoxColumn";
            this.staffAddressDataGridViewTextBoxColumn.Width = 150;
            // 
            // staffTypeDataGridViewTextBoxColumn
            // 
            this.staffTypeDataGridViewTextBoxColumn.DataPropertyName = "staff_Type";
            this.staffTypeDataGridViewTextBoxColumn.HeaderText = "staff_Type";
            this.staffTypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.staffTypeDataGridViewTextBoxColumn.Name = "staffTypeDataGridViewTextBoxColumn";
            this.staffTypeDataGridViewTextBoxColumn.Width = 150;
            // 
            // staffPhoneNumberDataGridViewTextBoxColumn
            // 
            this.staffPhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "staff_PhoneNumber";
            this.staffPhoneNumberDataGridViewTextBoxColumn.HeaderText = "staff_PhoneNumber";
            this.staffPhoneNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.staffPhoneNumberDataGridViewTextBoxColumn.Name = "staffPhoneNumberDataGridViewTextBoxColumn";
            this.staffPhoneNumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // staffPasswordDataGridViewTextBoxColumn
            // 
            this.staffPasswordDataGridViewTextBoxColumn.DataPropertyName = "staff_Password";
            this.staffPasswordDataGridViewTextBoxColumn.HeaderText = "staff_Password";
            this.staffPasswordDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.staffPasswordDataGridViewTextBoxColumn.Name = "staffPasswordDataGridViewTextBoxColumn";
            this.staffPasswordDataGridViewTextBoxColumn.Width = 150;
            // 
            // staffEmailDataGridViewTextBoxColumn
            // 
            this.staffEmailDataGridViewTextBoxColumn.DataPropertyName = "staff_Email";
            this.staffEmailDataGridViewTextBoxColumn.HeaderText = "staff_Email";
            this.staffEmailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.staffEmailDataGridViewTextBoxColumn.Name = "staffEmailDataGridViewTextBoxColumn";
            this.staffEmailDataGridViewTextBoxColumn.Width = 150;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.salonDataSet;
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataMember = "Customer";
            this.customerBindingSource1.DataSource = this.appointmentScheduleDataSet;
            // 
            // appointmentScheduleDataSet
            // 
            this.appointmentScheduleDataSet.DataSetName = "AppointmentScheduleDataSet";
            this.appointmentScheduleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // taStaff
            // 
            this.taStaff.ClearBeforeFill = true;
            // 
            // Login1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(790, 324);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblCust_ID);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Login1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentScheduleDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookAnAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDate;
        private SalonDataSet salonDataSet;
        private System.Windows.Forms.Label lblCust_ID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AppointmentScheduleDataSet appointmentScheduleDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private AppointmentScheduleDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffPhoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private SalonDataSetTableAdapters.StaffTableAdapter taStaff;
    }
}