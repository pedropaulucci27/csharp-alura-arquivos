using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

partial class Program
{
    static void EscritaBinaria()
    {
        var enderecoDoArquivo = "ContaCorrente.txt";
        using (var fs = new FileStream(enderecoDoArquivo, FileMode.Create))
        using (var escritor = new BinaryWriter(fs))
        {
            escritor.Write(456); // agencia
            escritor.Write(12312); // num da conta
            escritor.Write(3123.20); // saldo
            escritor.Write("Pedro"); // nome titular
        }
    }

    static void LeituraBinaria()
    {
        var enderecoDoArquivo = "ContaCorrente.txt";
        using (var fs = new FileStream(enderecoDoArquivo, FileMode.Open))
        using (var leitor = new BinaryReader(fs))
        {
            int agencia = leitor.ReadInt32();
            int numeroConta = leitor.ReadInt32();
            double saldo = leitor.ReadDouble();
            string nome = leitor.ReadString();

            Console.WriteLine($"Agência: {agencia} - Número da conta: {numeroConta} - saldo: {saldo} - nome: {nome}");
        }
    }
}
