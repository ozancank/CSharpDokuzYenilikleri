using System;
using System.Collections.Generic;

namespace TipBelirtmedenKurtulma
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Motor> motorList = new();
            motorList.Add(new() { Model = "AAA", Year = 2020, Color = "Black", Price = 800000 });
            Console.WriteLine(motorList.Count.ToString());
            Console.ReadKey();
        }

        public class Motor
        {
            public string Model { get; set; }
            public string Color { get; set; }
            public int Year { get; set; }
            public decimal Price { get; set; }
        }
    }
}