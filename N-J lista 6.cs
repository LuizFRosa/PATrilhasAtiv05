using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Escolha o tamanho da sua roupa (P, M ou G):");
        char tamanho = char.ToUpper(char.Parse(Console.ReadLine())); 

        switch (tamanho)
        {
            case 'P':
                Console.WriteLine("O tamanho P custa 40 reais");
                break;
            case 'M':
                Console.WriteLine("O tamanho M custa 60 reais");
                break;
            case 'G':
                Console.WriteLine("O tamanho G custa 80 reais");
                break;
            default:
                Console.WriteLine("Digite um tamanho válido (P, M ou G)");
                break;
        }
        Console.WriteLine("Clique qualquer botão para encerrar...");
        Console.ReadKey();
    }
}
