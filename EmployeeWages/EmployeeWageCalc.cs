using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWages
{
    public class EmployeeWageCalc: ComputeEmpWage
    {

        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public  LinkedList<Company> companyList;
        public Dictionary<string, Company> companyDict;


        public EmployeeWageCalc()
        {
            this.companyList = new LinkedList<Company>();
            this.companyDict = new Dictionary<string, Company>();
        }

        public void addCompany(string companyName, int empRatePerHour, int noOfWorkingDays, int noOfWorkingHours)
        {
            Company company = new Company(companyName, empRatePerHour, noOfWorkingDays, noOfWorkingHours);
            this.companyList.AddLast(company);
            this.companyDict.Add(companyName, company);
        }

        public void CalcTotalEmpWage()
        {
            foreach (Company company in this.companyList)
            {
                Console.WriteLine("For " + company.companyName);
                company.setTotalWage(this.CalcTotalEmpWage(company));
                Console.WriteLine("\nTotal Employee Wage of " + company.companyName + " : " + company.totalWage + "\n");
            }
        }
        private int CalcTotalEmpWage(Company company)
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
                int dailyWage = empHrs * company.empRatePerHour;
                Console.WriteLine("Days : " + totalWorkingDays + "\tEmp hours : " + empHrs + "\tDaily Wage : " + dailyWage);
            }
            totalWage = totalEmpHrs * company.empRatePerHour;
            company.setTotalWage(totalWage);
            return totalWage;
        }

        public int getTotalWage(string companyName)
        {
            if (this.companyDict.ContainsKey(companyName))
            {
                return this.companyDict[companyName].totalWage;
            }
            else
            {
                return 0;
            }
        }

    }
}