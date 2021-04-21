using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employee_Payslip;

namespace Employee_Payslip
{
    public class ContributionPH
    {

        Accountant account = new Accountant();

        //set philhealth contribution
        public double PhilHealthContribution(double gross_income)
        {

            if ((gross_income <= 8999.99)) { account.Amount = 100.00; }
            else if (account.RangeOf(9000.00, 9999.99, gross_income)) { account.Amount = 112.50; } 
            else if (account.RangeOf(10000.00, 10999.99, gross_income)) { account.Amount = 125.00; }
            else if (account.RangeOf(11000.00, 11999.99, gross_income)) { account.Amount = 137.50; } 
            else if (account.RangeOf(12000.00, 12999.99, gross_income)) { account.Amount = 150.00; } 
            else if (account.RangeOf(13000.00, 13999.99, gross_income)) { account.Amount = 162.50; } 
            else if (account.RangeOf(14000.00, 14999.99, gross_income)) { account.Amount = 175.00; } 
            else if (account.RangeOf(15000.00, 15999.99, gross_income)) { account.Amount = 187.50; } 
            else if (account.RangeOf(16000.00, 16999.99, gross_income)) { account.Amount = 200.00; } 
            else if (account.RangeOf(17000.00, 17999.99, gross_income)) { account.Amount = 212.50; } 
            else if (account.RangeOf(18000.00, 18999.99, gross_income)) { account.Amount = 225.00; } 
            else if (account.RangeOf(19000.00, 19999.99, gross_income)) { account.Amount = 237.50; } 
            else if (account.RangeOf(20000.00, 20999.99, gross_income)) { account.Amount = 250.00; } 
            else if (account.RangeOf(21000.00, 21999.99, gross_income)) { account.Amount = 262.50; } 
            else if (account.RangeOf(22000.00, 22999.99, gross_income)) { account.Amount = 275.00; } 
            else if (account.RangeOf(23000.00, 23999.99, gross_income)) { account.Amount = 287.50; } 
            else if (account.RangeOf(24000.00, 24999.99, gross_income)) { account.Amount = 300.00; } 
            else if (account.RangeOf(25000.00, 25999.99, gross_income)) { account.Amount = 312.50; } 
            else if (account.RangeOf(26000.00, 26999.99, gross_income)) { account.Amount = 325.00; } 
            else if (account.RangeOf(27000.00, 27999.99, gross_income)) { account.Amount = 337.50; } 
            else if (account.RangeOf(28000.00, 28999.99, gross_income)) { account.Amount = 350.00; } 
            else if (account.RangeOf(29000.00, 29999.99, gross_income)) { account.Amount = 362.50; } 
            else if (account.RangeOf(30000.00, 30999.99, gross_income)) { account.Amount = 375.00; } 
            else if (account.RangeOf(31000.00, 31999.99, gross_income)) { account.Amount = 387.50; } 
            else if (account.RangeOf(32000.00, 32999.99, gross_income)) { account.Amount = 400.00; } 
            else if (account.RangeOf(33000.00, 33999.99, gross_income)) { account.Amount = 412.50; } 
            else if (account.RangeOf(34000.00, 34999.99, gross_income)) { account.Amount = 425.00; } 
            else { account.Amount = 437.50; }

            return account.Amount;

        }

        //set SSS contribution
        public double SSSContribution(double gross_income)
        {

            if (account.RangeOf(1000, 1249.99, gross_income)) { account.Amount = 36.30; } 
            else if (account.RangeOf(1250, 1749.99, gross_income)) { account.Amount = 54.50; } 
            else if (account.RangeOf(1750, 2249.99, gross_income)) { account.Amount = 72.70; } 
            else if (account.RangeOf(2250, 2749.99, gross_income)) { account.Amount = 90.80; } 
            else if (account.RangeOf(2750, 3249.99, gross_income)) { account.Amount = 109.00; } 
            else if (account.RangeOf(3250, 3749.99, gross_income)) { account.Amount = 127.20; } 
            else if (account.RangeOf(3750, 4249.99, gross_income)) { account.Amount = 145.30; }
            else if (account.RangeOf(4250, 4749.99, gross_income)) { account.Amount = 163.50; } 
            else if (account.RangeOf(4750, 5249.99, gross_income)) { account.Amount = 181.70; }
            else if (account.RangeOf(5250, 5749.99, gross_income)) { account.Amount = 199.80; } 
            else if (account.RangeOf(5750, 6249.99, gross_income)) { account.Amount = 218.00; } 
            else if (account.RangeOf(6250, 6749.99, gross_income)) { account.Amount = 236.20; } 
            else if (account.RangeOf(6750, 7249.99, gross_income)) { account.Amount = 254.30; } 
            else if (account.RangeOf(7250, 7749.99, gross_income)) { account.Amount = 272.50; } 
            else if (account.RangeOf(7750, 8249.99, gross_income)) { account.Amount = 290.70; } 
            else if (account.RangeOf(8250, 8749.99, gross_income)) { account.Amount = 308.80; } 
            else if (account.RangeOf(8750, 9249.99, gross_income)) { account.Amount = 345.20; } 
            else if (account.RangeOf(9250, 9749.99, gross_income)) { account.Amount = 363.30; } 
            else if (account.RangeOf(9750, 10249.99, gross_income)) { account.Amount = 381.50; } 
            else if (account.RangeOf(10250, 10749.99, gross_income)) { account.Amount = 399.70; } 
            else if (account.RangeOf(10750, 11249.99, gross_income)) { account.Amount = 417.80; } 
            else if (account.RangeOf(11250, 11749.99, gross_income)) { account.Amount = 436.00; } 
            else if (account.RangeOf(11750, 12249.99, gross_income)) { account.Amount = 454.20; } 
            else if (account.RangeOf(12250, 12749.99, gross_income)) { account.Amount = 472.30; } 
            else if (account.RangeOf(12750, 13249.99, gross_income)) { account.Amount = 490.50; } 
            else if (account.RangeOf(13250, 13749.99, gross_income)) { account.Amount = 508.70; } 
            else if (account.RangeOf(13750, 14249.99, gross_income)) { account.Amount = 526.80; } 
            else if (account.RangeOf(14250, 14749.99, gross_income)) { account.Amount = 545.00; } 
            else if (account.RangeOf(14750, 15249.99, gross_income)) { account.Amount = 563.20; } 
            else if (gross_income > 15249.99) { account.Amount = 581.30; } else
            {

                account.Amount = 0.0;

            }

            return account.Amount;

        }

        //set pagibig contribution
        public double PagIbigContribution(Double gross_income)
        {

            if (gross_income >= 1500.00) { account.Amount = gross_income * 0.02; } 
            else { account.Amount = gross_income * 0.01; }

            return account.Amount;

        }


        //set tax
        public double Taxation(double gross_income)
        {

            if (gross_income < 250_000) { account.Amount = 0; }
            else if (account.RangeOf(250_000, 400_000, gross_income)) { account.Amount = TaxCompute(0.0, 0.20,gross_income); } 
            else if (account.RangeOf(400_000, 800_000, gross_income)) { account.Amount = TaxCompute(30_000, 0.25, gross_income); } 
            else if (account.RangeOf(800_000, 2_000_000, gross_income)) { account.Amount = TaxCompute(130_000, 0.30, gross_income); } 
            else if (account.RangeOf(2_000_000, 8_000_000, gross_income)) { account.Amount = TaxCompute(490_000, 0.32, gross_income); } 
            else { account.Amount = TaxCompute(2_410_000, 0.35, gross_income); }

            return account.Amount;

        }

        //compute tax
        private double TaxCompute(double add, double percent,double grossincome)
        {
            
            return add + (percent * grossincome);

        }

    }
}
