using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Payslip
{
    internal class Controller : Controller_Payroll
    {

        //declare variable
        private double income, honoraium, OPay, total,_a,_b,_d;
        private int _c;
        TextBox a, b, c;
        TextBox[] d;
        RichTextBox e;

        //take anonymous textbox and set it to local textbox of this class

        public Controller(TextBox a) => this.a = a;

        public Controller(RichTextBox a) => this.e = a;

        public Controller(TextBox a ,TextBox b)
        {
            this.a = a;
            this.b = b;

        }

        public Controller(TextBox a, TextBox b,TextBox c) {

            this.a = a;
            this.b = b;
            this.c = c;

        }

        public Controller(TextBox[] a) {

            for (int i = 0 ; i > a.Length ; i++) { 
                d = new TextBox[a.Length];
                this.d[i] = a[i];
            }
        }

        // set variable that will compute later
        private void SetCompute() {

            _a = Convert.ToDouble(this.a.Text);
            _c = Convert.ToInt32(this.b.Text);

        }

        private void SetCompute2()
        {

            _a = Convert.ToDouble(this.a.Text);
            _b = Convert.ToDouble(this.b.Text);
            _d = Convert.ToDouble(this.c.Text);

        }

        //compute those variable
        private double compute(double a) {

            a = _a * (double)_c;
            return a;

        }

        private double Total(double a)
        {
            SetCompute2();
            a = _a + _b + _d;

            return a;
        }

        protected internal void Clear() {

            for (int i = 0 ; i < d.Length ; i++) {

                d[i].Clear();

            }

        }

        private double GetCompute() => compute(total);
        private double GetTotal() => Total(total);

        protected internal void ExecuteThis() {

            SetCompute();
            c.Text = String.Format("{0}",GetCompute());

        }

        protected internal void ExecuteThis2() {

            e.Text = String.Format("{0}", GetTotal());

        }


    }
}
