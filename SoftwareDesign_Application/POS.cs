using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareDesign_Application
{
    public partial class POS : Form
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        db_connection_pos posdb_connect = new db_connection_pos();
        double Discount;
        public POS()
        {
            InitializeComponent();
        }

        private void POS_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            //codes for puting value of picturebox and load it to once the form will be loaded 
            lightsPicbox8.Image = Image.FromFile("C:\\Users\\Delli7\\Desktop\\software design\\images/lights_images/11.jfif");
            lightsPicbox9.Image = Image.FromFile("C:\\Users\\Delli7\\Desktop\\software design\\images/lights_images/12.jfif");
            lightsPicbox10.Image = Image.FromFile("C:\\Users\\Delli7\\Desktop\\software design\\images/lights_images/13.jfif");
            lightsPicbox11.Image = Image.FromFile("C:\\Users\\Delli7\\Desktop\\software design\\images/lights_images/14.jfif");
            lightsPicbox12.Image = Image.FromFile("C:\\Users\\Delli7\\Desktop\\software design\\images/lights_images/15.jfif");
            lightsPicbox13.Image = Image.FromFile("C:\\Users\\Delli7\\Desktop\\software design\\images/lights_images/16.jfif");
            lightsPicbox14.Image = Image.FromFile("C:\\Users\\Delli7\\Desktop\\software design\\images/lights_images/17.jfif");
            lightsPicbox15.Image = Image.FromFile("C:\\Users\\Delli7\\Desktop\\software design\\images/lights_images/18.jfif");
            lightsPicbox16.Image = Image.FromFile("C:\\Users\\Delli7\\Desktop\\software design\\images/lights_images/19.jfif");
            lightsPicbox17.Image = Image.FromFile("C:\\Users\\Delli7\\Desktop\\software design\\images/lights_images/20.jfif");
            lightsPicbox18.Image = Image.FromFile("C:\\Users\\Delli7\\Desktop\\software design\\images/lights_images/21.jfif");
            lightsPicbox19.Image = Image.FromFile("C:\\Users\\Delli7\\Desktop\\software design\\images/lights_images/22.jfif");
            lightsPicbox20.Image = Image.FromFile("C:\\Users\\Delli7\\Desktop\\software design\\images/lights_images/23.jfif");

            //defining of image name to be seen once the form will be loaded
            pos_imageLbl1.Text = "Light 1";
            pos_priceLbl1.Text = "1100.00";
            pos_imageLbl2.Text = "Light 2";
            pos_priceLbl2.Text = "2000.00";
            pos_imageLbl3.Text = "Light 3";
            pos_priceLbl3.Text = "5500.00";
            pos_imageLbl4.Text = "Light 4";
            pos_priceLbl4.Text = "8800.00";
            pos_imageLbl5.Text = "Light 5";
            pos_priceLbl5.Text = "11000.00";
            pos_imageLbl6.Text = "Light 6";
            pos_priceLbl6.Text = "560.00";
            pos_imageLbl7.Text = "Light 7";
            pos_priceLbl7.Text = "7777.00";
            pos_imageLbl8.Text = "Light 8";
            pos_priceLbl8.Text = "2500.00";
            pos_imageLbl9.Text = "Light 9";
            pos_priceLbl9.Text = "3300.00";
            pos_imageLbl10.Text = "Light 10";
            pos_priceLbl10.Text = "4300.00";
            pos_imageLbl11.Text = "Light 11";
            pos_priceLbl11.Text = "10300.00";
            pos_imageLbl12.Text = "Light 12";
            pos_priceLbl12.Text = "4100.00";
            pos_imageLbl13.Text = "Light 13";
            pos_priceLbl13.Text = "8100.00";
            pos_imageLbl14.Text = "Light 14";
            pos_priceLbl14.Text = "3100.00";
            pos_imageLbl15.Text = "Light 15";
            pos_priceLbl15.Text = "21000.00";
            pos_imageLbl16.Text = "Light 16";
            pos_priceLbl16.Text = "11000.00";
            pos_imageLbl17.Text = "Light 17";
            pos_priceLbl17.Text = "4000.00";
            pos_imageLbl18.Text = "Light 18";
            pos_priceLbl18.Text = "3000.00";
            pos_imageLbl19.Text = "Light 19";
            pos_priceLbl19.Text = "2000.00";
            pos_imageLbl20.Text = "Light 20";
            pos_priceLbl20.Text = "2500.00";

            // disabling of textboxes during loading of the form to avoid editing the displayed value

            itemnameTxtbox.Enabled = false;
            priceTxtbox.Enabled = false;
            discounted_amountTxtbox.Enabled = false;
            discount_amountTxtbox.Enabled = false;
            total_discount_amountTxtbox.Enabled = false;
            total_discount_givenTxtbox.Enabled = false;
            total_quantityTxtbox.Enabled = false;
            changeTxtbox.Enabled = false;

            pos_imageLbl1.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][2].ToString();
            pos_imageLbl2.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][3].ToString();
            pos_imageLbl3.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][4].ToString();
            pos_imageLbl4.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][5].ToString();
            pos_imageLbl5.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][6].ToString();
            pos_imageLbl6.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][7].ToString();
            pos_imageLbl7.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][8].ToString();
            pos_imageLbl8.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][9].ToString();
            pos_imageLbl9.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][10].ToString();
            pos_imageLbl10.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][11].ToString();
            pos_imageLbl11.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][12].ToString();
            pos_imageLbl12.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][13].ToString();
            pos_imageLbl13.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][14].ToString();
            pos_imageLbl14.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][15].ToString();
            pos_imageLbl15.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][16].ToString();
            pos_imageLbl16.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][17].ToString();
            pos_imageLbl17.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][18].ToString();
            pos_imageLbl18.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][19].ToString();
            pos_imageLbl19.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][20].ToString();
            pos_imageLbl20.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][21].ToString();



            pos_priceLbl1.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][24].ToString();
            pos_priceLbl2.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][25].ToString();
            pos_priceLbl3.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][26].ToString();
            pos_priceLbl4.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][27].ToString();
            pos_priceLbl5.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][28].ToString();
            pos_priceLbl6.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][29].ToString();
            pos_priceLbl7.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][30].ToString();
            pos_priceLbl8.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][31].ToString();
            pos_priceLbl9.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][32].ToString();
            pos_priceLbl10.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][33].ToString();
            pos_priceLbl11.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][34].ToString();
            pos_priceLbl12.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][35].ToString();
            pos_priceLbl13.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][36].ToString();
            pos_priceLbl14.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][37].ToString();
            pos_priceLbl15.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][38].ToString();
            pos_priceLbl16.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][39].ToString();
            pos_priceLbl17.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][40].ToString();
            pos_priceLbl18.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][41].ToString();
            pos_priceLbl19.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][42].ToString();
            pos_priceLbl20.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][43].ToString();



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lightsPicbox1_Click(object sender, EventArgs e)
        {
              itemnameTxtbox.Text= pos_imageLbl1.Text;
              priceTxtbox.Text = pos_priceLbl1.Text;
              quantityTxtbox.Focus();

        }

        private void lightsPicbox2_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = pos_imageLbl2.Text;
            priceTxtbox.Text = pos_priceLbl2.Text;
            quantityTxtbox.Focus();
        }

        private void lightsPicbox3_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = pos_imageLbl3.Text;
            priceTxtbox.Text = pos_priceLbl3.Text;
            quantityTxtbox.Focus();

        }

        private void lightsPicbox4_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = pos_imageLbl4.Text;
            priceTxtbox.Text = pos_priceLbl4.Text;
            quantityTxtbox.Focus();
        }

        private void lightsPicbox5_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = pos_imageLbl5.Text;
            priceTxtbox.Text = pos_priceLbl5.Text;
            quantityTxtbox.Focus();

        }

        private void lightsPicbox6_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = pos_imageLbl6.Text;
            priceTxtbox.Text = pos_priceLbl6.Text;
            quantityTxtbox.Focus();
        }

        private void lightsPicbox7_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = pos_imageLbl7.Text;
            priceTxtbox.Text = pos_priceLbl7.Text;
            quantityTxtbox.Focus();
        }

        private void lightsPicbox8_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = pos_imageLbl8.Text;
            priceTxtbox.Text = pos_priceLbl8.Text;
            quantityTxtbox.Focus();
        }

        private void lightsPicbox9_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = pos_imageLbl9.Text;
            priceTxtbox.Text = pos_priceLbl9.Text;
            quantityTxtbox.Focus();
        }

        private void lightsPicbox10_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = pos_imageLbl10.Text;
            priceTxtbox.Text = pos_priceLbl10.Text;
            quantityTxtbox.Focus();
        }

        private void lightsPicbox11_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = pos_imageLbl11.Text;
            priceTxtbox.Text = pos_priceLbl11.Text;
            quantityTxtbox.Focus();
        }

        private void lightsPicbox12_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = pos_imageLbl12.Text;
            priceTxtbox.Text = pos_priceLbl12.Text;
            quantityTxtbox.Focus();
        }

        private void lightsPicbox13_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = pos_imageLbl13.Text;
            priceTxtbox.Text = pos_priceLbl13.Text;
            quantityTxtbox.Focus();
        }

        private void lightsPicbox14_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = pos_imageLbl14.Text;
            priceTxtbox.Text = pos_priceLbl14.Text;
            quantityTxtbox.Focus();
        }

        private void lightsPicbox15_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = pos_imageLbl15.Text;
            priceTxtbox.Text = pos_priceLbl15.Text;
            quantityTxtbox.Focus();
        }

        private void lightsPicbox16_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = pos_imageLbl16.Text;
            priceTxtbox.Text = pos_priceLbl16.Text;
            quantityTxtbox.Focus();
        }

        private void lightsPicbox17_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = pos_imageLbl17.Text;
            priceTxtbox.Text = pos_priceLbl17.Text;
            quantityTxtbox.Focus();
        }

        private void lightsPicbox18_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = pos_imageLbl18.Text;
            priceTxtbox.Text = pos_priceLbl18.Text;
            quantityTxtbox.Focus();
        }

        private void lightsPicbox19_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = pos_imageLbl19.Text;
            priceTxtbox.Text = pos_priceLbl19.Text;
            quantityTxtbox.Focus();
        }

        private void lightsPicbox20_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = pos_imageLbl20.Text;
            priceTxtbox.Text = pos_priceLbl20.Text;
            quantityTxtbox.Focus();
        }

        private void total_quantityTxtbox_TextChanged(object sender, EventArgs e)
        {
            
                total_quantityTxtbox.Text = quantityTxtbox.Text;
          
        }

        private void discount_option_seniorRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            double Quantity, TotalPrice, Price, NewPrice, Discountedamount;

            Discount = 0.2;

            try
            {
                Quantity = Convert.ToDouble(total_quantityTxtbox.Text);
                Price = Convert.ToDouble(priceTxtbox.Text);

                TotalPrice = Quantity * Price;

                NewPrice = TotalPrice * Discount;

                Discountedamount = TotalPrice - NewPrice;
                discount_amountTxtbox.Text = NewPrice.ToString();
                discounted_amountTxtbox.Text = Discountedamount.ToString();
            }
            catch
            {
                MessageBox.Show("Please Input the Quantity First");
                discount_option_seniorRdbtn.Checked = false;
            }



        }

        private void discount_option_with_discount_cardRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            double Quantity, TotalPrice, Price, NewPrice, Discountedamount;

            Discount = 0.1;
            try
            {


                Quantity = Convert.ToDouble(total_quantityTxtbox.Text);
                Price = Convert.ToDouble(priceTxtbox.Text);

                TotalPrice = Quantity * Price;

                NewPrice = TotalPrice * Discount;

                Discountedamount = TotalPrice - NewPrice;
                discount_amountTxtbox.Text = NewPrice.ToString();
                discounted_amountTxtbox.Text = Discountedamount.ToString();
            }
            catch
            {
                MessageBox.Show("Please Input the Quantity First");
                discount_option_with_discount_cardRdbtn.Checked = false;
            }

        }

        private void discount_option_employeeRdbtn_CheckedChanged(object sender, EventArgs e)
        {

            double Quantity, TotalPrice, Price, NewPrice, Discountedamount;

            Discount = 0.15;
            try
            {

                Quantity = Convert.ToDouble(total_quantityTxtbox.Text);
                Price = Convert.ToDouble(priceTxtbox.Text);

                TotalPrice = Quantity * Price;

                NewPrice = TotalPrice * Discount;

                Discountedamount = TotalPrice - NewPrice;
                discount_amountTxtbox.Text = NewPrice.ToString();
                discounted_amountTxtbox.Text = Discountedamount.ToString();

            }
            catch
            {
                MessageBox.Show("Please Input the Quantity First");
                discount_option_employeeRdbtn.Checked = false;
            }

        }

        private void discount_option_no_discountRdbtn_CheckedChanged(object sender, EventArgs e)
        {

            double Quantity, TotalPrice, Price, NewPrice, Discountedamount;

            Discount = 0;

            try
            {

                Quantity = Convert.ToDouble(total_quantityTxtbox.Text);
                Price = Convert.ToDouble(priceTxtbox.Text);

                TotalPrice = Quantity * Price;

                NewPrice = TotalPrice * Discount;

                Discountedamount = TotalPrice - NewPrice;
                discount_amountTxtbox.Text = NewPrice.ToString();
                discounted_amountTxtbox.Text = Discountedamount.ToString();
            }
            catch
            {
                MessageBox.Show("Please Input the Quantity First");
                discount_option_no_discountRdbtn.Checked = false;

            }
            


        }

        private void changeTxtbox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {

            double  Quantity, TotalPrice, Price, NewPrice, Discountedamount;

            try
            {



                Quantity = Convert.ToDouble(total_quantityTxtbox.Text);
                Price = Convert.ToDouble(priceTxtbox.Text);

                TotalPrice = Quantity * Price;

                NewPrice = TotalPrice * Discount;

                Discountedamount = TotalPrice - NewPrice;
                discount_amountTxtbox.Text = NewPrice.ToString();
                discounted_amountTxtbox.Text = Discountedamount.ToString();
                total_discount_givenTxtbox.Text = Discount.ToString();
                total_discount_amountTxtbox.Text = discounted_amountTxtbox.Text;


                total_discount_givenTxtbox.Text = Discount.ToString();
                total_discount_amountTxtbox.Text = discounted_amountTxtbox.Text;

                double Cashgiven, TotalChange, Priceamount;
                Priceamount = Convert.ToDouble(total_discount_amountTxtbox.Text);
                Cashgiven = Convert.ToDouble(cash_givenTxtbox.Text);
                TotalChange = Cashgiven - Priceamount;
                changeTxtbox.Text = TotalChange.ToString();

                if ( Cashgiven < Discountedamount)
                {
                    cash_givenTxtbox.Clear();
                    changeTxtbox.Clear();
                    MessageBox.Show("Please Enter The Right Payment");
                }
            }
            catch
            {

            }
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            
                itemnameTxtbox.Clear();
                priceTxtbox.Clear();
                quantityTxtbox.Clear();
                discounted_amountTxtbox.Clear();
                discount_amountTxtbox.Clear();
                
           
        }

        private void itemnameTxtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
