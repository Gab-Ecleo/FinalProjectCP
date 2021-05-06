using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace FinalProjectCP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DiscountType.Text = "None";

        }

        //Variables
        public ArrayList name = new ArrayList();
        public ArrayList listedQuantity = new ArrayList();
        public ArrayList listedPrice = new ArrayList();
        public double priceSum;
        public double discount;
        public double vat;
        public string nameText;

        private int counter;
             

        //Class
        public Form3 frm3 = new Form3();

        //Functions
        private void DisplayItems()
        {
            //clear variables to avoid duplicates
            NameTB.Clear();
            priceTB.Clear();
            QtyTB.Clear();
            counter = 0;

            foreach (string nam in name)
            {
                counter++;
            }

            for (int i = 0; i < counter; i++)
            {
                
                NameTB.Text += name[i].ToString() + "\n";
                QtyTB.Text += listedQuantity[i].ToString() + "\n";
                priceTB.Text += listedPrice[i].ToString() + "\n";
            }

        }

        //Discount Type
        private double TypeOfDiscount()
        {
            //declare variables
            string value = DiscountType.Text.ToString();
            double discountValue = 0;

            //Compare Discount Type
            if (value == "Senior")
                discountValue = .10;
            else if (value == "Student")
                discountValue = .20;
            else if (value == "None")
                discountValue = 0;

            //return value
            return discountValue;
        }

        //Compute Total price w/o discounts
        private double SumOfPrice()
        {
            int qty = -1;
            double price = 0;

            foreach (int num in listedQuantity)
            {
                qty++;
            }

            for (int i = 0; i <= qty; i++)
            {
                price += Convert.ToDouble(listedPrice[i]);
            }

            return price;
        }


        //Methods

        //Combo Meals
        private void AdoboComboAdd_Click(object sender, EventArgs e)
        {
            //add name to list
            name.Add("Adobo w/ Rice");

            //add quantity to list
            int qty = Convert.ToInt32(AdoboComboQty.Value);
            listedQuantity.Add(qty);


            //compute item price
            int initialPrice = 0;
            for (int i = 0; i < qty; i++)
            {
                initialPrice += 80;
            }

            //add item price to list
            listedPrice.Add(initialPrice);

            //List to tray
            DisplayItems();

            
        }


        private void SinigangComboAdd_Click(object sender, EventArgs e)
        {
            //add name to list
            name.Add("Sinigang w/ Rice");

            //add quantity to list
            int qty = Convert.ToInt32(SinigangComboQty.Value);
            listedQuantity.Add(qty);

            //compute item price
            int initialPrice = 0;
            for (int i = 0; i < qty; i++)
            {
                initialPrice += 80;
            }

            //add item price to list
            listedPrice.Add(initialPrice);

            //List to tray
            DisplayItems();

        }

        private void PakbetComboAdd_Click(object sender, EventArgs e)
        {
            //add name to list
            name.Add("Pinakbet w/ Rice");

            //add quantity to list
            int qty = Convert.ToInt32(PakbetComboQty.Value);
            listedQuantity.Add(qty);

            //compute item price
            int initialPrice = 0;
            for (int i = 0; i < qty; i++)
            {
                initialPrice += 70;
            }

            //add item price to list
            listedPrice.Add(initialPrice);

            //List to tray
            DisplayItems();

        }
        //Ala Carte Meals
        private void AdoboAdd_Click(object sender, EventArgs e)
        {
            //add name to list
            name.Add("Adobo\t\t");

            //add quantity to list
            int qty = Convert.ToInt32(AdoboQty.Value);
            listedQuantity.Add(qty);

            //compute item price
            int initialPrice = 0;
            for (int i = 0; i < qty; i++)
            {
                initialPrice += 75;
            }

            //add item price to list
            listedPrice.Add(initialPrice);

            //List to tray
            DisplayItems();

        }

        private void SinigangAdd_Click(object sender, EventArgs e)
        {
            //add name to list
            name.Add("Sinigang\t");

            //add quantity to list
            int qty = Convert.ToInt32(SinigangQty.Value);
            listedQuantity.Add(qty);

            //compute item price
            int initialPrice = 0;
            for (int i = 0; i < qty; i++)
            {
                initialPrice += 75;
            }

            //add item price to list
            listedPrice.Add(initialPrice);

            //List to tray
            DisplayItems();

        }

        private void PakbetAdd_Click(object sender, EventArgs e)
        {
            //add name to list
            name.Add("Pinakbet\t");

            //add quantity to list
            int qty = Convert.ToInt32(PakbetQty.Value);
            listedQuantity.Add(qty);

            //compute item price
            int initialPrice = 0;
            for (int i = 0; i < qty; i++)
            {
                initialPrice += 65;
            }

            //add item price to list
            listedPrice.Add(initialPrice);

            //List to tray
            DisplayItems();

        }

        //Beverages
        private void WaterAdd_Click(object sender, EventArgs e)
        {
            //add name to list
            name.Add("Water\t\t");

            //add quantity to list
            int qty = Convert.ToInt32(WaterQty.Value);
            listedQuantity.Add(qty);

            //compute item price
            int initialPrice = 0;
            for (int i = 0; i < qty; i++)
            {
                initialPrice += 20;
            }

            //add item price to list
            listedPrice.Add(initialPrice);

            //List to tray
            DisplayItems();

        }

        private void CokeAdd_Click(object sender, EventArgs e)
        {
            //add name to list
            name.Add("Coke\t\t");

            //add quantity to list
            int qty = Convert.ToInt32(CokeQty.Value);
            listedQuantity.Add(qty);

            //compute item price
            int initialPrice = 0;
            for (int i = 0; i < qty; i++)
            {
                initialPrice += 40;
            }

            //add item price to list
            listedPrice.Add(initialPrice);

            //List to tray
            DisplayItems();

        }

        private void IcedTeaAdd_Click(object sender, EventArgs e)
        {
            //add name to list
            name.Add("Iced Tea\t");

            //add quantity to list
            int qty = Convert.ToInt32(IcedTeaQty.Value);
            listedQuantity.Add(qty);

            //compute item price
            int initialPrice = 0;
            for (int i = 0; i < qty; i++)
            {
                initialPrice += 30;
            }

            //add item price to list
            listedPrice.Add(initialPrice);

            //List to tray
            DisplayItems();

        }

        //Desserts
        private void LecheFlanAdd_Click(object sender, EventArgs e)
        {
            //add name to list
            name.Add("Leche Flan\t");

            //add quantity to list
            int qty = Convert.ToInt32(LecheFlanQty.Value);
            listedQuantity.Add(qty);

            //compute item price
            int initialPrice = 0;
            for (int i = 0; i < qty; i++)
            {
                initialPrice += 30;
            }

            //add item price to list
            listedPrice.Add(initialPrice);

            //List to tray
            DisplayItems();

        }

        private void HaloHaloAdd_Click(object sender, EventArgs e)
        {
            //add name to list
            name.Add("Halo-Halo\t");

            //add quantity to list
            int qty = Convert.ToInt32(HaloHaloQty.Value);
            listedQuantity.Add(qty);

            //compute item price
            int initialPrice = 0;
            for (int i = 0; i < qty; i++)
            {
                initialPrice += 50;
            }

            //add item price to list
            listedPrice.Add(initialPrice);

            //List to tray
            DisplayItems();

        }

        //Add-Ons
        private void RiceAdd_Click(object sender, EventArgs e)
        {
            //add name to list
            name.Add("Extra Rice\t");

            //add quantity to list
            int qty = Convert.ToInt32(RiceQty.Value);
            listedQuantity.Add(qty);

            //compute item price
            int initialPrice = 0;
            for (int i = 0; i < qty; i++)
            {
                initialPrice += 20;
            }

            //add item price to list
            listedPrice.Add(initialPrice);

            //List to tray
            DisplayItems();

        }

        //Confirm order
        private void ConfirmOrder_Click(object sender, EventArgs e)
        {
            //assign value in variables
            priceSum = SumOfPrice();
            discount = TypeOfDiscount();

            //Compute Discounts
            vat = priceSum * .12;
            double discountedPrice = (priceSum * discount);
            double totalPrice = (priceSum - discountedPrice ) + vat;


            //Display receipt

            //declare total index inside the array
            
            counter = -1;

            foreach (int num in listedQuantity)
                counter++;

            if (counter < 0)
            {
                MessageBox.Show("Warning: You haven't ordered anything yet");
            }
            else
            {
                
                

                //display receipt
                frm3.ReceiptTB.Text += String.Format("======================================\n" +
                                                     "||                           Comfort Kitchen                         ||\n" +
                                                     "======================================\n" +
                                                     "{0,-10}\t\t{1,-5}\t\t{2,5}\n", "Name", "Quantity", "Price");

                for (int i = 0; i <= counter; i++)
                {
                    nameText = String.Format("{0,-10}\t\t{1,-5}\t\t{2,5}\n", name[i].ToString(), listedQuantity[i].ToString(), "₱"+listedPrice[i].ToString());

                    frm3.ReceiptTB.Text += nameText; 
                }

                frm3.ReceiptTB.Text += "======================================\n";
                frm3.ReceiptTB.Text += String.Format("{0,-10}\t\t\t{1,17}\n", "Type of Discount:", DiscountType.Text.ToString());
                frm3.ReceiptTB.Text += String.Format("{0,-10}\t\t\t\t{1,17}\n", "Total VAT", "₱" + vat);
                frm3.ReceiptTB.Text += String.Format("{0,-10}\t\t\t\t{1,17}\n", "Total Price", "₱" + totalPrice);

                this.Hide();
                frm3.Show();
            }
        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Close();
        }

        private void rmvItem_Click(object sender, EventArgs e)
        {
            //Declare Variables
            int idNum = Convert.ToInt32(IDnumber.Value);

            //Error Catch Method when value exceeds array size
            counter = -1;

            foreach (string nam in name)
            {
                counter++;
            }

            if (idNum > counter)
            {
                MessageBox.Show("Error: ID Number does not exist");
            }

            else
            {
                //remove indicated value inside the array
                name.RemoveAt(idNum);
                listedPrice.RemoveAt(idNum);
                listedQuantity.RemoveAt(idNum);

                //display all items in their assigned textboxes
                DisplayItems();
            }
        }
    }
}
