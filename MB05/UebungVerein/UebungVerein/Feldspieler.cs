using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UebungVerein
{
    internal class Feldspieler
    {
        public string Name { get; set; }
        public Feldspieler(string name)
        {
            this.Name = name;
        }

        public void SchiesseTor()
        {
            Console.WriteLine("Feldspieler schiesst Tor.");
        }

        public void Graetschen()
        {
            Console.WriteLine("Feldspieler führt Graetsche aus?");
        }
    }
}
