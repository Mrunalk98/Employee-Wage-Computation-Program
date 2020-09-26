using System;

namespace EmployeeWages
{
    class Program
    {
        static void Main(string[] args)
        {
            string attendance = EmpAttendance();
            Console.WriteLine(attendance);

        }

        static string EmpAttendance()
        {
            int IS_FULL_TIME = 1;
            string result;
            Random random = new Random();

            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                result = "Employee is Present";
            }
            else
            {
                result = "Employee is Absent";
            }
            return result;
        }
    }
}
