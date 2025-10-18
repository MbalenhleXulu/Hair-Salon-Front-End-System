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
    public partial class RegisterStaff : Form
    {
        public RegisterStaff()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {


                taStaff.InsertNewStaff(txtName.Text, txtAddress.Text, 
                    cmbType.SelectedValue.ToString(), mtxtNumber.Text, txtPassword.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("New Staff member could not be added. Try again");
                txtName.Focus();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            // Get the text from the TextBox
            string password = txtPassword.Text;

            // Validate the password
            if (IsValidPassword(password))
            {
                // Optional: Display success message or change appearance
                label1.Text = "Valid Password";
                label1.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                // Optional: Display error message or change appearance
                label1.Text = "Invalid Password";
                label1.ForeColor = System.Drawing.Color.Red;
            }
        }

        // Method to validate the password using Regex
        private bool IsValidPassword(string password)
        {
            // Define a regex pattern for a strong password:
            // Minimum 8 characters, at least one uppercase letter, one lowercase letter, one number, and one special character.
            string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
            return Regex.IsMatch(password, passwordPattern);
        }
    }
    }

