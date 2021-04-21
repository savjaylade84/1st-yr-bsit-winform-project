using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_info
{
    public partial class Form1 : Form
    {

        //variable
        string picpath;
        string ConnectionString;
        OpenFileDialog fileDialog;
        SqlConnection con;
        SqlCommand com;
        DataSet dataset;
        SqlDataAdapter adapter_sql;
        string command;
        string queries = null;

        //contructor
        public Form1()
        {

            //init sql
            initSqlConnection();

            //init components
            InitializeComponent();

        }

        public void InitThis() {

             fileDialog = new OpenFileDialog();

        }
        // test the connection of the database 
        public void initSqlConnection() {


            this.ConnectionString = "Data Source =  SAVJAYLADE84\\SQLEXPRESS;" +
                                    " Initial Catalog = student_info;" +
                                    " user = SAVJAYLADE\\jayson;" +
                                    "Integrated Security = true";

            //test the connection
            try
            {

                con = new SqlConnection(this.ConnectionString);

            } catch {

                MessageBox.Show("Failed Connection", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //set queries and execute it
        public void Queries(string a, string b) {

            this.queries = a;
            try {

                if (b != "view")
                {
                    DialogResult dr = MessageBox.Show("Do you want to " + b, "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (DialogResult.Yes == dr)
                    {
                        try
                        {
                            com = new SqlCommand(queries, con);
                            com.CommandType = CommandType.Text;
                        } catch {

                            MessageBox.Show("Failed to " + b, "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        }
                    }

                } else
                {
                    try
                    {
                        com = new SqlCommand(queries, con);
                        com.CommandType = CommandType.Text;
                    } catch
                    {

                        MessageBox.Show("Failed to " + b, "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    }
                }

            } catch {

                MessageBox.Show("Failed to" + b, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        // test the adapter sql
        public void initAdapterSql(string n) {

            adapter_sql = new SqlDataAdapter();

            //determine the adapter sql command
            if (n == "select")
                adapter_sql.SelectCommand = com;
            else if (n == "update")
                adapter_sql.UpdateCommand = com;
            else if (n == "insert")
                adapter_sql.InsertCommand = com;
            else if (n == "delete")
                adapter_sql.DeleteCommand = com;

            //test the execution
            try
            {

                com.ExecuteNonQuery();

            } catch {

                MessageBox.Show("Failed Connection", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        //clear textbox
        public void ClearAll(TextBox[] a) {

            foreach (TextBox b in a)
                b.Clear();

        }

        //opening database connection
        public void DBOpen() {

            try { con.Open(); } catch {

                MessageBox.Show("Failed to Open", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        //closing database connection
        public void DBClose() {

            try { con.Close(); } catch {

                MessageBox.Show("Failed to close", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        //getting image location and post it 
        public void GetImage() {

            InitThis();
            fileDialog.Filter = "Image File |*.jpg;*.jpeg;*.png;*.gif;*bmp;";
            fileDialog.ShowDialog();
            picture.Image = Image.FromFile(fileDialog.FileName);
            picpath = fileDialog.FileName;
            pictureURL.Text = fileDialog.FileName;

        }

        //show the result  in the search
        public void DisplaySearch()
        {
            //test if data exist
            try
            {
                std_id.Text = dataset.Tables[0].Rows[0][0].ToString();
                std_name.Text = dataset.Tables[0].Rows[0][1].ToString();
                std_dept.Text = dataset.Tables[0].Rows[0][2].ToString();
                pictureURL.Text = dataset.Tables[0].Rows[0][3].ToString();

                //test if picture path can find
                try
                {
                    picture.Image = Image.FromFile(pictureURL.Text);

                } catch
                {
                    MessageBox.Show(" picture file not found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } catch {

                MessageBox.Show("Data Not Found! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
  
        }

        // show the data in the datagrid
        public void GetDataSetView() {

            dataset = new DataSet();
            adapter_sql.Fill(dataset, "student Table");
            datagridview.DataSource = dataset.Tables[0];

        }

        // insert the data in database
        private void save_db_Click(object sender, EventArgs e)
        {

            DBOpen();

            Queries("INSERT INTO student_info_table "+
                    "VALUES('" +
                    std_id.Text + "','" + std_name.Text +
                    "','" + std_dept.Text + "','" + pictureURL.Text + "')","Save");

            initAdapterSql("insert");

            Queries("SELECT * FROM student_info_table", "view");

            initAdapterSql("select");

            GetDataSetView();

            DBClose();

        }

        //delete the data in database
        private void del_db_Click(object sender, EventArgs e)
        {


            DBOpen();

            Queries("DELETE  FROM student_info_table where std_id = " + std_id.Text, "delete");

            initAdapterSql("Delete");

            Queries("SELECT * from student_info_table", "view");

            initAdapterSql("select");

            GetDataSetView();

            ClearAll(new TextBox[] {
            pictureURL,std_id,std_name,std_dept
            });

            DBClose();

        }

        // load and view the data in the datagrid
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureURL.Hide();
            DBOpen();

            Queries("SELECT * from student_info_table", "view");

            initAdapterSql("select");

            GetDataSetView();

            DBClose();

        }

        //clear all textbox
        private void cancel_db_Click(object sender, EventArgs e) => ClearAll(new TextBox[] {
                                                                    pictureURL,std_id,std_name,std_dept
                                                                    });

        //create new 
        private void new_db_Click(object sender, EventArgs e) => ClearAll(new TextBox[] {
                                                                 pictureURL,std_id,std_name,std_dept
                                                                 });

        //edit and update  the data from databse
        private void edit_db_Click(object sender, EventArgs e)
        {
            DBOpen();
            Queries("UPDAte student_info_table SET std_name = '" + 
                std_name.Text + "',std_dept = '" +  std_dept.Text +"', std_pic_path = '" + pictureURL.Text + 
                "' WHERE std_id = '" + std_id.Text +"'","update");

            initAdapterSql("update");

            Queries("SELECT * from student_info_table", "view");

            initAdapterSql("select");

            GetDataSetView();

            ClearAll(new TextBox[] {
            pictureURL,std_id,std_name,std_dept
            });

            DBClose();
        }

        //search  the data
        private void search_db_Click(object sender, EventArgs e)
        {
            DBOpen();

            Queries("SELECT * from student_info_table  WHERE std_id = '" + std_id.Text +"'", "search");

            initAdapterSql("select");

            GetDataSetView();

            DisplaySearch();

            DBClose();
        }

        //get the path file of the picture and insert it to database
        private void picture_Click(object sender, EventArgs e) => GetImage();
    }
}
