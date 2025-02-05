using System;

  class Program
  {
      static void Main()
      {
       Console.WriteLine("insira um numero inteiro");
	     int numero = int.Parse(Console.ReadLine());
	    	
	    	switch (Math.Sign(numero)) 
        {
	    		case  0:
	    	Console.WriteLine("o numero é igual a 0");break;
	    	
	    		case 1:
	    	Console.WriteLine("o numero é positivo");break;
	    	
	    		case -1:
	      Console.WriteLine("o numero é negativvo");break;
	    	}

        Console.WriteLine("Clique qualquer botão para encerrar...");
        Console.ReadKey();
    }
}
