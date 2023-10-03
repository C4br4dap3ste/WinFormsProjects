using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_entrada
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe o numero de alunos: ");
            int x = int.Parse(Console.ReadLine());

            String[] nome = new string[x];

            for (int i = 0; i <= (x - 1); i++)
            {
                Console.WriteLine("Digite o nome: ");
                nome[i] = Console.ReadLine();
            }

            for (int j = 0; j <= (x - 1); j++)
            {
                Console.WriteLine(" nome digitado: " + nome[j]);
            }
            Console.ReadKey();
        }
    }
}
    

