using ByteBankIO;
using System.Runtime.CompilerServices;

partial class Program
{
    static void Main(string[] args)
    {
        File.WriteAllText("arquivo.txt", "Olá mundo!");
        Console.WriteLine("Arquivo arquivo.txt criado!");

        var bytesArquivo = File.ReadAllBytes("contas.txt");
        Console.WriteLine(bytesArquivo.Length);

        var linhas = File.ReadAllLines("contas.txt");
        Console.WriteLine(linhas.Length);

        // Exemplos desenvolvidos ao longo do curso — descomente para testar:
        // LidandoComFileStreamDiretamente();
        // CriarArquivo();
        // CriarArquivoComWriter();
        // TestaEscrita();
        // UsandoStreamReader();
        // EscritaBinaria();
        // LeituraBinaria();
        // EscreverArquivo();
    }
}
