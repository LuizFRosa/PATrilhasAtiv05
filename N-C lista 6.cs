using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Escolha uma opção:\n1 - Idade completa\n2 - Idade em anos");
        int escolha = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite sua data de nascimento (yyyy-mm-dd):");
        DateTime dataNascimento = DateTime.Parse(Console.ReadLine());
        int idade = DateTime.Now.Year - dataNascimento.Year;

        if (DateTime.Now < dataNascimento.AddYears(idade)) idade--;

        switch (escolha)
        {
            case 1: Console.WriteLine("Sua idade completa é: " + idade + " anos."); break;
            case 2: Console.WriteLine("Sua idade em anos é: " + idade); break;
            default: Console.WriteLine("Opção inválida!"); break;
        }

        Console.ReadKey();
    }
}
