using System;

namespace Find_Area
{
    class AreaCalculator
    {
        private static int _user_choice;
        public static void Circle()
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("Find area of circle with:");
                Console.WriteLine("1) Diameter.");
                Console.WriteLine("2) Radius.");
                _user_choice = int.Parse(Console.ReadLine());
                if (_user_choice <= 2 && _user_choice >= 1) { break; }
            }
            switch (_user_choice)
            {
                case 1:
                    double diametr;
                    while (true)
                    {
                        Console.Clear();
                        Console.Write("Input diametr: ");
                        diametr = double.Parse(Console.ReadLine());
                        if (diametr > 0) { break; }
                    }
                    Console.WriteLine($"The area of the circle is:" +
                        $" {(Math.PI / 4) * (diametr * diametr)}");
                    break;
                case 2:
                    double radius;
                    while (true)
                    {
                        Console.Clear();
                        Console.Write("Input radius: ");
                        radius = double.Parse(Console.ReadLine());
                        if (radius > 0) { break; }
                    }
                    Console.WriteLine($"The area of the circle is:" +
                        $" {(Math.PI * (radius * radius))}");
                    break;
            }
        }
        public static void Triangle()
        {
            while (true)
            {
                Console.WriteLine("Find area of triangle with:");
                Console.WriteLine("1) Height and base.");
                Console.WriteLine("2) Heron's formula (three sides).");
            }
        }
    }
    class GeometriclFigures
    {
        private static string[] _geometric_figures;
        private static int _number_of_figures = 12;
        private static int _number_of_figure = 0;
        private static void SetGeometricFigure(string figure, int number)
        {
            _geometric_figures[number] = figure;
        }
        private static void InitFigures()
        {
            _geometric_figures = new string[_number_of_figures];
        }
        private static int CreateFigures()
        {
            SetGeometricFigure("Circle", _number_of_figure);
            _number_of_figure++;
            SetGeometricFigure("Triangle", _number_of_figure);
            SetGeometricFigure("Rectangle", _number_of_figure++);
            SetGeometricFigure("Square", _number_of_figure++);
            SetGeometricFigure("Parallelogram", _number_of_figure++);
            SetGeometricFigure("Free trapezoid", _number_of_figure++);
            SetGeometricFigure("Isosceles trapezoid", _number_of_figure++);
            SetGeometricFigure("Rhombus", _number_of_figure++);
            SetGeometricFigure("Circle sector", _number_of_figure++);
            SetGeometricFigure("Circle segment", _number_of_figure++);
            SetGeometricFigure("Ring sector", _number_of_figure++);
            SetGeometricFigure("Ring area", _number_of_figure++);
            SetGeometricFigure("Regular polygon", _number_of_figure++);
            return _number_of_figures;
        }
        public static void FillArrayOfFiruges()
        {
            InitFigures();
            CreateFigures();
        }
        public static void ShowGeometricFigures()
        {
            for (int i = 0; i < _number_of_figures; i++)
            {
                Console.WriteLine($"{i + 1}) {_geometric_figures[i]}.");
            }
        }
    }
    class Navigation
    {
        private static int _user_choice;
        public static void ShowNavigation()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the program " +
                    "for finding the area of any 2D figure.");
                GeometriclFigures.ShowGeometricFigures();
                Console.WriteLine("Input number: ");
                _user_choice = int.Parse(Console.ReadLine());
                if (_user_choice >= 1 && _user_choice <= 12) { break; }
            }
            switch(_user_choice)
            {
                case 1:
                    AreaCalculator.Circle();
                    break;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GeometriclFigures.FillArrayOfFiruges();
            Navigation.ShowNavigation();
        }
    }
}
