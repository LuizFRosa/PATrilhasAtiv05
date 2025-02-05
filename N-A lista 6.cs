using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Escolha uma opção de exibição:");
        Console.WriteLine("1 - Data completa");
        Console.WriteLine("2 - Hora completa");
        Console.WriteLine("3 - Data e hora");

        int escolha = int.Parse(Console.ReadLine());

        DateTime dataHoraAtual = DateTime.Now;

        switch (escolha)
        {
            case 1:
                Console.WriteLine("Data completa: " + dataHoraAtual.ToString("dddd, dd MMMM yyyy"));
                break;
            case 2:
                Console.WriteLine("Hora completa: " + dataHoraAtual.ToString("HH:mm:ss"));
                break;
            case 3:
                Console.WriteLine("Data e Hora: " + dataHoraAtual.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }

        Console.WriteLine("Clique qualquer botão para encerrar...");
        Console.ReadKey();
    }
}
