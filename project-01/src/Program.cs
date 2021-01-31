using System;

namespace project01 {
    class Rectangle {
        public float side1;
        public float side2;
        public Rectangle(float sideA, float sideB) {
            side1 = sideA;
            this.side2 = sideB;
        }

        public float calcArea() {
            return side1 * side2;
        }

        public float calcPerimeter() {
            return 2 * (side1 + side2);
        }
    }

    class Program {
        static void Main(string[] args) {
            Rectangle rect1 = new Rectangle(4, 3);
            Console.WriteLine(rect1.calcArea());
            Console.WriteLine(rect1.calcPerimeter());

            Human bob = new Human("Bob", "Johnson", DateTime.Parse("1983-12-05T21:55:00+1"));
            Console.WriteLine(bob.firstName);
            Console.WriteLine(bob.lastName);
            Console.WriteLine(bob.name);
            Console.WriteLine(bob.birth);
            Console.WriteLine(bob.age);
        }
    }
}
