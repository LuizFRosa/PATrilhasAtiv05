using System;


class Program
{
    static void Main()
    {
         Console.WriteLine("Insira um número de 1 a 7:");
         int numero = int.Parse(Console.ReadLine());

        switch (numero)
        {
            case 1:
                Console.WriteLine("Hoje é domingo");
                break;
            case 2:
                Console.WriteLine("Hoje é segunda-feira");
                break;
            case 3:
                Console.WriteLine("Hoje é terça-feira");
                break;
            case 4:
                Console.WriteLine("Hoje é quarta-feira");
                break;
            case 5:
                Console.WriteLine("Hoje é quinta-feira");
                break;
            case 6:
                Console.WriteLine("Hoje é sexta-feira");
                break;
            case 7:
                Console.WriteLine("Hoje é sábado");
                break;
            default:
                Console.WriteLine("Digite um número válido entre 1 e 7");
                break;
        }

        Console.WriteLine("Clique qualquer botão para encerrar...");
        Console.ReadKey();
    }
}
