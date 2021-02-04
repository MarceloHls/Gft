using System;
namespace baskara
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite A");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite B");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite C");
            double c = double.Parse(Console.ReadLine());

            double quadradoB = Math.Pow(b, 2);
            double deltaMetade = 4 * a * c;
            double delta = Math.Sqrt(quadradoB - deltaMetade);
            
            if (a == 0 || delta.ToString() == "NaN" || delta == 0)
            {
                Console.WriteLine("Impossível calcular.");

            }
            else
            {

                double x1 = (-b + delta) / (2 * a);
                double x2 = (-b - delta) / (2 * a);

                Console.WriteLine($"X1 = {x1.ToString("N5")}");
                Console.WriteLine($"X2 = {x2.ToString("N5")}");
            }









        }
    }
}
