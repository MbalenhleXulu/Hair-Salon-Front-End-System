using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace DaZieRange_Appointment_System
{
    public partial class Ordering : Form
    {




        public Ordering()
        {
            InitializeComponent();



        }
        public int ValueB
        {
            get
            {
                int value = 0;
                int.TryParse(textBox6.Text, out value);  // Assuming textBox1 is the name of the textbox
                return value;
            }
        }

        private void Ordering_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'newData1.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.newData1.Customer);
            // TODO: This line of code loads data into the 'salonDataSet.Customer' table. You can move, or remove it, as needed.
            //this.customerTableAdapter1.Fill(this.salonDataSet3.Customer);
            // TODO: This line of code loads data into the 'salonDataSet1.Customer' table. You can move, or remove it, as needed.
            //this.customerTableAdapter.Fill(this.salonDataSet1.Customer);
            product_2TableAdapter1.Fill(salonDataSet1.Product_2);
            //customerTableAdapter1.Fill(dataSetCart4.Customer);
            ////orderTableAdapter1.Fill(salonDataSet2.Order);
            tabPage2.Hide();
            tabPage3.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                product_2TableAdapter1.Insert(Convert.ToInt32(textBox1.Text), textBox3.Text, Convert.ToDecimal(textBox2.Text), Convert.ToDecimal(textBox4.Text), comboBox1.SelectedValue.ToString());
                MessageBox.Show("new Product Added to The Database");
                product_2TableAdapter1.Fill(salonDataSet1.Product_2);
            }
            catch (Exception)
            {
                MessageBox.Show("new Product NOT Added to The Database");

            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            product_2TableAdapter1.FillByName(salonDataSet1.Product_2, textBox5.Text);
        }

        private void dataGridView2_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataRow dr;
            dr = dataSetCart1.DTCart.NewRow();
            for (int i = 0; i < dr.ItemArray.Length; i++)
            {
                dr[i] = dataGridView2.CurrentRow.Cells[i].Value;
            }
            dataSetCart1.DTCart.Rows.Add(dr);
            textBox6.Text = GetTotal().ToString();

        }
        private decimal GetTotal()
        {
            decimal sum = 0;
            for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
            {
                sum += Convert.ToDecimal(dataGridView3.Rows[i].Cells[2].Value);
            }

            return sum;
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            dataSetCart1.Clear();
            textBox6.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // recordOrderTableAdapter1.Insert(Convert.ToDecimal(textBox6.Text), DateTime.Now);
                // taOrder1.Insert(Decimal.Parse(textBox6.Text, NumberStyles.Currency), DateTime.Now);  

                int Product_ID = (int)dataGridView3.CurrentRow.Cells[0].Value;
                int Cus_ID = Convert.ToInt32(Login1.lblCusID);
                DateTime orderDate = DateTime.Now;
                int order_Quantity = (int)dataGridView3.CurrentRow.Cells[3].Value;

                decimal amount = Convert.ToDecimal(textBox6.Text);

                //taOrder1.InsertQuery(Product_ID, Cus_ID, orderDate, order_Quantity, amount);


                MessageBox.Show("Order has been confirmed");
                // taOrder1.Fill(dataSetCart1.Order1);


            }
            catch (Exception)
            {
                MessageBox.Show(" error !!: check your Order and try again");



            }

            this.Hide();
            Transation TransactionForm = new Transation();
            TransactionForm.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //taOrder1.FillByDate(dataSetCart1.Order1,dateTimePicker1.Value);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void button5_Click(object sender, EventArgs e)
        {

            try
            {


                // Assign next order_ID by incrementing the last order_ID

                // Retrieve necessary values
                ///int customerID = Convert.ToInt32(Login1.lblCusID);  // Customer ID from login form's label
                int customerID = 1111;


                // Handling potential null or invalid value for product ID
                int productID = 0;
                if (dataGridView3.CurrentRow.Cells[0].Value != DBNull.Value)
                {
                    productID = Convert.ToInt32(dataGridView3.CurrentRow.Cells[0].Value);
                }
                else
                {
                    MessageBox.Show("Invalid Product ID.");
                    return;  // Exit method if Product ID is invalid
                }

                // Handling potential null or empty value for product name


                // Get current date and time
                DateTime orderDate = DateTime.Now;

                // Handling potential invalid or null value for order quantity
                int orderQuantity = 0;
                if (dataGridView3.CurrentRow.Cells[3].Value != DBNull.Value &&
                    int.TryParse(dataGridView3.CurrentRow.Cells[3].Value.ToString(), out orderQuantity))
                {
                    // Successfully parsed the order quantity
                }
                else
                {
                    MessageBox.Show("Invalid order quantity.");
                    return;  // Exit method if Order Quantity is invalid
                }

                // Handling potential invalid or non-numeric value for order amount
                decimal orderAmount = 0;
                if (decimal.TryParse(textBox6.Text, out orderAmount))
                {
                    // Successfully parsed the order amount
                }
                else
                {
                    MessageBox.Show("Invalid order amount.");
                    return;  // Exit method if Order Amount is invalid
                }


                //// Create a new row in the Order DataTable within the dataset
                //DataRow newRow = dataSetCart3.Order1.NewRow();

                //// Assign values to the new row

                //newRow["product_ID"] = productID;
                //newRow["customer_ID"] = customerID;
                //newRow["order_Date"] = orderDate;
                //newRow["order_Quantity"] = orderQuantity;
                //newRow["order_Amount"] = orderAmount;


                //// Add the new row to the Order DataTable
                //salonDataSet2.Order.Rows.Add(newRow);

                //// Save changes from the DataTable to the database
                //orderTableAdapter1.Update(salonDataSet2.Order);

                //MessageBox.Show("Order has been confirmed.");
                string productName;
                if (dataGridView3.CurrentRow.Cells[1].Value != DBNull.Value)
                {
                    productName = Convert.ToString(dataGridView3.CurrentRow.Cells[0].Value);
                }
                else
                {
                    MessageBox.Show("Invalid Product ID.");
                    return;  // Exit method if Product ID is invalid
                }
                try
                {
                    order1TableAdapter1.InsertQueryOne(productID, customerID, orderDate, orderAmount, orderQuantity, productName);
                    MessageBox.Show("Your order has been placed successfullly ");
                    order1TableAdapter1.Fill(dataSetCart3.Order1);
                }
                catch
                {
                    MessageBox.Show("unable to process transaction");
                };


                // Optionally, refresh the dataset to show the new entry in the UI if bound to a DataGridView
                order1TableAdapter1.Fill(dataSetCart3.Order1);
            }
            catch (Exception ex)
            {
                // Display error message if there is an issue with the operation
                MessageBox.Show($"Error recording order: {ex.Message}");
            }
            DataRow newRow = dataSetCart3.Order1.NewRow();

            //// Assign values to the new row
            //newRow["product_Name"] = productName;
        }







        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transation TransactionForm = new Transation();
            TransactionForm.Show();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                int customerID = 0;
                if (dataGridView4.CurrentRow?.Cells[0].Value != null &&
                    dataGridView4.CurrentRow.Cells[0].Value != DBNull.Value)
                {
                    customerID = Convert.ToInt32(dataGridView4.CurrentRow.Cells[0].Value);
                }
                else
                {
                    MessageBox.Show("Invalid customer ID.");
                    return;  // Exit method if Product ID is invalid
                }
                // Retrieve necessary values
                //int customer_ID = 1111;
                int customer_ID = Convert.ToInt32(label12.Text);

                // Handling potential null or invalid value for product ID
                int productID = 0;
                if (dataGridView3.CurrentRow?.Cells[0].Value != null &&
                    dataGridView3.CurrentRow.Cells[0].Value != DBNull.Value)
                {
                    productID = Convert.ToInt32(dataGridView3.CurrentRow.Cells[0].Value);
                }
                else
                {
                    MessageBox.Show("Invalid Product ID.");
                    return;  // Exit method if Product ID is invalid
                }

                // Get current date and time
                DateTime orderDate = DateTime.Now;

                // Handling potential invalid or null value for order quantity
                int orderQuantity = 0;
                if (dataGridView3.CurrentRow?.Cells[3].Value != null &&
                    int.TryParse(dataGridView3.CurrentRow.Cells[3].Value.ToString(), out orderQuantity))
                {
                    // Successfully parsed the order quantity
                }
                else
                {
                    MessageBox.Show("Invalid order quantity.");
                    return;  // Exit method if Order Quantity is invalid
                }

                // Handling potential invalid or non-numeric value for order amount
                decimal orderAmount = 0;
                if (decimal.TryParse(textBox6.Text, out orderAmount))
                {
                    // Successfully parsed the order amount
                }
                else
                {
                    MessageBox.Show("Invalid order amount.");
                    return;  // Exit method if Order Amount is invalid
                }
                string productName;
                if (dataGridView3.CurrentRow.Cells[1].Value != DBNull.Value)
                {
                    productName = Convert.ToString(dataGridView3.CurrentRow.Cells[0].Value);
                }
                else
                {
                    MessageBox.Show("Invalid Product ID.");
                    return;  // Exit method if Product ID is invalid
                }
                // Insert into order1 without productName
                try
                {
                    // Ensure InsertQueryOne matches the table schema (without product_Name)
                    orderTableAdapter1.InsertQuery1(productID, customer_ID, orderDate, orderQuantity, orderAmount, productName);
                    MessageBox.Show("Your order has been placed successfullly ");
                    orderTableAdapter1.Fill(salonDataSet2.Order);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unable to process transaction: {ex.Message}");
                }

                // Optionally, refresh the dataset to show the new entry in the UI if bound to a DataGridView
                orderTableAdapter1.Fill(salonDataSet2.Order);
            }
            catch (Exception ex)
            {
                // Display error message if there is an issue with the operation
                MessageBox.Show($"Error recording order: {ex.Message}");
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //taPrevApp.FillBy1(dsAppSch.PreviousAppointment, textBox1.Text);
                customerTableAdapter1.FillByName(salonDataSet2.Customer, textBox7.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Please enter valid Customer name");
            }

            //customerTableAdapter1.FillByName(salonDataSet3.Customer,textBox7.Text);
            //salonDataSet3.EnforceConstraints = true;
        }

        private void dataGridView4_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView5_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView4.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView4.SelectedRows[0];

                // Get the value of the cell in the selected row, for example, the "Name" column
                string Cust_ID = selectedRow.Cells[0].Value.ToString();
                //string CustSName = selectedRow.Cells[2].Value.ToString();
                //string CustName = selectedRow.Cells[1].Value.ToString();
                // string cusEmail = selectedRow.Cells[4].Value.ToString();

                // Display the value in the label
                label12.Text = Cust_ID;
                //lblCusName.Text = CustName;
                //lblCusSName.Text = CustSName;
                //lblEmail.Text = cusEmail;
            }
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView4.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView4.SelectedRows[0];

                // Get the value of the cell in the selected row, for example, the "Name" column
                string Cust_ID = selectedRow.Cells[0].Value.ToString();
                //string CustSName = selectedRow.Cells[2].Value.ToString();
                //string CustName = selectedRow.Cells[1].Value.ToString();
                // string cusEmail = selectedRow.Cells[4].Value.ToString();

                // Display the value in the label
                label12.Text = Cust_ID;
                //lblCusName.Text = CustName;
                //lblCusSName.Text = CustSName;
                //lblEmail.Text = cusEmail;

            }
        }
    }
}
    

















