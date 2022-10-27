using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareDesign_Application
{
    public partial class POS_admin : Form
    {
        OpenFileDialog openFileDialog1 = new OpenFileDialog();

        private string picpath;
        private Image pic;
        db_connection_pos posdb_connect = new db_connection_pos();

        public POS_admin()
        {
            //accessing function inside the db_connection class
            posdb_connect.pos_connString();
            InitializeComponent();
        }

        private void POS_admin_Load(object sender, EventArgs e)
        {

            try
            {
                picpathtxtbox1.Hide();
                picpathtxtbox2.Hide();
                picpathtxtbox3.Hide();
                picpathtxtbox4.Hide();
                picpathtxtbox5.Hide();
                picpathtxtbox6.Hide();
                picpathtxtbox7.Hide();
                picpathtxtbox8.Hide();
                picpathtxtbox9.Hide();
                picpathtxtbox10.Hide();
                picpathtxtbox11.Hide();
                picpathtxtbox12.Hide();
                picpathtxtbox13.Hide();
                picpathtxtbox14.Hide();
                picpathtxtbox15.Hide();
                picpathtxtbox16.Hide();
                picpathtxtbox17.Hide();
                picpathtxtbox18.Hide();
                picpathtxtbox19.Hide();
                picpathtxtbox20.Hide();

                posdb_connect.pos_select();
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSELECT();
                datagrid_display.DataSource = posdb_connect.pos_sql_dataset.Tables[0];


            }
            catch
            {
                MessageBox.Show("Error has occured, Please contanct the administrator");
            }




        }
        private void perfumepicbox1_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                openFileDialog1.Filter = "Image File | *.gif; *.jpg; *.png; *.bmp; *.jfif; *.JPG;";
                openFileDialog1.ShowDialog();
                picbox1.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathtxtbox1.Text = picpath;
            }
            catch
            {
                //MessageBox.Show("No image selected");
            }
        }

        private void picbox2_Click(object sender, EventArgs e)
        {
           try
            {
                open_file_image();
                picbox2.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathtxtbox2.Text = picpath;
            }
            catch
            {
                MessageBox.Show("No image selected");
            }
        }
    
        private void picbox3_Click(object sender, EventArgs e)
        {
           try
            {
                open_file_image();
                picbox3.Image = Image.FromFile(openFileDialog1.FileName);
                picpath= openFileDialog1.FileName;
                picpathtxtbox3.Text = picpath;
            }
            catch
            {
                MessageBox.Show("No image selected");
            }
        }

        private void picbox4_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                picbox4.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathtxtbox4.Text = picpath;
            }
            catch
            {
                MessageBox.Show("No image selected");
            }
        }

        private void picbox5_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                picbox5.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathtxtbox5.Text = picpath;
            }
            catch
            {

            }
        }

        private void picbox6_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                picbox6.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathtxtbox6.Text = picpath;
            }
            catch
            {

            }
        }

        private void picbox7_Click(object sender, EventArgs e)
        {
            try { 
            open_file_image();
            picbox7.Image = Image.FromFile(openFileDialog1.FileName);
            picpath = openFileDialog1.FileName;
            picpathtxtbox7.Text = picpath;
        }
            catch
            {
                MessageBox.Show("No image selected");
            }
        }

        private void picbox8_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                picbox8.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathtxtbox8.Text = picpath;
            }
            catch
            {
                MessageBox.Show("No image selected");
            }
        }

        private void picbox9_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                picbox9.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathtxtbox9.Text = picpath;
            }
            catch
            {
                MessageBox.Show("No image selected");
            }
        }

        private void picbox10_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                picbox10.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathtxtbox10.Text = picpath;
            }
            catch
            {
                MessageBox.Show("No image selected");
            }
        }

        private void picbox11_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                picbox11.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathtxtbox11.Text = picpath;
            }
            catch
            {
                MessageBox.Show("No image selected");
            }
        }

        private void picbox12_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                picbox12.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathtxtbox12.Text = picpath;
            }
            catch
            {
                MessageBox.Show("No image selected");
            }
        }

        private void picbox13_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                picbox13.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathtxtbox13.Text = picpath;
            }
            catch
            {
                MessageBox.Show("No image selected");
            }
        }

        private void picbox14_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                picbox14.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathtxtbox14.Text = picpath;
            }
            catch
            {
                MessageBox.Show("No image selected");
            }
        }

        private void picbox15_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                picbox15.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathtxtbox15.Text = picpath;
            }
            catch
            {
                MessageBox.Show("No image selected");
            }
        }

        private void picbox16_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "Image File | *.gif; *.jpg; *.png; *.bmp *.jfif; *.JPG;";
                openFileDialog1.ShowDialog();
                picbox16.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathtxtbox16.Text = picpath;
            }
            catch
            {
                MessageBox.Show("No image selected");
            }
        }

        private void picbox17_Click(object sender, EventArgs e)
        {
            try
            {

                open_file_image();
                picbox17.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathtxtbox17.Text = picpath;
            }
            catch
            {
                MessageBox.Show("No image selected");
            }
        }

        private void picbox18_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                picbox18.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathtxtbox18.Text = picpath;
            }
            catch
            {
                MessageBox.Show("No image selected");
            }
        }

        private void picbox19_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                picbox19.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathtxtbox19.Text = picpath;
            }
            catch
            {
                MessageBox.Show("No image selected");
            }
        }

        private void picbox20_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                picbox20.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathtxtbox20.Text = picpath;
            }
            catch
            {
                MessageBox.Show("No image selected");
            }
        }

        private void clearTxtbox()
        {
            try
            {
                pic = Image.FromFile("C:\\Users\\Delli7\\Desktop\\software design\\payroll and shop\\images/default.png");


                picpathtxtbox1.Clear();
                picpathtxtbox2.Clear();
                picpathtxtbox3.Clear();
                picpathtxtbox4.Clear();
                picpathtxtbox5.Clear();
                picpathtxtbox6.Clear();
                picpathtxtbox7.Clear();
                picpathtxtbox8.Clear();
                picpathtxtbox9.Clear();
                picpathtxtbox10.Clear();
                picpathtxtbox11.Clear();
                picpathtxtbox12.Clear();
                picpathtxtbox13.Clear();
                picpathtxtbox14.Clear();
                picpathtxtbox15.Clear();
                picpathtxtbox16.Clear();
                picpathtxtbox17.Clear();
                picpathtxtbox18.Clear();
                picpathtxtbox19.Clear();
                picpathtxtbox20.Clear();
                picbox1.Image = pic;
                picbox2.Image = pic;
                picbox3.Image = pic;
                picbox4.Image = pic;
                picbox5.Image = pic;
                picbox6.Image = pic;
                picbox7.Image = pic;
                picbox8.Image = pic;
                picbox9.Image = pic;
                picbox10.Image = pic;
                picbox11.Image = pic;
                picbox12.Image = pic;
                picbox13.Image = pic;
                picbox14.Image = pic;
                picbox15.Image = pic;
                picbox16.Image = pic;
                picbox17.Image = pic;
                picbox18.Image = pic;
                picbox19.Image = pic;
                picbox20.Image = pic;
                Price_txtbox1.Clear();
                Price_txtbox2.Clear();
                Price_txtbox3.Clear();
                Price_txtbox4.Clear();
                Price_txtbox5.Clear();
                Price_txtbox6.Clear();
                Price_txtbox7.Clear();
                Price_txtbox8.Clear();
                Price_txtbox9.Clear();
                Price_txtbox10.Clear();
                Price_txtbox11.Clear();
                Price_txtbox12.Clear();
                Price_txtbox13.Clear();
                Price_txtbox14.Clear();
                Price_txtbox15.Clear();
                Price_txtbox16.Clear();
                Price_txtbox17.Clear();
                Price_txtbox18.Clear();
                Price_txtbox19.Clear();
                Price_txtbox20.Clear();
                itemname_txtbox1.Clear();
                itemname_txtbox2.Clear();
                itemname_txtbox3.Clear();
                itemname_txtbox4.Clear();
                itemname_txtbox5.Clear();
                itemname_txtbox6.Clear();
                itemname_txtbox7.Clear();
                itemname_txtbox8.Clear();
                itemname_txtbox9.Clear();
                itemname_txtbox10.Clear();
                itemname_txtbox11.Clear();
                itemname_txtbox12.Clear();
                itemname_txtbox13.Clear();
                itemname_txtbox14.Clear();
                itemname_txtbox15.Clear();
                itemname_txtbox16.Clear();
                itemname_txtbox17.Clear();
                itemname_txtbox18.Clear();
                itemname_txtbox19.Clear();
                itemname_txtbox20.Clear();
            }
            catch
            {
                MessageBox.Show("Error has occured, Please contanct the administrator");
            }
            
        }
        private void open_file_image()
        {
            openFileDialog1.Filter = "Image File | *.gif; *.jpg; *.png; *.bmp; *.JPG;";
            openFileDialog1.ShowDialog();
        }


        private void Savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                posdb_connect.pos_sql = "INSERT INTO pos_itemnameTbl(stock_id, itemname1, itemname2, itemname3,itemname4,itemname5,itemname6,itemname7,itemname8,itemname9,itemname10,itemname11,itemname12,itemname13,itemname14,itemname15,itemname16,itemname17,itemname18,itemname19,itemname20)"
                 + "VALUES ('" + ItemIDtxtbox.Text + "','" + itemname_txtbox1.Text + "','" + itemname_txtbox2.Text + "','" +
                itemname_txtbox3.Text + "','" + itemname_txtbox4.Text + "','" + itemname_txtbox5.Text + "','" + itemname_txtbox6.Text + "','" +
                itemname_txtbox7.Text + "','" + itemname_txtbox8.Text + "','" + itemname_txtbox9.Text + "','" + itemname_txtbox10.Text + "','" +
                itemname_txtbox11.Text + "','" + itemname_txtbox12.Text + "','" + itemname_txtbox13.Text + "','" + itemname_txtbox14.Text + "','" +
                itemname_txtbox15.Text + "','" + itemname_txtbox16.Text + "','" + itemname_txtbox17.Text + "','" + itemname_txtbox18.Text + "','" +
                itemname_txtbox19.Text + "','" + itemname_txtbox20.Text + "')";

                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterInsert();



                posdb_connect.pos_sql = "INSERT INTO pos_priceTbl(price1,price2,price3,price4,price5,price6,price7,price8,price9,price10,price11,price12,price13,price14,price15,price16,price17,price18,price19,price20,stock_id)"
                 + "VALUES ('" + Price_txtbox1.Text + "','" + Price_txtbox2.Text + "','" + Price_txtbox3.Text + "','" +
                Price_txtbox4.Text + "','" + Price_txtbox5.Text + "','" + Price_txtbox6.Text + "','" +
                Price_txtbox7.Text + "','" + Price_txtbox8.Text + "','" + Price_txtbox9.Text + "','" + Price_txtbox10.Text + "','" +
                Price_txtbox11.Text + "','" + Price_txtbox12.Text + "','" + Price_txtbox13.Text + "','" + Price_txtbox14.Text + "','" +
                Price_txtbox15.Text + "','" + Price_txtbox16.Text + "','" + Price_txtbox17.Text + "','" + Price_txtbox18.Text + "','" +
                Price_txtbox19.Text + "','" + Price_txtbox20.Text + "','" + ItemIDtxtbox.Text + "')";

                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterInsert();




                posdb_connect.pos_sql = "INSERT INTO pos_picpathTbl(picpath1,picpath2,picpath3,picpath4,picpath5,picpath6,picpath7,picpath8,picpath9,picpath10,picpath11,picpath12,picpath13,picpath14,picpath15,picpath16,picpath17,picpath18,picpath19,picpath20,stock_id)"
                + "VALUES ('" + picpathtxtbox1.Text + "','" + picpathtxtbox2.Text + "','" + picpathtxtbox3.Text + "','" +
               picpathtxtbox4.Text + "','" + picpathtxtbox5.Text + "','" + picpathtxtbox6.Text + "','" +
               picpathtxtbox7.Text + "','" + picpathtxtbox8.Text + "','" + picpathtxtbox9.Text + "','" + picpathtxtbox10.Text + "','" +
               picpathtxtbox11.Text + "','" + picpathtxtbox12.Text + "','" + picpathtxtbox13.Text + "','" + picpathtxtbox14.Text + "','" +
               picpathtxtbox15.Text + "','" + picpathtxtbox16.Text + "','" + picpathtxtbox17.Text + "','" + picpathtxtbox18.Text + "','" +
               picpathtxtbox19.Text + "','" + picpathtxtbox20.Text + "','" + ItemIDtxtbox.Text + "')";

                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterInsert();

                posdb_connect.pos_select();
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSELECT();
                datagrid_display.DataSource = posdb_connect.pos_sql_dataset.Tables[0];
                clearTxtbox();
            }
            catch
            {
                MessageBox.Show("Error has occured, Data has not been saved");
            }
            

     

        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            try
            {
                posdb_connect.pos_sql = " SELECT * FROM pos_itemnameTbl INNER JOIN pos_picpathTbl ON pos_itemnameTbl.stock_id=pos_picpathTbl.stock_id INNER JOIN pos_priceTbl ON pos_picpathTbl.stock_id = pos_priceTbl.stock_id WHERE pos_itemnameTbl.stock_id = '" + ItemIDtxtbox.Text + "'";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSELECT();
                datagrid_display.DataSource = posdb_connect.pos_sql_dataset.Tables[0];
                itemname_txtbox1.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][2].ToString();
                itemname_txtbox2.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][3].ToString();
                itemname_txtbox3.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][4].ToString();
                itemname_txtbox4.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][5].ToString();
                itemname_txtbox5.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][6].ToString();
                itemname_txtbox6.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][7].ToString();
                itemname_txtbox7.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][8].ToString();
                itemname_txtbox8.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][9].ToString();
                itemname_txtbox9.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][10].ToString();
                itemname_txtbox10.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][11].ToString();
                itemname_txtbox11.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][12].ToString();
                itemname_txtbox12.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][13].ToString();
                itemname_txtbox13.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][14].ToString();
                itemname_txtbox14.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][15].ToString();
                itemname_txtbox15.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][16].ToString();
                itemname_txtbox16.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][17].ToString();
                itemname_txtbox17.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][18].ToString();
                itemname_txtbox18.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][19].ToString();
                itemname_txtbox19.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][20].ToString();
                itemname_txtbox20.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][21].ToString();

                picpathtxtbox1.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][24].ToString();
                picpathtxtbox2.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][25].ToString();
                picpathtxtbox3.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][26].ToString();
                picpathtxtbox4.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][27].ToString();
                picpathtxtbox5.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][28].ToString();
                picpathtxtbox6.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][29].ToString();
                picpathtxtbox7.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][30].ToString();
                picpathtxtbox8.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][31].ToString();
                picpathtxtbox9.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][32].ToString();
                picpathtxtbox10.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][33].ToString();
                picpathtxtbox11.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][34].ToString();
                picpathtxtbox12.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][35].ToString();
                picpathtxtbox13.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][36].ToString();
                picpathtxtbox14.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][37].ToString();
                picpathtxtbox15.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][38].ToString();
                picpathtxtbox16.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][39].ToString();
                picpathtxtbox17.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][40].ToString();
                picpathtxtbox18.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][41].ToString();
                picpathtxtbox19.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][42].ToString();
                picpathtxtbox20.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][43].ToString();
              

                Price_txtbox1.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][45].ToString();
                Price_txtbox2.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][46].ToString();
                Price_txtbox3.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][47].ToString();
                Price_txtbox4.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][48].ToString();
                Price_txtbox5.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][49].ToString();
                Price_txtbox6.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][50].ToString();
                Price_txtbox7.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][51].ToString();
                Price_txtbox8.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][52].ToString();
                Price_txtbox9.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][53].ToString();
                Price_txtbox10.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][54].ToString();
                Price_txtbox11.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][55].ToString();
                Price_txtbox12.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][56].ToString();
                Price_txtbox13.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][57].ToString();
                Price_txtbox14.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][58].ToString();
                Price_txtbox15.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][59].ToString();
                Price_txtbox16.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][60].ToString();
                Price_txtbox17.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][61].ToString();
                Price_txtbox18.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][62].ToString();
                Price_txtbox19.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][63].ToString();
                Price_txtbox20.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][64].ToString();



                picbox1.Image = Image.FromFile(picpathtxtbox1.Text);
                picbox2.Image = Image.FromFile(picpathtxtbox2.Text);
                picbox3.Image = Image.FromFile(picpathtxtbox3.Text);
                picbox4.Image = Image.FromFile(picpathtxtbox4.Text);
                picbox5.Image = Image.FromFile(picpathtxtbox5.Text);
                picbox6.Image = Image.FromFile(picpathtxtbox6.Text);
                picbox7.Image = Image.FromFile(picpathtxtbox7.Text);
                picbox8.Image = Image.FromFile(picpathtxtbox8.Text);
                picbox9.Image = Image.FromFile(picpathtxtbox9.Text);
                picbox10.Image = Image.FromFile(picpathtxtbox10.Text);
                picbox11.Image = Image.FromFile(picpathtxtbox11.Text);
                picbox12.Image = Image.FromFile(picpathtxtbox12.Text);
                picbox13.Image = Image.FromFile(picpathtxtbox13.Text);
                picbox14.Image = Image.FromFile(picpathtxtbox14.Text);
                picbox15.Image = Image.FromFile(picpathtxtbox15.Text);
                picbox16.Image = Image.FromFile(picpathtxtbox16.Text);
                picbox17.Image = Image.FromFile(picpathtxtbox17.Text);
                picbox18.Image = Image.FromFile(picpathtxtbox18.Text);
                picbox19.Image = Image.FromFile(picpathtxtbox19.Text);
                picbox20.Image = Image.FromFile(picpathtxtbox20.Text);
            }
            catch
            {
                MessageBox.Show("Error has occured, Please contanct the administrator");
            }



        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                posdb_connect.pos_sql = "DELETE FROM pos_priceTbl WHERE pos_priceTbl.stock_id = '" + ItemIDtxtbox.Text + "'";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterDelete();


                posdb_connect.pos_sql = "DELETE FROM pos_picpathTbl WHERE pos_picpathTbl.stock_id = '" + ItemIDtxtbox.Text + "'";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterDelete();

                posdb_connect.pos_sql = "DELETE FROM pos_itemnameTbl WHERE pos_itemnameTbl.stock_id = '" + ItemIDtxtbox.Text + "'";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterDelete();

                posdb_connect.pos_select();
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSELECT();
                datagrid_display.DataSource = posdb_connect.pos_sql_dataset.Tables[0];
                clearTxtbox();
            }
            catch
            {

                MessageBox.Show("Error has occured, You cannot Delete");

            }
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                posdb_connect.pos_sql = "UPDATE pos_itemnameTbl SET  itemname1 = '" + itemname_txtbox1.Text + "', itemname2 = '" + itemname_txtbox2.Text +
                   "', itemname3 = '" + itemname_txtbox3.Text + "',  itemname4= '" + itemname_txtbox4.Text + "', itemname5 = '" + itemname_txtbox5.Text +
                   "', itemname6 = '" + itemname_txtbox6.Text + "',  itemname7= '" + itemname_txtbox7.Text + "', itemname8 = '" + itemname_txtbox8.Text +
                   "', itemname9 = '" + itemname_txtbox9.Text + "',  itemname10= '" + itemname_txtbox10.Text + "', itemname11 = '" + itemname_txtbox11.Text +
                   "', itemname12 = '" + itemname_txtbox12.Text + "',  itemname13= '" + itemname_txtbox13.Text + "', itemname14 = '" + itemname_txtbox14.Text +
                   "', itemname15 = '" + itemname_txtbox15.Text + "',  itemname16= '" + itemname_txtbox16.Text + "', itemname17 = '" + itemname_txtbox17.Text +
                   "', itemname18 = '" + itemname_txtbox18.Text + "',  itemname19= '" + itemname_txtbox19.Text + "', itemname20 = '" + itemname_txtbox20.Text +
                   "' WHERE stock_id = '" + ItemIDtxtbox.Text + "'";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterUpdate();


                posdb_connect.pos_sql = "UPDATE pos_picpathTbl SET  picpath1 = '" + picpathtxtbox1.Text + "', picpath2 = '" + picpathtxtbox2.Text +
                      "', picpath3 = '" + picpathtxtbox3.Text + "',  picpath4= '" + picpathtxtbox4.Text + "', picpath5 = '" + picpathtxtbox5.Text +
                      "', picpath6 = '" + picpathtxtbox6.Text + "',  picpath7= '" + picpathtxtbox7.Text + "', picpath8 = '" + picpathtxtbox8.Text +
                      "', picpath9 = '" + picpathtxtbox9.Text + "',  picpath10= '" + picpathtxtbox10.Text + "', picpath11 = '" + picpathtxtbox11.Text +
                      "', picpath12 = '" + picpathtxtbox12.Text + "',  picpath13= '" + picpathtxtbox13.Text + "', picpath14 = '" + picpathtxtbox14.Text +
                      "', picpath15 = '" + picpathtxtbox15.Text + "',  picpath16= '" + picpathtxtbox16.Text + "', picpath17 = '" + picpathtxtbox17.Text +
                      "', picpath18 = '" + picpathtxtbox18.Text + "', picpath19 = '" + picpathtxtbox19.Text + "',  picpath20= '" + picpathtxtbox20.Text + "' WHERE stock_id = '" + ItemIDtxtbox.Text + "'";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterUpdate();


                posdb_connect.pos_sql = "UPDATE pos_priceTbl SET  price1 = '" + Price_txtbox1.Text + "',  price2 = '" + Price_txtbox2.Text +
                     "', price3 = '" + Price_txtbox3.Text + "',   price4= '" + Price_txtbox4.Text + "',  price5 = '" + Price_txtbox5.Text +
                     "',  price6 = '" + Price_txtbox6.Text + "',   price7= '" + Price_txtbox7.Text + "',  price8 = '" + Price_txtbox8.Text +
                     "',  price9 = '" + Price_txtbox9.Text + "',   price10= '" + Price_txtbox10.Text + "',  price11 = '" + Price_txtbox11.Text +
                     "', price12 = '" + Price_txtbox12.Text + "',  price13 = '" + Price_txtbox13.Text + "',   price14= '" + Price_txtbox14.Text +
                     "',  price15 = '" + Price_txtbox15.Text + "',  price16 = '" + Price_txtbox16.Text + "',   price17= '" + Price_txtbox17.Text +
                     "',  price18 = '" + Price_txtbox18.Text + "',  price19 = '" + Price_txtbox19.Text + "',   price20= '" + Price_txtbox20.Text + "' WHERE stock_id = '" + ItemIDtxtbox.Text + "'";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterUpdate();

                posdb_connect.pos_select();
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSELECT();
                datagrid_display.DataSource = posdb_connect.pos_sql_dataset.Tables[0];
                clearTxtbox();
            }
            catch
            {
                MessageBox.Show("Error has occured, Updating is not allowed");
            }
            

            
        }

        private void Newbtn_Click(object sender, EventArgs e)
        {
            clearTxtbox();
        }
    }
}
