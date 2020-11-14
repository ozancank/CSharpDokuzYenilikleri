using System;

namespace EqualsVeReferenceEquals
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

            var blackHonda = honda with { Color = "Black" }; //with ile nesnenin referansı farklı fakar değerleri aynı bir nensne oluşur.
            var colorHonda = honda with { Color = "red" }; //with ile nesnenin referansı farklı fakar değerleri aynı bir nensne oluşur.

            Console.WriteLine($"Referance Honda&Black Equals:{ReferenceEquals(honda, blackHonda)}");  //Referanslar farklı
            Console.WriteLine($"Equals Color&Honda :{Equals(colorHonda, honda)}"); //Nesne değerleri aynı
            Console.WriteLine($"Equals Black&Honda:{Equals(honda, blackHonda)}");  //Nesne değerleri farklı
            Console.ReadKey();
        }

        record Motor
        {
            public string Model { get; init; }
            public string Color { get; set; }
            public int Year { get; init; }
            public decimal Price { get; init; }
        }
    }
}