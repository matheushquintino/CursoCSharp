using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine().ToString();
            int b = Convert.ToInt32(a);
            Tabuada(b);

        }
        public static void Tabuada(int numero)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(numero + " X " + i + " = " + (numero * i));
            }
        }
    }
}
