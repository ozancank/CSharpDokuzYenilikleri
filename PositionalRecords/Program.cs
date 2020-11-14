using System;

namespace PositionalRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            var ozan = new Student("Ozan", "Kösemez", 1234);
            var (name, surname, no) = ozan;
            Console.WriteLine($"Student:\n1-)Name:{name}\n2-)Surname:{surname}\n3-)No:{no}");
            Console.ReadKey();
        }

        //public record Student(string name, string surname, int no)
        //{
        //    public string Name => name;

        //    public string Surname => surname;
        //    public int No => no;
        //}

        public record Student(string Name, string Surname, int No); //Daha kısa bir constructor

        //Değerler init olarak değerlendirilir. Oluşturulduktan sonra değiştirilmez.
    }
}