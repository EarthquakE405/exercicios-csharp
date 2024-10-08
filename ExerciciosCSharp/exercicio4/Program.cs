namespace exercicio4;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Por favor insira uma ou mais palavras: ");
        string caracteres  = Console.ReadLine();

        string cFiltrados = caracteres.Replace(" ", "");
        int tamanho = cFiltrados.Length;

        Console.WriteLine("Sua entrada possui " + tamanho + " letras!");
    }
}
