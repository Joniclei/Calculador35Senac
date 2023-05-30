namespace Calculadora35
{
  public class Program
  {
    public static void Main(string[] args)
    {
      int x = 0;
      do
      {
        Console.WriteLine("Digite a opcao : \n[1]Calcular  \n[2]Zerar \n[3]Sair");
        string t = Console.ReadLine();
        x = Calculadora.ValidacaoMenu(t);
      } while (x != 3);

    }
  }
}

// se tiver que armazenar o valor recebido anteriormente creio que terei que fazer um if de string fazia,pois quando digito a tecla enter ele gera uma string fazia e faz o  else{Console.WriteLine("Voce digitou um valor nao numerico,favor tente novamente");}
