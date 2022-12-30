using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicionais_e_operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 3;
            if (a == 1) Console.WriteLine("Entrou no IF"); //if ternario
            if (a == 2) //if convencional
            {
                Console.WriteLine("Entrou no IF");
            }
            else
            {
                Console.WriteLine("Entrou no else");
            }

            var b = 2;
            switch (b) //Switch e Case
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
                
            }

            //========= OPERADORES ==========

            if (a == 1 && b == 2) Console.WriteLine("Entrou no IF"); //operador 'E'
            if (a == 1 || b== 2) Console.WriteLine("Entrou no IF"); //operador 'OU'
            if (a != 1) Console.WriteLine("Entrou no IF"); //operador 'diferente de'
            if (a == 1) Console.WriteLine("Entrou no IF"); //operador 'igual a'
        }
    }
}
