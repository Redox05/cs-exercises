partial class Program
{
    static void TimesTable(byte number, byte size = 12)
    {
        WriteLine($"This is the {number} times table with {size} rows: ");
        WriteLine();

        for (int i = 1; i<=size; i++)
        {
            WriteLine($"{i} x {number} = {i * number}");
        }
        
        }
}
