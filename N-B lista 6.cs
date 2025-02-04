using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Escolha uma opção:\n1 - Calcular diferença entre duas datas\n2 - Sair");
        int escolha = int.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 1:
                Console.WriteLine("Digite a primeira data (dd/MM/yyyy):");
                DateTime data1 = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                Console.WriteLine("Digite a segunda data (dd/MM/yyyy):");
                DateTime data2 = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                Console.WriteLine($"A diferença entre as datas é de {(data1 - data2).TotalDays} dias.");
                break;
            case 2:
                Console.WriteLine("Saindo...");
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }

        Console.WriteLine("Aperte qualquer tecla para sair.");
        Console.ReadKey();
    }
}
