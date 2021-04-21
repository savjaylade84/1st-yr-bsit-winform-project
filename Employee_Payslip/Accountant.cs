using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Payslip
{
    class Accountant
    {
       
        private TextBox contributionTxtBox;
        private double amount;

        //compare range
        public bool RangeOf(Double arg1, Double arg2, Double gross) => ((gross >= arg1) && (gross <= arg2)) ? true : false;

        public TextBox contribution {

            set {

                this.contributionTxtBox = value;

            }

        }

       public Double Amount {

            set {

                this.amount = value;
            }
            get {

                return amount;

            }

        }


    }
}
