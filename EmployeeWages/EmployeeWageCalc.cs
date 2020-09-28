using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWages
{
    public class EmployeeWageCalc
    {

        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        int empRatePerHour;
        int noOfWorkingDays;
        int noOfWorkingHours;
        string companyName;

        public EmployeeWageCalc(string COMPANY_NAME, int EMP_RATE_PER_HOUR, int NO_OF_WORKING_DAYS, int NO_OF_WORKING_HOURS)
        {
            this.companyName = COMPANY_NAME;
            this.empRatePerHour = EMP_RATE_PER_HOUR;
            this.noOfWorkingDays = NO_OF_WORKING_DAYS;
            this.noOfWorkingHours = NO_OF_WORKING_HOURS;
        }
        public int CalcTotalEmpWage()
        {

            int empHrs;
            int totalWage;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;

            for (totalWorkingDays = 1; totalWorkingDays <= this.noOfWorkingDays && totalEmpHrs <= this.noOfWorkingHours; totalWorkingDays++)
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
            }
            totalWage = totalEmpHrs * this.empRatePerHour;
            Console.WriteLine("Total Employee Wage of " + this.companyName + " : " + totalWage);
            return totalWage;
        }
    }
}