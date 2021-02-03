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
            {
                Rectangle rectangle = new Rectangle(4, 3);
                Console.WriteLine(rectangle.calcArea());
                Console.WriteLine(rectangle.calcPerimeter());
            }

            {
                Human bob = new Human("Bob", "Johnson", DateTime.Parse("1983-12-05T21:55:00+1"));
                Console.WriteLine(bob.firstName);
                Console.WriteLine(bob.lastName);
                Console.WriteLine(bob.name);
                Console.WriteLine(bob.birth);
                Console.WriteLine(bob.age);
            }

            {
                Human bob = new Human("Bob", "Johnson", "1983-12-05T21:55:00+1");
                Console.WriteLine(bob.firstName);
                Console.WriteLine(bob.lastName);
                Console.WriteLine(bob.name);
                Console.WriteLine(bob.birth);
                Console.WriteLine(bob.age);
            }
        }
    }
}
