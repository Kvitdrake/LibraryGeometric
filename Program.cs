using TestWorkForAvito_library;

namespace GeometryAvitoLibrary
{
    class Program
    {
        public static void Main()
        {
            double a = 6, b = 8,  c = 10;
            Triangle t = new Triangle(a, b, c);

            double tP = t.Perimeter(),  tA = t.Area();

            Console.WriteLine("Периметр треугольника: " + tP  + "\n" +"Площать треугольника: " + tA);

            Console.ReadKey();
        }
    }
}
