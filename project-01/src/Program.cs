﻿using System;

namespace project01 {

    class Program {
        static void Main(string[] args) {
            {
                Shape shape = new Rectangle(4, 3);
                shape.displayInfo();
                shape = new Circle(5);
                shape.displayInfo();
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
