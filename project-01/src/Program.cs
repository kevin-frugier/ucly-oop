using System;

namespace project01 {

    class Program {
        static void Main(string[] args) {
            {
                Rectangle rectangle = new Rectangle(4, 3);
                Console.WriteLine(rectangle.calcArea());
                Console.WriteLine(rectangle.calcPerimeter());

                Circle circle = new Circle(5);
                Console.WriteLine(circle.calcAreaa());
                Console.WriteLine(circle.calcPerimeter());

                Shape shape = rectangle;
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
