using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DaZieRange_Appointment_System
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtSurname.Text) && !string.IsNullOrEmpty(txtEmail.Text) && !string.IsNullOrEmpty(txtAddress.Text) && !string.IsNullOrEmpty(txtID.Text) && (txtID.Text.Length < 13) && !string.IsNullOrEmpty(txtPhoneNum.Text))
                {
                    taCustomer.Insert(txtSurname.Text, txtName.Text, txtEmail.Text, txtAddress.Text, txtPhoneNum.Text, txtID.Text);
                    MessageBox.Show("You have been successfully signed up!!");
                    txtAddress.Clear();
                    txtName.Clear();
                    txtSurname.Clear();
                    txtEmail.Clear();
                    txtID.Clear();
                    txtPhoneNum.Clear();

                    this.Hide();
                    BookingAppointment BookingForm = new BookingAppointment();
                    BookingForm.Show();

                   
                }
                  
           }
           catch
           {
                MessageBox.Show("Invalid customer details. Please try again");
                txtAddress.Clear();
                txtName.Clear();
                txtSurname.Clear();
                txtEmail.Clear();
                txtID.Clear();
                txtPhoneNum.Clear();
            }
            


        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHomePage form = new frmHomePage();
            form.Show();
        }

        private void staffLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login1 from = new Login1();
            from.Show();
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

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            // Get the text from the TextBox
            string firstName = txtName.Text;

            // Validate the first name
            if (IsValidFirstName(firstName))
            {
                // Optional: Display success message or change appearance
                label4.Text = "Valid Name";
                label4.ForeColor = System.Drawing.Color.Green;

            }
            else
            {
                // Optional: Display error message or change appearance
                label4.Text = "Invalid Name";
                label4.ForeColor = System.Drawing.Color.Red;

            }

        }
        // Method to validate first name using Regex
        private bool IsValidFirstName(string firstName)
        {
            // Regex pattern for validating names that contain only letters
            string namePattern = @"^[a-zA-Z]+$";
            return Regex.IsMatch(firstName, namePattern);
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            // Get the text from the TextBox
            string lastName = txtSurname.Text;

            // Validate the last name
            if (IsValidLastName(lastName))
            {
                // Optional: Display success message or change appearance
                label3.Text = "Valid Last Name";
                label3.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                // Optional: Display error message or change appearance
                label3.Text = "Invalid Last Name";
                label3.ForeColor = System.Drawing.Color.Red;
            }
        }

        // Method to validate last name using Regex
        private bool IsValidLastName(string lastName)
        {
            // Regex pattern for validating names that contain only letters
            string namePattern = @"^[a-zA-Z]+$";
            return Regex.IsMatch(lastName, namePattern);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            String email = txtEmail.Text;

            if (IsValidEmail(email))
            {
                // Optional: Display success message or change appearance
                label2.Text = "Valid Email";
                label2.ForeColor = System.Drawing.Color.Green;

            }
            else
            {
                // Optional: Display error message or change appearance
                label2.Text = "Invalid Email";
                label2.ForeColor = System.Drawing.Color.Red;

            }


        }
        // Method to validate email using Regex
        private bool IsValidEmail(string email)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);

        }

        private void txtPhoneNum_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtID_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}


