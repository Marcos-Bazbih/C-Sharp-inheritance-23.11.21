using System;

namespace ConsoleProject_21_11_21
{
    class Manager
    {
        string division;
        int salary;
        int numberOfEmployees;
        public string Division
        {
            get { return this.division; }
            set { this.division = value; }
        }

        public int Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }

        public int NumberOfEmployees
        {
            get { return this.numberOfEmployees; }
            set { this.numberOfEmployees = value; }
        }

    }
}
