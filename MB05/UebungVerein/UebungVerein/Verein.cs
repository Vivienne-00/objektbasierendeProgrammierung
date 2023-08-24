using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UebungVerein
{
    internal class Verein
    {
        private List<Mannschaft> mannschaften = new List<Mannschaft>();

        private Physiotherapeutin physiotherapeutin;
        public string Name { get; set; }
        public Verein(Praesident praesident, string name)
        {
            this.Name = name;
        }
    }
}
