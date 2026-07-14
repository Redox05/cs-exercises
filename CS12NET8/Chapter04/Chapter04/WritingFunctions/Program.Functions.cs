using System.Globalization;

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

    static decimal CalculateTax(decimal amount, string twoLetterRegionCode)
    {
        decimal rate = twoLetterRegionCode switch
        {
            "CH" => 0.08M, //Switzerland
            "DK" or "NO" => 0.25M, //Denmark or Norway
            "GB" or "FR" => 0.2M,
            "HU" => 0.27M, //Hungary
            "OR" or "AK" or "MT" => 0.0M, //Oregon, Alaska, and Montana
            "ND" or "WI" => 0.05M,
            "CA" => 0.0825M,

        };
        return amount * rate;
    }
    static void ConfigureConsole(string culture = "en-US", bool useComputerCulture = false)
    {
        OutputEncoding = System.Text.Encoding.UTF8;
        if (!useComputerCulture)
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);
        }
        WriteLine($"Current culture: {CultureInfo.CurrentCulture.DisplayName}");
    }
}
