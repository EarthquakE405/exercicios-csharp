namespace exercicio2;
using System;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Por favor, insira seu nome: ");
        string nome = Console.ReadLine();

        Console.WriteLine("Por favor, insira seu sobrenome: ");
        string snome = Console.ReadLine();

        Console.WriteLine("Olá, " + nome + " " + snome);

    }
}
