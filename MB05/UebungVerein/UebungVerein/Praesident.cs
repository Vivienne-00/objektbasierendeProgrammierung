using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UebungVerein
{
    internal class Praesident
    {
        public string Name { get; set; }
        public Praesident(string name)
        {
            this.Name = name;
        }

        public void Unterzeichnen(string vertrag)
        {
            Console.WriteLine($"Der Präsident hat die {vertrag} unterzeichnet");
        }
    }
}
