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
                    string opcao = GerarMenu();

                    if (opcao == "S")
                    {
                         Console.ForegroundColor = ConsoleColor.Red;
                         Console.WriteLine("\nSaindo...");
                         Console.ResetColor();
                         break;
                    }

                    string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    char[] letraAlfabeto = alfabeto.ToCharArray();

                    char letra = PegarLetra("\nEntre com uma letra diferente de 'a':\n> ");

                    bool verificaLetra = char.IsLetter(letra);

                    int posicaoLetra = alfabeto.IndexOf(letra);

                    if (letra == 'A' || verificaLetra == false)
                    {
                         Console.Clear();
                         Console.Write("Entre com uma letra válida!");
                         letra = PegarLetra("\nEntre com uma letra diferente de 'a':\n> ");                       
                    }

                    else
                    {
                         ImprimirLetrasParteSuperior(letraAlfabeto, posicaoLetra);
                         ImprimirLetrasParteInferior(letraAlfabeto, posicaoLetra);
                    }

                    Console.ReadLine();

               } while (true);
          }

          #region Funções;

          private static void ImprimirLetrasParteInferior(char[] letraAlfabeto, int posicaoLetra)
          {
               for (int i = posicaoLetra - 1; i >= 0; i--)
               {
                    Console.WriteLine("\n");

                    for (int a = 0; a < posicaoLetra - i; a++)
                    {
                         Console.Write(" ");
                    }

                    for (int a = 0; a < 1; a++)
                    {
                         Console.Write(letraAlfabeto[i]);

                         for (int g = 0; g <= 2 * i - 2; g++)
                         {
                              Console.Write(" ");
                         }

                         if (i != 0)
                         {
                              Console.WriteLine(letraAlfabeto[i]);
                         }
                    }

               }
          }

          private static void ImprimirLetrasParteSuperior(char[] letraAlfabeto, int posicaoLetra)
          {
               for (int i = 0; i <= posicaoLetra; i++)
               {
                    Console.WriteLine("\n");

                    for (int a = 0; a < posicaoLetra - i; a++)
                    {
                         Console.Write(" ");
                    }

                    for (int p = 0; p < 1; p++)
                    {
                         Console.Write(letraAlfabeto[i]);

                         for (int k = 0; k <= 2 * i - 2; k++)
                         {
                              Console.Write(" ");
                         }

                         if (i != 0)
                         {
                              Console.WriteLine(letraAlfabeto[i]);
                         }
                    }

               }
          }

          static string GerarMenu()
          {
               Console.Clear();
               Console.WriteLine("===============================");
               Console.WriteLine("\nDiamante Alfabético\n");
               Console.WriteLine("===============================");

               Console.Write("\nDigite S para sair, ou qualquer outro botão para continuar:\n> ");

               string opcao;

               opcao = Console.ReadLine().ToUpper();
               return opcao;
          }

          static char PegarLetra(string mensagem)
          {
               Console.Write(mensagem);
               char letra = Convert.ToChar(Console.ReadLine().ToUpper());
               return letra;
          }

          #endregion
     }
}