using System;

namespace Nom_Ciutats
{
    class Program
    {
        static void Main(string[] args)
        {
            string ciutat1, ciutat2, ciutat3, ciutat4, ciutat5, ciutat6;
            Console.WriteLine("Nom ciutat 1 :");
            ciutat1 = Console.ReadLine();
            Console.WriteLine("Nom ciutat 2 :");
            ciutat2 = Console.ReadLine();
            Console.WriteLine("Nom ciutat 3 :");
            ciutat3 = Console.ReadLine();
            Console.WriteLine("Nom ciutat 4 :");
            ciutat4 = Console.ReadLine();
            Console.WriteLine("Nom ciutat 5 :");
            ciutat5 = Console.ReadLine();
            Console.WriteLine("Nom ciutat 6 :");
            ciutat6 = Console.ReadLine();

            string[] arrayCiutats = { ciutat1, ciutat2, ciutat3, ciutat4, ciutat5, ciutat6 };

            char[] chars1 = new char[ciutat1.Length];
            chars1 = ciutat1.ToCharArray();
            char[] chars2 = new char[ciutat2.Length];
            chars2 = ciutat2.ToCharArray();
            char[] chars3 = new char[ciutat3.Length];
            chars3 = ciutat3.ToCharArray();
            char[] chars4 = new char[ciutat4.Length];
            chars4 = ciutat4.ToCharArray(); 
            char[] chars5 = new char[ciutat5.Length];
            chars5 = ciutat5.ToCharArray();
            char[] chars6 = new char[ciutat6.Length];
            chars6 = ciutat6.ToCharArray();

            char[][] chars = { chars1, chars2, chars3, chars4, chars5, chars6 };

            foreach (var ciutat in chars)
            {
                Console.Write(string.Join("", ciutat)+" - ");
                Array.Reverse(ciutat);
                Console.WriteLine(ciutat);
            }
        }
    }
}
