using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InfoForm;

namespace Employee_Payslip
{
    public partial class Controller_Payroll : Form
    {

        //declare variable
        private double rate, income, honoraium, OPay, grossincome, deduction;
        private int hour;
        private TextBox a, b;
        private DatabaseController control;
        private DataSet set;
        private Cleaner clean;
        private String table;
        private String table2;
        private ContributionPH contribution;
      
        //initialize everthing 
        public Controller_Payroll()
        {
            InitializeComponent();
            InitObject();
        }

        //initialize object variable also the connect to the database
        private void InitObject() {

            this.clean = new Cleaner();
            this.set = new DataSet();
            this.control = new DatabaseController();
            this.contribution = new ContributionPH();
            control.ConnectionString =
                                    "Data Source =  SAVJAYLADE84\\SQLEXPRESS;" +
                                    " Initial Catalog = Emp_Info_DB;" +
                                    " user id = SAVJAYLADE\\jayson;" +
                                    "Integrated Security = true;";
            control.Table = "Emp_Info_Table";
            table = control.Table;
            control.Connect();
        }

        // exit the form
        private void exitThis_Click(object sender, EventArgs e) {

            //ask user if it want to exit
           DialogResult dr = MessageBox.Show("Do you want to exit?", 
               "Warning",
               MessageBoxButtons.YesNo, 
               MessageBoxIcon.Warning);

            //if it a yes close the form
            if (dr == DialogResult.Yes)
                this.Close();
                 
                }


    
        //add all deductions
        private void SetDeduction(TextBox[] deduction) {


            for (int i = 0 ; i < deduction.Length - 1 ; i++)
            {

                if ((deduction[i].Text == "" && deduction[i + 1].Text == ""))
                {

                    MessageBox.Show("Missing or Wrong input", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                } else if ((deduction[i].Text == null && deduction[i + 1].Text == null)) {

                    Console.OpenStandardError();

                } else { this.deduction = Convert.ToDouble(deduction[i].Text) + Convert.ToDouble(deduction[i + 1].Text); }

            }

            TotalDeduction.Text = String.Format("{0}", this.deduction);

        }

        //get total deduction
        private void GetDeduction()
        {
            try
            {
                SetDeduction(new TextBox[] {

            SSS,PagIbig,PhilHealth,SSS_Loan,PagIbi_Loan,FacultySaving_Deposite,
            FacultySaving_Loan,SalaryLoan,Other_2

            });
            } catch
            {

                MessageBox.Show("Wrong Input", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
        }


        //display total
       private void Display_TxtBox() {
                   
                if (a.Equals(IncomeNH) && b.Equals(IncomeRPH)){

                try
                {
                    this.SetRateHour();
                    this.income = rate * (double)hour;
                    this.Income.Text = String.Format("{0}", income);
                } catch {

                    MessageBox.Show("Wrong Input", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

                 }

                else if (a.Equals(HonoraiumNH) && b.Equals(HonoraiumRPH)){
                try
                {
                    this.SetRateHour();
                    this.honoraium = rate * (double)hour;
                    this.Honoraium.Text = String.Format("{0}", honoraium);
                } catch
                {

                    MessageBox.Show("Wrong Input", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }

                else if (a.Equals(OPayNH) && b.Equals(OPayRPH)){

                try
                {
                    this.SetRateHour();
                    this.OPay = rate * (double)hour;
                    this.OtherPay.Text = String.Format("{0}", OPay);
                    this.GrossIncome();
                } catch
                {

                    MessageBox.Show("Wrong Input", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }

        }

        //set netincome
        private void SetNetIncome() {

            NetIncome.Text = String.Format("{0}",this.grossincome - this.deduction);

        }

        //set pagibig in 100.00
        private void Form1_Load(object sender, EventArgs e) {

            control.Open();

            control.Query = "SELECT * FROM " + this.table;
            control.ExecuteQuery("select");
            control.dataset = set;
            control.View = gridview;
            control.ViewDataTable(0);

            control.Close();
            PagIbig.Text = "100.00";

        }

        //display and compute the grossincome
        private void GrossIncome()
        {

            grossincome = honoraium + OPay + income;
            _GrossIncome.Text = String.Format("{0}", grossincome);

        }

        //set one textbox
        private void Set_TxtBox(TextBox a) => this.a = a;

        //set two textbox
        private void Set_TxtBox(TextBox a, TextBox b)
        {

            this.a = a;
            this.b = b;

        }

        //set the netincome when mouse leave this area
        private void Other_2_Leave(object sender, EventArgs e)
        {
            GetDeduction();
            SetNetIncome();
        }

        //cancel the present input and clear all
        private void Cancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        //save the data 
        private void Save_Click(object sender, EventArgs e)
        {
            control.Open();

            //put long query to string builder so its will not take time in sending the whole query
            StringBuilder sb = new StringBuilder("INSERT INTO " + this.table2 + " VALUES('" + EmployeeNumber.Text + "','" + IncomeRPH.Text + "','" + IncomeNH.Text + "','" + Income.Text + "','" +
                HonoraiumRPH.Text + "','" + HonoraiumNH.Text + "','" + Honoraium.Text + "','" + OPayRPH.Text + "','" + OPayNH.Text + "','" +
                OtherPay.Text + "','" + SSS.Text + "','" + PhilHealth.Text + "','" + PagIbig.Text + "','" + Tax.Text + "','" + SSS_Loan.Text + "','" +
                PagIbi_Loan.Text + "','" + FacultySaving_Deposite.Text + "','" + FacultySaving_Loan.Text + "','" + SalaryLoan.Text + "','" +
                Other_2.Text + "','" + _GrossIncome.Text + "','" + NetIncome.Text + "','" + TotalDeduction.Text + "')");

            control.Query = sb.ToString() ;
            control.ExecuteQuery("insert");
            control.Query = "Select * FROM " + this.table2;

            control.ExecuteQuery("select");
            control.dataset = set;
            control.View = gridview;
            control.ViewDataTable(0);
            Clear();

            control.Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {

            control.Open();

            //deleting priceTable
            control.Query = "DELETE FROM "+ table2 +" WHERE priceTable.pos_id = " + EmployeeNumber.Text;
            control.ExecuteQuery("delete");

            control.Query = "Select * FROM " + this.table2;

            control.ExecuteQuery("select");
            control.dataset = set;
            control.View = gridview;
            control.ViewDataTable(0);
            Clear();

            control.Close();

        }


        //must fixed function need to chance bugs starts here
        private void Calculate_Click(object sender, EventArgs e)
        {
            //control.Open();

            //control.Query = "SELECT  FROM Emp_Info_Table WHERE emp_id = " + EmployeeNumber.Text;
            //control.ExecuteQuery("select");
            //control.dataset = set;
            //control.View = gridview;
            //control.ViewDataTable(0);

            //control.textBox = new TextBox[]
            //{

            // EmployeeFName,EmployeeMName,EmployeeLName 

            //};
            //control.InsertDataToTextBox(0, 0, 0, 1);
            //Department.Text = control.GetDataSetRow(0, 0, 63); ;
            //Designation.Text = control.GetDataSetRow(0, 0, 60);
            //NumberDependent.Text = control.GetDataSetRow(0, 0, 4);
            //CivilStatus.Text = control.GetDataSetRow(0, 0, 11);
            //control.Single_Picture = ProfilePic;
            //control.InsertDataToImage(0, 0, 64);
            //control.Close();

            //control.Open();
            //control.Table = "empPayroll_Table";
            //control.Query = "SELECT  FROM "+ table2 +" WHERE emp_id = " + EmployeeNumber.Text;
            //control.ExecuteQuery("select");
            //control.dataset = set;
            //control.View = gridview;
            //control.ViewDataTable(0);

            //control.textBox = new TextBox[] {

            //    IncomeRPH,IncomeNH,Income,HonoraiumRPH,HonoraiumNH,Honoraium,
            //    OPayRPH,OPayNH,OtherPay,SSS,PhilHealth,PagIbig,Tax,SSS_Loan,
            //    PagIbi_Loan,FacultySaving_Deposite,FacultySaving_Loan,SalaryLoan,Other_2

            //};
            //control.InsertDataToTextBox(0, 0, 0, 1);
            //_GrossIncome.Text = control.GetDataSetRow(0, 0, 16);
            //NetIncome.Text = control.GetDataSetRow(0, 0, 17);
            //TotalDeduction.Text = control.GetDataSetRow(0, 0, 18);


            //control.Close();
        }

        //must fixed function 
        private void Print_Click(object sender, EventArgs e)
        {

        //printTabOne.Text = " \nFirst Name :" + EmployeeFName.Text +
        //"\nMiddle Name : " + EmployeeMName.Text +
        //"\nLast Name : " + EmployeeLName.Text +
        //"\nCivil Status : " + CivilStatus.Text +
        //"\nDesignation : " + Designation.Text +
        //"\nDepartment : " + Department.Text;

        //    printTabTwo.Text = "Income\n Rate Per Hour:" + IncomeRPH.Text +
        //            "\nNumber of Hour:" + IncomeNH.Text +
        //            "\nTotal Income:" + Income.Text + 
        //            "\n Honoraium Rate Per Hour:" + HonoraiumRPH.Text +
        //            "\nNumber of Hour:" + HonoraiumNH.Text + 
        //            "\nTotal Honoraium:" + Honoraium.Text +
        //            "\nOther Rate Per Hour:" + OPayRPH.Text +
        //            "\nNumber of Hour:" + OPayNH.Text + 
        //            "\nTotal Honoraium:" + OtherPay.Text;

        }

        //create new and clear all 
        private void New_Click(object sender, EventArgs e)
        {
            Clear();
        }

        //set all textbox and rich textbox that will clear
        private void Clear() {

            clean.Textboxes = new TextBox[]{

                SSS,PagIbig,PhilHealth,Income,IncomeNH,
                IncomeRPH,Honoraium,HonoraiumRPH,HonoraiumNH,
                OPayNH,OPayRPH,OtherPay,SSS_Loan,PagIbi_Loan,
                FacultySaving_Deposite,FacultySaving_Loan,SalaryLoan,
                Other_2,Tax

            };
            clean.RichTextBoxes = new RichTextBox[] {

                _GrossIncome,NetIncome,TotalDeduction

            };
            clean.ClearAll();

        }


        //set the rate per hour
        private void SetRateHour()
        {

            try
            {
                this.rate = Convert.ToDouble(b.Text);
                this.hour = Convert.ToInt32(a.Text);
            } catch {

                MessageBox.Show("Wrong Input", "Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                a.Text = "";
                b.Text = "";

            }

        }

        //display and compute for total honoraium
        private void HonoraiumNH_Leave(object sender, EventArgs e)
        {

            Set_TxtBox(HonoraiumNH,HonoraiumRPH);
            Display_TxtBox();

        }

        //display and compute for total income
        private void IncomeNH_Leave(object sender, EventArgs e)
        {
            Set_TxtBox(IncomeNH,IncomeRPH);
            Display_TxtBox();

        }

        //display and compute for total other pay and all contribution
        private void OPayNH_Leave(object sender, EventArgs e)
        {

            Set_TxtBox(OPayNH, OPayRPH);
            Display_TxtBox();
            SSS.Text = string.Format($"{contribution.SSSContribution(this.grossincome)}");
            PhilHealth.Text = string.Format($"{contribution.PhilHealthContribution(this.grossincome)}");
            PagIbig.Text = string.Format($"{contribution.PagIbigContribution(this.grossincome)}");
            Tax.Text = string.Format($"{contribution.Taxation(this.grossincome)}");

        }
    }
}
