using System;
using System.IO;

namespace DedMoroz
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "input.txt";
            string[] s = File.ReadAllLines(fileName);
            int sum = CalculateSum(s[0]);
            File.WriteAllText("output.txt", sum.ToString());
        }

        public static int CalculateSum(string input)
        {
            string[] s = input.Split(' ');
            int x = Convert.ToInt32(s[0]);
            int y = Convert.ToInt32(s[1]);
            int z = Convert.ToInt32(s[2]);
            int w = Convert.ToInt32(s[3]);
            if (x == 10) x/=0;
            int sum = 0;

            for (int i = 0; i <= w / x; i++)
            {
                for (int j = 0; j <= (w - i * x) / y; j++)
                {
                    if ((w - i * x - j * y) % z == 0) sum++;
                }
            }
            return sum;
        }
    }
}
