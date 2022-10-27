using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SoftwareDesign_Application
{
    public partial class sampleFrm_database_functions : Form
    {
        string picturepath;
        string connectionString = null;
        SqlConnection connection;
        SqlCommand command;
        DataSet dset;
        SqlDataAdapter adaptersql;
        string sql = null;
        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        public sampleFrm_database_functions()
        {
            
            //codes in creating and establi8shing SQL Connection Object
            connectionString = "Data Source= DESKTOP-G3VQF4N\\SQLEXPRESS; Initial Catalog = software_designDb; user id = mel; password = erzascarlet";
            connection = new SqlConnection(connectionString);
            InitializeComponent();
        }

        private void sampleFrm_database_functions_Load(object sender, EventArgs e)
        {
            connection.Open();
            sqlSelect_no_Filter();
            cmd();
            sqladapterSelect();
            sqlDataset();
            connection.Close();
        }

        private void clearTxtboxes()
        {
            student_numTxtbox.Clear();
            student_nameTxtbox.Clear();
            student_departmentTxtbox.Clear();

            picturpathTxtbox.Text = "C:\\Users\\Delli7\\Desktop\\software design\\payroll and shop\\images/default.png";
            pictureBox1.Image = Image.FromFile(picturpathTxtbox.Text);
        }
        private void sqlSelect_Search()
        {
            sql = "SELECT * FROM studentTbl WHERE student_no = '" + student_numTxtbox.Text + "'";
        }

        private void sqlSelect_no_Filter()
        {
            sql = "SELECT * FROM studentTbl";
        }

        private void sqlUpdate()
        {
            sql = "UPDATE studentTbl SET student_name = '" + student_nameTxtbox.Text +
                "', student_department = '" + student_departmentTxtbox.Text +
                "' WHERE student_no = '" + student_numTxtbox.Text + "'";
        }

        private void sqlDelete()
        {
            sql = " DELETE FROM studentTbl WHERE student_no = '" + student_numTxtbox + "'";
        }
        private void sqlInsert()
        {
            sql = " INSERT INTO studentTbl (student_no, student_name, student_department, picturepath)" +
                "VALUES('" + student_numTxtbox.Text + "', '" + student_nameTxtbox.Text + "','" + student_departmentTxtbox.Text
                + "','" + picturpathTxtbox.Text + "')";
        }
        private void sqladapterSelect()
        {
            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();
        }
        private void sqladapterUpdate()
        {
            adaptersql = new SqlDataAdapter();
            adaptersql.UpdateCommand = command;
            command.ExecuteNonQuery();
        }
        private void sqladapterDelete()
        {
            adaptersql = new SqlDataAdapter();
            adaptersql.DeleteCommand = command;
            command.ExecuteNonQuery();
        }
        private void sqladapterInsert()
        {
            adaptersql = new SqlDataAdapter();
            adaptersql.InsertCommand = command;
            command.ExecuteNonQuery();
        }
        private void sqlDataset()
        {
            dset = new DataSet();
            adaptersql.Fill(dset, "studentTbl");
            datagrid_display.DataSource = dset.Tables[0];

        }
        private void cmd()
        {
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //codes for inserting picture from the local file to the picturebox
            //filtering of image display using specific file extension
            openFileDialog1.Filter = "Image File | *.gif; *.jpg; *.png; *.bmp";

            //displaying the file dialogbox where the possible image is located
            openFileDialog1.ShowDialog();

            //inserting of selected image to the pocture box shown in the GUI Interface
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);

            //storing the file location of the selected image inserted in picturebox to a variable
            picturepath = openFileDialog1.FileName;

            //displaying the file location of the image stored in a variable to the textbox
            picturpathTxtbox.Text = picturepath;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            sqlInsert();
            cmd();
            sqladapterInsert();

            sqlSelect_no_Filter();
            cmd();
            sqladapterSelect();
            sqlDataset();

            connection.Close();
            clearTxtboxes();
            student_numTxtbox.Focus();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            sqlSelect_Search();
            cmd();
            sqladapterSelect();
            sqlDataset();
            student_nameTxtbox.Text = dset.Tables[0].Rows[0][1].ToString();
            student_departmentTxtbox.Text = dset.Tables[0].Rows[0][2].ToString();
            picturpathTxtbox.Text = dset.Tables[0].Rows[0][3].ToString();
            pictureBox1.Image = Image.FromFile(picturpathTxtbox.Text);
            connection.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            sqlDelete();
            cmd();
            sqladapterDelete();
            sqlSelect_no_Filter();
            cmd();
            sqladapterSelect();
            sqlDataset();
            clearTxtboxes();
            connection.Close();
            student_numTxtbox.Focus();

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            sqlUpdate();
            cmd();
            sqladapterUpdate();
            sqlSelect_no_Filter();
            cmd();
            sqladapterSelect();
            sqlDataset();
            connection.Close();
            clearTxtboxes();
            student_numTxtbox.Focus();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            clearTxtboxes();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            clearTxtboxes();
        }
    }
}
