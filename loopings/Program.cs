using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 3;
            while (a < 3)
            {
                Console.WriteLine(a);
                a++;
            }

            Console.WriteLine("Fim");

            do
            {
                Console.WriteLine(b);
                b++;
            }
            while (b <= 10);

            for (int d = 1; d < 3; d++)
            {
                Console.WriteLine(d);
            }

            int[] e = { 1, 2, 3 };
            foreach(int v in e)
            {
                Console.WriteLine(v);
            }
        }
    }
}
