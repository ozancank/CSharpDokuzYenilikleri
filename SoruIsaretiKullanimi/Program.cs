using System;

namespace SoruIsaretiKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Honda honda = null;
            Kawasaki kawasaki = new("ZX6R", "green", 2020, 85000, 280, 0.6);

            Motor vehicle = honda ?? kawasaki; //null kontrolü
            Console.WriteLine("Vehicle: " + vehicle);

            Kawasaki kawasaki2 = new("ZX6R", "green", 2020, 85000, 0, 0.6);
            Motor vehicle2 = honda ?? kawasaki2;
            int? maxSpeed = vehicle2 is Kawasaki ? ((Kawasaki)vehicle2).maxSpeed : null; // nullable value
            Console.WriteLine("Vehicle Max Speed: " + maxSpeed);

            Console.ReadKey();
        }

        public record Motor(string Model, string Color, int Year, decimal Price)
        {
            public string Color { get; set; }
        }

        public record Honda(string Model, string Color, int Year, decimal Price, int maxSpeed) : Motor(Model, Color, Year, Price);

        public record Kawasaki(string Model, string Color, int Year, decimal Price, int maxSpeed, double perLiterCost) : Honda(Model, Color, Year, Price, maxSpeed);
    }
}