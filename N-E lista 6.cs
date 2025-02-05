using System;


    class Program
	  {
	
	    static void Main()
	    {
	    	Console.WriteLine("escolha uma das opçoes abaixo.(1, 2 ou 3)");
	    	
	    	Console.WriteLine("opção 1.");
	    	Console.WriteLine("opção 2.");
	    	Console.WriteLine("opção 3.");
	    	
	    	
	    	string escolha = (Console.ReadLine());
	    	
	    	switch (escolha)  {
	    	
    		  case "1":
	    	
	    			Console.WriteLine("a opção 1 foi escolhida");break;
	    	
	    	  case "2":
	    	
	    	    Console.WriteLine("a opção 2 foi escolhida");break;
	    	
	    	  case "3":
	    	
	       Console.WriteLine("a opção 3 foi escolhida");break;
	    	}
	    	Console.WriteLine("Clique em qualquer botão para encerrar...");
	    	Console.ReadKey();
	    }
	}
