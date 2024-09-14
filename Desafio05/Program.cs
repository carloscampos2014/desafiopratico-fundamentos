// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

string placa = CaptureText("Placa");

string pattern = @"^[A-Za-z]{3}\d{4}$";
string result = Regex.IsMatch(placa, pattern) && placa.Length == 7 ? "Verdadeiro" : "Falso";
Console.WriteLine($"A placa {placa.ToUpperInvariant()} é valida: {result}");


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