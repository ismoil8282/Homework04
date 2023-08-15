namespace HomeWork04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///// TASK1
            Rectangle rectangle = new Rectangle(5, 4);
            rectangle.CalculatePerimetr();
            rectangle.CalculateArea();
            rectangle.CalculeteDiagonal();

            Console.WriteLine();

            Circle circle = new Circle(5);
            circle.CalculatePerimetr();
            circle.CalculateArea();
        }
    }

    class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public void CalculatePerimetr()
        {
            Console.WriteLine($"Perimetr : {2 * (Width + Height)}");
        }

        public void CalculateArea()
        {
            Console.WriteLine($"Area : {Width * Height}");
        }

        public void CalculeteDiagonal()
        {
            Console.WriteLine($"Diagonal : {Math.Sqrt(Width * Width) + Math.Sqrt(Height * Height)}");
        }
    }

    class Circle
    {
        public double Radius { get; set; }


        public Circle(double radius)
        {
            Radius = radius;
        }

        public void CalculatePerimetr()
        {
            Console.WriteLine($"Perimetr circle : {2 * Math.PI * Radius}");
        }
        public void CalculateArea()
        {
            Console.WriteLine($"Area cirle : {Math.PI * Math.Pow(Radius, 2)}");
        }
    }
}