using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabeAggregation
{
    internal class FirmaUndMitarbeiter
    {
        public int MitarbeiterId { get; set; }
        public string Name { get; set; }
        public Firma Firma { get; set; }
    }
}
