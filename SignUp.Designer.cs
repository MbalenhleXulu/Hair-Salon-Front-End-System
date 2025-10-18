
namespace DaZieRange_Appointment_System
{
    partial class SignUp
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddUser = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dsSalon1 = new DaZieRange_Appointment_System.SalonDataSet();
            this.taCustomer = new DaZieRange_Appointment_System.SalonDataSetTableAdapters.CustomerTableAdapter();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPhoneNum = new System.Windows.Forms.MaskedTextBox();
            this.txtID = new System.Windows.Forms.MaskedTextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSalon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(247, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "________________________________________";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "_______________________________________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(240, 39);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 13);
            this.label7.TabIndex = 17;
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(62, 26);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // staffLoginToolStripMenuItem
            // 
            this.staffLoginToolStripMenuItem.Name = "staffLoginToolStripMenuItem";
            this.staffLoginToolStripMenuItem.Size = new System.Drawing.Size(63, 26);
            this.staffLoginToolStripMenuItem.Text = "Login";
            this.staffLoginToolStripMenuItem.Click += new System.EventHandler(this.staffLoginToolStripMenuItem_Click);
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
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem1
            // 
            this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            this.closeToolStripMenuItem1.Size = new System.Drawing.Size(58, 26);
            this.closeToolStripMenuItem1.Text = "Close";
            this.closeToolStripMenuItem1.Click += new System.EventHandler(this.closeToolStripMenuItem1_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(130, 216);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 28;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(130, 131);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 27;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(130, 174);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 26;
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "ID*";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Email address*";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "First Name";
            // 
            // AddUser
            // 
            this.AddUser.BackColor = System.Drawing.Color.Thistle;
            this.AddUser.Font = new System.Drawing.Font("Monotype Corsiva", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUser.Location = new System.Drawing.Point(25, 357);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(205, 23);
            this.AddUser.TabIndex = 20;
            this.AddUser.Text = "REGISTER";
            this.AddUser.UseVisualStyleBackColor = false;
            this.AddUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Monotype Corsiva", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "Home address*";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(130, 258);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("SimSun", 36F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label8.Location = new System.Drawing.Point(18, 61);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 48);
            this.label8.TabIndex = 33;
            this.label8.Text = "SIGN UP";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DaZieRange_Appointment_System.Properties.Resources.Cover_Page1;
            this.pictureBox1.Location = new System.Drawing.Point(415, 55);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Monotype Corsiva", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 297);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 16);
            this.label10.TabIndex = 35;
            this.label10.Text = "Phone number*";
            // 
            // dsSalon1
            // 
            this.dsSalon1.DataSetName = "SalonDataSet";
            this.dsSalon1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taCustomer
            // 
            this.taCustomer.ClearBeforeFill = true;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.dsSalon1;
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Location = new System.Drawing.Point(130, 296);
            this.txtPhoneNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPhoneNum.Mask = "(999) 000-0000";
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNum.TabIndex = 36;
            this.txtPhoneNum.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtPhoneNum_MaskInputRejected);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(130, 327);
            this.txtID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtID.Mask = "0000000000000";
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 37;
            this.txtID.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtID_MaskInputRejected);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtPhoneNum);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AddUser);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.menuStrip1);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSalon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddUser;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private SalonDataSet dsSalon1;
        private SalonDataSetTableAdapters.CustomerTableAdapter taCustomer;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.MaskedTextBox txtPhoneNum;
        private System.Windows.Forms.MaskedTextBox txtID;
    }
}