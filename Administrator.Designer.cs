
namespace DaZieRange_Appointment_System
{
    partial class Administrator
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPhoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeSlotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.previousAppointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsAppSchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsAppSch = new DaZieRange_Appointment_System.AppointmentScheduleDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBookingSeach = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.customerIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderInnerJoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCart = new DaZieRange_Appointment_System.DataSetCart();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearchOrder = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSalon = new DaZieRange_Appointment_System.SalonDataSet();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.taProduct = new DaZieRange_Appointment_System.SalonDataSetTableAdapters.Product_2TableAdapter();
            this.taPrevApp = new DaZieRange_Appointment_System.AppointmentScheduleDataSetTableAdapters.PreviousAppointmentTableAdapter();
            this.taOrderInner = new DaZieRange_Appointment_System.DataSetCartTableAdapters.OrderInnerJoinTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previousAppointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAppSchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAppSch)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderInnerJoinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCart)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSalon)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1176, 602);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Thistle;
            this.tabPage1.Controls.Add(this.monthCalendar1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtBookingSeach);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1168, 569);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View Bookings";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(158, 9);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.customerSurnameDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.customerEmailDataGridViewTextBoxColumn,
            this.customerPhoneNumberDataGridViewTextBoxColumn,
            this.appointmentDateDataGridViewTextBoxColumn,
            this.timeSlotDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.previousAppointmentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(39, 268);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1085, 298);
            this.dataGridView1.TabIndex = 4;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "customer_ID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "customer_ID";
            this.customerIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerIDDataGridViewTextBoxColumn.Width = 137;
            // 
            // customerSurnameDataGridViewTextBoxColumn
            // 
            this.customerSurnameDataGridViewTextBoxColumn.DataPropertyName = "customer_Surname";
            this.customerSurnameDataGridViewTextBoxColumn.HeaderText = "customer_Surname";
            this.customerSurnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.customerSurnameDataGridViewTextBoxColumn.Name = "customerSurnameDataGridViewTextBoxColumn";
            this.customerSurnameDataGridViewTextBoxColumn.Width = 185;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "customer_Name";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "customer_Name";
            this.customerNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.Width = 162;
            // 
            // customerEmailDataGridViewTextBoxColumn
            // 
            this.customerEmailDataGridViewTextBoxColumn.DataPropertyName = "customer_Email";
            this.customerEmailDataGridViewTextBoxColumn.HeaderText = "customer_Email";
            this.customerEmailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.customerEmailDataGridViewTextBoxColumn.Name = "customerEmailDataGridViewTextBoxColumn";
            this.customerEmailDataGridViewTextBoxColumn.Width = 159;
            // 
            // customerPhoneNumberDataGridViewTextBoxColumn
            // 
            this.customerPhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "customer_PhoneNumber";
            this.customerPhoneNumberDataGridViewTextBoxColumn.HeaderText = "customer_PhoneNumber";
            this.customerPhoneNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.customerPhoneNumberDataGridViewTextBoxColumn.Name = "customerPhoneNumberDataGridViewTextBoxColumn";
            this.customerPhoneNumberDataGridViewTextBoxColumn.Width = 222;
            // 
            // appointmentDateDataGridViewTextBoxColumn
            // 
            this.appointmentDateDataGridViewTextBoxColumn.DataPropertyName = "appointment_Date";
            this.appointmentDateDataGridViewTextBoxColumn.HeaderText = "appointment_Date";
            this.appointmentDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.appointmentDateDataGridViewTextBoxColumn.Name = "appointmentDateDataGridViewTextBoxColumn";
            this.appointmentDateDataGridViewTextBoxColumn.Width = 178;
            // 
            // timeSlotDataGridViewTextBoxColumn
            // 
            this.timeSlotDataGridViewTextBoxColumn.DataPropertyName = "TimeSlot";
            this.timeSlotDataGridViewTextBoxColumn.HeaderText = "TimeSlot";
            this.timeSlotDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.timeSlotDataGridViewTextBoxColumn.Name = "timeSlotDataGridViewTextBoxColumn";
            this.timeSlotDataGridViewTextBoxColumn.Width = 107;
            // 
            // previousAppointmentBindingSource
            // 
            this.previousAppointmentBindingSource.DataMember = "PreviousAppointment";
            this.previousAppointmentBindingSource.DataSource = this.dsAppSchBindingSource;
            // 
            // dsAppSchBindingSource
            // 
            this.dsAppSchBindingSource.DataSource = this.dsAppSch;
            this.dsAppSchBindingSource.Position = 0;
            // 
            // dsAppSch
            // 
            this.dsAppSch.DataSetName = "AppointmentScheduleDataSet";
            this.dsAppSch.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(744, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Search by Customer Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search by Date:";
            // 
            // txtBookingSeach
            // 
            this.txtBookingSeach.Location = new System.Drawing.Point(748, 71);
            this.txtBookingSeach.Name = "txtBookingSeach";
            this.txtBookingSeach.Size = new System.Drawing.Size(302, 26);
            this.txtBookingSeach.TabIndex = 1;
            this.txtBookingSeach.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Thistle;
            this.tabPage2.Controls.Add(this.monthCalendar2);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtSearchOrder);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1168, 569);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View Orders";
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(175, 9);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 10;
            this.monthCalendar2.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn1,
            this.customerNameDataGridViewTextBoxColumn1,
            this.orderDateDataGridViewTextBoxColumn,
            this.orderQuantityDataGridViewTextBoxColumn,
            this.orderAmountDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.orderInnerJoinBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(44, 275);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(937, 298);
            this.dataGridView2.TabIndex = 9;
            // 
            // customerIDDataGridViewTextBoxColumn1
            // 
            this.customerIDDataGridViewTextBoxColumn1.DataPropertyName = "customer_ID";
            this.customerIDDataGridViewTextBoxColumn1.HeaderText = "customer_ID";
            this.customerIDDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.customerIDDataGridViewTextBoxColumn1.Name = "customerIDDataGridViewTextBoxColumn1";
            this.customerIDDataGridViewTextBoxColumn1.Width = 137;
            // 
            // customerNameDataGridViewTextBoxColumn1
            // 
            this.customerNameDataGridViewTextBoxColumn1.DataPropertyName = "customer_Name";
            this.customerNameDataGridViewTextBoxColumn1.HeaderText = "customer_Name";
            this.customerNameDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.customerNameDataGridViewTextBoxColumn1.Name = "customerNameDataGridViewTextBoxColumn1";
            this.customerNameDataGridViewTextBoxColumn1.Width = 162;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "order_Date";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "order_Date";
            this.orderDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.Width = 126;
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
            this.orderAmountDataGridViewTextBoxColumn.Width = 147;
            // 
            // productNameDataGridViewTextBoxColumn1
            // 
            this.productNameDataGridViewTextBoxColumn1.DataPropertyName = "product_Name";
            this.productNameDataGridViewTextBoxColumn1.HeaderText = "product_Name";
            this.productNameDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.productNameDataGridViewTextBoxColumn1.Name = "productNameDataGridViewTextBoxColumn1";
            this.productNameDataGridViewTextBoxColumn1.Width = 150;
            // 
            // orderInnerJoinBindingSource
            // 
            this.orderInnerJoinBindingSource.DataMember = "OrderInnerJoin";
            this.orderInnerJoinBindingSource.DataSource = this.dsCart;
            // 
            // dsCart
            // 
            this.dsCart.DataSetName = "DataSetCart";
            this.dsCart.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(714, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Search by Order ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Search by Date:";
            // 
            // txtSearchOrder
            // 
            this.txtSearchOrder.Location = new System.Drawing.Point(718, 74);
            this.txtSearchOrder.Name = "txtSearchOrder";
            this.txtSearchOrder.Size = new System.Drawing.Size(302, 26);
            this.txtSearchOrder.TabIndex = 6;
            this.txtSearchOrder.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Thistle;
            this.tabPage3.Controls.Add(this.btnUpdate);
            this.tabPage3.Controls.Add(this.dgvProduct);
            this.tabPage3.Controls.Add(this.cmbCategory);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.txtQuantity);
            this.tabPage3.Controls.Add(this.txtName);
            this.tabPage3.Controls.Add(this.txtPrice);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.btnInsert);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1168, 569);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Update Product List";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Thistle;
            this.btnUpdate.Font = new System.Drawing.Font("Monotype Corsiva", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(53, 444);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(307, 35);
            this.btnUpdate.TabIndex = 78;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvProduct
            // 
            this.dgvProduct.AutoGenerateColumns = false;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productPriceDataGridViewTextBoxColumn,
            this.productQuantityDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn});
            this.dgvProduct.DataSource = this.product2BindingSource;
            this.dgvProduct.Location = new System.Drawing.Point(382, 199);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidth = 62;
            this.dgvProduct.RowTemplate.Height = 28;
            this.dgvProduct.Size = new System.Drawing.Size(761, 296);
            this.dgvProduct.TabIndex = 77;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "product_ID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "product_ID";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "product_Name";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "product_Name";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // productPriceDataGridViewTextBoxColumn
            // 
            this.productPriceDataGridViewTextBoxColumn.DataPropertyName = "product_Price";
            this.productPriceDataGridViewTextBoxColumn.HeaderText = "product_Price";
            this.productPriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productPriceDataGridViewTextBoxColumn.Name = "productPriceDataGridViewTextBoxColumn";
            this.productPriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // productQuantityDataGridViewTextBoxColumn
            // 
            this.productQuantityDataGridViewTextBoxColumn.DataPropertyName = "product_Quantity";
            this.productQuantityDataGridViewTextBoxColumn.HeaderText = "product_Quantity";
            this.productQuantityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productQuantityDataGridViewTextBoxColumn.Name = "productQuantityDataGridViewTextBoxColumn";
            this.productQuantityDataGridViewTextBoxColumn.Width = 150;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "category";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.Width = 150;
            // 
            // product2BindingSource
            // 
            this.product2BindingSource.DataMember = "Product 2";
            this.product2BindingSource.DataSource = this.dsSalon;
            // 
            // dsSalon
            // 
            this.dsSalon.DataSetName = "SalonDataSet";
            this.dsSalon.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Beauty",
            "Hair",
            "Nails",
            "MakeUp",
            "Weave"});
            this.cmbCategory.Location = new System.Drawing.Point(212, 343);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(148, 28);
            this.cmbCategory.TabIndex = 76;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("SimSun", 36F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label8.Location = new System.Drawing.Point(25, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(733, 72);
            this.label8.TabIndex = 75;
            this.label8.Text = "UPDATE PRODUCT LIST";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Monotype Corsiva", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(62, 347);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 24);
            this.label9.TabIndex = 74;
            this.label9.Text = "Catergory";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(212, 294);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(148, 26);
            this.txtQuantity.TabIndex = 73;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(212, 199);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(148, 26);
            this.txtName.TabIndex = 72;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(212, 249);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(148, 26);
            this.txtPrice.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 295);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 24);
            this.label2.TabIndex = 70;
            this.label2.Text = "Product Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 250);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 69;
            this.label3.Text = "Product Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 24);
            this.label4.TabIndex = 68;
            this.label4.Text = "Product Name";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Thistle;
            this.btnInsert.Font = new System.Drawing.Font("Monotype Corsiva", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(53, 399);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(307, 35);
            this.btnInsert.TabIndex = 67;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // taProduct
            // 
            this.taProduct.ClearBeforeFill = true;
            // 
            // taPrevApp
            // 
            this.taPrevApp.ClearBeforeFill = true;
            // 
            // taOrderInner
            // 
            this.taOrderInner.ClearBeforeFill = true;
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1176, 602);
            this.Controls.Add(this.tabControl1);
            this.Name = "StaffForm";
            this.Text = "StaffForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previousAppointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAppSchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAppSch)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderInnerJoinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCart)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSalon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInsert;
        private SalonDataSet dsSalon;
        private SalonDataSetTableAdapters.Product_2TableAdapter taProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource product2BindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBookingSeach;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearchOrder;
        private AppointmentScheduleDataSet dsAppSch;
        private AppointmentScheduleDataSetTableAdapters.PreviousAppointmentTableAdapter taPrevApp;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPhoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeSlotDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource previousAppointmentBindingSource;
        private System.Windows.Forms.BindingSource dsAppSchBindingSource;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource orderInnerJoinBindingSource;
        private DataSetCart dsCart;
        private DataSetCartTableAdapters.OrderInnerJoinTableAdapter taOrderInner;
    }
}