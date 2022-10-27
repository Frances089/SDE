using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareDesign_Application
{
    public partial class sampleFrm_database_class : Form
    {
        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        //variable where we put the location of the image
        string picpath;
        //accessing the calss which consists of codes to connect the database
        db_connection db_connect = new db_connection();
        public sampleFrm_database_class()
        {
            //accessing function inside the db_connection class
            db_connect.connString();
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //codes for inserting picture from the local file to the picturebox
            //filtering of image display using specific file extension
            openFileDialog1.Filter = "Image File | *.gif; *.jpg; *.png; *.bmp";

            //displaying the file dialogbox where the possible image is located
            openFileDialog1.ShowDialog();

            //inserting of selected image to the pocture box shown in the GUI Interface
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);

            //storing the file location of the selected image inserted in picturebox to a variable
            picpath = openFileDialog1.FileName;

            //displaying the file location of the image stored in a variable to the textbox
            picturpathTxtbox.Text = picpath;

        }

        private void sampleFrm_database_class_Load(object sender, EventArgs e)
        {
            db_connect.sql = " SELECT * FROM studentTbl";
            db_connect.cmd();
            db_connect.sqladapterSelect();
            db_connect.sqladapterDataset();
            datagrid_display.DataSource = db_connect.sql_dataset.Tables[0];
        }

        private void picturepathTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearTxtbox()
        {
            student_numTxtbox.Clear();
            student_numTxtbox.Clear();
            student_nameTxtbox.Clear();
            student_departmentTxtbox.Clear();
           
            picturpathTxtbox.Text = "C:\\Users\\Delli7\\Desktop\\software design\\payroll and shop\\images/default.png";
            pictureBox1.Image = Image.FromFile(picturpathTxtbox.Text);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            db_connect.sql = "INSERT INTO studentTbl (student_no, student_name, student_department, picturepath) " +
              "VALUES ('" + student_numTxtbox.Text + "','" + student_nameTxtbox.Text + "','" + student_departmentTxtbox.Text + "','" + picturpathTxtbox.Text + "')";
            db_connect.cmd();
            db_connect.sqladapterSelect();
            db_connect.sql = "SELECT * FROM studentTbl";
            db_connect.cmd();
            db_connect.sqladapterSelect();
            db_connect.sqladapterDataset();
            datagrid_display.DataSource = db_connect.sql_dataset.Tables[0];
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            db_connect.sql = " SELECT * FROM studentTbl WHERE student_no = '" + student_numTxtbox.Text + "'";
            db_connect.cmd();
            db_connect.sqladapterSelect();
            db_connect.sqladapterDataset();
            datagrid_display.DataSource = db_connect.sql_dataset.Tables[0];
            student_nameTxtbox.Text = db_connect.sql_dataset.Tables[0].Rows[0][1].ToString();
            student_departmentTxtbox.Text = db_connect.sql_dataset.Tables[0].Rows[0][2].ToString();
            picturpathTxtbox.Text = db_connect.sql_dataset.Tables[0].Rows[0][3].ToString();
            pictureBox1.Image = Image.FromFile(picturpathTxtbox.Text);

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            db_connect.sql = "DELETE FROM studentTbl WHERE student_no = '" + student_numTxtbox.Text + "'";
            db_connect.cmd();
            db_connect.sqladapterDelete();
            db_connect.sql = "SELECT * FROM studentTbl";
            db_connect.cmd();
            db_connect.sqladapterSelect();
            db_connect.sqladapterDataset();
            datagrid_display.DataSource = db_connect.sql_dataset.Tables[0];
            clearTxtbox();
            student_numTxtbox.Focus();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            db_connect.sql = "UPDATE studentTbl SET student_name = '" + student_nameTxtbox.Text + "', student_department = '" + student_departmentTxtbox.Text + 
                "', picturepath = '" + picturpathTxtbox.Text + "' WHERE student_no = '" + student_numTxtbox.Text + "'";
            db_connect.cmd();
            db_connect.sqladapterUpdate();
            db_connect.sql = "SELECT * FROM studentTbl";
            db_connect.cmd();
            db_connect.sqladapterSelect();
            db_connect.sqladapterDataset();
            datagrid_display.DataSource = db_connect.sql_dataset.Tables[0];
            clearTxtbox();
            student_numTxtbox.Focus();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            clearTxtbox();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            clearTxtbox();
        }
    }
}
