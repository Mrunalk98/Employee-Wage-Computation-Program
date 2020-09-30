using System;
using System.Collections.Generic;

namespace EmployeeWages
{
    class Program
    {

        public static EmployeeWageCalc empWageCalc = new EmployeeWageCalc();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");

            Console.WriteLine("Enter the number of companies : ");
            var num = Convert.ToInt32(Console.ReadLine());

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
                Console.WriteLine();
                empWageCalc.addCompany(companyName, empRatePerHour, noOfWorkingDays, noOfWorkingHours);
            }
            empWageCalc.CalcTotalEmpWage();

            Console.WriteLine("Enter company name to get Total Wage : ");
            var name = Console.ReadLine();
            int total = empWageCalc.getTotalWage(name);
            Console.WriteLine("Total wage for " + name + " is " + total);
        }

    }
}
