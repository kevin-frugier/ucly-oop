using System;

namespace project01 {
    class Circle : Shape {
        public float radius;
        public Circle(float radius) {
            this.radius = radius;
        }

        public override float calcArea() {
            return (float)(Math.PI * Math.Pow(radius, 2));
        }

        public float calcPerimeter() {
            return (float)(2 * Math.PI * radius);
        }
    }
}
