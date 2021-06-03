using System;

namespace ConsoleApp3
{
    public delegate int Nomer();
    public delegate int MediumCalculator(Nomer[] arrayX);
    class Program
    {
        public static int RandomizerChisel()
        {
            Random rand = new Random();
            return rand.Next(1, 10);
        }
        static void Main(string[] args)
        {
            Nomer[] numArr = new Nomer[5];
            for (int i = 0; i < numArr.Length; i++)
            {
                numArr[i] = RandomizerChisel;
                Console.Write(" " + numArr[i].Invoke() + " ");
            }
            Console.WriteLine();

            MediumCalculator mediumCalc = delegate (Nomer[] arrayX)
            {
                int sum = 0;
                for (int i = 0; i < arrayX.Length; i++)
                {
                    sum += arrayX[i]();
                }
                return ((sum) / (arrayX.Length));
            };

            Console.WriteLine(mediumCalc(numArr));

            Console.ReadKey();
        }
    }
}