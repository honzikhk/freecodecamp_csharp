namespace classes_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chef is a superclass
            // ItalianChef is a subclass
            Chef chef = new Chef();
            chef.MakeSpecialDish();

            ItalianChef italianChef = new ItalianChef();
            italianChef.MakeSpecialDish();

            Console.ReadLine();
        }
    }
}