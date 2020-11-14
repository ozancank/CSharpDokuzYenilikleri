using System;

namespace RelationalPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Kawasaki motor = new("ZX6R", "green", 2020, 85000, 280, 0.6);
            decimal price = GetPriceWithTax(motor);
            Console.WriteLine($"Motor Son Fiyatı {price}");
            Console.ReadKey();
        }

        public record Motor(string Model, string Color, int Year, decimal Price)
        {
            public string Color { get; set; }
        }

        public record Honda(string Model, string Color, int Year, decimal Price, int maxSpeed) : Motor(Model, Color, Year, Price);

        public record Kawasaki(string Model, string Color, int Year, decimal Price, int maxSpeed, double perLiterCost) : Honda(Model, Color, Year, Price, maxSpeed);

        public static decimal GetPriceWithTax(Motor motor) =>
                   motor.Year switch
                   {
                       > 2019 => motor.Price * Convert.ToDecimal(1.2),
                       >= 2018 and <= 2019 => motor.Price * Convert.ToDecimal(1.1),
                       < 2018 => motor.Price * Convert.ToDecimal(1.3),
                       //_ => motor.Price //ide den dolayı yorum yapıldı.
                   };
    }
}