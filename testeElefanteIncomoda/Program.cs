public class ElefanteIncomoda
{
   public string criarString(int qtd)
   {
      string qtdIncomoda = "";

      for (var i = 0; i < qtd; i++)
      {
         qtdIncomoda = qtdIncomoda + "Incomoda ";
      }

      return qtdIncomoda;
   }
   public static void Main(string[] args)
   {
      Console.WriteLine("Digite um numero para terminar a musica:");
      Console.WriteLine("Um elefante incomoda muita gente...");
      string strQtd = Console.ReadLine();
      int numQtd = Int16.Parse(strQtd);
      ElefanteIncomoda metodo = new ElefanteIncomoda();
      string incomoda = metodo.criarString(numQtd);
      Console.WriteLine($"{incomoda}muito mais");
   }
}
