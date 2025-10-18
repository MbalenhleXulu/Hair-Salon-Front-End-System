using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaZieRange_Appointment_System
{
    public partial class Login1 : Form
    {
        public static string lblCusID;
        public Login1()
        {
            InitializeComponent();
        }

        private void Login1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appointmentScheduleDataSet.Customer' table. You can move, or remove it, as needed.
            this.taStaff.Fill(this.salonDataSet.Staff);
            // TODO: This line of code loads data into the 'salonDataSet.Customer' table. You can move, or remove it, as needed.
            this.taStaff.Fill(this.salonDataSet.Staff);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHomePage HomeForm = new frmHomePage();
            HomeForm.Show();
        }

        private void staffLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void bookAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblCusID = lblCust_ID.Text;
            this.Hide();
            BookingAppointment BookingForm = new BookingAppointment();
            BookingForm.Show();
        }

        private void orderProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ordering OrderForm = new Ordering();
            OrderForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            taStaff.FillByLogin(salonDataSet.Staff, txtUserName.Text, txtPassWord.Text);
            if (salonDataSet.Staff.Rows.Count > 0)
            {
                MessageBox.Show("Welcome to Die Zie Range!! You can now make an appointment or place an order by clicking the services button.");
                bookAppointmentToolStripMenuItem.Enabled = true;
                orderProductsToolStripMenuItem.Enabled = true;
                bookAnAppointmentToolStripMenuItem.Enabled = true;
                txtPassWord.Clear();
                txtUserName.Clear();
                lblCust_ID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

               
              BookingAppointment BookingForm = new BookingAppointment();
              BookingForm.Show();

            }
            else
            {
                MessageBox.Show("Incorrect log in details.Please re-enter your details or sign up if you do not have an account.");
            }
        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignUp frm1 = new SignUp();
            frm1.Show();
        }

        private void bookAppointmentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            lblCusID = lblCust_ID.Text;
            this.Hide();
            BookingAppointment AppointmentForm = new BookingAppointment();
            AppointmentForm.Show();

        }

        private void orderProductsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Ordering OrderForm = new Ordering();
            OrderForm.Show();
        }

        private void homeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmHomePage from = new frmHomePage();
            from.Show();
        }

        private void staffLoginToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            GetInTouch form = new GetInTouch();
            form.Show();
        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtPassWord_TextChanged(object sender, EventArgs e)
        {

        }

        private void salonDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lblCust_ID_Click(object sender, EventArgs e)
        {

        }
    }
}
