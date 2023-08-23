using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UebungenAssoziation
{
    internal class KindUndVater
    {
        public int KindId { get; set; }
        public string Name { get; set; }
        public Vater Vater { get; set; }
    }
}

