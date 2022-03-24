public class SenhaValida
{  
   int senhaValida = 2018;
   public bool verificarSenha(int senha)
   {  
      if(senha == senhaValida){
         return true;
      } else {
         return false;
      }
   }
   public static void Main(string[] args)
   {
      bool validacaoSenha = false;
      SenhaValida metodo = new SenhaValida();

      while (validacaoSenha == false)
      {
         Console.WriteLine("Digite a sua senha de 4 digitos");
         string strSenha = Console.ReadLine();
         int intSenha = Int16.Parse(strSenha);
         validacaoSenha = metodo.verificarSenha(intSenha);
         if(validacaoSenha == false){
            Console.WriteLine("Senha inválida");
         }
      }
      Console.WriteLine("Acesso Garantido");
   }
}
