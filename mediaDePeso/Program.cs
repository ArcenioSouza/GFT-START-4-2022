public class MediaDePeso
{
   public static void Main(string[] args)
   {  
      int I10 = 0;
      int I20 = 0;
      int I30 = 0;
      int I31 = 0;
      double P10 = 0;
      double P20 = 0;
      double P30 = 0;
      double P31 = 0;
      int qtd = 1;
      Console.WriteLine("Me informe a idade e o peso de 10 pessoas");
      while(qtd <= 10){
         Console.WriteLine($"Qual é a idade da pessoa {qtd}");
         string strIdade = Console.ReadLine();
         Console.WriteLine($"Qual é o peso da pessoa {qtd}");
         string strPeso = Console.ReadLine();

         int idade = Int16.Parse(strIdade);
         double peso = Convert.ToDouble(strPeso);

         if(idade <= 10){
            I10 = I10 + 1;
            P10 = P10 + peso;
         } else if(idade <= 20){
            I20 = I20 + 1;
            P20 = P20 + peso;
         } else if(idade <= 30){
            I30 = I30 + 1;
            P30 = P30 + peso;
         } else {
            I31 = I31 + 1;
            P31 = P31 + peso;
         }
         qtd = qtd + 1;
      }
      
      Console.WriteLine($"A média de peso de 1 a 10 anos é: {P10/I10}");
      Console.WriteLine($"A média de peso de 11 a 20 anos é: {P20/I20}");
      Console.WriteLine($"A média de peso de 21 a 30 anos é: {P30/I30}");
      Console.WriteLine($"A média de peso para acima de 31 anos é: {P31/I31}");
   }
}
