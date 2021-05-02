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
         
        }

        //Variables
        public ArrayList name = new ArrayList();
        public ArrayList listedQuantity = new ArrayList();
        public ArrayList listedPrice = new ArrayList();
        public double priceSum;
        public double discount;
        public double vat;

        private int counter;
             

        //Class
        public Form3 frm3 = new Form3();

        //Functions

        //Discount Type
        private double TypeOfDiscount()
        {
            //declare variables
            string value = DiscountType.Text.ToString();
            double discountValue;

            //Compare Discount Type
            if (value == "Senior")
                discountValue = .10;
            else if (value == "Student")
                discountValue = .20;
            else
                discountValue = 1;

            //return value
            return discountValue;
        }

        //Compute Total price w/o discounts
        private double SumOfPrice()
        {
            int qty = 0;
            double price = 0;

            foreach (int num in listedQuantity)
            {
                qty++;
            }

            for (int i = 0; i < qty; i++)
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
            AdoboComboAdd.Enabled = false;
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
            SinigangComboAdd.Enabled = false;
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
            PakbetComboAdd.Enabled = false;
        }
        //Ala Carte Meals
        private void AdoboAdd_Click(object sender, EventArgs e)
        {
            //add name to list
            name.Add("Adobo");

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
            AdoboAdd.Enabled = false;
        }

        private void SinigangAdd_Click(object sender, EventArgs e)
        {
            //add name to list
            name.Add("Sinigang");

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
            SinigangAdd.Enabled = false;
        }

        private void PakbetAdd_Click(object sender, EventArgs e)
        {
            //add name to list
            name.Add("Pinakbet");

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
            PakbetAdd.Enabled = false;
        }

        //Beverages
        private void WaterAdd_Click(object sender, EventArgs e)
        {
            //add name to list
            name.Add("Water");

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
            WaterAdd.Enabled = false;
        }

        private void CokeAdd_Click(object sender, EventArgs e)
        {
            //add name to list
            name.Add("Coke");

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
            CokeAdd.Enabled = false;
        }

        private void IcedTeaAdd_Click(object sender, EventArgs e)
        {
            //add name to list
            name.Add("Iced Tea");

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
            IcedTeaAdd.Enabled = false;
        }

        //Desserts
        private void LecheFlanAdd_Click(object sender, EventArgs e)
        {
            //add name to list
            name.Add("Leche Flan");

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
            LecheFlanAdd.Enabled = false;
        }

        private void HaloHaloAdd_Click(object sender, EventArgs e)
        {
            //add name to list
            name.Add("Halo-Halo");

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
            HaloHaloAdd.Enabled = false;
        }

        //Add-Ons
        private void RiceAdd_Click(object sender, EventArgs e)
        {
            //add name to list
            name.Add("Extra Rice");

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
            RiceAdd.Enabled = false;
        }

        //Confirm order
        private void ConfirmOrder_Click(object sender, EventArgs e)
        {
            //assign value in variables
            priceSum = SumOfPrice();
            discount = TypeOfDiscount();

            //Compute Discounts
            vat = priceSum * .12;
            double totalPrice = (priceSum - (priceSum * discount)) + vat;


            //Display receipt

            //declare total index inside the array
            foreach (int num in listedQuantity)
                counter++;

            //loop display text
            for (int i = 0; i < counter; i++)
            {
                frm3.ItemsTB.Text += name[i].ToString();
                frm3.ItemsTB.Text += "\n";
                frm3.QuantityTB.Text += listedQuantity[i].ToString();
                frm3.QuantityTB.Text += "\n";
                frm3.PriceTB.Text += listedPrice[i].ToString();
                frm3.PriceTB.Text += "\n";
            }

            frm3.VatTB.Text = "₱" + vat.ToString();
            frm3.TotalPriceTB.Text = "₱" + totalPrice.ToString();

            frm3.Show();
            this.Hide();

        }
    }
}
