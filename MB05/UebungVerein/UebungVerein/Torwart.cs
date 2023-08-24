using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UebungVerein
{
    internal class Torwart
    {
        public string Name { get; set; }
        public Torwart(string name)
        {
            this.Name = name;
        }
        public void HalteBall()
        {
            Console.WriteLine("Torwart hat den Ball gefangen.");
        }
    }
}
