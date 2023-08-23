using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabeKapselung
{
    internal class Person
    {
        private int wutLevel = 0;
        private int appetitLevel = 0;
        public void Provozieren(int level)
        {
            wutLevel += level;

            if (wutLevel >= 100)
            {
                Ausrasten();
            }
            else
            {
                Console.WriteLine($"Person ist auf dem Wutlevel {wutLevel}");
            }
        }
        private void Ausrasten()
        {
            Console.WriteLine($"Person ist am ausrasten und auf dem Wutlevel {wutLevel}");
        }

        public void EssenGeben(string antwort)
        {
            if ( antwort == "ja") 
            {
                wutLevel = 0;
                appetitLevel = 0;
                Console.WriteLine($"Die Person konnte sich beruhigen und ist auf dem Wutlevel {wutLevel}");
            } 
            else
            {
                EssenVerweigern();
            }
        }

        public void EssenVerweigern()
        {
            wutLevel = 15 + wutLevel;
            appetitLevel = 15 + appetitLevel;
            Console.WriteLine($"Die Person ist hangry und auf dem Wutlevel {wutLevel}");
        }

        public void ArbeitsauftragGeben(int level)
        {
            if (level != 0)
            {
                wutLevel = level + wutLevel;
                appetitLevel = level + appetitLevel;
                Console.WriteLine($"Die Person ist von der Arbeit erschöpft und auf dem Wutlevel {wutLevel}");
            } else
            {
                Console.WriteLine($"Der Zustand der Person bleibt gleich, Wutlevel {wutLevel}");
            }
            
        }
    }
}
