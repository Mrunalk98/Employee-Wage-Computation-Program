using System;

namespace EmployeeWages
{
    class Program
    {
        private static Company[] companyArray = new Company[10];
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");

            Console.WriteLine("Enter the number of companies : ");
            var num = Convert.ToInt32(Console.ReadLine());

            EmployeeWageCalc empWageCalc = new EmployeeWageCalc();

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine("Enter data of company " + i);
                Console.WriteLine("Enter company name : ");
                var companyName = Console.ReadLine();
                Console.WriteLine("Enter employee rate per hour: ");
                var empRatePerHour = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter number of working days : ");
                var noOfWorkingDays = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter number of working hours : ");
                var noOfWorkingHours = Convert.ToInt32(Console.ReadLine());
                companyArray[i] = new Company(companyName, empRatePerHour, noOfWorkingDays, noOfWorkingHours);
                empWageCalc.CalcTotalEmpWage(companyArray[i]);
            }
        }

    }
}
