using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UebungVerein
{
    internal class Mannschaft
    {
        private List<Feldspieler> feldspielerListe = new List<Feldspieler>();
        private List<Torwart> torwartListe = new List<Torwart>();
        public string Motto { get; set; }
        public Mannschaft(string motto)
        {
            this.Motto = motto;
        }

        public void SchreibeNamen()
        {
            foreach (var torwartName in torwartListe)
            {
                Console.WriteLine($"Torwart: {torwartName}");
            }
            foreach (var feldspielerName in feldspielerListe)
            {
                Console.WriteLine($"Feldspieler: {feldspielerName}");
            }
        }

    }
}
