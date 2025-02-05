using System;


    class Program
	  {
	
	    static void Main()
	    {
	    	Console.WriteLine("informe um dia especifico do ano (yyyy-mm-dd)");
	    	DateTime data = DateTime.Parse(Console.ReadLine());
	    	
	    	DateTime dataFeriado = new DateTime(2024, 12, 25);
	    	DateTime dataFeriado2 = new DateTime(2024, 3, 4);
	    	
	    	if (data == dataFeriado || data == dataFeriado2)
	    	{
	    		Console.WriteLine("esta data é um feriado nacional");
	    	}
	    	else
	    	{
	    	Console.WriteLine("esta data não é um feriado nacional");	
	    	}
	    	
	    	Console.WriteLine("Clique em qualquer botão para encerrar...");
	    	Console.ReadKey();
	    }
	}
