using System;

namespace PositionalRecordInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Kawasaki motor = new Kawasaki("ZX6R", "green", 2020, 161000, 280, 0.60);
            Console.WriteLine(motor.Color);
        }

        public record Motor(string Model, string Color, int Year, decimal Price)
        {
            public string Color { get; set; } //Color değişeceği için set olarak ayarlandı.
        }

        public record Honda(string Model, string Color, int Year, decimal Price, int maxSpeed) : Motor(Model, Color, Year, Price);

        public record Kawasaki(string Model, string Color, int Year, decimal Price, int maxSpeed, double perLiterCost) : Honda(Model, Color, Year, Price, maxSpeed);
    }
}