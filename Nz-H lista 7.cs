using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número inteiro: ");
        int numero;
      
        do
        {
            Console.WriteLine("Por favor, insira um número inteiro válido.");
        } while (!int.TryParse(Console.ReadLine(), out numero));

            Console.WriteLine("Tabuada do numero é:");

        for (int i = 1; i <= 10; i++)
        {
            int resultado = numero * i;
            Console.WriteLine("{0} x {1} = {2}", numero, i, resultado);
            Console.ReadKey();
        }
    }
}
