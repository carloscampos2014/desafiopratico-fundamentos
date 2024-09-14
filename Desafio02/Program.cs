// See https://aka.ms/new-console-template for more information
var nome = CaptureText("Nome:");
var sobreNome = CaptureText("Sobrenome:");
Console.WriteLine($"Seu nome completo é {nome} {sobreNome}");

static string CaptureText(string prompt)
{
    string text = string.Empty;
    while (true)
    {
        Console.Write($"{prompt.Replace(":", string.Empty).Trim()}: ");
        text = Console.ReadLine() ?? string.Empty;
        if (!string.IsNullOrEmpty(text)) break;
        Console.WriteLine($"Você deve digitar seu {prompt.Replace(":", string.Empty).Trim()}.");
    }

    return text;
}