using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace DaZieRange_Appointment_System
{
    public partial class Transation : Form
    {
        private BookingAppointment formA;
        private Ordering formB;

       
        public Transation()
        {
            InitializeComponent();
            //BookingAppointment formA = new BookingAppointment();
            //Ordering formB = new Ordering();
            //this.formB = formB;
        }
        
        public string Email
        {
            get { return lblEmail.Text; }
            set { lblEmail.Text = value; }
        }

        public string NameText
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        public string SurnameText
        {
            get { return lblSurname.Text; }
            set { lblSurname.Text = value; }
        }

        public string ApptType
        {
            get { return lblApptType.Text; }
            set { lblApptType.Text = value; }
        }

        public string ServiceRequested
        {
            get { return lblServiceReq.Text; }
            set { lblServiceReq.Text = value; }
        }

        public string BookingFee
        {
            get { return lblBookingFee.Text; }
            set { lblBookingFee.Text = value; }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            taPayment.InsertPayment(Convert.ToInt16(LblOrder_ID), Convert.ToInt16(lblAppt_ID), Convert.ToDecimal(lblBookingFee));
            
        }
        private void calcTotal()
        {
            BookingAppointment formA = new BookingAppointment();
            Ordering formB = new Ordering();
            int total = formA.ValueA + formB.ValueB;
            txtTotal.Text = total.ToString();
        }

        private void Transation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsSalon.Appointment' table. You can move, or remove it, as needed.
            //this.taAppointment.Fill(this.dsSalon.Appointment);
            calcTotal();
            this.taAppointment.Fill(this.dsSalon.Appointment);
            this.taOrder.Fill(this.dsSalon.Order);
            this.taAppointment.FillByDescAppID(this.dsSalon.Appointment);
            this.taOrder.FillByDescOrderID(this.dsSalon.Order);

            LblOrder_ID.Text = dataGridView2.CurrentRow.Cells[0].ToString();
            lblAppt_ID.Text = dataGridView1.CurrentRow.Cells[0].ToString();


            txtCart.Text = lblApptType.Text + Environment.NewLine + lblBookingFee.Text + Environment.NewLine + lblServiceReq.Text;
            txtTotal.Text = lblBookingFee.Text;

        }

        private void orderProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ordering OrderForm = new Ordering();
            OrderForm.Show();
        }

        private void bookAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookingAppointment BookingForm = new BookingAppointment();
            BookingForm.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHomePage HomePage = new frmHomePage();
            HomePage.Show();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            GetInTouch ContactForm = new GetInTouch();
            ContactForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("dnokubonga69@gmail.com");
                msg.To.Add(lblEmail.Text);
                msg.Subject = "Booking Confirmation";
                msg.Body = txtCart.Text;

                SmtpClient smt = new SmtpClient();
                smt.Host = "smtp.gmail.com";
                System.Net.NetworkCredential ntcd = new NetworkCredential();
                ntcd.UserName = "dnokubonga69@gmail.com";
                ntcd.Password = "tlxe gyqn ghdr pqao";
                smt.Credentials = ntcd;
                smt.EnableSsl = true;
                smt.Port = 587;
                smt.Send(msg);

                MessageBox.Show(" your confirmation email has been sent");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    }
    

  
    


    

