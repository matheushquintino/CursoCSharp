using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace tipos_de_variaveis
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int i = 1; //int de maneira estatica
            var i2 = 2; //int com tipagem dinamica

            string s = "matheus"; //string de maneira estatica
            var s2 = "matheus2"; //string com tipagem dinamica

            float f = 1.5f; //float de maneira estatica
            var f2 = 2.5f; // float com tipagem dinamica

            double d = 1.5; //double de maneira estatica
            var d2 = 2.5; //double com tipagem dinamica

            char c = 'a'; // char de maneira estatica
            var c2 = 'b'; // char com tipagem dinamica

            bool b = true; //booleano de maneira estatica
            var b2 = false; //booleano com tipagem dinamica

            Console.WriteLine(i);
            Console.WriteLine(i2);
            Console.WriteLine(s);
            Console.WriteLine(s2);
            Console.WriteLine(f);
            Console.WriteLine(f2);
            Console.WriteLine(d);
            Console.WriteLine(d2);
            Console.WriteLine(c);
            Console.WriteLine(c2);
            Console.WriteLine(b);
            Console.WriteLine(b2);

            //============== Conversões ==============
            
            bool bo = bool.Parse("false"); //String para booleano
            bool bo2 = Convert.ToBoolean("true"); //String para booleano

            Console.WriteLine(bo);
            Console.WriteLine(bo2);

        }
    }
}
