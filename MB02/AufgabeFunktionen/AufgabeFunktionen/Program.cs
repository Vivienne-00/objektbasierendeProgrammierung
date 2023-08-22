namespace AufgabeFunktionen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 12, b = 16;
            Console.WriteLine(MyMath.Calc_ggT(a, b));
            Console.WriteLine(MyMath.Calc_kgV(a, b));
            Console.WriteLine($"Eingegebene Zahl: {ReadInt()}");
        }

        //Aufgabe 4
        static int ReadInt()
        {
            int i;
            do
            {
                Console.WriteLine("Bitte Zahl eingeben");
                string s = Console.ReadLine();
                int.TryParse(s, out i);

            } while (i <= 0);
            Console.WriteLine("danke");
            return i;
        }

        //Aufgabe 5
        
        static void ShowResult(int[] arr, int a, int b)
        { 
            int ggTZ = MyMath.Calc_ggT(a, b);
            int KgVZ = MyMath.Calc_kgV(a, b);

          
            arr[0] = a;
            arr[1] = b;
            arr[2] = ggTZ;
            arr[3] = KgVZ;

            Console.WriteLine($"ggT von {arr[0]} und {arr[1]} ist {arr[2]}");
            Console.WriteLine($"KgV von {arr[0]} und {arr[1]} ist {arr[3]}");

            /* for (int i = 0; i < arr.Length; i++)
             {
                 Console.WriteLine(arr[i]);
             }*/
        }

    }
}