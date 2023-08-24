namespace UebungVerein
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Praesident praesident = new Praesident("Sheraldo");
            Verein verein = new Verein(praesident, "RandomName");
            Torwart torwart = new Torwart("Fin");

            List<Feldspieler> feldspieler = new List<Feldspieler>();
            Feldspieler David = new Feldspieler("David");
            feldspieler.Add(David);
            Feldspieler Amir = new Feldspieler("Amir");
            feldspieler.Add(Amir);
            Feldspieler Tyler = new Feldspieler("Tyler");
            feldspieler.Add(Tyler);
            Feldspieler Cyrill = new Feldspieler("Cyrill");
            feldspieler.Add(Cyrill);
            Feldspieler Lucas = new Feldspieler("Lucas");
            feldspieler.Add(Lucas);
            Feldspieler Julian = new Feldspieler("Julian");
            feldspieler.Add(Julian);
            Feldspieler Manuel = new Feldspieler("Manuel");
            feldspieler.Add(Manuel);
            Feldspieler Robert = new Feldspieler("Robert");
            feldspieler.Add(Robert);
            Feldspieler Charles = new Feldspieler("Charles");
            feldspieler.Add(Charles);
            Feldspieler Florian = new Feldspieler("Florian");
            feldspieler.Add(Florian);

            Mannschaft mannschaft = new Mannschaft("LoL");

            praesident.Unterzeichnen("Spielgenehmigung");

            Physiotherapeutin physiotherapeutin = new Physiotherapeutin("Bianca");

            Console.WriteLine("Alle Spieler:");
            Console.WriteLine(mannschaft.Motto);
            mannschaft.SchreibeNamen();
            Console.WriteLine(torwart.HalteBall());
            physiotherapeutin.Massieren();
        }
    }
}