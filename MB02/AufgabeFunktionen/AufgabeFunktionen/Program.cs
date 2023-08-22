namespace AufgabeFunktionen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 12, b = 16;
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(MyMath.Calc_ggT(a, b));
            Console.WriteLine(MyMath.Calc_kgV(a, b));
            //Console.WriteLine($"Eingegebene Zahl: {ReadInt()}");
            Console.WriteLine(ShowResult("kgV", a, b, MyMath.Calc_kgV(a, b) ));
            Console.WriteLine(ShowResult("ggT", a, b, MyMath.Calc_ggT_r(a, b)));
            Console.WriteLine($"Durschnitt von Array: {MyMath.NumericalAverage(arr)}");
            Console.WriteLine($"kleinste Zahl von Array: {MyMath.SmallestNumber(arr)}");
            Console.WriteLine($"grösste Zahl von Array: {MyMath.BiggestNumber(arr)}");
            //MyMath.Swap(ref a, ref b);
            //Console.WriteLine($"a:{a}, b:{b}");
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

        //Aufgabe 5 + 6
        private static string ShowResult(string mathType, int a, int b, int result)
        {
            return $"{mathType} von {a} und {b} ist {result}";
        }

    }
}