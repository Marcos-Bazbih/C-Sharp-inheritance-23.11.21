using System;

namespace ConsoleProject_21_11_21
{
    public class User : IComparable
    {
        public string name;
        public int birthYear;
        public string email;
        public User() { }
        public User(string _name, int _birthYear, string _email)
        {
            this.name = _name;
            this.birthYear = _birthYear;
            this.email = _email;
        }

        protected virtual string PrintInfo()
        {
            return $"name: {this.name} birth Year:{this.birthYear} email:{this.email}";
        }

        public int CompareTo(object? obj)
        {
            User u = (User)obj;
            if (this.birthYear < u.birthYear) return -1;
            if (this.birthYear > u.birthYear) return 1;
            return 0;
        }

    }
}
