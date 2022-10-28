using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadata1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj: ");

            string broj = Console.ReadLine();

            bool nasao = false;

            for (int i = 0; i < broj.Length; i++)
            {
                if (broj[i] == '3')
                {
                    Console.WriteLine("broj " + broj + " sadryi u sebi broj 3");
                    break;
                }

            }

            if (!nasao)
            {
                Console.WriteLine("broj " + broj + " NE sadryi u sebi broj 3");
            }

            Console.ReadKey();
        }
    }
}
