﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWages
{
    public interface ComputeEmpWage
    {
        public int CalcTotalEmpWage(Company company);
    }
    public class Company
    {
        public int empRatePerHour;
        public int noOfWorkingDays;
        public int noOfWorkingHours;
        public string companyName;

        public Company(string COMPANY_NAME, int EMP_RATE_PER_HOUR, int NO_OF_WORKING_DAYS, int NO_OF_WORKING_HOURS)
        {
            this.companyName = COMPANY_NAME;
            this.empRatePerHour = EMP_RATE_PER_HOUR;
            this.noOfWorkingDays = NO_OF_WORKING_DAYS;
            this.noOfWorkingHours = NO_OF_WORKING_HOURS;
        }

    }
}