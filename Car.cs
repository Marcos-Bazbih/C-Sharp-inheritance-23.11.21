using System;

namespace ConsoleProject_21_11_21
{
    class Car : IComparable
    {
        public string model;
        public int capacity;
        public string color;
        public Car(string _model, int _capacity, string _color)
        {
            this.model = _model;
            this.capacity = _capacity;
            this.color = _color;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"model: {this.model}, capacity: {this.capacity}, color: {this.color}");
        }
        public int CompareTo(object? obj)
        {
            Car c = (Car)obj;
            if (this.capacity < c.capacity) return -1;
            if (this.capacity > c.capacity) return 1;
            return 0;

        }
    }
}
