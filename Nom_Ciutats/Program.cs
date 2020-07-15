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
            string[] arrayArrayCiutatsModificades = new string[6];
            int count = 0;


            foreach (string c in arrayCiutats)
            {
                arrayArrayCiutatsModificades[count] = c.Replace("a", "4");
                count++;
            }

            Array.Sort(arrayArrayCiutatsModificades, StringComparer.InvariantCulture);

            Console.WriteLine("Las ciudades introducidas son: ");
            foreach (string c in arrayArrayCiutatsModificades)
            {
                Console.WriteLine(c);
            }
        }
    }
}
