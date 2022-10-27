using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SoftwareDesign_Application
{
    public partial class samplefrm_connectedDb : Form
    {
        
        string picturepath;
        string connectionString = null;
        SqlConnection connection;
        SqlCommand command;
        DataSet dset;
        SqlDataAdapter adaptersql;
        string sql = null;
        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        public samplefrm_connectedDb()
        {
            //codes in creating and establi8shing SQL Connection Object
            connectionString = "Data Source= DESKTOP-G3VQF4N\\SQLEXPRESS; Initial Catalog = software_designDb; user id = mel; password = erzascarlet";
            connection = new SqlConnection(connectionString);
            InitializeComponent();
        }

        private void samplefrm_connectedDb_Load(object sender, EventArgs e)
        {
            connection.Open();
            sql = "SLECT * FROM studentTbl";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();
            dset = new DataSet();
            adaptersql.Fill(dset, "studentTbl");
            datagrid_display.DataSource = dset.Tables[0];
            connection.Close();

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
            //code to open the connection betweeen c# and ms sql
            connection.Open();

            //mssql query to insert or save data from GUI Interface to the student table located inside the database
            sql = "INSERT INTO studentTbl (student_no, student_name, student_department, picturepath) Values('" + student_numTxtbox.Text + "'"
                + student_nameTxtbox.Text + "','" + student_departmentTxtbox.Text + "','" + picturpathTxtbox.Text + "')";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            //codes for mediating the language or world of C# and MSSQL
            adaptersql = new SqlDataAdapter();
            adaptersql.InsertCommand = command;
            command.ExecuteNonQuery();

            //mssql query to display the contents of student table located inside the database
            sql = "SELECT * FROM studentTbl";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            //codes for mediating the language or world of C# and MSSQL
            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();

            //codes for mirroring the contents of the databse inside the MSSQL going to C# or Visual Studio
            dset = new DataSet();
            adaptersql.Fill(dset, "studentTbl");

            //codes for displaying the contents of student table to the inside of data grid view
            datagrid_display.DataSource = dset.Tables[0];

            //clearing of textboxes after saving the data to the new database
            pictureBox1.Image = Image.FromFile("C:\\Users\\Delli7\\Desktop\\software design\\payroll and shop\\images/default.png");

            student_numTxtbox.Clear();
            student_nameTxtbox.Clear();
            student_departmentTxtbox.Clear();
            picturpathTxtbox.Clear();

            connection.Close();

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            sql = "SELECT * FROM studentTbl WHERE student_no = '" + student_numTxtbox.Text + "'";
            command = new SqlCommand();
            command.CommandType= CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();

            dset = new DataSet();
            adaptersql.Fill(dset, "student Tbl");

            datagrid_display.DataSource = dset.Tables[0];

            student_nameTxtbox.Text = dset.Tables[0].Rows[0][1].ToString();
            student_departmentTxtbox.Text= dset.Tables[0].Rows[0][2].ToString();
            picturpathTxtbox.Text = dset.Tables[0].Rows[0][3].ToString();
            pictureBox1.Image = Image.FromFile(picturpathTxtbox.Text);

            connection.Close();


        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            sql = "DELETE * FROM studentTbl WHERE student_no = '" + student_numTxtbox.Text + "'";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.DeleteCommand = command;
            command.ExecuteNonQuery();

            sql = "SELECT * FROM studentTbl";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();

            dset = new DataSet();
            adaptersql.Fill(dset, "student Tbl");

            datagrid_display.DataSource = dset.Tables[0];

            connection.Close();

            student_numTxtbox.Clear();
            student_nameTxtbox.Clear();
            student_departmentTxtbox.Clear();
            student_numTxtbox.Focus();

            picturpathTxtbox.Text= "C:\\Users\\Delli7\\Desktop\\software design\\payroll and shop\\images/default.png";
            pictureBox1.Image = Image.FromFile(picturpathTxtbox.Text);


        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            sql = "UPDATE studentTbl SET student_name = '" + student_nameTxtbox.Text + "', student_department = '" + student_departmentTxtbox.Text + 
                "', picturepath = '" + picturpathTxtbox.Text + "' WHERE student_no = '" + student_numTxtbox.Text + "'";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.UpdateCommand = command;
            command.ExecuteNonQuery();

            sql = "SELECT * FROM studentTbl";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();

            dset = new DataSet();
            adaptersql.Fill(dset, "student Tbl");

            datagrid_display.DataSource = dset.Tables[0];

            connection.Close();


        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            student_numTxtbox.Clear();
            student_nameTxtbox.Clear();
            student_departmentTxtbox.Clear();
            student_numTxtbox.Focus();

            picturpathTxtbox.Text = "C: //Users/Delli7/Desktop/software design/payroll and shop/images/default.png";
            pictureBox1.Image = Image.FromFile(picturpathTxtbox.Text);

            connection.Open();

            sql = "SELECT * FROM studentTbl";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();

            dset = new DataSet();
            adaptersql.Fill(dset, "student Tbl");

            datagrid_display.DataSource = dset.Tables[0];

            connection.Close();
        }

        private void student_noTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            student_numTxtbox.Clear();
            student_nameTxtbox.Clear();
            student_departmentTxtbox.Clear();
            student_numTxtbox.Focus();

            picturpathTxtbox.Text = "C: //Users/Delli7/Desktop/software design/payroll and shop/images/default.png";
            pictureBox1.Image = Image.FromFile(picturpathTxtbox.Text);

            connection.Open();

            sql = "SELECT * FROM studentTbl";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();

            dset = new DataSet();
            adaptersql.Fill(dset, "student Tbl");

            datagrid_display.DataSource = dset.Tables[0];

            connection.Close();
        }
    }
}
