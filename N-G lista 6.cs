using System;


class Program
{
    static void Main()
    {
      Console.WriteLine("Digite o nome de uma cor entre estas opções:");
      Console.WriteLine("- Vermelho -");
      Console.WriteLine("- Verde -");
      Console.WriteLine("- Azul -");
      
	    string cor = Console.ReadLine().ToLower();
	   
      
	      switch (cor)  {
	    	
	    		case  "vermelho":
	    			Console.WriteLine("a cor escolhida foi vermelho");break;
	    	
	    		case "azul":
	    	Console.WriteLine("a cor escolhida foi azul");break;
	    	
	    		case "verde":
	       Console.WriteLine("cor escolhida foi verde");break;
	    	}

        Console.WriteLine("Clique qualquer botão para encerrar...");
        Console.ReadKey();
    }
}
