using System;

namespace EmployeeWages
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");

            int totalWage = CalcTotalEmpWage();
            Console.WriteLine("Total Employee Wage : " + totalWage);

        }

        // Use Case 6
        static int CalcTotalEmpWage()
        {
            const int IS_PART_TIME = 1;
            const int IS_FULL_TIME = 2;
            const int EMP_RATE_PER_HOUR = 20;
            const int NO_OF_WORKING_DAYS = 20;
            const int NO_OF_WORKING_HOURS = 100;

            int empHrs;
            int totalWage;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;

            while (totalWorkingDays < NO_OF_WORKING_DAYS && totalEmpHrs <= NO_OF_WORKING_HOURS)
            {
                totalWorkingDays++;
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
            totalWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            return totalWage;
        }
    }
}
