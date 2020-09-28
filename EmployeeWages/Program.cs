using System;

namespace EmployeeWages
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");

            EmployeeWageCalc capgemini = new EmployeeWageCalc("Capgemini", 10, 12, 40);
            capgemini.CalcTotalEmpWage();
        }

    }
}
