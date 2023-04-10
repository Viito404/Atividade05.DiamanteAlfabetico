using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace P04.DiamanteAlfabético
{
     internal class Program
     {
          static void Main(string[] args)
          {
               do
               {
                    GerarMenu();
                    DiamanteAlfabeto diamante1 = new DiamanteAlfabeto();

                    diamante1.PegarLetra("\nEntre com uma letra diferente de 'a':\n> ");

                    diamante1.ImprimirDiamanteAlfabeto();

                    Console.ReadLine();

               } while (true);
          }

          static void GerarMenu()
          {
               Console.Clear();
               Console.WriteLine("===============================");
               Console.WriteLine("\nDiamante Alfabético\n");
               Console.WriteLine("===============================");

               Console.Write("\nDigite S para sair, ou qualquer outro botão para continuar:\n> ");

               string opcao;

               opcao = Console.ReadLine().ToUpper();

               if (opcao == "S")
               {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.ResetColor();
                    Environment.Exit(0);
               }
          }
     }
}