using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BagShop
{
    public partial class BagShopGui : Form
    {
        Bags NewBags = new Bags();
        Shippment NewShippment = new Shippment();

        public BagShopGui()
        {
            InitializeComponent();
        }


        private void BagShopGui_Load(object sender, EventArgs e)
        {
            
            for (int i = 0; i < NewBags.bagList.Length; i++)
            {
               
                cmboBxBags.Items.Add(NewBags.bagList[i]);
            }

        }

        private void exitFileMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearOrderEditMenu_Click(object sender, EventArgs e)
        {
            NewBags.Name = "";
            NewBags.SelectedBag = "";
            NewBags.QuantitySelected = "";
            NewBags.Price = 0.0;
            NewShippment.ShippmentFee = 0.0;
            NewBags.TotalAmount = 0.0;
            MessageBox.Show("Entries Cleared.");
        }

        private void displayOrderViewMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Customer Name:" + " " + NewBags.Name + "\nBag Selection:" + " " + NewBags.SelectedBag +
                "\nQuantity:" + " " + NewBags.QuantitySelected +"\nBag(s) Price:"+" "+NewBags.Price.ToString("C") + "\nShippment Fee:"+" "+ NewShippment.ShippmentFee.ToString("C") +
                "\nTotalPayment:" + " "+ NewBags.TotalAmount.ToString("C"));

        }



        private void CalculatePrice(int index)
        {
            txtBxPrice.Text =( NewBags.Price * (index + 1)).ToString();
        }

        private void cmboBxQuantity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboBxBags.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a Bag");
                cmboBxBags.Focus();

                cmboBxQuantity.SelectedItem = null;

                return;
            }

         
            
                int index = cmboBxQuantity.SelectedIndex;
            

            if (index > -1)
            {
                CalculatePrice(index);
            }
            
            else
            {
                MessageBox.Show("Please Select Quantity!");

                return;

            }
          
        }

        private void btnSave_Click(object sender, EventArgs e)

        {


            //if (txtBxName.Text == "")
            //{
            //    MessageBox.Show("Please Enter your name");
            //    txtBxName.Focus();
            //    return;
            //}
            NewBags.Name = txtBxName.Text;


           
           if (cmboBxBags.SelectedIndex < 0 )
            {
                MessageBox.Show("Please select a Bag");
               
                cmboBxBags.Focus();
                return;
            }
          
            NewBags.SelectedBag = cmboBxBags.SelectedIndex.ToString();



           
            if (cmboBxQuantity.SelectedItem == null)
            {
                MessageBox.Show("Please select the Quantity.");
                cmboBxQuantity.Focus();
                return;
            }

          

            NewBags.QuantitySelected = cmboBxQuantity.Text;


            double inValue = NewShippment.ShippmentFee;
            if (!double.TryParse(txtBxShippmentFee.Text, out inValue))
            {
                MessageBox.Show("Please Select Shippment Type!");
                cmboBxQuantity.Focus();
                return;
            }
            if(inValue <= 0)
            {
                MessageBox.Show("Please enter Quantity and Shippment type");
                cmboBxQuantity.Focus();
                return;
            }

            NewShippment.ShippmentFee = inValue;

           
                NewBags.TotalAmount = double.Parse(txtBxTotalPayment.Text);


            double ivalue;
            double.TryParse(txtBxPrice.Text, out ivalue);
            
            NewBags.Price = ivalue;



                dataGridViewTable.ColumnCount = 5;

                dataGridViewTable.Columns[0].Name = "Bag Type";
                dataGridViewTable.Columns[1].Name = "Quantity";
                dataGridViewTable.Columns[2].Name = "Price";
                dataGridViewTable.Columns[3].Name = "Shippment Fee";
                dataGridViewTable.Columns[4].Name = "Total Payment";

                string[] row = new string[] { cmboBxBags.SelectedItem.ToString(),cmboBxQuantity.SelectedItem.ToString(),
            txtBxPrice.Text,txtBxShippmentFee.Text,txtBxTotalPayment.Text};
                dataGridViewTable.Rows.Add(row);


            cmboBxQuantity.Text = "";
            txtBxName.Text = "";
            txtBxPrice.Text = "";
            txtBxShippmentFee.Text = "";
            txtBxTotalPayment.Text = "";
        }

        
        private void SetPrice(int index)
        {
            NewBags.Price = NewBags.bagPrice[index];
        }
       

        private void ShippmentType_CheckedChanged(object sender, EventArgs e)
        {
            if (cmboBxQuantity.SelectedItem == null)
            {
                MessageBox.Show("Please select Quantity");
                txtBxShippmentFee.Text = "";
                txtBxTotalPayment.Text = "";

                cmboBxQuantity.Focus();
                return;
            }

            if (radBxOvernight.Checked)
            {
                string shipment = NewShippment.OverNight.ToString();
                txtBxShippmentFee.Text = CalculateShippmentFee(shipment).ToString();
                txtBxTotalPayment.Text = CalculateTotalPayment().ToString();
            }
            else if (radBx3Day.Checked)
            {
                string shipment = NewShippment._3Day.ToString();
                txtBxShippmentFee.Text = CalculateShippmentFee(shipment).ToString();
                txtBxTotalPayment.Text = CalculateTotalPayment().ToString();
            }
            else if(radBxStandard.Checked)
          
            { 
            
                string shipment = NewShippment.Standard.ToString();
                txtBxShippmentFee.Text = CalculateShippmentFee(shipment).ToString();
                txtBxTotalPayment.Text = CalculateTotalPayment().ToString();
            }
            
        }
        public double CalculateShippmentFee(string shippment)
        {
            double inPrice;
            double inValue;
            double.TryParse(shippment, out inValue);
            double.TryParse(txtBxPrice.Text, out inPrice);
            inValue = inPrice * (inValue / 100);
            return inValue;
        }
        public double CalculateTotalPayment()
        {
            double payment;
            double price;
            double shipmentfee;
            double.TryParse(txtBxPrice.Text, out price);
            double.TryParse(txtBxShippmentFee.Text, out shipmentfee);
            payment = price + shipmentfee;

            return payment;
        }

        private void cmboBxBags_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            int index = cmboBxBags.SelectedIndex;
            if (index > -1)
            {
                SetPrice(index);
            }

            else
            {
                MessageBox.Show("Please Select a Bag!");
               
                cmboBxBags.Focus();
                return;
            }
           
           
            
        }


    }
}
