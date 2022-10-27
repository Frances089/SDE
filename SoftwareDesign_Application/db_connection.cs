using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;


namespace SoftwareDesign_Application
{
    internal class db_connection
    {
        //declaration of variables for database and query which is used to access it from one form to another
        public String connectionString = null;
        public SqlConnection sql_connection;
        public SqlCommand sql_command;
        public DataSet sql_dataset;
        public SqlDataAdapter sql_dataadapter;
        public string sql = null;


        public void connString()
        {
            sql_connection = new SqlConnection();
            connectionString = "Data Source = DESKTOP-G3VQF4N\\SQLEXPRESS; Initial Catalog = software_designDb; user id = mel; password = erzascarlet";
            sql_connection = new SqlConnection(connectionString);
            sql_connection.ConnectionString = connectionString;
            sql_connection.Open();
        }
        public void cmd()
        {
            sql_command = new SqlCommand(sql, sql_connection);
            sql_command.CommandType = CommandType.Text;

        }
        public void sqladapterSelect()
        {
           
                sql_dataadapter = new SqlDataAdapter();
                sql_dataadapter.SelectCommand = sql_command;
                sql_command.ExecuteNonQuery();
          

        }
        public void sqladapterInsert()
        {
            sql_dataadapter = new SqlDataAdapter();
            sql_dataadapter.InsertCommand = sql_command;
            sql_command.ExecuteNonQuery();
        }
        public void sqladapterDelete()
        {
            sql_dataadapter = new SqlDataAdapter();
            sql_dataadapter.DeleteCommand = sql_command;
            sql_command.ExecuteNonQuery();
        }
        public void sqladapterUpdate()
        {
            sql_dataadapter = new SqlDataAdapter();
            sql_dataadapter.UpdateCommand = sql_command;
            sql_command.ExecuteNonQuery();
        }
        public void sqladapterDataset()
        {
            sql_dataset = new DataSet();
            sql_dataadapter.Fill(sql_dataset, "studentTbl");
        }
    }
}

