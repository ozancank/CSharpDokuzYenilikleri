namespace InitKullanma
{
    class Program
    {
        static void Main(string[] args)
        {
            var honda = new Motor { Model = "CBR650R", Color = "red", Year = 2020, Price = 90000 };
            //honda.Model = "CBR1000RRR"; //HATA
            honda.Color = "Dark Black"; //DOĞRU
        }

        public class Motor
        {
            public string Model { get; init; } // init değeri sadece nesne oluşturulurken verilebilir.
            public string Color { get; set; }
            public int Year { get; init; } // init değeri sadece nesne oluşturulurken verilebilir.
            public decimal Price { get; init; } // init değeri sadece nesne oluşturulurken verilebilir.
        }

        //init ve set beraber kullanılamaz.
    }
}