using System;

namespace RecordsKullanma
{
    class Program
    {
        static void Main(string[] args)
        {
            Motor honda = new()
            {
                Model = "CBR650R",
                Color = "red",
                Year = 2020,
                Price = 90000
            };

            var blackHonda = honda with { Color = "Dark Black" };
            WriteMotor(blackHonda);
        }

        static void WriteMotor(Motor motor)
        {
            Console.WriteLine($"1-){motor.Model}\n2-){motor.Color}\n3-){motor.Year}\n4-){motor.Price}");
            Console.ReadKey();
        }

        public record Motor
        {
            public string Model { get; init; }
            public string Color { get; set; }
            public int Year { get; init; }
            public decimal Price { get; init; }
        }
    }
}