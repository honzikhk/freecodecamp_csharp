using getter_setter;

namespace SetterGetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie shreck = new Movie("Shrek", "Adam Adamson", "PG");

            avengers.Rating = "G";
            Console.WriteLine(avengers.Rating);
            Console.ReadLine();
        }



    }
}