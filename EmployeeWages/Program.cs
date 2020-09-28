using System;

namespace EmployeeWages
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");

            CalcTotalEmpWage("Jio", 20, 10, 12);

        }

        // Use Case 6
        static int CalcTotalEmpWage(string CompanyName, int EMP_RATE_PER_HOUR, int NO_OF_WORKING_DAYS, int NO_OF_WORKING_HOURS)
        {
            const int IS_PART_TIME = 1;
            const int IS_FULL_TIME = 2;

            int empHrs;
            int totalWage;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;

            for (totalWorkingDays = 1; totalWorkingDays <= NO_OF_WORKING_DAYS && totalEmpHrs <= NO_OF_WORKING_HOURS; totalWorkingDays++)
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
            totalWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Employee Wage of " + CompanyName + " : " + totalWage);
            return totalWage;
        }
    }
}
