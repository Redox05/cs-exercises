using static System.Console;

partial class Program
{
    static void WhatsMyNamespace()
    {
        WriteLine($"Namespace of Program clas: {0}", arg0: typeof(Program).Namespace ?? "null");
    }
}
