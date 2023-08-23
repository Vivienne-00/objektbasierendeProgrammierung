using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabeKomposition
{
    internal class Kunde
    {
        public int KundeId { get; set; }
        public string Name { get; set; }

        public Konto[] Kontos = new Konto[5];
    }
}
