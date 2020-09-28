using System;

namespace EmployeeWages
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");

            EmployeeWageCalc capgemini = new EmployeeWageCalc("Capgemini", 10, 12, 40);
            EmployeeWageCalc jio = new EmployeeWageCalc("Jio", 10, 8, 50);
            capgemini.CalcTotalEmpWage();
            jio.CalcTotalEmpWage();
        }

    }
}
