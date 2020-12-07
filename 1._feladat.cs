using System;
using System.IO;

namespace _2020_12_06
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("forras58.txt", FileMode.Open);
            StreamReader rs = new StreamReader(fs);
            string s = rs.ReadLine();
            int legnagyobb = 0;
            int legkisebb = 0;
            //Az első sor tartalmazza a darabszámot
            int db = Convert.ToInt32(s);
            int[] szamok = new int[db];    
            for (int i = 0; i < db; i++)
            {
                s = rs.ReadLine();
                szamok[i] = Convert.ToInt32(s);
                if (i == 0)
                {
                    legnagyobb = szamok[i];
                    legkisebb = szamok[i];
                }
                if (szamok[i] > legnagyobb)
                    legnagyobb = szamok[i];
                if (szamok[i] < legkisebb)
                    legkisebb = szamok[i];
            }
            Console.Write("Legkisebb: {0}\n", legkisebb);
            Console.Write("Legnagyobb: {0}", legnagyobb);
            rs.Close();
            fs.Close();
            Console.ReadKey();
        }
    }
}
