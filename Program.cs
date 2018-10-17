using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace DevBlockChain
{
    class Program
    {             

        static void Main(string[] args)
        {
            string s1 = "Majchrowicz";
            string s2 = "Majchrowicz";
            Action<string> Wypisz = Console.WriteLine;
            Wypisz (StringHash.GetHashString(s1));
            Wypisz(StringHash.GetHashString(s2));
            Console.ReadKey();
        }
    }
}
