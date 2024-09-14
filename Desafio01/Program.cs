// See https://aka.ms/new-console-template for more information
while (true)
{
    Console.Write("Digite seu nome: ");
    string nome = Console.ReadLine() ?? string.Empty;
    if (!string.IsNullOrWhiteSpace(nome))
    {
        Console.WriteLine($"Olá, {nome}! Seja muito bem-vindo!");
        break;
    }

    Console.WriteLine("Você deve digitar um nome!");
}