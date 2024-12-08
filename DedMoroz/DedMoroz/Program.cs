using System;
using System.IO;

namespace DedMoroz
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "input.txt";
            string[] s;
            StreamReader sr = new StreamReader(fileName);
            fileName = "output.txt";
            StreamWriter sw = new StreamWriter(fileName);
            string line = sr.ReadLine();
            s = line.Split(' ');
            int x, y, z, w, sum=0;
            x = Convert.ToInt32(s[0]);
            y = Convert.ToInt32(s[1]);
            z = Convert.ToInt32(s[2]);
            w = Convert.ToInt32(s[3]);

            for (int i=0;i<=w/x;i++)
            {
                for (int j=0;j<=(w-i*x)/y;j++)
                {
                    if ((w - i * x - j * y) % z == 0) sum++;
                }
            }
            sw.WriteLine(sum);
            sr.Close();
            sw.Close();
        }
    }
}
