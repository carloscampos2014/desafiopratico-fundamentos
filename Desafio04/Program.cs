// See https://aka.ms/new-console-template for more information
while (true)
{
    Console.Write("Digite uma palavra (deixe em branco para sair): ");
    var word = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(word)) break;

    Console.WriteLine($"A palavra {word} tem {word.Length:N0} letras!");
}
