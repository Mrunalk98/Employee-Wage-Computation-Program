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

        static int CalcTotalEmpWage()
        {
            const int IS_PART_TIME = 1;
            const int IS_FULL_TIME = 2;
            const int EMP_RATE_PER_HOUR = 20;
            const int NO_OF_WORKING_DAYS = 20;

            int empHrs = 0;
            int empWage = 0;
            int totalWages = 0;

            for (int day = 0; day < NO_OF_WORKING_DAYS; day++)
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
                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalWages += empWage;
                Console.WriteLine("Employee Wage : " + empWage);
            }
            return totalWages;
        }
    }
}
