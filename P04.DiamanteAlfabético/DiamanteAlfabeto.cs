using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04.DiamanteAlfabético
{
     internal class DiamanteAlfabeto
     {
          public string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
          public char[] letraAlfabeto;
          public int posicaoLetra;
          public char letra;

          public bool verificaLetra;

          private void ImprimirLetrasParteInferior()
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

          private void ImprimirLetrasParteSuperior()
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

          public char PegarLetra(string mensagem)
          {
               Console.Write(mensagem);
               letra = Convert.ToChar(Console.ReadLine().ToUpper());
               return letra;
          }

          private void VerificarLetra()
          {
              verificaLetra = char.IsLetter(letra);
              letraAlfabeto = alfabeto.ToCharArray();

              posicaoLetra = alfabeto.IndexOf(letra);

               while (letra == 'A' || verificaLetra == false)
               {
                    Console.Clear();
                    Console.Write("Entre com uma letra válida!");
                    letra = PegarLetra("\nEntre com uma letra diferente de 'a':\n> ");                 
               }
          }

          public void ImprimirDiamanteAlfabeto()
          {
               VerificarLetra();              
               ImprimirLetrasParteSuperior();
               ImprimirLetrasParteInferior();
          }
     }
}
