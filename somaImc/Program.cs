public class SomaImc
{
   public static void Main(string[] args)
   {
      int opcao = 0;
      while (opcao != 3)
      {
         Console.WriteLine($"Escolha a opção a seguir:\n1. Soma\n2. IMC\n3. Sair");
         string strOpcao = Console.ReadLine();
         opcao = Int16.Parse(strOpcao);

         switch (opcao)
         {
            case 1:
               Console.WriteLine("Digite o valor 1");
               string strValor1 = Console.ReadLine();
               int valor1 = Int16.Parse(strValor1);
               
               Console.WriteLine("Digite o valor 2");
               string strValor2 = Console.ReadLine();
               int valor2 = Int16.Parse(strValor1);
               
               Console.WriteLine($"A soma dos valores é: {valor1 + valor2}");
               break;
            case 2:
               Console.WriteLine("Digite o seu peso");
               string strValor3 = Console.ReadLine();
               double peso = Convert.ToDouble(strValor3);
               
               Console.WriteLine("Digite sua altura");
               string strValor4 = Console.ReadLine();
               double altura = Convert.ToDouble(strValor4);

               double resultado = peso/(altura * altura);
               if(resultado < 18.5){
                  Console.WriteLine($"IMC:{resultado} - Peso abaixo do normal");
               } else if(resultado < 25){
                  Console.WriteLine($"IMC:{resultado} - Peso normal");
               } else if(resultado < 30){
                  Console.WriteLine($"IMC:{resultado} - Sobre o peso");
               } else if(resultado > 30 && resultado <= 35){
                  Console.WriteLine($"IMC:{resultado} - Grau de obesidade I");
               }
               break;
            default:
               Console.WriteLine($"Obrigado por usar nosso sistema");
               opcao = 3;
               break;
         }         
      }
      
   }
}
