using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class Form1 : Form
    {
        String OrderDetails = "{0, -50}, {1, -50}, {2, -50}, {3, -50}, {4, -50}";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Button Clicked!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

                lstOutput.Items.Add(String.Format(OrderDetails, "Customer ID", "Name", "Order Made", "Date Ordered", "Price"));
            cmbOrderMade.Items.Add("Select Order");
            cmbOrderMade.Items.Add("Account");
            cmbOrderMade.Items.Add("Telephone");
            cmbOrderMade.Items.Add("Instore Order");
            cmbOrderMade.Items.Add("Direct Debit");

            lstBrand.Items.Add("Japan");
            lstBrand.Items.Add("Tokyo");
            lstBrand.Items.Add("Chigoya");
            lstBrand.Items.Add("Nagoya");


        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnOrder(object sender, EventArgs e)
        {
            String ID, name, order, date, price;
            ID = txt_CustomerID.Text;
            name = txtName.Text;
            order = cmbOrderMade.Text;
            date = dateTimePicker1.Text;

            if (lstBrand.Text == "")
            {
                MessageBox.Show("You must select a brand", "Brands", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if ((chkBeans.Checked == false) && (chkMeat.Checked == false) && (chkRice.Checked == false)) {
                MessageBox.Show("You must select an item", "Items", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if ((rb1.Checked == false) && (rb2.Checked == false) && (rb3.Checked == false))
            {
                MessageBox.Show("You must select an quantity", "Quantity", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chkRice_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult Iexit = MessageBox.Show("Exit the App?", "Inventory System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Iexit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void chkFullSet_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFullSet.Checked)
            {
                chkBeans.Checked = true;
                chkRice.Checked = true;
                chkMeat.Checked = true;
            }
            else {
                chkBeans.Checked = false;
                chkRice.Checked = false;
                chkMeat.Checked = false;
            }
        }
    }
}
