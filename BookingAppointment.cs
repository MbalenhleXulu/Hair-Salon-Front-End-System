using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;
//using System;
//using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DaZieRange_Appointment_System
{

    public partial class BookingAppointment : Form
    {
        //blic static BookingAppointment instance;
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataSet ds;
        public BookingAppointment()
        {
            InitializeComponent();
           // label10.Text = Login1.lblCusID;

            ds = new DataSet();
            string connectionString = "Data Source=146.230.177.46;Initial Catalog=G6Wst2024;User ID=G6Wst2024;Password=8yhd2";
            connection = new SqlConnection(connectionString);
            monthCalendar2.DateChanged += monthCalendar2_DateChanged;

        }
        public int ValueA
        {
            get
            {
                int value = 0;
                int.TryParse(txtBookingFee.Text, out value);  // Assuming textBox1 is the name of the textbox
                return value;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BookingAppointment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appointmentScheduleDataSet3.Appointment1' table. You can move, or remove it, as needed.
            this.appointment1TableAdapter1.Fill(this.appointmentScheduleDataSet3.Appointment1);
            // TODO: This line of code loads data into the 'appointmentScheduleDataSet2.Appointment' table. You can move, or remove it, as needed.
            // this.taAppInnerJoin1.Fill(this.appointmentScheduleDataSet2.Appointment);
            // TODO: This line of code loads data into the 'appointmentScheduleDataSet.Appointment' table. You can move, or remove it, as needed.
            //this.taAppInnerJoin1.Fill(this.appointmentScheduleDataSet.Appointment);
            // TODO: This line of code loads data into the 'appointmentScheduleDataSet.Appointment' table. You can move, or remove it, as needed.
            //this.taAppInnerJoin1.Fill(this.appointmentScheduleDataSet.Appointment);
            // TODO: This line of code loads data into the 'appointmentScheduleDataSet.Appointment' table. You can move, or remove it, as needed.
            ///this.taAppInnerJoin1.Fill(this.appointmentScheduleDataSet.Appointment);
            appointment1TableAdapter1.Fill(dsAppSch.Appointment1);
            // TODO: This line of code loads data into the 'dsAppSch.TimeSlot' table. You can move, or remove it, as needed.
            this.timeSlotTableAdapter.Fill(this.dsAppSch.TimeSlot);
            //taPrevApp.FillBy(dsAppSch.PreviousAppointment);
            //label20.Text = monthCalendar1.SelectionStart.ToShortDateString();
            //tabPage3.Hide();
            

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmHomePage form = new frmHomePage();
            form.Show();
        }

        private void bookAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void staffLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login1 LoginForm = new Login1();
            LoginForm.Show();

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transation TransactionForm = new Transation();

            TransactionForm.NameText = lblCusName.Text;
            TransactionForm.SurnameText = lblCusSName.Text;
            TransactionForm.ApptType = label17.Text;
            TransactionForm.ServiceRequested = label19.Text;
            TransactionForm.BookingFee = txtBookingFee.Text;
            TransactionForm.Email = lblEmail.Text;
            

            this.Hide();
            TransactionForm.Show();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            GetInTouch ContactUsForm = new GetInTouch();
            ContactUsForm.Show();
        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Hair")
            {
                // Enable the ListBox if "Option 2" is selected
                Hair.Enabled = true;
                Nails.Enabled = false;
                MakeUp.Enabled = false;
                txtBookingFee.Text = "500";
                label17.Text = "Hair Installation";
                label4.Text = "3012";
            }
            else if (comboBox1.SelectedItem.ToString() == "Nails")
            {
                Nails.Enabled = true;
                MakeUp.Enabled = false;
                Hair.Enabled = false;
                txtBookingFee.Text = "150";
                label17.Text = "Nails";
                label4.Text = "3013";
            }
            else if (comboBox1.SelectedItem.ToString() == "Make Up")
            {
                MakeUp.Enabled = true;
                Hair.Enabled = false;
                Nails.Enabled = false;
                txtBookingFee.Text = "300";
                label17.Text = "Make UP";
                label4.Text = "3014";
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
            try
            {
                string selectedDate = Convert.ToString(monthCalendar2.SelectionStart);
                string Year = selectedDate.Substring(0, 4);
                string Month = selectedDate.Substring(5, 2);
                string Day = selectedDate.Substring(8, 2);
                selectedDate = Year + "-" + Month + "-" + Day;
                taPrevApp.Fill(dsAppSch.PreviousAppointment, selectedDate);


            }
            catch (Exception)
            {

                MessageBox.Show("Please select a date with booking");
            }
        }

        private void fillByAvailableTimeSlotToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.timeSlotTableAdapter.FillByAvailableTimeSlot(this.dsAppSch.TimeSlot);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            string selectedDate = Convert.ToString(monthCalendar2.SelectionStart);
            string Year = selectedDate.Substring(0, 4);
            string Month = selectedDate.Substring(5, 2);
            string Day = selectedDate.Substring(8, 2);
            selectedDate = Year + "-" + Month + "-" + Day;
            //taPrevApp.Fill(dsAppSch.PreviousAppointment, selectedDate);
            // taAvailableSlot.FillByAvailableTimeslot2(dsAppSch.DTTimeSlotAvailable, selectedDate);
            //dtTimeSlotAvailableTableAdapter1.FillByAvailableTimeSlot(dsAppSch.DTTimeSlotAvailable, selectedDate);
            appointment1TableAdapter1.FillByDate(dsAppSch.Appointment1, selectedDate);
            timeSlotTableAdapter.Fill(dsAppSch.TimeSlot);
            comboBox2.Items.Clear();
            for(int i=0; i<dsAppSch.TimeSlot.Rows.Count; i++)
            {
                comboBox2.Items.Add(dsAppSch.TimeSlot.Rows[i][1]);

            }
            for (int i = 0; i < dsAppSch.Appointment1.Rows.Count; i++)
            {
                string txtRemove = dsAppSch.Appointment1.Rows[i][3].ToString();


                // Loop through the ComboBox items in reverse to avoid index issues while removing
                for (int k = comboBox2.Items.Count - 1; k >= 0; k--)
                {
                    // Get the item text
                    string itemText = comboBox2.Items[k].ToString();

                    // Compare with the textToRemove
                    if (itemText == txtRemove)
                    {
                        // Remove the item from the ComboBox
                        comboBox2.Items.RemoveAt(k);
                    }
                }

            }
            comboBox2.SelectedIndex = 0;
            //timeSlot1TableAdapter1.Fill(dsAppSch.TimeSlot1, )
            //try
            //{
            //    // Assuming dateString is the string representation of the date
            //    string dateString = selectedDate; // Replace this with your actual date string

            //    //string query = "SELECT * FROM YourTable WHERE CONVERT(date, YourStringDateColumn, 120) = @Date";
            //    string query = @"SELECT TimeID, TimeSlot FROM TimeSlot WHERE(TimeID NOT IN (SELECT        TimeID
            //                   FROM            Appointment
            //                   WHERE (CONVERT(date, appointment_Date, 120) = @Date)))";
            //    adapter = new SqlDataAdapter(query, connection);
            //    adapter.SelectCommand.Parameters.AddWithValue("@Date", dateString);
            //    ds.Clear();
            //    adapter.Fill(ds, "TimeSlot");
            //    //dataGridView1.DataSource = ds.Tables["YourTable"];
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error loading data: " + ex.Message);
            //}
            label20.Text = monthCalendar2.SelectionStart.ToShortDateString();
            if (monthCalendar2.SelectionRange.Start < DateTime.Today)
            {
                MessageBox.Show("We can only allow booking for upcoming dates. Please reselect the date.");
            }


        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (Hair.SelectedIndex >= 0)
            {
                label17.Text = "Hair Installation";
                label19.Text = Hair.SelectedItem.ToString();
            }
            else if (Nails.SelectedIndex >= 0)
            {
                label17.Text ="Nails";
                label19.Text = Nails.SelectedItem.ToString();
            }
            else if(MakeUp.SelectedIndex >= 0)
            {
                label17.Text = "Make UP";
                label19.Text = MakeUp.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Please select service type");
            }

            //if (comboBox1.SelectedItem.ToString() == "Hair")
            //{
            //    // Enable the ListBox if "Option 2" is selected
            //    Hair.Enabled = true;
            //    Nails.Enabled = false;
            //    MakeUp.Enabled = false;
            //    txtBookingFee.Text = "500";
            //    label17.Text = "Hair Installation";
            //    label4.Text = "3012";
            //}
            //else if (comboBox1.SelectedItem.ToString() == "Nails")
            //{
            //    Nails.Enabled = true;
            //    MakeUp.Enabled = false;
            //    Hair.Enabled = false;
            //    txtBookingFee.Text = "150";
            //    label17.Text = "Nails";
            //    label4.Text = "3013";
            //}
            //else if (comboBox1.SelectedItem.ToString() == "Make Up")
            //{
            //    MakeUp.Enabled = true;
            //    Hair.Enabled = false;
            //    Nails.Enabled = false;
            //    txtBookingFee.Text = "300";
            //    label17.Text = "Make UP";
            //    label4.Text = "3014";
            //}
            try
            {
                timeSlotTableAdapter.Fill(dsAppSch.TimeSlot);
                for (int i = 0; i < dsAppSch.TimeSlot.Rows.Count; i++)
                {
                    string time = dsAppSch.TimeSlot.Rows[i][1].ToString();
                    if (time == comboBox2.Text)
                    {
                        lblTimeID.Text = dsAppSch.TimeSlot.Rows[i][0].ToString();
                    }

                }
                label12.Text = lblTimeID.Text;
            }
            catch (Exception)
            {

                MessageBox.Show("Please select the time slot");
            }
            int Cust_ID = Convert.ToInt32(label10.Text);
            //string app_Type = label17.Text;
            //string App_Time = label18.Text;
            int staff_ID = Convert.ToInt32(label4.Text);
            decimal amount_Due = Convert.ToDecimal(txtBookingFee.Text);
            //service_Req = label19.Text;
            //string booking_ref = label11.Text;
            int Time_ID = Convert.ToInt32(lblTimeID.Text);
            string App_Date = label20.Text;
            string timeslot = Convert.ToString(label18.Text);
            //string hour = timeslot.Substring(0, 2);
            //string minutes = timeslot.Substring(3, 2);
            //timeslot = hour + ":" + minutes + ":00";
            string randomReference = GenerateRandomReference();

           
            //timeSlotTableAdapter.FillByTimeSlot(dsAppSch.TimeSlot, Convert.ToString(comboBox2.SelectedValue));
            //if (dsAppSch.TimeSlot.Rows.Count > 0)
            //{
            //    lblTimeID.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            //}
            //else
            //{
            //    MessageBox.Show("Please select the correct timeslot");
            //}
            
             

            if (monthCalendar2.SelectionRange.Start < DateTime.Today)
            {
                MessageBox.Show("We can only allow booking for upcoming dates. Please reselect the date.");
            }
            else
            {
                DialogResult result = MessageBox.Show("Do you want to confirm the appointment booking?", "Appointment Confirm", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    appointment1TableAdapter1.Insert(Cust_ID, label17.Text.ToString(), timeslot, monthCalendar2.SelectionStart.Date, staff_ID, amount_Due, Convert.ToString(label19.Text), randomReference, Time_ID);
                    //appointmentTableAdapter1.Insert(Cust_ID, label17.Text.ToString(), TimeSpan.Parse(timeslot.ToString()), monthCalendar2.SelectionStart.Date, staff_ID, amount_Due, Convert.ToString(label19.Text), randomReference, Time_ID);
                    MessageBox.Show(lblCusName.Text + " " + lblCusSName.Text + " your appointment has been scheduled for the " + monthCalendar2.SelectionStart.ToShortDateString() + " at " + timeslot + " for " + label19.Text.ToString() + ".");
                    //timeSlotTableAdapter.FillByTimeSlot(dsAppSch.TimeSlot, Convert.ToString(comboBox2.SelectedValue));
                    string selectedDate = Convert.ToString(monthCalendar2.SelectionStart);
                    string Year = selectedDate.Substring(0, 4);
                    string Month = selectedDate.Substring(5, 2);
                    string Day = selectedDate.Substring(8, 2);
                    selectedDate = Year + "-" + Month + "-" + Day;
                    //taPrevApp.Fill(dsAppSch.PreviousAppointment, selectedDate);
                    //taAvailableSlot.FillByAvailableTimeslot2(dsAppSch.DTTimeSlotAvailable, selectedDate);
                    //dtTimeSlotAvailableTableAdapter1.FillByAvailableTimeSlot(dsAppSch.DTTimeSlotAvailable, selectedDate);
                    appointment1TableAdapter1.FillByDate(dsAppSch.Appointment1, selectedDate);
                    timeSlotTableAdapter.Fill(dsAppSch.TimeSlot);
                    comboBox2.Items.Clear();
                    for (int i = 0; i < dsAppSch.TimeSlot.Rows.Count; i++)
                    {
                        comboBox2.Items.Add(dsAppSch.TimeSlot.Rows[i][1]);

                    }
                    for (int i = 0; i < dsAppSch.Appointment1.Rows.Count; i++)
                    {

                        string txtRemove = dsAppSch.Appointment1.Rows[i][3].ToString();
                        

                        // Loop through the ComboBox items in reverse to avoid index issues while removing
                        for (int k = comboBox2.Items.Count - 1; k >= 0; k--)
                        {
                            // Get the item text
                            string itemText = comboBox2.Items[k].ToString();

                            // Compare with the textToRemove
                            if (itemText == txtRemove)
                            {
                                // Remove the item from the ComboBox
                                comboBox2.Items.RemoveAt(k);
                            }
                        }

                    }
                    comboBox2.SelectedIndex = 0;
                    appointment1TableAdapter1.Fill(dsAppSch.Appointment1);
                }

            }


            //try
            //{

            //    label12.Text = comboBox2.SelectedValue.ToString();
            //}
            //catch (Exception)
            //{

            //    MessageBox.Show("Please select the time slot");
            //}

            timeSlot2TableAdapter1.FillByTimeSlot(dsAppSch.TimeSlot2, label12.Text);
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // DateTime selectedDate = dateTimePicker1.Value;
            //taAvailableSlot.FillByAvailableTimeSlot(dsAppSch.DTTimeSlotAvailable, Convert.ToString(selectedDate));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //comboBox1.SelectedIndex = -1;
            // Hair.ClearSelected();
            //MakeUp.ClearSelected();
            //Nails.ClearSelected();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //taPrevApp.FillByName(dsAppSch.PreviousAppointment, textBox1.Text);
        }

        private void label10_Click(object sender, EventArgs e)
        {
            //label10.Text =dataGridView1.CurrentCell[]
        }
        //public string LabelText
        //{
        //    get { return label10.Text; }
        //}

        private void Hair_SelectedIndexChanged(object sender, EventArgs e)
        {
            label19.Text = Hair.SelectedItem.ToString();
        }

        private void Nails_SelectedIndexChanged(object sender, EventArgs e)
        {
            label19.Text = Nails.SelectedItem.ToString();
        }

        private void MakeUp_SelectedIndexChanged(object sender, EventArgs e)
        {
            label19.Text = MakeUp.SelectedItem.ToString();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            string randomReference = GenerateRandomReference();

            // Set the generated reference to the label
            label11.Text = randomReference;
        }
        private string GenerateRandomReference()
        {
            Random random = new Random();
            StringBuilder reference = new StringBuilder();

            // Generate 2 random numbers
            for (int i = 0; i < 2; i++)
            {
                reference.Append(random.Next(0, 10));
            }

            // Generate 2 random letters
            for (int i = 0; i < 2; i++)
            {
                reference.Append((char)random.Next('A', 'Z' + 1));
            }

            // Generate 2 random numbers
            for (int i = 0; i < 2; i++)
            {
                reference.Append(random.Next(0, 10));
            }

            // Generate 2 random letters
            for (int i = 0; i < 2; i++)
            {
                reference.Append((char)random.Next('A', 'Z' + 1));
            }

            return reference.ToString();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string selectedDate = Convert.ToString(monthCalendar2.SelectionStart);
            string Year = selectedDate.Substring(0, 4);
            string Month = selectedDate.Substring(5, 2);
            string Day = selectedDate.Substring(8, 2);
            selectedDate = Year + "-" + Month + "-" + Day;
            selectedDate = label20.Text;

            //ring timeslot = label11.Text;
            try
            {

                label12.Text = comboBox2.SelectedValue.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Please select the time slot");
            }
            string timeslot = label12.Text;
            string hour = timeslot.Substring(0, 2);
            string minut = timeslot.Substring(3, 2);
            string app_Time = hour + ":" + minut + ":" + "00";
            label18.Text = app_Time;

            string randomReference = GenerateRandomReference();

            // Set the generated reference to the label
            label11.Text = randomReference;

            //string labelText = LabelText;
            //label10.Text = labelText;
            //gin1.instance.lblCustID1.Text = label10.Text;

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{

            //    label12.Text = comboBox2.SelectedValue.ToString();
            //}
            //catch (Exception)
            //{

            //    MessageBox.Show("Please select the time slot");
            //}

            //timeSlot2TableAdapter1.FillByTimeSlot(dsAppSch.TimeSlot2, label12.Text);
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void orderProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            SignUp frm = new SignUp();
            frm.Show();
        }

        private void orderProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Ordering orderForm = new Ordering();
            orderForm.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            //string randomReference = GenerateRandomReference();
            //randomReference = label11.Text;
            //try
            //{
            //    label12.Text = comboBox2.SelectedValue.ToString();
            //}
            //catch (Exception)
            //{

            //    MessageBox.Show("Please select the time slot");
            //}
            //string timeslot = Convert.ToString(label12.Text);
            //string hour = timeslot.Substring(0, 2);
            //string minutes = timeslot.Substring(3, 2);
            //timeslot = hour + ":" + minutes + ":00";
            //MessageBox.Show(timeslot.ToString());
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            //string randomReference = GenerateRandomReference();
            //randomReference = label11.Text;
            ////try
            ////{
            ////    label12.Text = comboBox2.SelectedValue.ToString();
            ////}
            ////catch (Exception)
            ////{

            ////    MessageBox.Show("Please select the time slot");
            ////}
            //string timeslot = Convert.ToString(label12.Text);
            //string hour = timeslot.Substring(0, 2);
            //string minutes = timeslot.Substring(3, 2);
            //timeslot = hour + ":" + minutes + ":00";
            //MessageBox.Show(timeslot.ToString());

            try
            {
                //taPrevApp.FillBy1(dsAppSch.PreviousAppointment, textBox1.Text);
                dataTable1TableAdapter.FillByName(dsAppSch.DataTable1, textBox1.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Please enter valid Customer name");
            }
            
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //timeSlotTableAdapter.FillByTimeSlot(dsAppSch.TimeSlot, Convert.ToString(comboBox2.SelectedValue));
            //if (dsAppSch.TimeSlot.Rows.Count > 0)
            //{
            //    lblTimeID.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            //}
            //else
            //{
            //    MessageBox.Show("Please select the correct timeslot");
            //}
            label18.Text = comboBox2.Text;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Hair_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Get the value of the cell in the selected row, for example, the "Name" column
                string CustID  = selectedRow.Cells[0].Value.ToString();
                string CustSName = selectedRow.Cells[2].Value.ToString();
                string CustName = selectedRow.Cells[1].Value.ToString();
                string cusEmail = selectedRow.Cells[4].Value.ToString();

                // Display the value in the label
                label10.Text = CustID;
                lblCusName.Text = CustName;
                lblCusSName.Text = CustSName;
                lblEmail.Text = cusEmail;
            }
        }

        private void lblCusName_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                label10.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                lblCusName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                lblCusSName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                lblEmail.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
            tabControl1.SelectedTab = tabPage1;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp frm1 = new SignUp();
            frm1.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    taAppInnerJoin1.FillByAppID(dsAppSch.Appointment, Convert.ToInt16(textBox2.Text));
            //}
            //catch
            //{
            //    MessageBox.Show("Please ensure that you've entered the correct appointment number");
            //}
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            //try
            //{
            //    taAppInnerJoin1.DeleteQuery(Convert.ToInt32(dgvCncl.CurrentRow.Cells[0].Value));
            //    string selectedDate = Convert.ToString(monthCalendar2.SelectionStart);
            //    string Year = selectedDate.Substring(0, 4);
            //    string Month = selectedDate.Substring(5, 2);
            //    string Day = selectedDate.Substring(8, 2);
            //    selectedDate = Year + "-" + Month + "-" + Day;
            //    taAvailableSlot.FillByAvailableTimeSlot(dsAppSch.DTTimeSlotAvailable, selectedDate);
            //    MessageBox.Show("The appointment you selected has been deleted and the available timeslot has been updated");
            //}
            //catch
            //{
            //    MessageBox.Show("There was a problem cancelling the appointment please try again later");
            //}
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void dgvCncl_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                taAppInnerJoin1.DeleteQuery(Convert.ToInt32(dgvCncl.CurrentRow.Cells[0].Value));
                taAvailableSlot.FillByAvailableTimeSlot(dsAppSch.DTTimeSlotAvailable, Convert.ToString(dgvCncl.CurrentRow.Cells[4].Value));
                // taPrevApp.FillBy2(dsAppSch.PreviousAppointment, Convert.ToInt16(dgvCncl.CurrentRow.Cells[2].Value));
                appointment1TableAdapter1.Fill(dsAppSch.Appointment1);
                MessageBox.Show("The appointment you selected has been deleted and the available timeslot has been updated");
            }
            catch
            {
                MessageBox.Show("There was a problem cancelling the appointment please try again later");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                taAppInnerJoin1.FillByAppID(dsAppSch.Appointment, Convert.ToInt16(textBox2.Text));
            }
            catch
            {
                MessageBox.Show("Please ensure that you've entered the correct appointment number");
            }
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtBookingFee_TextChanged(object sender, EventArgs e)
        {

        }
    }
}