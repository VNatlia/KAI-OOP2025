namespace FiguresLib
{
    public class Figure
    {
        protected double x1, y1, x2, y2, x3, y3;

        // Конструктор за замовчуванням
        public Figure()
        {
            x1 = y1 = x2 = y2 = x3 = y3 = 0;
        }

        // Конструктор з параметрами
        public Figure(double ax1, double ay1, double ax2, double ay2, double ax3, double ay3)
        {
            x1 = ax1; y1 = ay1;
            x2 = ax2; y2 = ay2;
            x3 = ax3; y3 = ay3;
        }

        // Конструктор копіювання
        public Figure(Figure other)
        {
            x1 = other.x1; y1 = other.y1;
            x2 = other.x2; y2 = other.y2;
            x3 = other.x3; y3 = other.y3;
        }

        // Метод для обчислення довжини сторони
        protected double SideLength(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
