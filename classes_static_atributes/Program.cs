namespace classes_static_atributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Song holiday = new Song("Holiday", "Green day", 200);
            Console.WriteLine(Song.songCount);
            Song kashmir = new Song("Kashmir", "Led Zepplin", 150);
            Console.WriteLine(Song.songCount);


            
            Console.WriteLine(holiday.title);
            Console.WriteLine(kashmir.title);

            Console.ReadLine();
        }
    }
}