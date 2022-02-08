using System;

namespace puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randArr = RandArray();
            Console.WriteLine(TossCoin());
            Console.WriteLine(TossMultipleCoins(10));
        }

        public static int[] RandArray()
        {
            int maxlength = 10;
            int[] randarr = new int[maxlength];
            Random rand = new Random();

            for (int i = 0; i <= randarr.Length - 1; i++)
            {
                int randidx = rand.Next(5, 25);
                randarr[i] = randidx;
                Console.WriteLine(randarr[i]);
            }
            return randarr;
        }

        public static string TossCoin()
        {
            string result = "";
            Random rand = new Random();
            int toss = rand.Next(0, 100);
            Console.WriteLine("Tossing a coin");
            if (toss % 2 != 0)
            {
                result = "Heads";
            }
            else
            {
                result = "Tails";
            }
            return result;
        }

        public static double TossMultipleCoins(int num)
        {
            double heads = 0;
            double all = num;
            for (int i = 1; i <= num; i++)
            {
                string toss = TossCoin();
                if (toss == "Heads")
                {
                    heads += 1;
                }
                Console.WriteLine(heads);
            }

            double totals = heads * 100 / all;
            return totals;
        }
    }
}
