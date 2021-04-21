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

/*
 * this application function as selling tranction to the user
 * Author:John Jayson B. De Leon
 * 
 */

namespace jayson_activity
{
    public partial class POSCashier : Form
    {
        //variable
        private static double discount_p, discount_a, total_d, total_a, price, change_r, change,tax;
        private static int quantity, total_quantity;
        private DataSet Data;
        private DatabaseController control;
        private string itemName = "itemTable";
        private string itemPrice = "priceTable";
        private string picpath = "picpathTable";


        //constructor of Form1
        public POSCashier()
        {
            control = new DatabaseController();
            try
            {
                control.ConnectionString = "Data Source =  SAVJAYLADE84\\SQLEXPRESS;" +
                                        " Initial Catalog = Emp_Info_DB;" +
                                        " user id = SAVJAYLADE\\jayson;" +
                                        "Integrated Security = true;";
                control.Connect();
            } catch
            {

                MessageBox.Show("Connection Failed");

            }

            control.dataset = Data;
            control.Table = "CashierDiagramTable";
            Data = new DataSet();
            InitializeComponent();
        }

        //sum of all total
        private void totalCount() {

            //count every transaction 
            total_quantity += quantity;
            total_d += discount_a;
            total_a += discount_p;

        } 

        //display change
        private double MoneyChange() {

            InitThis();

            if (MoneyGiven.Text != "")
            {
                change_r = Double.Parse(MoneyGiven.Text);     //get the amount to user 
                change = change_r - discount_p;                 //get the change

            }
            else {

                MessageBox.Show(
                "Missing Money Input!", "Alert",                 //alert user if the change render is empty
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            // alert the user if its money is uneffecient to buy the item
            return change < 0 ? GetNoMoney() : change;

        }

        private double GetNoMoney()
        {
            MoneyGiven.Text = "";
            UserChange.Text = "";
            return (double)MessageBox.Show(
           "Your money is not enough to buy this item!", "Alert",       //alert user if it money is suffiecient to the amount of a item
            MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        //cancel button
        private void button3_Click(object sender, EventArgs e) => ClearMe();          //call the ClearME function to clear some textbox

        private void InitThis() {

            if (ItemPrice.Text != "" && ItemQuantity.Text != "")
            {

                // getting the value from textbox 
                //and declare it to a variable 
                //but first convert it to specify data
                quantity = Int32.Parse(ItemQuantity.Text);
                price = Double.Parse(ItemPrice.Text);
                
                if(ItemDiscountAmount.Text != "")
                discount_a = Double.Parse(ItemDiscountAmount.Text);

                discount_a = ((double)quantity * price) * tax;
                discount_p = ((double)quantity * price) - discount_a;       //formula

            }
            //else {

              //  MessageBox.Show(
                //"Missing Either or both:\nQuantity ,Price ,or Discount amount Input!", "Alert",     //alert the user if price , quantity
                // MessageBoxButtons.OK, MessageBoxIcon.Error);                                       // and discount amount textbox are empty

            //}

        }

        //exit button
        private void button5_Click(object sender, EventArgs e) => Exit();                 //call exit to close the  form

        private void picValue(string ab, double a) {              // get the order and display it

            if ((ItemQuantity.Text == "") && (ItemDiscountAmount.Text == ""))
            {

                ItemName.Text = string.Format("{0}", ab);            //name of the order
                ItemPrice.Text = string.Format("{0}", a);              //price of the order
            }
            else {

                MessageBox.Show("Must click new or cancel button to proceed the new transaction!","Alert!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

            }

        }

        //picture menu items
        private void pictureBox1_Click(object sender, EventArgs e) => picValue(name1.Text, Convert.ToDouble(price1.Text));     //leimpo adobo

        private void pictureBox2_Click(object sender, EventArgs e) => picValue(name2.Text, Convert.ToDouble(price2.Text));      //Bacon And Egg

        private void pictureBox3_Click(object sender, EventArgs e) => picValue(name3.Text, Convert.ToDouble(price3.Text));     //Fried Macarel

        private void pictureBox4_Click(object sender, EventArgs e) => picValue(name4.Text, Convert.ToDouble(price4.Text));      //Pinoy Pizza

        private void pictureBox5_Click(object sender, EventArgs e) => picValue(name5.Text, Convert.ToDouble(price5.Text));    //Premium Burger

        private void pictureBox6_Click(object sender, EventArgs e) => picValue(name6.Text, Convert.ToDouble(price6.Text));       //Adobo Steak

        private void pictureBox7_Click(object sender, EventArgs e) => picValue(name7.Text, Convert.ToDouble(price7.Text));      //pancit bihon

        private void pictureBox8_Click(object sender, EventArgs e) => picValue(name8.Text, Convert.ToDouble(price8.Text));        //spaghetti

        private void Menu_BZT_Click(object sender, EventArgs e) => picValue(name9.Text, Convert.ToDouble(price9.Text));        //Brazillian tacos

        private void Menu_MC_Click(object sender, EventArgs e) => picValue(name10.Text, Convert.ToDouble(price10.Text));        //mac and cheese

        private void Menu_FF_Click(object sender, EventArgs e) => picValue(name11.Text, Convert.ToDouble(price11.Text));        //french fries

        private void Menu_JBF_Click(object sender, EventArgs e) => picValue(name12.Text, Convert.ToDouble(price12.Text));        //j's breakfast

        private void Menu_GS_Click(object sender, EventArgs e) => picValue(name13.Text, Convert.ToDouble(price13.Text));        //german steak

        private void Menu_SS_Click(object sender, EventArgs e) => picValue(name14.Text, Convert.ToDouble(price14.Text));        //steak sauce

        private void Menu_AG_Click(object sender, EventArgs e) => picValue(name15.Text, Convert.ToDouble(price15.Text));        //argentina grill

        private void Menu_WS_Click(object sender, EventArgs e) => picValue(name16.Text, Convert.ToDouble(price16.Text));        //wanton soup

        private void Menu_PTB_Click(object sender, EventArgs e) => picValue(name17.Text, Convert.ToDouble(price17.Text));        //pieta bread

        private void Menu_SW_Click(object sender, EventArgs e) => picValue(name18.Text, Convert.ToDouble(price18.Text));        //sweet pork

        private void Menu_BP_Click(object sender, EventArgs e) => picValue(name19.Text, Convert.ToDouble(price19.Text));        //berry pie

        private void Menu_RT_Click(object sender, EventArgs e) => picValue(name20.Text, Convert.ToDouble(price20.Text));        //russian turon

        //display discount price
        private void textBox4_Enter(object sender, EventArgs e)
        {

            InitThis();             //call the initThis to get the data and formula needs
            ItemDiscountPrice.Text = String.Format("{0}", discount_p);      //print the discount price

        }

        private double GetDiscount() {
            InitThis();
            return discount_a;

        } //get the discount
    
        private void SetDiscount(double a) {
            InitThis();
            tax = a;

        } //set the discount

        private void MoneyGiven_Click(object sender, EventArgs e)
        {

        }

        //display discount 
        public void DisplayDiscount(double a){

            InitThis();
            SetDiscount(a);
            ItemDiscountAmount.Text = string.Format("{0}", GetDiscount());
            ItemDiscountPrice.Text = string.Format("{0}",discount_p);

        }

        private void CheckRadioButton_Clicked() {

            InitThis();                                                 //call the InitThis to get the data and formula needs

            //check if one of the radio button is selected
            if (radioButton2.Checked)
            {

                if (ItemDiscountAmount.Text == "" && discount_a <= 0)
                {
                    DisplayDiscount(0.30);
                }

            }
            else if (radioButton1.Checked)
            {


                if (ItemDiscountAmount.Text == "" && discount_a <= 0)
                {
                    DisplayDiscount(0.10);
                }

            }
            else if (radioButton3.Checked)
            {

                if (ItemDiscountAmount.Text == "" && discount_a <= 0)
                {
                    DisplayDiscount(0.05);
                }

            }
            else
            {

                if (ItemDiscountAmount.Text == "" && discount_a <= 0)
                {
                    DisplayDiscount(0.00);
                }
            }



        }

        //event for numpad in the form
        private void button6_Click(object sender, EventArgs e) => addNumber('1'); 

        private void button7_Click(object sender, EventArgs e) => addNumber('2');

        private void button8_Click(object sender, EventArgs e) => addNumber('3');

        private void button9_Click(object sender, EventArgs e) => addNumber('4');

        private void button10_Click(object sender, EventArgs e) => addNumber('5');

        private void button11_Click(object sender, EventArgs e) => addNumber('6');

        private void button12_Click(object sender, EventArgs e) => addNumber('7');

        private void button13_Click(object sender, EventArgs e) => addNumber('8');

        private void button21_Click(object sender, EventArgs e) => addNumber('9');

        private void button15_Click(object sender, EventArgs e) => addNumber('0');

        private void button14_Click(object sender, EventArgs e) => MoneyGiven.Clear();

        private void button16_Click(object sender, EventArgs e) => addNumber('.');


        //enter num to money given
        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void changeBtn_Click(object sender, EventArgs e)
        {

            control.Open();
            //showing the  data contents of those three tables above 
            control.Query = " SELECT * FROM " + this.itemName + "   INNER JOIN  " + this.itemPrice + " ON " +
         this.itemName + ".pos_id =" + this.itemPrice + ".pos_id " +
          " INNER JOIN " + this.picpath + " ON " + this.itemPrice + ".pos_id = " + this.picpath + ".pos_id  WHERE itemTable.pos_id = " + posid.Text;
            control.ExecuteQuery("select");

            //show the database in the datagridview
            control.dataset = Data;
            control.setDataSet("CashierDiagramTable");

            control.Labels = new Label[] {

                name1,name2,name3,name4,name5
                ,name6,name7,name8,name9,name10
                ,name11,name12,name13,name14,name15
                ,name16,name17,name18,name19,name20

            };
            control.InsertDataToLabel(0,0,0,1);

            control.textBox = new TextBox[] {

                price1,price2,price3,price4,price5
                ,price6,price7,price8,price9,price10
                ,price11,price12,price13,price14,price15
                ,price16,price17,price18,price19,price20

            };
            control.InsertDataToTextBox(0,0,0,22);

            control.Picture = new PictureBox[] {

                menu1,menu2,menu3,menu4,menu5
                ,menu6,menu7,menu8,menu9,menu10
                ,menu11,menu12,menu13,menu14,menu15
                ,menu16,menu17,menu18,menu19,menu20

            };
            control.InsertDataToImage(0,0,0, 44);

            control.Close();


        }

        private void DisplayDiscount() {

            if (ItemQuantity.Text != "")
                CheckRadioButton_Clicked();
            else
                MessageBox.Show("Quantity input missing!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) => DisplayDiscount();
        private void radioButton1_CheckedChanged(object sender, EventArgs e) => DisplayDiscount();
        private void radioButton3_CheckedChanged(object sender, EventArgs e) => DisplayDiscount();
        private void radioButton4_CheckedChanged(object sender, EventArgs e) => DisplayDiscount();




        //clear all the textbox
        private void button1_Click(object sender, EventArgs e)
        {
         
            totalCount();       //call the totalCount to add all the total discount amount,
                                //discount price and quantity
            ClearMe();          //call CLearMe to clean some textbox

        }

        //add the previous character to old character
        public void addNumber(char a) {

            MoneyGiven.Text += a;

        }

        //clear all
        private void ClearMe() {

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;

            //first panel of transaction
            ItemName.Clear();
            ItemQuantity.Clear();
            ItemPrice.Clear();
            ItemDiscountAmount.Clear();
            ItemDiscountPrice.Clear();

            //lower part of the application
            UserChange.Clear();
            MoneyGiven.Clear();

        }

       //display the total of all
        private void button2_Click(object sender, EventArgs e)
        {
            if (Calculate.CanSelect)
            {
                totalCount();               //total all the total price ,quantity and discount
                MoneyChange();              //get the change
                PrintTotal();

            }

        }

        //display all the total in the middle panel 
        private void PrintTotal() {

            ItemTotalGiven.Text = string.Format("{0}", total_d);              //total discount
            ItemTotalQuantity.Text = string.Format("{0}", total_quantity);      //total quantity
            ItemTotalAmount.Text = string.Format("{0}", total_a);              //total amount
            UserChange.Text = string.Format("{0}", change);

        }

        //close the form
        private void Exit() {

            DialogResult d = MessageBox.Show(
            "Do you want to exit?","alert",                     //alert user if it want to exit
            MessageBoxButtons.YesNo, MessageBoxIcon.Error);

            if (d == DialogResult.Yes)                         //if yes button click then exit this form
            {
                this.Close();                                  //close the form
            }

        }       // close this form 

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
