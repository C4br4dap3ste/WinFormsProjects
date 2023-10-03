using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _231254
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sf=0;
            Console.WriteLine("Digite seu saldo bancário");
            double saldo= double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a operação desejada(saque(S) ou depósito(D))");
            string SD = Console.ReadLine();

            Console.WriteLine("Digite a a quantia a ser movimentada");
            double Q= double.Parse(Console.ReadLine());
            switch (SD)
            {
                case "D":

                    sf = saldo + Q;
                    Console.WriteLine("Operação concluída, saldo final:" + sf);

                    break;

                case "S":
                    if (SD == "S" && Q > saldo)
                        Console.WriteLine("Saldo insuficiente");
                    else
                    {
                        sf = saldo - Q;
                        Console.WriteLine("Operação concluída, saldo final:" + sf);
                    }
                        

                    
                    break;

                    default: Console.WriteLine("Opção inválida");

                    break;
            }

            Console.ReadKey();

        }
    }
}
