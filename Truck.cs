using System;


namespace ConsoleProject_21_11_21
{
    class Truck : Car
    {
        public string name;
        public int numOfWheels;
        public Truck(string _model, int _capacity, string _color, string _name, int _numOfWheels)
            : base(_model, _capacity, _color)
        {
            this.name = _name;
            this.numOfWheels = _numOfWheels;
        }
    }
}
