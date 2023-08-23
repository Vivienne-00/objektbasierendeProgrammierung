using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UebungenAssoziation
{
    internal class KundeUndBuch
    {
        public int KundeId { get; set; }
        public string Name { get; set; }
        public List<Buch> Buecher { get; set; } = new List<Buch>();
    }
}
