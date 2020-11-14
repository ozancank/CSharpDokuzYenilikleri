using System;

namespace ImprovedPatternMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            Honda motor = new("cbr650r", "red", 2019, 90000, 250);
            Kawasaki motor2 = new("ZX6R", "green", 2020, 161000, 280, 0.6);
            Kuba motor3 = new("", "", 2019, 10000, 200);
            Honda motor4 = new("cbr650r", "red", 2019, 180000, 250);
            Kawasaki motor5 = new("ZX6R", "green", 2020, 85000, 280, 0.6); //Hondadan miras aldığı için sonucu honda olarak döndürecek.

            string priceType = GetPriceState(motor);
            Console.WriteLine($"Gerçekten {priceType}");

            string priceType2 = GetPriceState(motor2);
            Console.WriteLine($"Gerçekten {priceType2}");

            try
            {
                string priceType3 = GetPriceState(motor3); //Hata fırlatır.
                Console.WriteLine($"Gerçekten {priceType3}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            string priceType4 = GetPriceState(motor4);
            Console.WriteLine($"Gerçekten {priceType4}");

            string priceType5 = GetPriceState(motor5);
            Console.WriteLine($"Gerçekten {priceType5}");

            Console.ReadKey();
        }

        public record Motor(string Model, string Color, int Year, decimal Price)
        {
            public string Color { get; set; }
        }

        public record Honda(string Model, string Color, int Year, decimal Price, int maxSpeed) : Motor(Model, Color, Year, Price);

        public record Kawasaki(string Model, string Color, int Year, decimal Price, int maxSpeed, double perLiterCost) : Honda(Model, Color, Year, Price, maxSpeed);

        public record Kuba(string Model, string Color, int Year, decimal Price, int maxSpeed) : Motor(Model, Color, Year, Price);

        public static string GetPriceState(Motor motor) =>
                    motor switch
                    {
                        Honda h when h.Price < 30000 => "Ucuz Honda",
                        Honda h when h.Price > 30000 & h.Price < 100000 => "Pahalı Honda",
                        Kawasaki k when k.Price > 100000 => "Kawasaki hep Pahalı",
                        Honda or Kawasaki => "Honda veya Kawasaki çok pahalı",

                        _ => throw new ArgumentException("Bilinen bir motor değil", nameof(motor))
                    };
    }
}