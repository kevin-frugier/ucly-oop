using System;

namespace project01 {
    abstract class Shape {
        public abstract float calcArea();
        public abstract float calcPerimeter();

        public virtual void displayInfo() {
            Console.WriteLine($"Area: {calcArea()}");
            Console.WriteLine($"Perimeter: {calcPerimeter()}");
        }
    }
}