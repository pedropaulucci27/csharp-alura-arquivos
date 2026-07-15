# C# — Trabalhando com Arquivos

Repositório com os exercícios e o projeto do curso **"C#: trabalhando com arquivos"** da Alura, 5º curso da minha trilha de C#.

## 🎯 Sobre o curso

Curso focado em I/O de baixo nível em C#: como o `Stream` é a abstração por trás de toda leitura/escrita de dados — seja em arquivo, no console, em texto ou em binário. O projeto usado como fio condutor é o **ByteBankIO**, um sistema simplificado de conta corrente que lê e escreve dados de clientes em arquivo.

## 🗂️ Estrutura do repositório

```
Modelos/
├── Cliente.cs              → dados do titular da conta (nome, CPF, profissão)
└── ContaCorrente.cs        → conta bancária com depósito e saque

Program.cs                          → ponto de entrada, exemplos comentados
LidandoComFileStreamDiretamente.cs  → leitura de arquivo via FileStream + buffer manual
CriandoArquivo.cs                   → escrita de arquivo via FileStream e via StreamWriter
UsandoStreamReader.cs               → leitura de texto linha a linha + parsing pra objeto
StreamBinario.cs                    → escrita/leitura de dados primitivos em binário
UsandoStreamDoConsole.cs            → Console como Stream (entrada padrão)
```

## 🧠 Principais conceitos aplicados

- **Stream como abstração central**: toda entrada/saída de dados em C# (arquivo, console, rede) passa pelo conceito de `Stream` — uma sequência de bytes lida/escrita em pedaços, sem precisar carregar tudo na memória de uma vez
- **Leitura em buffer**: uso de `Read(buffer, offset, count)` em loop, essencial para arquivos maiores que a RAM disponível (ex.: vídeos, arquivos grandes)
- **Encoding (UTF-8)**: conversão entre bytes crus e texto legível via `Encoding.UTF8.GetBytes()` / `GetString()`
- **FileMode**: diferença entre `FileMode.Open` (abre existente), `FileMode.Create` (cria ou sobrescreve) e `FileMode.CreateNew` (só cria se não existir, lança exceção caso contrário)
- **StreamReader / StreamWriter**: leitura/escrita de texto de alto nível (`ReadLine`, `ReadToEnd`, `WriteLine`), abstraindo o trabalho manual com bytes
- **Flush()**: os dados escritos num stream ficam em buffer até serem efetivamente gravados no arquivo — `Flush()` força essa gravação, e o `Dispose()` (chamado pelo `using`) garante isso automaticamente ao final do bloco
- **BinaryReader / BinaryWriter**: leitura/escrita de tipos primitivos (`int`, `double`, `string`) diretamente em binário, mais compacto e rápido que texto, porém ilegível fora do programa
- **Console como Stream**: `Console.OpenStandardInput()` expõe o fluxo de entrada padrão como um `Stream` real, mostrando que `Console.ReadLine()` é só uma abstração de mais alto nível sobre a mesma ideia
- **Métodos auxiliares da classe `File`**: `File.ReadAllText`, `File.ReadAllBytes`, `File.ReadAllLines`, `File.WriteAllText`, `File.Exists` — atalhos estáticos para as operações mais comuns, sem precisar instanciar `FileStream` manualmente

## 🚀 Como executar

```bash
dotnet run
```

> O `Program.cs` chama só os exemplos mais básicos por padrão (leitura/escrita simples de texto). Os demais métodos (`LidandoComFileStreamDiretamente`, `CriarArquivo`, `UsandoStreamReader`, `EscritaBinaria`/`LeituraBinaria`, `EscreverArquivo`) estão comentados — descomente o que quiser testar. Alguns exemplos esperam um arquivo `contas.txt` na raiz do projeto, no formato `agencia,numero,saldo,nome`.

## 📚 Trilha de cursos C# — Alura

1. [C#: Criando sua primeira aplicação](https://github.com/pedropaulucci27/csharp-alura-fundamentos)
2. [C#: Aplicando a Orientação a Objetos](https://github.com/pedropaulucci27/csharp-alura-poo)
3. [C#: Dominando a Orientação a Objetos](https://github.com/pedropaulucci27/csharp-alura-dominando-oo)
4. [C#: Consumindo API, gravando arquivos e LINQ](https://github.com/pedropaulucci27/csharp-alura-consumo-api-linq)
5. **C#: Trabalhando com arquivos** *(este repositório)*

---

Feito por [Pedro Paulucci Noronha](https://github.com/pedropaulucci27) — Engenharia de Software & Data Science/IA @ Ibmec BH
