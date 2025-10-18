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
    public partial class GetInTouch : Form
    {
        public GetInTouch()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void GetInTouch_Load(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHomePage Homeform = new frmHomePage();
            Homeform.Show();
        }

        private void staffLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login1 LoginForm = new Login1();
            LoginForm.Show();
        }

        private void bookAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transation TransactionForm = new Transation();
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

        private void bookAnAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
