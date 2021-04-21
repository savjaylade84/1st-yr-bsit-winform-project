using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using jayson_activity;
using CashierAdministrator;
using InfoForm;
using Employee_Payslip;
using AboutUs;

namespace Main
{
    public partial class MainPage : Form
    {

        DatabaseController control;

        public MainPage()
        {

            control = new DatabaseController();
            InitializeComponent();
        }

        private void salaryInfoEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Emp_Info emp = new Emp_Info();
            control.Buttons[0].Enabled = false;
            control.Buttons[1].Enabled = false;
            emp.MdiParent = this;
            emp.Show();
        }

        private void salaryInfoAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Emp_Info emp = new Emp_Info();
            emp.MdiParent = this;
            emp.Show();
        }

        private void pOSSTAFFToolStripMenuItem_Click(object sender, EventArgs e)
        {

            POSCashier cashier = new POSCashier();
            cashier.MdiParent = this;
            cashier.Show();

        }

        private void pOSADMINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CashierAdministrator.CashierAdministrator cashier = new CashierAdministrator.CashierAdministrator();
            cashier.MdiParent = this;
            cashier.Show();
        }

        private void arrangeIconsToolStripMenuItem_Click(object sender, EventArgs e) => this.LayoutMdi(MdiLayout.ArrangeIcons);

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e) => this.LayoutMdi(MdiLayout.Cascade);

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e) => this.LayoutMdi(MdiLayout.TileHorizontal);

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e) => this.LayoutMdi(MdiLayout.TileVertical);

        private void payrollSTAFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controller_Payroll payroll = new Controller_Payroll();
            payroll.MdiParent = this;
            payroll.Show();
        }

        private void payrollADMINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controller_Payroll payroll = new Controller_Payroll();
            payroll.MdiParent = this;
            payroll.Show();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about About = new about();
            About.MdiParent = this;
            About.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
