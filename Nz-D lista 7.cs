using System;


class Program
{
    static void Main()
    {
              Console.WriteLine("digite uma senha: ");
              string senha =Console.ReadLine();
        
              int tentativas = 0;
              int maxTentativas = 3;
        
            while (tentativas < maxTentativas )
                {
                Console.WriteLine("insira a senha: "); 
            
                string tentativaSenha = (Console.ReadLine());
            
            if (tentativaSenha == senha)
            {
                Console.WriteLine("A senha esta correta");
                Console.ReadKey();
                break; 
            }
            else
            {
                Console.WriteLine("a senha esta incorreta.");
                tentativas++;
            }
                Console.WriteLine("Clique qualquer botão para encerrar...");
                Console.ReadKey();
    }
}
