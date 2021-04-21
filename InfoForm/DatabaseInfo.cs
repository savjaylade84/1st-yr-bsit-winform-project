using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Sql;
using System.Data;

//---------------------------------------------------------------------------------------------------------------------------------------------------
/*
 * 
 * This class receive sql object and assign to this class local variable
 * 
 * 
 * author john jayson b. de leon
 *  Date Modify:10/05/2019
 *  
*/
//---------------------------------------------------------------------------------------------------------------------------------------------------


namespace InfoForm
{
    public class DatabaseInfo : AdminLogJournal
    {

        //set sql info
        private string query;
        private string con;
        private static string database;
        private static string table;
        private static string user;
        private static string password;
        private static string datasource;
        private const string colon = ";";
        private static DataGridView view;
        private static TextBox[] text;
        private static TextBox text2;
        private static PictureBox[] pictures;
        private static Label[] labels;
        private static PictureBox pictures2;
        private static ComboBox[] combos;
        private static ComboBox combos2;
        private Boolean integratedSecurity;
        private static DataSet set;
        private static Button btn;
        private static Button[] buttons;


        public DatabaseInfo() {

            view = new DataGridView();

        }

        //destroy this object
        ~DatabaseInfo() {


            //set sql info to null
            view = null;
            query = null;
            con = null;
            database = null;
            user = null;
            password = null;
            datasource = null;
            pictures = null;

        }

        //the full information of login in the database 
        public string ConnectionString
        {

            get => con;

            set => this.con = value;

        }

        //get the name of the table
        public string Table {

            set => table = value;
            get => table;

        }

        /*
         *this method is going to get the database name 
         *from unknown user
         * 
         */

        public string Database
        {

            get => database;

            set => database = "Initial Catalog = " + value + colon;

        }

        /*
         * 
         * this method is going to get the username or userid
         * from unknown user.
         * 
         */

        public string User
        {

            get => user;

            set => user = "user id = " + value + colon;

        }

        /*
         *
         *this method is going to get the server name
         * from unknown user.
         * 
         */
        public string Datasource
        {

            get => datasource;

            set => datasource = "Data Source = " + value + colon;

        }

        //getting the query
        public string Query
        {
            get => query;
            set => query = value;

        }

        /*
         * 
         * this method is going to get the password of the unknown user
         * 
         */
        public string Password {

            get => password;

            set => password = "password = " + value + colon;

        }

        //get the  integrated security
        public Boolean IntegratedSecurity {

            get => integratedSecurity;

            set => integratedSecurity = value;

        }

        //get the  dataset
        public DataSet dataset {

            get => set;
            set => set = value;

        }

        //get the datagridview 
        public DataGridView View {

            get => view;
            set => view = value;

        }

        //get the textboxes
        public TextBox[] textBox {

            set => text = value;
            get => text;

        }

        //get the textbox
        public TextBox Single_textBox {

            set => text2 = value;
            get => text2;

        }

        //get the pictureboxes
        public PictureBox[] Picture {

            set => pictures = value;
            get => pictures;

        }

        //get the picturebox
        public PictureBox Single_Picture {

            set => pictures2 = value;
            get => pictures2;

        }

        //get the comboxes
        public ComboBox[] comboBox {

            set => combos = value;
            get => combos;

        }

        public Label[] Labels {

            set => labels = value;
            get => labels;


        }

        public Button button {

            set => btn = value;
            get => btn;

        }

        public Button[] Buttons {

            set => buttons = value;
            get => buttons;

        }

    }
}
