using System;
using System.IO;

namespace _2020_12_06_2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("forras59.txt", FileMode.Open);
            StreamReader rs = new StreamReader(fs);
            int legkisebb = 0;
            string s = rs.ReadLine();
            int db = Convert.ToInt32(s);
            int[] szamok = new int[db];
            for (int i = 0; i < db; i++)
            {
                s = rs.ReadLine();
                szamok[i] = Convert.ToInt32(s);
                if (i == 0)
                    legkisebb = szamok[i];
                if (szamok[i] < legkisebb && (szamok[i] % 2) == 0)
                    legkisebb = szamok[i];
            }
            Console.Write("A legkisebb páros szám: {0}",legkisebb);
            rs.Close();
            fs.Close();
            Console.ReadKey();
        }
    }
}
