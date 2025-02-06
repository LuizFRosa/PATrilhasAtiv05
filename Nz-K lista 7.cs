using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma sequência de números inteiros positivos: ");

        int soma = 0;
        int i = 0;

        do
        {
            Console.WriteLine("Digite um número inteiro positivo: ");
            int numero = int.Parse(Console.ReadLine());

            
            if (numero > 0)
            {
                soma += numero; 
                Console.WriteLine("O número escolhido foi: " + numero);
                i++;
            }
            else
            {
                Console.WriteLine("Por favor, insira um número inteiro positivo.");
            }

          } 
                while (i < 5); 
                Console.WriteLine("A soma da sequência dos números é: " + soma);
                Console.WriteLine("Clique qualquer botão para encerrar...");

    }
}
