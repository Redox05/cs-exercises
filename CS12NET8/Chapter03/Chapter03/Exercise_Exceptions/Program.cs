float n1Parsed;
float n2Parsed;
float division;

Console.Write("Enter a number in the range of 0 to 255: ");

bool firstNumberParsed = float.TryParse(Console.ReadLine(), out n1Parsed);

Console.Write("Enter another number in the range of 0 to 255: ");
bool secondNumberPas = float.TryParse(Console.ReadLine(), out n2Parsed);

if (!firstNumberParsed || !secondNumberPas)
{
    Console.WriteLine($"The input is not in the correct format");
    return;
}

Console.WriteLine($"{n1Parsed} divided by {n2Parsed} is {division = n1Parsed / n2Parsed}");



