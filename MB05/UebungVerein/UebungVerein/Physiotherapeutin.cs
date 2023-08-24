using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UebungVerein
{
    internal class Physiotherapeutin
    {
        public string Name { get; set; }
        public Physiotherapeutin(string name)
        {
            this.Name = name;
        }
        public void Massieren()
        {
            Console.WriteLine("Nach dem Spiel massieren...");
        }
    }
}
