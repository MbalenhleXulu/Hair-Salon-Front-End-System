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
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string Name, Category;
            int Quantity;
            decimal Price;

            Name = txtName.Text;
            Category = cmbCategory.SelectedItem.ToString();
            Quantity = int.Parse(txtQuantity.Text);
            Price = decimal.Parse(txtPrice.Text);

            try
            {
                taProduct.InsertNewProduct(Name, Price, Quantity, Category);


            }
            catch (Exception)
            {
                MessageBox.Show("New product could not be added. Try again");
                txtName.Focus();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int Quantity;
            decimal Price;

            Quantity = int.Parse(txtQuantity.Text);
            Price = decimal.Parse(txtPrice.Text);

            try
            {
                taProduct.UpdateProductInfo(Price, Quantity, (int)dgvProduct.CurrentRow.Cells[2].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                txtName.Focus();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             try
            {
                taPrevApp.FillBy1(dsAppSch.PreviousAppointment, Convert.ToString(txtBookingSeach.Text));
            }
            catch (Exception)
            {

                MessageBox.Show("Please enter valid Customer name");
            }
        }

       

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            try
            {
                string selectedDate = Convert.ToString(monthCalendar1.SelectionStart);
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

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            try
            {
                string selectedDate = Convert.ToString(monthCalendar2.SelectionStart);
                string Year = selectedDate.Substring(0, 4);
                string Month = selectedDate.Substring(5, 2);
                string Day = selectedDate.Substring(8, 2);
                selectedDate = Year + "-" + Month + "-" + Day;
                taOrderInner.FillByDate(dsCart.OrderInnerJoin, selectedDate);
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a valid date.");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                taOrderInner.FillByName(dsCart.OrderInnerJoin, txtSearchOrder.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Please enter valid Customer name");
            }
        }
    }
}
