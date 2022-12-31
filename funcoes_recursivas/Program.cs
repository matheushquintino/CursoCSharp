using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace funcoes_recursivas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LerArquivo(1);
        }
        private static void LerArquivo(int numeroArquivo)
        {
            string caminhoArquivo = @"C:\Arquivos\arquivo" + numeroArquivo + ".txt";
            if (File.Exists(caminhoArquivo))
            {
                using (StreamReader arquivo = File.OpenText(caminhoArquivo))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }
            }

            string caminhoArquivo2 = @"C:\Arquivos\arquivo" + (numeroArquivo + 1) + ".txt";
            if (File.Exists(caminhoArquivo2))
            {
                LerArquivo(numeroArquivo + 1);
            }
        }
    }
}
