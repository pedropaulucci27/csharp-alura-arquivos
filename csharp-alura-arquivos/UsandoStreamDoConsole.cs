using System;
using System.Collections.Generic;
using System.Text;

partial class Program
{
    static void EscreverArquivo()
    {
        var enderecoDoArquivo = "NovoArquivo.txt";
        using (var fluxoDoArquivo = Console.OpenStandardInput())
        using (var fs = new FileStream(enderecoDoArquivo, FileMode.Create))
        {
            var buffer = new byte[1024];

            while (true)
            {
                var bytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                fs.Write(buffer, 0, bytesLidos);
                fs.Flush();
                Console.WriteLine($"Bytes lidos no console: {bytesLidos}");
            }
        }
    }
}
