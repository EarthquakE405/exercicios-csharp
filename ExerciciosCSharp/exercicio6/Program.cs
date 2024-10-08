namespace exercicio6;
using System;
using System.Globalization;
using System.Reflection.PortableExecutable;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Por favor digite uma opção para exibição da data:\n1-Formato Completo\n2-Apenas Data\n3-Apenas Hora\n4-Apenas Data (mês por extenso)");
        int opcao = int.Parse(Console.ReadLine());

        DateTime data = DateTime.Now;

        string dia1 = data.ToString("F", new CultureInfo("pt-BR"));
        string dia2 = data.ToString("d", new CultureInfo("pt-BR"));
        string dia3 = data.ToString("HH:mm", new CultureInfo("pt-BR"));
        string dia4 = data.ToString("d/MMMM/yyyy", new CultureInfo("pt-BR"));

        switch (opcao)
        {
            case 1:
                Console.WriteLine(dia1);
                break;
            case 2:
                Console.WriteLine(dia2);
                break;
            case 3:
                Console.WriteLine(dia3);
                break;
            case 4:
                Console.WriteLine(dia4);
                break;
        }

    }
}
