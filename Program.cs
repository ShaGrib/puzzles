using System;
using System.Collections.Generic;

namespace puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randArr = RandArray();
            Console.WriteLine(TossCoin());
            Console.WriteLine(TossMultipleCoins(10));
            var names = Names();
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

            return (double)heads / all;
        }

        public static List<string> Names()
        {
            List<string> names = new List<string>()
            {
                "Todd", "Tiffany", "Charlie", "Geneva", "Sydney"
            };

            Random rand = new Random();

            for (var i = 0; i < names.Count / 2; i++)
            {
                int randomIndex = rand.Next(names.Count);
                string temp = names[randomIndex];
                names[randomIndex] = names[i];
                names[i] = temp;
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            for (var i = 0; i < names.Count; i++)
            {
                if (names[i].Length <= 5)
                    names.RemoveAt(i);
            }

            return names;
        }
    }
}
