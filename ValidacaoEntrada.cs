namespace Calculadora35
{
  public class ValidacaoEntrada
  {
    public int Validentrada = 0;
    public static int ValidaEntrada(string valoR)
    {
      int resultadoValor = 0;
      if (int.TryParse(valoR, out int intValue))
      {
        resultadoValor = Convert.ToInt32(valoR);
        Calculadora.parWhile = 5;
      }
      else if (double.TryParse(valoR, out double doubleValue))
      {
        Console.WriteLine("Favor digitar um valor inteiro");
        Calculadora.parWhile=0;
      }
      else
      {
        Console.WriteLine("Voce digitou um valor nao numerico,favor tente novamente");
        Calculadora.parWhile=0;
      }

      return resultadoValor;

    }
  }
}
