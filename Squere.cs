using System;


namespace ConsoleProject_21_11_21
{
    class Squere
    {
        public int height;
        public int width;
        public Squere(int _heigth, int _width)
        {
            this.height = _heigth;
            this.width = _width;
        }
        public int GetSum()
        {
            return this.height * this.width;
        }
    }
}
