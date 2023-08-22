using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabeFunktionen
{
    internal class MyMath
    {   
        //Aufgabe 2
        public static int Calc_ggT(int a, int b)
        {
            int z = 0;

            while(b != 0)
            {
                z = a % b;
                a = b;
                b = z;
            }
            return a;
        }

        //Aufgabe 7
        public static int Calc_ggT_r(int a, int b)
        {
            if (b == 0)
            {
                return a;

            } else
            {
                return Calc_ggT_r(b, a % b);
            }
        }

        //Aufgabe 3
        public static int Calc_kgV(int a, int b)
        {
            return a * b / Calc_ggT(a, b);
        }

        //Aufgabe 8

        public static int NumericalAverage(int[] arr)
        {
            int sum = 0;
            foreach (int v in arr)
            {
                sum += v;
            }
            return sum / (arr.Length);
        }

        public static int SmallestNumber(int[] arr)
        {
            int smallestNum = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < smallestNum)
                {
                    smallestNum = arr[i];
                }
            }
            return smallestNum;
        }
        public static int BiggestNumber(int[] arr)
        {
            int biggestNum = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > biggestNum)
                {
                    biggestNum = arr[i];
                }
            }
            return biggestNum;
        }

        //Aufgabe 9
        public static void Swap(ref int a, ref int b)
        {
            int z = b;
            b = a;
            a = z;
        }

    }
}
