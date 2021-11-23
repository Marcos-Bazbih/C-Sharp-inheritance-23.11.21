using System;

namespace ConsoleProject_21_11_21
{
    class Bus : Car
    {
        public int seats;
        public string company;
        public Bus(string _model, int _capacity, string _color, int _seats, string _company)
            : base(_model, _capacity, _color)
        {
            this.seats = _seats;
            this.company = _company;
        }






        //int seats;
        //string company;
        //public int Seats
        //{
        //    get { return this.seats; }
        //    set { this.seats = value; }
        //}
        //public string Company
        //{
        //    get { return this.company; }
        //    set { this.company = value; }
        //}
    }
}
