
namespace DaZieRange_Appointment_System
{
    partial class Transation
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookAnAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCart = new System.Windows.Forms.RichTextBox();
            this.btnPayment = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblApptType = new System.Windows.Forms.Label();
            this.lblServiceReq = new System.Windows.Forms.Label();
            this.lblBookingFee = new System.Windows.Forms.Label();
            this.dsSalon = new DaZieRange_Appointment_System.SalonDataSet();
            this.taPayment = new DaZieRange_Appointment_System.SalonDataSetTableAdapters.PaymentTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.appointmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taAppointment = new DaZieRange_Appointment_System.SalonDataSetTableAdapters.AppointmentTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taOrder = new DaZieRange_Appointment_System.SalonDataSetTableAdapters.OrderTableAdapter();
            this.LblOrder_ID = new System.Windows.Forms.Label();
            this.lblAppt_ID = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSalon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment Method :";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(31, 156);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(75, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Debit Card";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(31, 120);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(77, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.Text = "Credit Card";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(423, 390);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Total :    ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(383, 41);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(247, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "________________________________________";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 41);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(241, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "_______________________________________";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(256, 41);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "YOUR HOME OF GLAM";
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
            this.menuStrip1.Size = new System.Drawing.Size(722, 28);
            this.menuStrip1.TabIndex = 18;
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
            this.bookAppointmentToolStripMenuItem.Click += new System.EventHandler(this.bookAppointmentToolStripMenuItem_Click);
            // 
            // orderProductsToolStripMenuItem
            // 
            this.orderProductsToolStripMenuItem.Name = "orderProductsToolStripMenuItem";
            this.orderProductsToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.orderProductsToolStripMenuItem.Text = "Order Products";
            this.orderProductsToolStripMenuItem.Click += new System.EventHandler(this.orderProductsToolStripMenuItem_Click);
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
            // 
            // txtCart
            // 
            this.txtCart.Location = new System.Drawing.Point(457, 57);
            this.txtCart.Name = "txtCart";
            this.txtCart.Size = new System.Drawing.Size(173, 171);
            this.txtCart.TabIndex = 22;
            this.txtCart.Text = "CART";
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(19, 383);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(113, 20);
            this.btnPayment.TabIndex = 28;
            this.btnPayment.Text = "Process Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(31, 186);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(49, 17);
            this.radioButton3.TabIndex = 29;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Cash";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(28, 73);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 13);
            this.lblName.TabIndex = 30;
            this.lblName.Text = "Cust Name";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(103, 73);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(73, 13);
            this.lblSurname.TabIndex = 31;
            this.lblSurname.Text = "Cust Surname";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(457, 385);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(68, 20);
            this.txtTotal.TabIndex = 32;
            // 
            // lblApptType
            // 
            this.lblApptType.AutoSize = true;
            this.lblApptType.Location = new System.Drawing.Point(44, 265);
            this.lblApptType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApptType.Name = "lblApptType";
            this.lblApptType.Size = new System.Drawing.Size(59, 13);
            this.lblApptType.TabIndex = 33;
            this.lblApptType.Text = "Appt_Type";
            this.lblApptType.Visible = false;
            // 
            // lblServiceReq
            // 
            this.lblServiceReq.AutoSize = true;
            this.lblServiceReq.Location = new System.Drawing.Point(44, 292);
            this.lblServiceReq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServiceReq.Name = "lblServiceReq";
            this.lblServiceReq.Size = new System.Drawing.Size(69, 13);
            this.lblServiceReq.TabIndex = 34;
            this.lblServiceReq.Text = "Service_Req";
            this.lblServiceReq.Visible = false;
            // 
            // lblBookingFee
            // 
            this.lblBookingFee.AutoSize = true;
            this.lblBookingFee.Location = new System.Drawing.Point(47, 317);
            this.lblBookingFee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookingFee.Name = "lblBookingFee";
            this.lblBookingFee.Size = new System.Drawing.Size(70, 13);
            this.lblBookingFee.TabIndex = 35;
            this.lblBookingFee.Text = "Booking_Fee";
            this.lblBookingFee.Visible = false;
            // 
            // dsSalon
            // 
            this.dsSalon.DataSetName = "SalonDataSet";
            this.dsSalon.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taPayment
            // 
            this.taPayment.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appointmentIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.appointmentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(457, 232);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(160, 97);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.Visible = false;
            // 
            // appointmentIDDataGridViewTextBoxColumn
            // 
            this.appointmentIDDataGridViewTextBoxColumn.DataPropertyName = "appointment_ID";
            this.appointmentIDDataGridViewTextBoxColumn.HeaderText = "appointment_ID";
            this.appointmentIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.appointmentIDDataGridViewTextBoxColumn.Name = "appointmentIDDataGridViewTextBoxColumn";
            this.appointmentIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataMember = "Appointment";
            this.appointmentBindingSource.DataSource = this.dsSalon;
            // 
            // taAppointment
            // 
            this.taAppointment.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.productIDDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.orderQuantityDataGridViewTextBoxColumn,
            this.orderAmountDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.orderBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(259, 232);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(160, 97);
            this.dataGridView2.TabIndex = 37;
            this.dataGridView2.Visible = false;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "order_ID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "order_ID";
            this.orderIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "product_ID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "product_ID";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "customer_ID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "customer_ID";
            this.customerIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "order_Date";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "order_Date";
            this.orderDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // orderQuantityDataGridViewTextBoxColumn
            // 
            this.orderQuantityDataGridViewTextBoxColumn.DataPropertyName = "order_Quantity";
            this.orderQuantityDataGridViewTextBoxColumn.HeaderText = "order_Quantity";
            this.orderQuantityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.orderQuantityDataGridViewTextBoxColumn.Name = "orderQuantityDataGridViewTextBoxColumn";
            this.orderQuantityDataGridViewTextBoxColumn.Width = 150;
            // 
            // orderAmountDataGridViewTextBoxColumn
            // 
            this.orderAmountDataGridViewTextBoxColumn.DataPropertyName = "order_Amount";
            this.orderAmountDataGridViewTextBoxColumn.HeaderText = "order_Amount";
            this.orderAmountDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.orderAmountDataGridViewTextBoxColumn.Name = "orderAmountDataGridViewTextBoxColumn";
            this.orderAmountDataGridViewTextBoxColumn.Width = 150;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.dsSalon;
            // 
            // taOrder
            // 
            this.taOrder.ClearBeforeFill = true;
            // 
            // LblOrder_ID
            // 
            this.LblOrder_ID.AutoSize = true;
            this.LblOrder_ID.Location = new System.Drawing.Point(256, 129);
            this.LblOrder_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblOrder_ID.Name = "LblOrder_ID";
            this.LblOrder_ID.Size = new System.Drawing.Size(50, 13);
            this.LblOrder_ID.TabIndex = 38;
            this.LblOrder_ID.Text = "Order_ID";
            this.LblOrder_ID.Visible = false;
            // 
            // lblAppt_ID
            // 
            this.lblAppt_ID.AutoSize = true;
            this.lblAppt_ID.Location = new System.Drawing.Point(256, 159);
            this.lblAppt_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAppt_ID.Name = "lblAppt_ID";
            this.lblAppt_ID.Size = new System.Drawing.Size(46, 13);
            this.lblAppt_ID.TabIndex = 39;
            this.lblAppt_ID.Text = "Appt_ID";
            this.lblAppt_ID.Visible = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(575, 385);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(113, 23);
            this.btnConfirm.TabIndex = 40;
            this.btnConfirm.Text = "Send confirmation";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(44, 339);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 41;
            this.lblEmail.Text = "Email";
            // 
            // Transation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(722, 424);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblAppt_ID);
            this.Controls.Add(this.LblOrder_ID);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblBookingFee);
            this.Controls.Add(this.lblServiceReq);
            this.Controls.Add(this.lblApptType);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.txtCart);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Name = "Transation";
            this.Text = "Transation";
            this.Load += new System.EventHandler(this.Transation_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSalon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookAnAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem1;
        private System.Windows.Forms.RichTextBox txtCart;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.RadioButton radioButton3;
        private SalonDataSet dsSalon;
        private SalonDataSetTableAdapters.PaymentTableAdapter taPayment;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblApptType;
        private System.Windows.Forms.Label lblServiceReq;
        private System.Windows.Forms.Label lblBookingFee;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private SalonDataSetTableAdapters.AppointmentTableAdapter taAppointment;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private SalonDataSetTableAdapters.OrderTableAdapter taOrder;
        private System.Windows.Forms.Label LblOrder_ID;
        private System.Windows.Forms.Label lblAppt_ID;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblEmail;
    }
}