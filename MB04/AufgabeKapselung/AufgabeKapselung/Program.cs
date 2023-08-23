namespace AufgabeKapselung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int antwortProvokation = ProvokationsLevel();
            string antwortEssen = HungerLevel();
            int antwortArbeit = ArbeitsLevel();
            Person person = new Person();
            person.Provozieren(antwortProvokation);
            person.EssenGeben(antwortEssen);
            person.ArbeitsauftragGeben(antwortArbeit);
        }
        public static int ProvokationsLevel()
        {
            int antwortProvokation;
            do
            {
                Console.Write("Werden Sie provoziert von 1-100? ");
                string antwort = Console.ReadLine();
                int.TryParse(antwort, out antwortProvokation);
            } 
            while (antwortProvokation <= 0);
            return antwortProvokation;
        }
        public static string HungerLevel()
        {
            string antwortEssen;
            do
            {
                Console.Write("Haben Sie etwas gegessen, ja oder nein? ");
                antwortEssen = Console.ReadLine();

            }
            while (antwortEssen.Length < 0);
            return antwortEssen;
        }
        public static int ArbeitsLevel()
        {
            int antwortArbeit;
            do
            {
                Console.Write("Wie viel arbeiten Sie von 1-100? ");
                string antwort = Console.ReadLine();
                int.TryParse(antwort, out antwortArbeit);
            } 
            while (antwortArbeit <= 0);
            return antwortArbeit;
        }
    
    }
}