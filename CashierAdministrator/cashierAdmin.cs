using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Sql;
using InfoForm;

/// <summary>
/// 
/// this type of window form is created to let administrator to
/// edit its selling item in the other form
/// 
/// the functionality deals of storing,restoring,updating and deleting
/// data in the database and
/// retrieve it to the other form
/// 
/// its retrieve name of the product,price of the product and picture that will transport
/// to other form
/// 
/// @AUTHOR:John Jayson B. De Leon
/// Date Create:02/23/19
/// Date Modified:05/08/19
/// 
/// </summary>

namespace CashierAdministrator
{
    public partial class CashierAdministrator : Form
    {
       
        //variables
        private DatabaseController control;
        protected static int id;
        private Cleaner clean;
        private GetItem getItem;
        private DataSet Data;
        private string itemName = "itemTable";
        private string itemPrice = "priceTable";
        private string picpath = "picpathTable";
        private string picture;


        //this constructor is trying to connect to the database server
        //also inititalize all the component needed
        public CashierAdministrator()
        {
            initObject();
            try
            {
                control.ConnectionString = "Data Source =  SAVJAYLADE84\\SQLEXPRESS;" +
                                        " Initial Catalog = Emp_Info_DB;" +
                                        " user id = SAVJAYLADE\\jayson;" +
                                        "Integrated Security = true;";
                control.Connect();
            }catch{

                MessageBox.Show("Connection Failed");

            }

            control.dataset = Data;
            control.Table = "CashierDiagramTable";
            InitializeComponent();
      
        }

       //initialize the object
        private void initObject() {

            clean = new Cleaner();
            getItem = new GetItem();
            control = new DatabaseController();
            Data = new DataSet();
            id = 10;

        }

        //get the image source and display it
        private void GetImage(PictureBox picture,TextBox a) {

                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image File |*.jpg;*.jpeg;*.png;*.gif;*bmp;";
                dialog.ShowDialog();
                picture.Image = Image.FromFile(dialog.FileName);
                this.picture = dialog.FileName;
                a.Text = this.picture;

        }


        private void insertData() { }

        //show the database in this form load or started
        private void CashierAdministrator_Load(object sender, EventArgs e)
        {
            control.Open();
            control.Query = " SELECT * FROM " + this.itemName + "   INNER JOIN  " + this.itemPrice + " ON " +
                this.itemName +".pos_id ="+ this.itemPrice +".pos_id " +
                 " INNER JOIN " + this.picpath + " ON " +this.itemPrice+".pos_id = "+this.picpath+".pos_id ";
            control.ExecuteQuery("select");
            control.dataset = Data;
            control.View = gridview;
            control.ViewDataTable(0);
            control.Close();
        }

        //displaying and getting the picture in the disk
        private void PicItem1_Click(object sender, EventArgs e) { GetImage(PicItem1, picpath1); }
        private void PicItem2_Click(object sender, EventArgs e) { GetImage(PicItem2, picpath2); }
        private void PicItem3_Click(object sender, EventArgs e) { GetImage(PicItem3, picpath3); }
        private void PicItem4_Click(object sender, EventArgs e) { GetImage(PicItem4, picpath4); }
        private void PicItem5_Click(object sender, EventArgs e) { GetImage(PicItem5, picpath5); }
        private void PicItem6_Click(object sender, EventArgs e) { GetImage(PicItem6, picpath6); }   
        private void PicItem7_Click(object sender, EventArgs e) { GetImage(PicItem7, picpath7); }
        private void PicItem8_Click(object sender, EventArgs e) { GetImage(PicItem8, picpath8); }
        private void PicItem9_Click(object sender, EventArgs e) { GetImage(PicItem9, picpath9); }
        private void PicItem10_Click(object sender, EventArgs e) { GetImage(PicItem10, picpath10); }
        private void PicItem11_Click(object sender, EventArgs e) { GetImage(PicItem11, picpath11); }
        private void PicItem12_Click(object sender, EventArgs e) { GetImage(PicItem12, picpath12); }
        private void PicItem13_Click(object sender, EventArgs e) { GetImage(PicItem13, picpath13); } 
        private void PicItem14_Click(object sender, EventArgs e) { GetImage(PicItem14, picpath14); }
        private void PicItem15_Click(object sender, EventArgs e) { GetImage(PicItem15, picpath15); }
        private void PicItem16_Click(object sender, EventArgs e) { GetImage(PicItem16, picpath16); }
        private void PicItem17_Click(object sender, EventArgs e) { GetImage(PicItem17, picpath17); }
        private void PicItem18_Click(object sender, EventArgs e) { GetImage(PicItem18, picpath18); }
        private void PicItem19_Click(object sender, EventArgs e) { GetImage(PicItem19, picpath19); }
        private void PicItem20_Click(object sender, EventArgs e) { GetImage(PicItem20, picpath20); }

        //saving all the item data to the database
        private void save_Click(object sender, EventArgs e)
        {
            control.Open();

            //inserting data for itemTable in the database
            control.Query = "INSERT INTO itemTable VALUES('"+ PosId.Text +"','"
                + Item1.Text+"','"+Item2.Text+ "','" + Item3.Text + "','" +  Item4.Text +"','" + Item5.Text + "','" 
                + Item6.Text + "','" + Item7.Text + "','" + Item8.Text + "','" + Item9.Text +"','" + Item10.Text + "','" 
                + Item11.Text + "','" + Item12.Text + "','" + Item13.Text + "','" + Item14.Text +"','" + Item15.Text + "','" 
                + Item16.Text + "','" + Item17.Text + "','" + Item18.Text + "','" + Item19.Text +"','" + Item20.Text + "')";
            control.ExecuteQuery("insert");

            //inserting data for price table in the database
            control.Query = "INSERT INTO priceTable VALUES('"+ PosId.Text +"','"
                + itemPrice1.Text +"','"+ itemPrice2.Text + "','" + itemPrice3.Text + "','" + itemPrice4.Text + "','" + itemPrice5.Text + "','"
                + itemPrice6.Text + "','" + itemPrice7.Text + "','" + itemPrice8.Text + "','" + itemPrice9.Text + "','" + itemPrice10.Text + "','" 
                + itemPrice11.Text + "','" + itemPrice12.Text + "','" + itemPrice13.Text + "','" + itemPrice14.Text + "','" + itemPrice15.Text + "','" 
                + itemPrice16.Text + "','" + itemPrice17.Text + "','" + itemPrice18.Text + "','" + itemPrice19.Text + "','" + itemPrice20.Text + "')";
            control.ExecuteQuery("insert");

            //inserting data for picpathTable in the database
            control.Query = "INSERT INTO picpathTable VALUES('"+ PosId.Text + "','" 
                + picpath1.Text + "','" + picpath2.Text + "','" + picpath3.Text + "','" + picpath4.Text + "','" + picpath5.Text + "','" 
                + picpath6.Text + "','" + picpath7.Text + "','" + picpath8.Text + "','" + picpath9.Text + "','" + picpath10.Text + "','" 
                + picpath11.Text + "','" + picpath12.Text + "','" + picpath13.Text + "','" + picpath14.Text + "','" + picpath15.Text + "','" +
                picpath16.Text + "','" + picpath17.Text + "','" + picpath18.Text + "','" + picpath19.Text + "','" + picpath20.Text + "')";
            control.ExecuteQuery("insert");

            //showing the  data contents of those three tables above 
            control.Query = " SELECT * FROM " + this.itemName + "   INNER JOIN  " + this.itemPrice + " ON " +
         this.itemName + ".pos_id =" + this.itemPrice + ".pos_id " +
          " INNER JOIN " + this.picpath + " ON " + this.itemPrice + ".pos_id = " + this.picpath + ".pos_id ";
            control.ExecuteQuery("select");

            //show the database in the datagridview
            control.dataset = Data;
            control.View = gridview;
            control.ViewDataTable(0);


            control.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            //ask user if it want to exit
            DialogResult dr = MessageBox.Show("Do you want to exit?",
                "Warning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            //if it a yes close the form
            if (dr == DialogResult.Yes)
                this.Close();
        }

        //delete or clean all the content of textboxe and combox
        private void newCancel_Click(object sender, EventArgs e)
        {
            clean.Textboxes = new TextBox[] { Item1, Item2 , Item3, Item4, Item5, Item6, Item7, Item8, Item9, Item10, Item12, Item13, Item14,
            Item15 , Item16 , Item17 , Item18 ,Item19 ,Item20 , itemPrice1 , itemPrice2 , itemPrice3 , itemPrice4 , itemPrice5 , itemPrice6 ,
             itemPrice7 , itemPrice8 , itemPrice9 , itemPrice10 , itemPrice11 , itemPrice12 , itemPrice13 , itemPrice14 , itemPrice15 , itemPrice16 ,
             itemPrice17 , itemPrice18 , itemPrice19 , itemPrice20 , picpath1 , picpath2 , picpath3 , picpath4 , picpath5 , picpath6 , picpath7 ,
             picpath8 , picpath9 , picpath10 , picpath11 , picpath12 , picpath13 , picpath14 , picpath15 , picpath16 , picpath17 , picpath18 ,
                picpath19 ,picpath20};

            clean.ClearTextboxes();

        }


        //delete data in a specify column
        private void delete_Click(object sender, EventArgs e)
        {
            control.Open();

            //deleting priceTable
            control.Query = "DELETE FROM priceTable WHERE priceTable.pos_id = " + PosId.Text;
            control.ExecuteQuery("delete");

            //deleting picpathTable
            control.Query = "DELETE FROM picpathTable WHERE .picpathTable.pos_id = " + PosId.Text;
            control.ExecuteQuery("delete");

            //deleting itemTable
            control.Query = "DELETE FROM itemTable WHERE itemTable.pos_id = " + PosId.Text;
            control.ExecuteQuery("delete");

            //showing the  data contents of those three tables above 
            control.Query = " SELECT * FROM " + this.itemName + "   INNER JOIN  " + this.itemPrice + " ON " +
         this.itemName + ".pos_id =" + this.itemPrice + ".pos_id " +
          " INNER JOIN " + this.picpath + " ON " + this.itemPrice + ".pos_id = " + this.picpath + ".pos_id ";
            control.ExecuteQuery("select");

            //show the database in the datagridview
            control.dataset = Data;
            control.View = gridview;
            control.ViewDataTable(0);

            control.Close();
        }

        private void search_Click(object sender, EventArgs e)
        {
            control.Open();
            //showing the  data contents of those three tables above 
            control.Query = " SELECT * FROM " + this.itemName + "   INNER JOIN  " + this.itemPrice + " ON " +
         this.itemName + ".pos_id =" + this.itemPrice + ".pos_id " +
          " INNER JOIN " + this.picpath + " ON " + this.itemPrice + ".pos_id = " + this.picpath + ".pos_id  WHERE itemTable.pos_id = " + PosId.Text;
            control.ExecuteQuery("select");

            //show the database in the datagridview
            control.dataset = Data;
            control.View = gridview;
            control.ViewDataTable(0);

            //inserting itemTable data into textboxes
            control.textBox = new TextBox[] {

                Item1,Item2,Item3,Item4,Item5,
                Item6,Item7,Item8,Item9,Item10,
                Item11,Item12,Item13,Item14,Item15,
                Item16,Item17,Item18,Item19,Item20,

            };
            control.InsertDataToTextBox(0,0,0,1);


            //inserting priceTable data into textboxes
            control.textBox = new TextBox[] {

                itemPrice1,itemPrice2,itemPrice3,itemPrice4,itemPrice5,
                itemPrice6,itemPrice7,itemPrice8,itemPrice9,itemPrice10,
                itemPrice11,itemPrice12,itemPrice13,itemPrice14,itemPrice15,
                itemPrice16,itemPrice17,itemPrice18,itemPrice19,itemPrice20,

            };
            control.InsertDataToTextBox(0, 0, 0, 22);

            //inserting picpathTable data into pictureboxes
            control.Picture = new PictureBox[] {

                PicItem1,PicItem2,PicItem3,PicItem4,PicItem5,
                PicItem6,PicItem7,PicItem8,PicItem9,PicItem10,
                PicItem11,PicItem12,PicItem13,PicItem14,PicItem15,
                PicItem16,PicItem17,PicItem18,PicItem19,PicItem20,

            };
            control.InsertDataToImage(0, 0, 0, 43);

            control.Close();
        }

        //update database   
        private void update_Click(object sender, EventArgs e)
        {

            control.Open();
            
            //update data in the itemtable
            control.Query =
                "UPDATE itemTable SET "+
                "item1 = '" + Item1.Text +"', item2 ='" + Item2.Text + "', item3 ='" + Item3.Text + "', item4 ='" + Item4.Text + "', item5 ='" + Item5.Text
                + "', item6 ='" + Item6.Text + "', item7 ='" + Item7.Text + "', item8 ='" + Item8.Text + "', item9 ='" + Item9.Text + "', item10 ='" + Item10.Text 
                + "', item11 ='" + Item11.Text+ "', item12 ='" + Item12.Text + "', item13 ='" + Item13.Text + "', item14 ='" + Item14.Text + "', item15 ='" + Item15.Text 
                + "', item16 ='" + Item16.Text + "', item17 ='" + Item17.Text + "', item18 ='" + Item18.Text + "', item19 ='" + Item19.Text + "', item20 ='" + Item20.Text 
                + "' WHERE pos_id = '" + PosId.Text + "'";
            control.ExecuteQuery("update");

            //update data in the priceTable
            control.Query = 
                "UPDATE priceTable SET "+
                "price1 = " + itemPrice1.Text + ", price2 = " + itemPrice2.Text + ", price3 = " + itemPrice3.Text + ", price4 = " + itemPrice4.Text +
                ", price5 = " + itemPrice5.Text + ", price6 = " + itemPrice6.Text + ", price7 = " + itemPrice7.Text + ", price8 = " + itemPrice8.Text +
                ", price9 = " + itemPrice9.Text + ", price10 = " + itemPrice10.Text + ", price11 = " + itemPrice11.Text + ", price12 = " + itemPrice12.Text +
                ", price13 = " + itemPrice13.Text + ", price14 = " + itemPrice14.Text +", price15 = " + itemPrice15.Text + ", price16 = " + itemPrice16.Text +
                ", price17 = " + itemPrice17.Text + ", price18 = " + itemPrice18.Text + ", price19 = " + itemPrice19.Text + ", price20 = " + itemPrice20.Text +
                " WHERE pos_id =  " + PosId.Text;
            control.ExecuteQuery("update");

            control.Query = "";
            control.ExecuteQuery("update");

            //showing the  data contents of those three tables above 
            control.Query = " SELECT * FROM " + this.itemName + "   INNER JOIN  " + this.itemPrice + " ON " +
         this.itemName + ".pos_id =" + this.itemPrice + ".pos_id " +
          " INNER JOIN " + this.picpath + " ON " + this.itemPrice + ".pos_id = " + this.picpath + ".pos_id ";
            control.ExecuteQuery("select");

            //show the database in the datagridview
            control.dataset = Data;
            control.View = gridview;
            control.ViewDataTable(0);

            control.Close();

        }

        private void add_Click(object sender, EventArgs e)
        {

            PosId.Items.Add(++id);

        }
    }
}
