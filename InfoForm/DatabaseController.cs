using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Sql;
using System.Data;
using System.Windows.Forms;
using InfoForm;
using System.Drawing;
using System.Threading;

//------------------------------------------------------------------------------------------------
/*
 *  <p>
 * 
 *      this class contains methods to connect 
 *      and manipulate database in a less coupling way 
 * 
 *  </p>
 * 
 *  @author john jayson b. de leon
 *  Date Modify:24/03/2019
 * 
 * 
 */
//--------------------------------------------------------------------------------------------------

namespace InfoForm
{
    public class DatabaseController : DatabaseInfo
    {

        //declare sql objects
        private SqlCommand command;
        private SqlConnection conn;
        private SqlDataAdapter Adapter;
        private string datarow;
        private string datatable;
        private string log;

        //initilize sql objects
        public DatabaseController(){

            Adapter = new SqlDataAdapter();
            conn = new  SqlConnection();
            command = new SqlCommand();

        }

       //destroy this object
        ~DatabaseController() {

            //set sql objects to null
            Adapter = null;
            conn = null;
            command = null;
        }

        //open the connection
        public void Open() {

            //test if the connection is open 
            try
            {
                conn.Open();

            } catch (SqlException e) {

                MessageBox.Show("Cannot Open a Connection","Database Error:",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.ErrorLagWriterFile(new string[] { "SQL Opening Connection Error: ",
                 e.Message, e.LineNumber.ToString(), e.Source,
                 e.State.ToString(), e.TargetSite.ToString(), e.Server });

            }

        }

        //close the connection

        public void Close() {

            //test if the connection is close
            try
            {
                conn.Close();
            } catch (SqlException e) {

                MessageBox.Show("Cannot Close a Connection","Database Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ErrorLagWriterFile(new string[] { "SQL Closing Connection Error: ",
                 e.Message, e.LineNumber.ToString(), e.Source,
                 e.State.ToString(), e.TargetSite.ToString(), e.Server });

            }

            }

        //connect the database
        public void Connect() {

            //test if it can connection
            try
            {
                conn = new SqlConnection(ConnectionString);
            } catch (SqlException e) {

                MessageBox.Show("Connection Failed","Database Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ErrorLagWriterFile(new string[] { "SQL Connection Error: ",
                 e.Message, e.LineNumber.ToString(), e.Source,
                 e.State.ToString(), e.TargetSite.ToString(), e.Server });
            }

        }

        //determine the type of Adapter command
        private void AdapterType(string CommadType) {

            switch (CommadType.ToLower()) {

                case "select":

                    try { Adapter.SelectCommand = command; } catch(SqlException e) {

                        MessageBox.Show("Cannot Retrieve Data From DataBase ", "Database Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.ErrorLagWriterFile(new string[] { "SQL Select Command Error: ",
                        e.Message, e.LineNumber.ToString(), e.Source,
                        e.State.ToString(), e.TargetSite.ToString(), e.Server });

                    }

                    break;

                case "insert":

                    try { Adapter.InsertCommand = command; } catch (SqlException e) {

                        MessageBox.Show("Cannot Send Data to DataBase ", "Database Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.ErrorLagWriterFile(new string[] { "SQL Insert Command Error: ",
                        e.Message, e.LineNumber.ToString(), e.Source,
                        e.State.ToString(), e.TargetSite.ToString(), e.Server });

                    }

                    break;

                case "update":

                    try { Adapter.UpdateCommand = command; } catch(SqlException e) {

                        MessageBox.Show("Cannot Update Data From DataBase ", "Database Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.ErrorLagWriterFile(new string[] { "SQL Update Command Error: ",
                        e.Message, e.LineNumber.ToString(), e.Source,
                        e.State.ToString(), e.TargetSite.ToString(), e.Server });

                    }

                    break;

                case "delete":

                    try { Adapter.DeleteCommand = command; } catch (SqlException e) {

                        MessageBox.Show("Cannot Delete Data From DataBase ", "Database Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.ErrorLagWriterFile(new string[] { "SQL Delete Command Error: ",
                        e.Message, e.LineNumber.ToString(), e.Source,
                        e.State.ToString(), e.TargetSite.ToString(), e.Server });

                    }

                    break;

                default:


                    break;


            }

        }
        
        /*
         *
         *  this method is trying to execute query from the query string
         *  if the query is cannot execute then throw dialog and 
         *  write the error in the errorlag.text
         * 
         */
        public void ExecuteQuery(string AdapterType) {

            using (command = new SqlCommand(Query, conn))
            {
                command.CommandType = CommandType.Text;

                //determine the type of data manipulation is needed to use
                this.AdapterType(AdapterType);

                //test to execute the query
                try { command.ExecuteNonQuery(); } catch (SqlException e)
                {

                    MessageBox.Show("Cannot Access Database", "Database Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.ErrorLagWriterFile(new string[] { "SQL Query Execution Error: ",
                   e.Message, e.LineNumber.ToString(), e.Source,
                    e.State.ToString(), e.TargetSite.ToString(), e.Server });
                }
            }
        }


        //set the view of database in the datagrid view
        public void ViewDataTable(int Table) {

            //test if the adpater can fill the database
            try { this.Adapter.Fill(dataset, this.Table); }
            //catch adapter filled if its already filled
            catch (SqlAlreadyFilledException e) { this.errorAdpaterFilled(e); }
            //catch adapter filled if the its a filled is empty
            catch (SqlNotFilledException e) { this.errorAdpaterFilled(e); }

            View.DataSource = dataset.Tables[Table];

        }

        private void errorAdpaterFilled(Exception e) {

            MessageBox.Show("Cannot Access Database", "Database Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.ErrorLagWriterFile(new string[] { "SQL Adapter Filled Error: ",
                   e.Message, e.Source, e.TargetSite.ToString()});


        }

        //set the view of database in the datagrid view
        public void ViewDataTable(int Table,string TableName)
        {

            //test if the adpater can fill the database
            try{this.Adapter.Fill(dataset, TableName);} 
            //catch adapter filled if its already filled
            catch (SqlAlreadyFilledException e) { this.errorAdpaterFilled(e); }
            //catch adapter filled if the its a filled is empty
            catch (SqlNotFilledException e){ this.errorAdpaterFilled(e); }

            View.DataSource = dataset.Tables[Table];

        }

        // fill the dataset with the data in the given table
        public void setDataSet(string TableName) {

            this.Adapter.Fill(this.dataset, TableName);

        }

        //get the data set row then return it
        public String GetDataSetRow(int Table ,int Row1,int Row2) {

            try
            {
                this.datarow = dataset.Tables[Table].Rows[Row1][Row2].ToString();
            } catch (SqlException e) {

                MessageBox.Show("Cannot Retrieve Data From Database", "Database Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ErrorLagWriterFile(new string[] { "SQL Dataset Error: ",
                 e.Message, e.LineNumber.ToString(), e.Source,
                 e.State.ToString(), e.TargetSite.ToString(), e.Server });

            }
            return datarow;

        }

        //get the data set row then return it (version 2)
        public String GetDataSetRow(int Table, int Row)
        {

            try
            {
                this.datarow = dataset.Tables[Table].Rows[Row].ToString();
            } catch (SqlException e)
            {

                MessageBox.Show("Cannot Retrieve Data From Database", "Database Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ErrorLagWriterFile(new string[] { "SQL Dataset Error: ",
                 e.Message, e.LineNumber.ToString(), e.Source,
                 e.State.ToString(), e.TargetSite.ToString(), e.Server });

            }
            return datarow;

        }



        //get the data set row table then return it
        public String GetDataTable(int Table) {

            this.datatable = dataset.Tables[Table].ToString();

            return datatable;

        }

        //get the data in the database and put it to the textbox in a loop
        public void InsertDataToTextBox(int Table,int Size,int outerRow,int innerRow) {

            int j = innerRow;

            for (int i = outerRow ; i <= Size ; i++) {

                foreach (var a in textBox) {

                    a.Text = GetDataSetRow(Table,i,j++);


                }

            }

        }

        //get the data in the database and put it to the textbox (version 2)
        public void InsertDataToTextBox(int Table, int outerRow, int innerRow )
        {

                    Single_textBox.Text = GetDataSetRow(Table, outerRow, innerRow);

        }

        /*
         * this method get the array of picture that will hold the url of the image
         * from the database and each of its run through the loop it put the url which will may display
         * the image from url come from the database. 
         * 
         * data needed to input in the parameter are the number of table which the size of the 
         * data that will get and startfrom where it should be start in the loop and
         * startfrom2 is the second row of it.
         * 
         */

        // get all image path in the database and display image to the picturebox 
        public void InsertDataToImage(int Table, int Size, int outerRow, int innerRow) {


            int j = innerRow;

            for (int i = outerRow ; i <= Size ; i++)
            {

                foreach (PictureBox a in Picture)
                {

                    try { a.Image = Image.FromFile(GetDataSetRow(Table, i, j++)); } catch {

                        a.Image = Image.FromFile("C:\\Users\\jayson\\Pictures\\Other\\Unknown_empty.png");

                    }

                }

            }

        }

        //get a image path in the database and display image to the picturebox 
        public void InsertDataToImage(int Table, int outerRow, int innerRow)
        {

            try { Single_Picture.Image = Image.FromFile(GetDataSetRow(Table, outerRow, innerRow)); } catch
            {

                Single_Picture.Image = Image.FromFile("C:\\Users\\jayson\\Pictures\\Other\\Unknown_empty.png");

            }

        }

        //get all text in the  database and display text to the label
        public void InsertDataToLabel(int Table, int Size, int outerRow, int innerRow)
        {


            int j = innerRow;

            for (int i = outerRow ; i <= Size ; i++)
            {

                foreach (Label a in Labels)
                {

                    a.Text = GetDataSetRow(Table, i, j++);

                }

            }

        }


    }
}
