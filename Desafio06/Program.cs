// See https://aka.ms/new-console-template for more information
Console.Write("Digite uma Data: ");
var textDate = Console.ReadLine();
if (!DateTime.TryParse(textDate, out var date))
{
    Console.WriteLine("Você deve digitar uma data valida!");
    return;
}

Console.WriteLine($"{date:F}");
Console.WriteLine($"{date:dd/MM/yyyy}");
Console.WriteLine($"{date:T}");
Console.WriteLine($"{date:dd 'de' MMMM 'de' yyyy}");

