using System;

namespace project01
{
    class Rectangle
    {
        public float side1;
        public float side2;
        public Rectangle(float sideA, float sideB)
        {
            side1 = sideA;
            this.side2 = sideB;
        }

        public float calcArea()
        {
            return side1 * side2;
        }

        public float calcPerimeter()
        {
            return 2 * (side1 + side2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle(4, 3);
            Console.WriteLine(rect1.calcArea());
            Console.WriteLine(rect1.calcPerimeter());
        }
    }
}
