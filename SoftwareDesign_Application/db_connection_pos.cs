using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;
using System.Diagnostics;
using System.Xml.Linq;

namespace SoftwareDesign_Application
{
    internal class db_connection_pos
    {
        public String pos_connectionString = null;
        public SqlConnection pos_sql_connection;
        public SqlCommand pos_sql_command;
        public DataSet pos_sql_dataset;
        public SqlDataAdapter pos_sql_dataadapter;
        public string pos_sql = null;
        public void pos_connString()
        {
            pos_sql_connection = new SqlConnection();
            pos_connectionString = "Data Source = DESKTOP-G3VQF4N\\SQLEXPRESS; Initial Catalog = software_designDb; user id = mel; password = erzascarlet";
            pos_sql_connection = new SqlConnection(pos_connectionString);
            pos_sql_connection.ConnectionString = pos_connectionString;
            pos_sql_connection.Open();
        }
        public void pos_cmd()
        {
            pos_sql_command = new SqlCommand(pos_sql, pos_sql_connection);
            pos_sql_command.CommandType = CommandType.Text;

        }
        public void pos_sqladapterSelect()
        {
            pos_sql_dataadapter = new SqlDataAdapter();
            pos_sql_dataadapter.SelectCommand = pos_sql_command;
            pos_sql_command.ExecuteNonQuery();

        }
        public void pos_sqladapterInsert()
        {
            pos_sql_dataadapter = new SqlDataAdapter();
            pos_sql_dataadapter.InsertCommand = pos_sql_command;
            pos_sql_command.ExecuteNonQuery();
        }
        public void pos_sqladapterDelete()
        {
            pos_sql_dataadapter = new SqlDataAdapter();
            pos_sql_dataadapter.DeleteCommand = pos_sql_command;
            pos_sql_command.ExecuteNonQuery();
        }
        public void pos_sqladapterUpdate()
        {
            pos_sql_dataadapter = new SqlDataAdapter();
            pos_sql_dataadapter.UpdateCommand = pos_sql_command;
            pos_sql_command.ExecuteNonQuery();
        }
        public void pos_sqldatasetSELECT()
        {
            pos_sql_dataset = new DataSet();
            pos_sql_dataadapter.Fill(pos_sql_dataset, "pos_itemnameTbl");
        }

        public void pos_sqldatasetSELECTSALES()
        {
            pos_sql_dataset = new DataSet();
            pos_sql_dataadapter.Fill(pos_sql_dataset, "salesTbl");
        }
        public void pos_select()
        {
            pos_sql = "SELECT * FROM pos_itemnameTbl INNER JOIN pos_picpathTbl ON pos_itemnameTbl.stock_id=pos_picpathTbl.stock_id INNER JOIN pos_priceTbl ON  pos_picpathTbl.stock_id= pos_priceTbl.stock_id";
        }
        public void pos_select_cashier()
        {
            pos_sql = "SELECT * FROM pos_itemnameTbl INNER JOIN pos_picpathTbl ON pos_itemnameTbl.stock_id=pos_picpathTbl.stock_id INNER JOIN pos_priceTbl ON pos_picpathTbl.stock_id = pos_priceTbl.stock_id WHERE pos_itemnameTbl.stock_id = 1";
        }

        public void pos_select_cashier1()
        {
            pos_sql = "SELECT * FROM pos_itemnameTbl INNER JOIN pos_picpathTbl ON pos_itemnameTbl.stock_id=pos_picpathTbl.stock_id INNER JOIN pos_priceTbl ON pos_picpathTbl.stock_id = pos_priceTbl.stock_id WHERE pos_itemnameTbl.stock_id = 2";
        }

        public void pos_select_cashier_display()
        {
            pos_sql = "SELECT pos_empregTbl.emp_id, emp_fname, emp_surname, pos_terminal_no, account_type FROM pos_empRegTbl INNER JOIN useraccountTbl ON pos_empRehTbl.emp_id = useraccountTbl.emp_id WHERE account_type ='Administartor";
        }
        public void pos_select_cashier_Selectdisplay()
        {
            pos_sql_dataset = new DataSet();
            pos_sql_dataadapter.Fill(pos_sql_dataset, "pos_empRegTbl");
        }
    }
}

       


