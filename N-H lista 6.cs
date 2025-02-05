using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Insira uma letra:");
        char letra = char.Parse(Console.ReadLine().ToLower());
      
        if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
        {
            Console.WriteLine("A letra é uma vogal.");
        }
        else if (Char.IsLetter(letra)) 
        {
            Console.WriteLine("A letra é uma consoante.");
        }
        else
        {
            Console.WriteLine("Entrada inválida! Por favor, insira uma letra.");
        }

        Console.WriteLine("Clique qualquer botão para encerrar...");
        Console.ReadKey();
    }
}
