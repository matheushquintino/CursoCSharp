using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace arrays_collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
        // ======= Arrays =======
            string[] a = new string[3];
            a[0] = "Matheus";
            a[1] = "Henrique";
            a[2] = "Quintino";

            foreach (string nome in a)
            {
                Console.WriteLine(nome);
            }
            int size_array = a.Length;// busca em inteiro o tamanho do array
            Console.WriteLine(size_array);

            if(Array.Exists(a, e=>e == "Matheus"))// busca dentro do array 
            {
                Console.WriteLine("Entrou no if");
            }

        // ======= Collections =======
            List<string> b = new List<string>();
            b.Add("Matheus");
            b.Add("Henrique");
            b.Add("Quintino");

            foreach (string nome in b) 
            {
                Console.WriteLine(nome);
            }
            int size_list = b.Count;// busca em inteiro o tamanho da lista
            Console.WriteLine(size_list);

            string[] c = b.ToArray(); //conversão de lista pra array
            Console.WriteLine(c[1]);

            if (b.Exists( e => e == "Matheus")) //busca dentro da lista
            {
                Console.WriteLine("Entrou no if");
            }

        }
    }
}
