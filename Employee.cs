using System;

namespace ConsoleProject_21_11_21
{
    public class Employee : User
    {
        public string position;
        public int salary;
        public Employee(string _name, int _birthYear, string _email, string _position, int _salary)
            : base(_name, _birthYear, _email)
        {
            this.position = _position;
            this.salary = _salary;
        }
        protected override string PrintInfo()
        {
            return base.PrintInfo()+ $" position: { this.position} salary:{ this.salary}";
        }
        public void GetPrintedInfo()
        {
            Console.WriteLine(this.PrintInfo());
        }
    }
}
