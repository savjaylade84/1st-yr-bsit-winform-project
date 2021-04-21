using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Sql;
using System.Windows.Forms;

namespace InfoForm
{
    public partial class Emp_Info : Form
    {
        private DatabaseController Controller;
        private Cleaner cleaner;
        private String[] aGe, staTus, gen;
        private TextBox[] a;
        private DataSet set;
        private String picpath,table;
        private DialogResult dialog;
        private OpenFileDialog fileDialog;


        //constructor
        public Emp_Info()
        {
            this.InitObjects();
            Controller.ConnectionString =
                                    "Data Source =  SAVJAYLADE84\\SQLEXPRESS;" +
                                    " Initial Catalog = Emp_Info_DB;" +
                                    " user id = SAVJAYLADE\\jayson;" +
                                    "Integrated Security = true;";
            Controller.Table = "Emp_Info_Table";
            table = Controller.Table;
            Controller.Connect();
            InitializeComponent();

        }

        //initialize object
        private void InitObjects() {

            set = new DataSet();
            Controller = new DatabaseController();
            cleaner = new Cleaner();
            dialog = new DialogResult();
            fileDialog = new OpenFileDialog();
            editBtn = new Button();
            deleteBtn = new Button();
            Controller.Buttons = new Button[] {

                editBtn,deleteBtn

            };
        }

        //clear all fields
        public void CleanAll() {

            cleaner.Textboxes = new TextBox[]{

            emp_id,emp_fname,emp_mname,emp_sname,dependent,sss,tin,philhealth,pagibig,height,weight,
            yearOfStay,house,subdivision,phase,baranggay,municipality,city,country,stateProvince,zip,
            permanentStay,permanentHouse,permanentSubdiv,permanentPhase,permanentBrgy,permanentMun,
            permamnentCity,permanentCountry,permanentSP,permanentZip,telephone,cellphoneOne,cellphoneTwo,
            emailAddress,ContactPerson,CPersonNumber,elemSchool,elemAward,secSchool,secAward,terSchool,
            terCourse,terAward,gradSchool,gradDegree,gradAward,otherSchool,position,PDependents,department,browse,
            CPersonAddress

            };
            cleaner.RichTextBoxes = new RichTextBox[] {

                elemAddress,secAddress,terAddress,gradAddress,

            };
            cleaner.ComboBoxes = new ComboBox[] { status, age,gender};
            cleaner.ClearAll();

        }

        //bring data to the textbox
        private void getData()
        {

            //name and dependent
            Controller.textBox = new TextBox[] { emp_fname, emp_mname, emp_sname, dependent};
            Controller.InsertDataToTextBox(0, 0, 0, 2);

            age.Text = Controller.GetDataSetRow(0, 0, 6);
            gender.Text = Controller.GetDataSetRow(0, 0, 7);

            //contribution
            Controller.textBox = new TextBox[] { sss, tin, philhealth, pagibig };
            Controller.InsertDataToTextBox(0, 0, 0, 8);

            status.Text = Controller.GetDataSetRow(0, 0, 12);

            //height,weight and address
            Controller.textBox = new TextBox[] {

            height,weight,yearOfStay,house,subdivision,
            phase,baranggay,municipality,city,country,
            stateProvince,zip,permanentStay,permanentHouse,permanentSubdiv,
            permanentPhase,permanentBrgy,permanentMun,permamnentCity,permanentCountry,
            permanentSP,permanentZip,telephone,cellphoneOne,cellphoneTwo,
            emailAddress,ContactPerson,CPersonNumber,elemSchool

            };
            Controller.InsertDataToTextBox(0, 0, 0, 13);

            elemAddress.Text = Controller.GetDataSetRow(0, 0, 42);
            elemGraduated.Text = Controller.GetDataSetRow(0, 0, 43);
            elemAward.Text = Controller.GetDataSetRow(0, 0, 44);
            secSchool.Text = Controller.GetDataSetRow(0, 0, 45);
            secAddress.Text = Controller.GetDataSetRow(0, 0, 46);
            secGraduated.Text = Controller.GetDataSetRow(0, 0, 47);
            secAward.Text = Controller.GetDataSetRow(0, 0, 48);
            terSchool.Text = Controller.GetDataSetRow(0, 0, 49);
            terCourse.Text = Controller.GetDataSetRow(0, 0, 50);
            terAddress.Text = Controller.GetDataSetRow(0, 0, 51);
            terGraduated.Text = Controller.GetDataSetRow(0, 0, 52);
            terAward.Text = Controller.GetDataSetRow(0, 0, 53);
            gradSchool.Text = Controller.GetDataSetRow(0, 0, 54);
            gradDegree.Text = Controller.GetDataSetRow(0, 0, 55);
            gradAddress.Text = Controller.GetDataSetRow(0, 0, 56);
            gradGraduated.Text = Controller.GetDataSetRow(0, 0, 57);
            gradAward.Text = Controller.GetDataSetRow(0, 0, 58);
            otherSchool.Text = Controller.GetDataSetRow(0, 0, 59);
            position.Text = Controller.GetDataSetRow(0, 0, 60);
            PDependents.Text = Controller.GetDataSetRow(0, 0, 61);
            DateHire.Text = Controller.GetDataSetRow(0, 0, 62);
            department.Text = Controller.GetDataSetRow(0, 0, 63);
            browse.Text = Controller.GetDataSetRow(0, 0, 64);

            picture.Image = Image.FromFile(browse.Text);



        }


        //set all the items in the combobox
        private void AgeStatus() {

            aGe = new string[65];   //age

            staTus = new string[] {    //status
                "Single","Married","Inrelationship","Widow" 
            };

            gen = new string[] {       //gender
                "Male","Female","Gay","Lesbian","Bisexual"

            };

            for (int i = 0 ; i < 65 ; i++)
                aGe[i] = (i + 18).ToString();

            foreach (string a in gen)
                gender.Items.Add(a);

            foreach (string b in aGe)
                age.Items.Add(b);

            foreach (string c in staTus)
                status.Items.Add(c);

        }

        //close this form 
        private void exitBtn_Click(object sender, EventArgs e){

            dialog = MessageBox.Show("Do You Want To Exit?","Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (dialog.Equals(DialogResult.Yes))
            this.Close();
              
        }

        //add data from the user to the database
        private void addBtn_Click(object sender, EventArgs e)
        {
            string email = emailAddress.Text;
            Controller.Open();

            Controller.Query = "INSERT INTO " + this.table + " VALUES('" +
                            emp_id.Text + "','" + emp_fname.Text + "','" + emp_mname.Text + "','" + emp_sname.Text + "','" +
                            dependent.Text + "','" + age.Text + "','" + gender.Text + "','" +
                             sss.Text + "','" + tin.Text + "','" + philhealth.Text + "','" +
                            pagibig.Text + "','" + status.Text + "','" + height.Text + "','" +
                            weight.Text + "','" + yearOfStay.Text + "','" + house.Text + "','" + subdivision.Text + "','" +
                            phase.Text + "','" + baranggay.Text + "','" + municipality.Text + "','" + city.Text + "','" +
                            country.Text + "','" + stateProvince.Text + "','" + zip.Text + "','" + permanentStay.Text + "','" +
                            permanentHouse.Text + "','" + permanentSubdiv.Text + "','" + permanentPhase.Text + "','" +
                            permanentBrgy.Text + "','" + permanentMun.Text + "','" + permamnentCity.Text + "','" +
                            permanentCountry.Text + "','" + permanentSP.Text + "','" + permanentZip.Text + "','" +
                            telephone.Text + "','" + cellphoneOne.Text + "','" + cellphoneTwo.Text + "','" + emailAddress.Text + "','" +
                            ContactPerson.Text + "','" + CPersonNumber.Text + "','" + CPersonAddress.Text + "','" +
                            elemSchool.Text + "','" + elemAddress.Text + "','" + elemGraduated.Text + "','" + elemAward.Text + "','" +
                            secSchool.Text + "','" + secAddress.Text + "','" + secGraduated.Text + "','" + secAward.Text + "','" +
                            terSchool.Text + "','" + terCourse.Text + "','" + terAddress.Text + "','" + terGraduated.Text + "','" +
                            terAward.Text + "','" + gradSchool.Text + "','" + gradDegree.Text + "','" + gradAddress.Text + "','" +
                            gradGraduated.Text + "','" + gradAward.Text + "','" + otherSchool.Text + "','" + position.Text + "','" +
                            PDependents.Text + "','" + DateHire.Text + "','" + department.Text + "','" + browse.Text + "')";

            if (email.Contains("@") && email.Contains(".com"))
            {
                Controller.ExecuteQuery("insert");
                Controller.Query = "Select * FROM " + this.table;
                Controller.ExecuteQuery("select");
                Controller.dataset = set;
                Controller.View = empDataView;
                Controller.ViewDataTable(0);
                
            } else
            {

                MessageBox.Show("Missing or Invalid Input","Warning",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }

            CleanAll();
            Controller.Close();

        }

        //cancel the transaction
        private void cancelBtn_Click(object sender, EventArgs e) {

            CleanAll();

        }

        //get the picture in the local storage
        private void browseBtn_Click(object sender, EventArgs e)
        {

            fileDialog.Filter = "Image File |*.jpg;*.jpeg;*.png;*.gif;*bmp;";
            fileDialog.ShowDialog();
            picture.Image = Image.FromFile(fileDialog.FileName);
            picpath = fileDialog.FileName;
            browse.Text = fileDialog.FileName;

        }

        //searching for the information
        private void SearchBtn_Click(object sender, EventArgs e)
        {

            Controller.Open();

            Controller.Query = "SELECT * FROM " + this.table + "WHERE emp_id = '" + emp_id.Text + "'" ;
            Controller.ExecuteQuery("select");
            Controller.dataset = set;
            Controller.View = empDataView;
            Controller.ViewDataTable(0);
            getData();  

            Controller.Close();

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            Controller.Open();

            Controller.Query = "DELETE FROM" + this.table + " WHERE emp_id = " + emp_id.Text;
            Controller.ExecuteQuery("delete");
            CleanAll();

            Controller.Query = "SELECT * FROM " + this.table;
            Controller.ExecuteQuery("select");
            Controller.dataset = set;
            Controller.View = empDataView;
            Controller.ViewDataTable(0);

            Controller.Close();

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            Controller.Open();
            Controller.Query = "UPDATE " + this.table + " SET " + "emp_id = '";
            Controller.Close();
        }

        //create new 
        private void newBtn_Click(object sender, EventArgs e)
        {

            CleanAll();

        }

        //load the values in the combobox and data grid view
        private void Emp_Info_Load(object sender, EventArgs e) {

            AgeStatus();

            Controller.Open();

            Controller.Query = "SELECT * FROM " + this.table;
            Controller.ExecuteQuery("select");
            Controller.dataset = set;
            Controller.View = empDataView;
            Controller.ViewDataTable(0);

            Controller.Close();


        }
    }
}
