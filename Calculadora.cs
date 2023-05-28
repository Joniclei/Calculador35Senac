using System;

namespace Calculadora35
{
  public class Calculadora
  {
    public static int ValorA = 0;
    public static int ValorB = 0;

    public static int parWhile = 0;
    public static int ValidacaoMenu(string t)
    {
      int x = 5;
      if (int.TryParse(t, out int intValue))
      {
        Convert.ToInt32(t);
        x = Convert.ToInt32(t);
        if (x == 1)
        {
          do
          {

            Console.WriteLine("Escreva o primeiro valor:");
            string valorA = Console.ReadLine();

            ValorA = ValidacaoEntrada.ValidaEntrada(valorA);

          } while (parWhile != 5);

          parWhile = 0;
          do
          {
            Console.WriteLine("Escreva o segundo valor:");
            string valorB = Console.ReadLine();
            ValorB = ValidacaoEntrada.ValidaEntrada(valorB);

          } while (parWhile != 5);

          if (ValorA != 0 && ValorB != 0)
          {
            Console.WriteLine($"Somando os numero: {ValorA} + {ValorB} = {ValorA + ValorB}");
            Console.WriteLine($"Subitraindo os numero: {ValorA} - {ValorB} = {ValorA - ValorB}");
            Console.WriteLine($"Multiplicando os numero: {ValorA} * {ValorB} = {ValorA * ValorB}");
            Console.WriteLine($"Dividindo os numero: {ValorA} / {ValorB} = {(double)ValorA / ValorB} ");
          }
          else
          {
            Console.WriteLine("Digite um valor valido,diferente de 0");
          }


        }
        else if (x == 2)
        {
          ValorA = 0;
          ValorB = 0;
          Console.WriteLine("Valor Zerado");
          x = 0;
        }

        else if (x == 3)
        {


          x = 3;
        }
      }
      else if (double.TryParse(t, out double doubleValue))
      {
        Console.WriteLine("Valor digitado e um valor fracionado,favor tentar novamente.");
      }
      else
      {
        Console.WriteLine("Valor digitado nao e numerico");
      }

      return x;

    }

  }
}
