using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class EmployeeController
    {

        public void calculateNetSalary(PayrollEmployee payroll)
        {
            if (payroll == null) return;

            if (payroll.Experience > 10)
            {
                payroll.DA = 10 * payroll.BasicSalary / 100;
                payroll.HRA = 8.5 * payroll.BasicSalary / 100;
                payroll.PF = 6200;


            }
            else if (payroll.Experience > 7 && payroll.Experience < 10)
            {

                payroll.DA = 7 * payroll.BasicSalary / 100;
                payroll.HRA = 6.5 * payroll.BasicSalary / 100;
                payroll.PF = 4100;
            }
            else if (payroll.Experience > 5 && payroll.Experience < 7)
            {
                payroll.DA = 4.1 * payroll.BasicSalary / 100;
                payroll.HRA = 3.8 * payroll.BasicSalary / 100;
                payroll.PF = 1800;
            }
            else
            {
                payroll.DA = 1.9 * payroll.BasicSalary / 100;
                payroll.HRA = 2.0 * payroll.BasicSalary / 100;
                payroll.PF = 1200;
            }

            double grossSalary = payroll.BasicSalary + payroll.DA + payroll.HRA;



            payroll.Netsalary = grossSalary - payroll.PF;





        }
    }
}
