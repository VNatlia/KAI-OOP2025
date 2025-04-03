namespace FiguresLib
{
    public class Triangle : Figure //наслідування
    {
      
        public Triangle() : base() { } //коли визив коннструктор визив реалізацію конструктора базового класу

        public Triangle(double ax1, double ay1, double ax2, double ay2, double ax3, double ay3)
            : base(ax1, ay1, ax2, ay2, ax3, ay3) { }

        public Triangle(Triangle other) : base(other) { }

        public double Perimeter()
        {
            return SideLength(x1, y1, x2, y2) +
                   SideLength(x2, y2, x3, y3) +
                   SideLength(x3, y3, x1, y1);
        }

        public double Area()
        {
            double a = SideLength(x1, y1, x2, y2);
            double b = SideLength(x2, y2, x3, y3);
            double c = SideLength(x3, y3, x1, y1);
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
    }
}
