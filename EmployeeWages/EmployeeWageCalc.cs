using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWages
{
    public class EmployeeWageCalc
    {

        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;


        public int CalcTotalEmpWage(Company company)
        {

            int empHrs;
            int totalWage;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;

            for (totalWorkingDays = 1; totalWorkingDays <= company.noOfWorkingDays && totalEmpHrs <= company.noOfWorkingHours; totalWorkingDays++)
            {

                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;

                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;

                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days : " + totalWorkingDays + ", Emp hours : " + empHrs);
            }
            totalWage = totalEmpHrs * company.empRatePerHour;
            Console.WriteLine("\nTotal Employee Wage of " + company.companyName + " : " + totalWage + "\n");
            return totalWage;
        }
    }
}