using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabeAggregation
{
    internal class NotebookUndFestplatte
    {
        public int NotebookId { get; set; }
        public string Name { get; set; }
        public Festplatte Festplatte { get; set; }
    }
}
