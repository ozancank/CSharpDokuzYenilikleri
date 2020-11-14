namespace CovariantReturns
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer developer = new();
        }

        public abstract class Person
        {
            public abstract Person GetJob();
        }

        public class Developer : Person
        {
            public override Developer GetJob() //Abstractan gelen method dönüş tipi sınıfın tipine dönüştürülebilir.
            {
                return new Developer();
            }
        }
    }
}