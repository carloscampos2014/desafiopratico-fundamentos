// See https://aka.ms/new-console-template for more information
using System.Globalization;

double number01 = CaptureNumber();
double number02 = CaptureNumber();

Console.WriteLine($"{number01:N2} + {number02:N2} = {(number01 + number02):N2}");
Console.WriteLine($"{number01:N2} - {number02:N2} = {(number01 - number02):N2}");
Console.WriteLine($"{number01:N2} x {number02:N2} = {(number01 * number02):N2}");
Console.WriteLine(number02 != 0 ?
    $"{number01:N2} ÷ {number02:N2} = {(number01 / number02):N2}" :
    "Não é possível realizar a divisão pois o segundo numero é 0!");
Console.WriteLine($"A média entre {number01:N2} e {number02:N2} é {((number01 + number02) / 2):N2}");


static double CaptureNumber()
{
    double value = 0;
    while (true)
    {
        Console.Write("Digite um Número: ");
        string text = Console.ReadLine() ?? string.Empty;
        if (double.TryParse(text, out value)) break;
        Console.WriteLine($"Você deve digitar um valor valido!");
    }

    return value;
}
