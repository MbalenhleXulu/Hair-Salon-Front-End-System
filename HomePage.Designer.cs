
namespace DaZieRange_Appointment_System
{
    partial class frmHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHomePage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookAnAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.TransactionToolStripMenuItem,
            this.aboutUsToolStripMenuItem,
            this.closeToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(821, 28);
            this.menuStrip1.TabIndex = 0;
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
            this.bookAnAppointmentToolStripMenuItem.Click += new System.EventHandler(this.bookAnAppointmentToolStripMenuItem_Click);
            // 
            // bookAppointmentToolStripMenuItem
            // 
            this.bookAppointmentToolStripMenuItem.Name = "bookAppointmentToolStripMenuItem";
            this.bookAppointmentToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.bookAppointmentToolStripMenuItem.Text = "Book Appointment";
            this.bookAppointmentToolStripMenuItem.Click += new System.EventHandler(this.bookAppointmentToolStripMenuItem_Click);
            // 
            // orderProductsToolStripMenuItem
            // 
            this.orderProductsToolStripMenuItem.Enabled = false;
            this.orderProductsToolStripMenuItem.Name = "orderProductsToolStripMenuItem";
            this.orderProductsToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.orderProductsToolStripMenuItem.Text = "Order Products";
            this.orderProductsToolStripMenuItem.Click += new System.EventHandler(this.orderProductsToolStripMenuItem_Click);
            // 
            // TransactionToolStripMenuItem
            // 
            this.TransactionToolStripMenuItem.Enabled = false;
            this.TransactionToolStripMenuItem.Name = "TransactionToolStripMenuItem";
            this.TransactionToolStripMenuItem.Size = new System.Drawing.Size(104, 26);
            this.TransactionToolStripMenuItem.Text = "Transaction";
            this.TransactionToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 36F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label1.Location = new System.Drawing.Point(19, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "DA ZIE RANGE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 36F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label2.Location = new System.Drawing.Point(19, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 48);
            this.label2.TabIndex = 4;
            this.label2.Text = "BEAUTY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 36F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label3.Location = new System.Drawing.Point(19, 230);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 48);
            this.label3.TabIndex = 5;
            this.label3.Text = "PARLOUR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "YOUR HOME OF GLAM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-3, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "_______________________________________";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(379, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(247, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "________________________________________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 302);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(403, 60);
            this.label7.TabIndex = 11;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(8, 62);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 12;
            this.lblDate.Text = "Date";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(144, 62);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(30, 13);
            this.lblTime.TabIndex = 13;
            this.lblTime.Text = "Time";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DaZieRange_Appointment_System.Properties.Resources.Cover_Page_2;
            this.pictureBox2.Location = new System.Drawing.Point(473, 80);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(340, 320);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DaZieRange_Appointment_System.Properties.Resources.Icon;
            this.pictureBox1.Location = new System.Drawing.Point(675, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(821, 439);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmHomePage";
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.frmHomePage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookAnAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
    }
}

