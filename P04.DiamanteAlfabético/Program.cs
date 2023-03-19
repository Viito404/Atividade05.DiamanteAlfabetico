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
                    #region Menu e opção de sair;


                    Console.Clear();
                    Console.WriteLine("===============================");
                    Console.WriteLine("\nDiamante Alfabético\n");
                    Console.WriteLine("===============================");

                    Console.Write("\nDigite S para sair, ou qualquer outro botão para continuar:\n> ");

                    string op;
                    
                   op = Console.ReadLine();

                    if (op == "s" || op == "S")
                    {
                         Console.WriteLine("\nSaindo...");
                         break;
                    }

                    #endregion

                    #region Atribuição do alfabeto em uma variável e separação dos caracteres;

                    string alfa = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    char[] alfac = alfa.ToCharArray();

                    #endregion

                    #region Entrada da letra, formatação e comparação com a string do alfabeto;

                    Console.Write("\nEntre com uma letra diferente de 'a':\n> ");
                    char l = Convert.ToChar(Console.ReadLine());
                    bool v = char.IsLetter(l);
                    l = char.ToUpper(l);

                    //retorno da posição dentro da Array.
                    int ia = alfa.IndexOf(l);

                    #endregion

                    #region Verificação da letra;

                    if (l == 'A' || v == false)
                    {
                         Console.Clear();
                         Console.Write("Entre com uma letra válida!");
                         Console.Write("\nEntre com uma letra diferente de 'a':\n> ");
                         l = Convert.ToChar(Console.ReadLine());
                         l = char.ToLower(l);
                    }

                    #endregion

                    #region Espaços externos da parte superior do diamante;

                    else
                    {
                         for (int i = 0; i <= ia; i++)
                         {
                              Console.WriteLine("\n");

                              for(int a = 0; a < ia - i; a++)
                              {
                                   Console.Write(" ");
                              }

                              #endregion

                              #region Impressão da letra na posição correspondende dentro da Array;

                              for (int p = 0; p < 1; p++)
                              {
                                   Console.Write(alfac[i]);

                                   #endregion

                                   #region Espaços internos da parte superior;

                                   for (int k = 0; k <= 2 * i - 2; k++)
                                   {
                                        Console.Write(" ");
                                   }

                                   #endregion

                                   #region Correção problema do duplo A;

                                   if (i != 0)
                                   {
                                        Console.WriteLine(alfac[i]);
                                   }
                              }

                         }

                         #endregion


                         #region Espaços externos da parte inferior do diamante;

                         for (int i = ia - 1; i >= 0; i--)
                         {
                              Console.WriteLine("\n");

                              for(int a = 0; a < ia - i; a++)
                              {
                                   Console.Write(" ");
                              }

                              #endregion

                              #region Impressão da letra; 

                              for ( int a = 0; a < 1; a++)
                              {
                                   Console.Write(alfac[i]);

                                   #endregion

                                   #region Espaços internos parte inferior;

                                   for (int g = 0; g <= 2 * i - 2; g++)
                                   {
                                        Console.Write(" ");
                                   }

                                   #endregion

                                   if (i != 0)
                                   {
                                        Console.WriteLine(alfac[i]);
                                   }
                              }

                         }
                    }

                    Console.ReadLine();

               } while (true);
          }
     }
}